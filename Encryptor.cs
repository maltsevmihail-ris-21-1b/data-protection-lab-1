using System.Security.Cryptography;
using System.Text;

namespace Lab4Main
{
    public class Encryptor
    {
        private const int BLOCK_SIZE = 32;
        private const int KEY_SIZE = 16;
        private const int ROUNDS = 16;
        private const int SYMBOL_SIZE = 16;
        private const int keyShift = 1;
        private const int symbolsInBlock = BLOCK_SIZE / SYMBOL_SIZE;
        
       static  private ulong keyUlong = 0;

        static string Key = "";

        static private ulong StringToUlong(string str)
        {
            ulong result = 0;
            for (int i = 0; i < str.Length; ++i)
            {
                result = result << SYMBOL_SIZE;
                result += str[i];
            }
            return result;
        }

        static private string UlongToString(ulong ul)
        {
            string str = "";
            for (int i = 0; i < symbolsInBlock / 2; ++i)
            {
                str += (char)ul;
                ul = ul >> SYMBOL_SIZE;
            }
            return str;
        }

        private void ShiftLeft(ref string oldKey)
        {
            string newKey = oldKey.Substring(keyShift);
            newKey += oldKey.Substring(0, keyShift);
            oldKey = newKey;
            keyUlong = StringToUlong(oldKey);
        }

        static private void ShiftRight(ref string oldKey)
        {
            string newKey = oldKey.Substring(oldKey.Length - keyShift);
            newKey += oldKey.Substring(0, oldKey.Length - keyShift);
            oldKey = newKey;
            keyUlong = StringToUlong(oldKey);
        }

        static private string PadString(string str)
        {
            int count = symbolsInBlock - (str.Length % symbolsInBlock);
            if (count != symbolsInBlock)
            {
                for (int i = 0; i < count; ++i)
                {
                    str += " ";
                }
            }
            return str;
        }

        static private string EncryptBlock(string block)
        {
            ulong tempblock = StringToUlong(block);
            for (int i = 0; i < 100; ++i)
            {
                string stringLeft = block.Substring(0, block.Length / 2);
                string stringRight = block.Substring(block.Length / 2);

                ulong ulongLeft = StringToUlong(stringLeft);
                ulong ulongRight = StringToUlong(stringRight);

                ulong tmp = ulongLeft ^ (ulongRight ^ keyUlong);
                ulongLeft = ulongRight;
                ulongRight = tmp;

                stringLeft = UlongToString(ulongLeft);
                stringRight = UlongToString(ulongRight);

                block = stringLeft + stringRight;
            }
            ulong temp = StringToUlong(block);
            temp = tempblock ^ temp;
            block = UlongToString(temp);
            Key = block;
            return block;
        }

        private string DecryptBlock(string block)
        {
            for (int i = 0; i < ROUNDS; ++i)
            {
                string stringLeft = block.Substring(0, block.Length / 2);
                string stringRight = block.Substring(block.Length / 2);

                ulong ulongLeft = StringToUlong(stringLeft);
                ulong ulongRight = StringToUlong(stringRight);

                ulong tmp = ulongRight ^ (ulongLeft ^ keyUlong);
                ulongRight = ulongLeft;
                ulongLeft = tmp;

                stringLeft = UlongToString(ulongLeft);
                stringRight = UlongToString(ulongRight);

                block = stringLeft + stringRight;
            }
            return block;
        }

        static private void Initialize(string key)
        {
            keyUlong = StringToUlong(key);
        }

        static public string Encrypt(string text)
        {
            Initialize(Key);
            string result = "";
            text = PadString(text);
            int count = text.Length / symbolsInBlock;
            for (int i = 0; i < count; ++i)
            {
                int start = i * symbolsInBlock;
                result += EncryptBlock(text.Substring(start, symbolsInBlock));
                ShiftRight(ref Key);
            }
            return result;
        }

        //public string Decrypt(string text, string key)
        //{
        //    string tmpKey = key;

        //    Initialize(key);

        //    if (text.Length % symbolsInBlock != 0)
        //    {
        //        return "Ошибка: зашифрованная строка в неверном формате.";
        //    }

        //    string result = "";
        //    int count = text.Length / symbolsInBlock;
        //    for (int i = count - 1; i >= 0; --i)
        //    {
        //        ShiftLeft(ref key);
        //        int start = i * symbolsInBlock;
        //        result = DecryptBlock(text.Substring(start, symbolsInBlock)) + result;
        //    }

        //    key = tmpKey;
        //    text = Encrypt(result, key);

        //    key = tmpKey;
        //    Initialize(key);
        //    result = "";
        //    count = text.Length / symbolsInBlock;
        //    for (int i = count - 1; i >= 0; --i)
        //    {
        //        ShiftLeft(ref key);
        //        int start = i * symbolsInBlock;
        //        result = DecryptBlock(text.Substring(start, symbolsInBlock)) + result;
        //    }

        //    return result;
        //}

        public string GenerateKey()
        {
            var random = new Random();
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string key = "";

            for (int i = 0; i < KEY_SIZE; ++i)
            {
                char curChar = alphabet[random.Next(alphabet.Length)];
                key += curChar;
            }
            Encoding encoding = Encoding.UTF8;
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(key));
            return Convert.ToBase64String(hash);
        }
    }
}
