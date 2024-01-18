using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace data_protection_lab_1
{
    public class Gamma
    {
        public static int BLOCK_SIZE = 48/16;
        public string key = "";
        string encrypted = "";
        public Gamma() 
        {
            key = GenerateKey(BLOCK_SIZE);
        }
        public string GenerateKey(int length)
        {
            Random random = new Random();
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            char[] key = new char[BLOCK_SIZE];
            for (int i = 0; i < BLOCK_SIZE; i++)
            {
                key[i] = alphabet[random.Next(alphabet.Length)];
            }

            return new string(key);
        }
         public string? Update(string message)
        {
            Encoding encoding = Encoding.ASCII;
            byte[] bytes = encoding.GetBytes(message);

            int countOfBlock = bytes.Length;
            byte[] encryptedBytes = new byte[countOfBlock];

            for (int i = 0; i < bytes.Length; i++)
            {
                encryptedBytes[i] = ((byte)(bytes[i] ^ (byte)key[i % BLOCK_SIZE]));
            }

            encrypted = new string(encoding.GetChars(encryptedBytes));
            return encrypted;
        }

        public string Decode()
        {
            return Update(encrypted);
        }
    }
}
