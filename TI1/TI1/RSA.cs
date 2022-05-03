using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI1
{
    internal class RSA : Cipher
    {
        private int p, q, r, f, public_key, private_key;
        public byte[] data;
        private ushort[] cipherText, decipherText;

        public bool isPrime(int number) {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public int getR() {
            r = p * q;
            return r;
        }

        public void SetF() {
            f = (p - 1) * (q - 1);
        }

        public int getF() {
            return f;
        }

        public int getPublicKey() {
            Triple triple = evkl_extended(f, private_key);
            public_key = triple.y;
            return public_key;
        }

        public Triple evkl_extended(int a, int b) {
            int d0, d1, d2, x0, x1, x2, y0, y1, y2, q;
            d0 = a; d1 = b; x0 = 1; x1 = 0; y0 = 0; y1 = 1;
            while (d1 > 1) {
                q = d0 / d1;
                d2 = d0 % d1;
                x2 = x0 - q * x1;
                y2 = y0 - q * y1;
                d0 = d1; d1 = d2;
                x0 = x1; x1 = x2;
                y0 = y1; y1 = y2;
            }
            if (y1 < 0) y1 += a;
            return new Triple(x1, y1, d1);
        }

        public int fast_exp(int a, int z, int n) {
            int a1, z1, x;
            a1 = a; z1 = z; x = 1;
            while (z1 != 0) {
                while (z1 % 2 == 0) {
                    z1 = z1 / 2;
                    a1 = (a1 * a1) % n;
                }
                z1--;
                x = (x * a1) % n;
            }
            return x;
        }

        public void cipher()
        {
            if (data == null)
            {
                MessageBox.Show("Данные не введены.");
                return;
            }
            cipherText = new ushort[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                cipherText[i] = (ushort)fast_exp(data[i], public_key, r);
            }
        }
        public override void decipher()
        {
            if (cipherText == null)
            {
                return;
            }
            decipherText = new ushort[cipherText.Length];
            for (int i = 0; i < cipherText.Length; i++)
            {
                decipherText[i] = (ushort)fast_exp(cipherText[i], private_key, r);
            }
        }

        public override ushort[] getCipher() {
            return cipherText;
        }

        public void setCipher(ushort[] cipher)
        {
            this.cipherText = cipher;
        }

        public ushort[] getDecipher() {
            return decipherText;
        }

        public override int setP(String pText)
        {
            p = Convert.ToInt32(pText);
            return p;
        }

        public override int setQ(String qText)
        {
            q = Convert.ToInt32(qText);
            getR();
            SetF();            
            return q;
        }

        public override int setPrivateKey(String text)
        {
            private_key = Convert.ToInt32(text);
            getPublicKey();
            return private_key;
        }

        public String checkPrKey() {
            if (private_key > f) return "Ключ больше функции Эйлера";
            Triple triple = evkl_extended(f, private_key);
            if (triple.d != 1) return "Ключ и функция Эйлера не взаимно простые";
            return "";
        }

        public String getNumberFromText(String text) { 
            char[] chars = text.ToCharArray();
            StringBuilder numberText = new StringBuilder();
            char[] digits = "0123456789".ToCharArray();
            for (int i = 0; i < chars.Length; i++) {
                if (digits.Contains(chars[i])) { 
                    numberText.Append(chars[i]);
                }
            }
            if (numberText.Length == 0)
            {
                return "";
            }
            else
            {
                return numberText.ToString();
            }
        }
    }
    class Triple {
        public int x, y, d;
        public Triple(int x, int y, int d) { 
            this.x = x;
            this.y = y;
            this.d = d;
        }
    }
}
