using System.Collections;

namespace TI1
{
    public partial class Form1 : Form
    {
        RSA cipher;
        String prKeyValue1 = "", pValue1 = "", qValue1 = "";
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            cipher = new RSA();
        }
        private void compute_button_Click(object sender, EventArgs e)
        {
            String p, q, prKey;
            String pValue, qValue, prKeyValue;            
            p = PBox.Text;
            q = QBox.Text;
            prKey = PrivateKeyBox.Text;
            if (p == "" || q == "" || prKey == "")
            {
                if (p == "")
                    MessageBox.Show("Введите P.");
                if (q == "")
                    MessageBox.Show("Введите Q.");
                if (prKey == "")
                    MessageBox.Show("Введите ключ.");
            }
            else
            {                
                pValue = cipher.getNumberFromText(p);
                qValue = cipher.getNumberFromText(q);
                prKeyValue = cipher.getNumberFromText(prKey);
                if (pValue == "" || qValue == "" || prKeyValue == "")
                {
                    if (pValue == "")
                        MessageBox.Show("P состоит из недопустимых символов.");
                    if (qValue == "")
                        MessageBox.Show("Q состоит из недопустимых символов.");
                    if (prKeyValue == "")
                        MessageBox.Show("Ключ состоит из недопустимых символов.");
                }
                else
                {
                    bool p1 = !cipher.isPrime(cipher.setP(pValue));
                    bool q1 = !cipher.isPrime(cipher.setQ(qValue));
                    cipher.setPrivateKey(prKeyValue);
                    String pr1 = cipher.checkPrKey();
                    int r = cipher.getR();
                    if (p1 || q1 || pr1 != "" || r >= 65_535 || r < 256)
                    {
                        if (p1)
                            MessageBox.Show("P не простое число.");
                        if (q1)
                            MessageBox.Show("Q не простое число.");
                        if (pr1 != "")
                            MessageBox.Show(pr1);
                        if (r >= 65_535 || r < 256)
                            MessageBox.Show("Произведение p и q неоднозначно для расшифровки.");
                    }
                    else
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            resultBox.Text = "";
                            pValue1 = pValue;
                            qValue1 = qValue;
                            prKeyValue1 = prKeyValue;
                            cipher.cipher();
                            if (cipher.getCipher() != null)
                            {
                                cipher.printDecimal(cipher.getCipher(), resultBox);
                                keyBox.Text = cipher.getPublicKey().ToString();
                                textBox1.Text = cipher.getF().ToString();
                                MessageBox.Show("Computed.");
                            }
                        }
                        else
                        {
                            if (!pValue1.Equals(pValue) || !qValue1.Equals(qValue) || !prKeyValue1.Equals(prKeyValue))
                            {
                                MessageBox.Show("Введенные параметры не применимы для расшифровки.");
                            }
                            else
                            {
                                cipher.decipher();
                                if (cipher.getDecipher() != null)
                                {
                                    cipher.printDecimal(cipher.getDecipher(), resultBox);
                                    MessageBox.Show("Computed.");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                ushort[] data;
                string filePath = saveFD.FileName;
                if (comboBox1.SelectedIndex == 0)
                {
                    data = cipher.getCipher();
                    byte[] result = new byte[data.Length * sizeof(ushort)];
                    Buffer.BlockCopy(data, 0, result, 0, result.Length);
                    File.WriteAllBytes(filePath, result);
                }
                else
                {
                    data = cipher.getDecipher();
                    var sdata = Array.ConvertAll(data, b => (byte)b);
                    File.WriteAllBytes(filePath, sdata);
                }
            }
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    string filePath = openFD.FileName;
                    cipher.data = File.ReadAllBytes(filePath);
                    cipher.printBytes(cipher.data, dataBox);
                }
                else {
                    string filePath = openFD.FileName;
                    byte[] data = File.ReadAllBytes(filePath);
                    ushort[] sdata = new ushort[(int)Math.Ceiling(data.Length / 2.0)];
                    Buffer.BlockCopy(data, 0, sdata, 0, data.Length);
                    cipher.setCipher(sdata);
                    cipher.printDecimal(cipher.getCipher(), dataBox);                    
                }
            }
        }
    }
}