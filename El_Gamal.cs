using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace data_protection_lab_1
{
    class El_Gamal
    {
        public long P { get; set; }
        public long G { get; set; }
        public BigInteger X { get; set; }
        public BigInteger Y { get; set; }

        static bool IsPrime(long prime)
        {
            if (prime <= 2) return false;
            BigInteger j = (BigInteger)Math.Sqrt(prime);

            for (BigInteger i = 2; i <= j; i++)
            {
                if (prime % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        public static long GeneratePrime()
        {
            long maxValue = (long)Math.Pow(2, 20);
            long minValue = (long)Math.Pow(2, 12);
            long prime = new Random().NextInt64(minValue, maxValue);
            while (!IsPrime(prime))
            {
                prime = new Random().NextInt64(minValue, maxValue);
            }
            return prime;
        }
        public bool GenerateKeys()
        {
            P = GeneratePrime();
            do
            {
                G = new Random().NextInt64(P - 1);
            } while (!IsPrime(G) || BigInteger.ModPow(G, P - 1, P) != 1);

            X = new Random().NextInt64(1, P - 1);

            Y = BigInteger.ModPow(G, X, P);
            return true;
        }
        public string Encrypt(string msg, string outFileName, string inFileName)
        {
            using (StreamWriter write = new StreamWriter(inFileName))
            {
                write.Write(msg);
            }
            using (StreamReader reader = new StreamReader(inFileName))
            using (StreamWriter writer = new StreamWriter(outFileName))
            {
                var ans = new StringBuilder();
                while (!reader.EndOfStream)
                {
                    // Чтение символа из файла
                    
                    int m = reader.Read();
                    if (m > 0)
                    {
                        // Генерация случайного числа k, 1 < k < p-2
                        BigInteger k = new Random().Next(1, (int)P - 1);

                        // Вычисление a = g^k mod p
                        BigInteger a = BigInteger.ModPow(G, k, P);

                        // Вычисление b = (y^k * m) mod p
                        BigInteger b = (BigInteger.ModPow(Y, k, P) * m) % P;

                        // Запись пары (a, b) в файл
                        writer.WriteLine($"{a} {b}");
                        ans.AppendLine(a + " " + b);
                        
                    }
                }
                return ans.ToString();
            }
        }

        public string Decrypt(string outFileName, string inFileName)
        {
            using (StreamReader reader = new StreamReader(inFileName))
            using (StreamWriter writer = new StreamWriter(outFileName))
            {
                string ans = "";
                while (!reader.EndOfStream)
                {
                    string[] parts = reader.ReadLine().Split(' ');
                    if (parts.Length == 2)
                    {
                        // Чтение пары (a, b) из файла
                        BigInteger a = BigInteger.Parse(parts[0]);
                        BigInteger b = BigInteger.Parse(parts[1]);

                        // Вычисление обратного элемента к a: a^(-1) mod p
                        BigInteger aInverse = BigInteger.ModPow(a, P - 1 - X, P);

                        // Вычисление исходного символа m = (a^(-1) * b) mod p
                        int m = (int)((aInverse * b) % P);

                        // Запись расшифрованного символа в файл
                        writer.Write((char)m);
                        ans += (char)m;
                    }
                }
                return ans;
            }
        }
    }
}
