using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_protection_lab_1
{
    internal class Checker
    {
        private int packetSize;

        public Checker(int packetSize)
        {
            this.packetSize = packetSize;
        }

        private string Format(byte[] data)
        {
            string result = string.Empty;
            foreach (byte value in data)
            {
                string binarybyte = Convert.ToString(value, 2);
                while (binarybyte.Length < 12)
                {
                    binarybyte = "0" + binarybyte;
                }
                result += binarybyte;
            }
            return result;
        }

        private string PadString(string text)
        {
            while (text.Count() % packetSize != 0)
            {
                text += '0';
            }

            return text;
        }

        private string AddParityBits(string text)
        {
            text = PadString(text);
            string result = string.Empty;

            for (int i = 0; i < text.Count(); i += packetSize)
            {
                string curPack = text.Substring(i, packetSize);
                int ones = 0;
                foreach (char c in curPack)
                {
                    if (c == '1')
                    {
                        ++ones;
                    }
                }
                curPack += (ones % 2).ToString();
                result += curPack;
            }

            return result;
        }

        public string ConvertToBinary(string text)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(text);
            text = Format(bytes);
            text = AddParityBits(text);
            return text;
        }

        public bool Check(string text)
        {
            int parityPacketSize = packetSize + 1;

            if (text.Count() % parityPacketSize != 0)
            {
                return false;
            }

            for (int i = 0; i < text.Count(); i += parityPacketSize)
            {
                string curPack = text.Substring(i, parityPacketSize);
                int ones = 0;
                for (int j = 0; j < curPack.Count() - 1; ++j)
                {
                    if (curPack[j] == '1')
                    {
                        ++ones;
                    }
                }

                char cor;
                if (ones % 2 == 0)
                {
                    cor = '0';
                }
                else
                {
                    cor = '1';
                }

                if (cor != curPack[curPack.Count() - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
