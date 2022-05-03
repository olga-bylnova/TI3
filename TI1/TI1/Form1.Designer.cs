namespace TI1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.load_button = new System.Windows.Forms.Button();
            this.compute_button = new System.Windows.Forms.Button();
            this.QBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.PrivateKeyBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Действие";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(790, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "P";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Шифровать",
            "Дешифровать"});
            this.comboBox1.Location = new System.Drawing.Point(29, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 33);
            this.comboBox1.TabIndex = 7;
            // 
            // PBox
            // 
            this.PBox.Location = new System.Drawing.Point(777, 48);
            this.PBox.Name = "PBox";
            this.PBox.Size = new System.Drawing.Size(561, 31);
            this.PBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Исходный текст";
            // 
            // dataBox
            // 
            this.dataBox.Location = new System.Drawing.Point(12, 139);
            this.dataBox.Multiline = true;
            this.dataBox.Name = "dataBox";
            this.dataBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dataBox.Size = new System.Drawing.Size(634, 207);
            this.dataBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Результат";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(12, 405);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultBox.Size = new System.Drawing.Size(634, 207);
            this.resultBox.TabIndex = 12;
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(261, 12);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(227, 32);
            this.load_button.TabIndex = 13;
            this.load_button.Text = "Загрузить из файла";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // compute_button
            // 
            this.compute_button.Location = new System.Drawing.Point(261, 88);
            this.compute_button.Name = "compute_button";
            this.compute_button.Size = new System.Drawing.Size(227, 32);
            this.compute_button.TabIndex = 15;
            this.compute_button.Text = "Вычислить";
            this.compute_button.UseVisualStyleBackColor = true;
            this.compute_button.Click += new System.EventHandler(this.compute_button_Click);
            // 
            // QBox
            // 
            this.QBox.Location = new System.Drawing.Point(777, 139);
            this.QBox.Name = "QBox";
            this.QBox.Size = new System.Drawing.Size(561, 31);
            this.QBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(790, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Q";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(790, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Public Key";
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(777, 405);
            this.keyBox.Multiline = true;
            this.keyBox.Name = "keyBox";
            this.keyBox.ReadOnly = true;
            this.keyBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.keyBox.Size = new System.Drawing.Size(552, 39);
            this.keyBox.TabIndex = 21;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(261, 50);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(227, 32);
            this.save_button.TabIndex = 22;
            this.save_button.Text = "Сохранить в файл";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(790, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Private Key";
            // 
            // PrivateKeyBox
            // 
            this.PrivateKeyBox.Location = new System.Drawing.Point(777, 242);
            this.PrivateKeyBox.Name = "PrivateKeyBox";
            this.PrivateKeyBox.Size = new System.Drawing.Size(561, 31);
            this.PrivateKeyBox.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(777, 513);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(552, 39);
            this.textBox1.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(790, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "F";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 701);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PrivateKeyBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.QBox);
            this.Controls.Add(this.compute_button);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox PBox;
        private Label label4;
        private TextBox dataBox;
        private Label label5;
        private TextBox resultBox;
        private Button load_button;
        private Button compute_button;
        private TextBox QBox;
        private Label label7;
        private Label label1;
        private TextBox keyBox;
        private Button save_button;
        private OpenFileDialog openFD;
        private SaveFileDialog saveFD;
        private Label label8;
        private TextBox PrivateKeyBox;
        private TextBox textBox1;
        private Label label6;
    }
}