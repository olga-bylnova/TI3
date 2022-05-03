using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI1
{
    internal abstract class Cipher
    {       
        public abstract void decipher();
        public abstract int setP(String pText);
        public abstract int setQ(String qText);
        public abstract ushort[] getCipher();
        public abstract int setPrivateKey(String keyText);
        public void printBytes(byte[] bytes, TextBox textBox)
        {
            int i = 0;
            int countMax = 496;
            StringBuilder text = new StringBuilder();
            for (; i < countMax && i < bytes.Length; i++)
            {
                text.Append(bytes[i].ToString() + " ");
            }
            textBox.Text = text.ToString();
        }
        public void printDecimal(ushort[] data, TextBox textBox) {
            int i = 0;
            int countMax = 496;
            StringBuilder text = new StringBuilder();
            for (; i < countMax && i < data.Length; i++)
            {
                text.Append(data[i].ToString() + " ");
            }
            textBox.Text = text.ToString();
        }
    }
}
