namespace TrstenjakDavid_PPZ02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.comboBox_količina = new System.Windows.Forms.ComboBox();
            this.radioButton_gazirana = new System.Windows.Forms.RadioButton();
            this.radioButton_negazirana = new System.Windows.Forms.RadioButton();
            this.radioButton_alkoholna = new System.Windows.Forms.RadioButton();
            this.labelNaslov = new System.Windows.Forms.Label();
            this.trackBar_postotak = new System.Windows.Forms.TrackBar();
            this.richTextBox_ispis = new System.Windows.Forms.RichTextBox();
            this.textBox_naziv = new System.Windows.Forms.TextBox();
            this.textBox_cijena = new System.Windows.Forms.TextBox();
            this.comboBox_pakiranje = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelVrijednost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_postotak)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(620, 45);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(125, 75);
            this.btnUnos.TabIndex = 0;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(620, 160);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(125, 75);
            this.btnIspis.TabIndex = 1;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // comboBox_količina
            // 
            this.comboBox_količina.FormattingEnabled = true;
            this.comboBox_količina.Items.AddRange(new object[] {
            "0.5 L",
            "1 L",
            "1.5 L",
            "2 L"});
            this.comboBox_količina.Location = new System.Drawing.Point(205, 79);
            this.comboBox_količina.Name = "comboBox_količina";
            this.comboBox_količina.Size = new System.Drawing.Size(145, 21);
            this.comboBox_količina.TabIndex = 2;
            // 
            // radioButton_gazirana
            // 
            this.radioButton_gazirana.AutoSize = true;
            this.radioButton_gazirana.Location = new System.Drawing.Point(77, 79);
            this.radioButton_gazirana.Name = "radioButton_gazirana";
            this.radioButton_gazirana.Size = new System.Drawing.Size(67, 17);
            this.radioButton_gazirana.TabIndex = 3;
            this.radioButton_gazirana.TabStop = true;
            this.radioButton_gazirana.Text = "Gazirana";
            this.radioButton_gazirana.UseVisualStyleBackColor = true;
            // 
            // radioButton_negazirana
            // 
            this.radioButton_negazirana.AutoSize = true;
            this.radioButton_negazirana.Location = new System.Drawing.Point(77, 102);
            this.radioButton_negazirana.Name = "radioButton_negazirana";
            this.radioButton_negazirana.Size = new System.Drawing.Size(79, 17);
            this.radioButton_negazirana.TabIndex = 4;
            this.radioButton_negazirana.TabStop = true;
            this.radioButton_negazirana.Text = "Negazirana";
            this.radioButton_negazirana.UseVisualStyleBackColor = true;
            // 
            // radioButton_alkoholna
            // 
            this.radioButton_alkoholna.AutoSize = true;
            this.radioButton_alkoholna.Location = new System.Drawing.Point(77, 125);
            this.radioButton_alkoholna.Name = "radioButton_alkoholna";
            this.radioButton_alkoholna.Size = new System.Drawing.Size(72, 17);
            this.radioButton_alkoholna.TabIndex = 5;
            this.radioButton_alkoholna.TabStop = true;
            this.radioButton_alkoholna.Text = "Alkoholna";
            this.radioButton_alkoholna.UseVisualStyleBackColor = true;
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNaslov.Location = new System.Drawing.Point(305, 24);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(168, 24);
            this.labelNaslov.TabIndex = 6;
            this.labelNaslov.Text = "Narudžbenica pića";
            // 
            // trackBar_postotak
            // 
            this.trackBar_postotak.Location = new System.Drawing.Point(77, 190);
            this.trackBar_postotak.Maximum = 60;
            this.trackBar_postotak.Name = "trackBar_postotak";
            this.trackBar_postotak.Size = new System.Drawing.Size(466, 45);
            this.trackBar_postotak.TabIndex = 7;
            this.trackBar_postotak.Scroll += new System.EventHandler(this.trackBar_postotak_Scroll);
            // 
            // richTextBox_ispis
            // 
            this.richTextBox_ispis.Location = new System.Drawing.Point(80, 270);
            this.richTextBox_ispis.Name = "richTextBox_ispis";
            this.richTextBox_ispis.Size = new System.Drawing.Size(668, 168);
            this.richTextBox_ispis.TabIndex = 8;
            this.richTextBox_ispis.Text = "";
            this.richTextBox_ispis.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox_naziv
            // 
            this.textBox_naziv.Location = new System.Drawing.Point(403, 79);
            this.textBox_naziv.Multiline = true;
            this.textBox_naziv.Name = "textBox_naziv";
            this.textBox_naziv.Size = new System.Drawing.Size(140, 20);
            this.textBox_naziv.TabIndex = 9;
            // 
            // textBox_cijena
            // 
            this.textBox_cijena.Location = new System.Drawing.Point(403, 124);
            this.textBox_cijena.Name = "textBox_cijena";
            this.textBox_cijena.Size = new System.Drawing.Size(140, 20);
            this.textBox_cijena.TabIndex = 10;
            // 
            // comboBox_pakiranje
            // 
            this.comboBox_pakiranje.FormattingEnabled = true;
            this.comboBox_pakiranje.Items.AddRange(new object[] {
            "Staklo",
            "PET",
            "Tetrapak"});
            this.comboBox_pakiranje.Location = new System.Drawing.Point(205, 122);
            this.comboBox_pakiranje.Name = "comboBox_pakiranje";
            this.comboBox_pakiranje.Size = new System.Drawing.Size(145, 21);
            this.comboBox_pakiranje.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Vrsta pića";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Naziv pića";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cijena pića";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Količina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Vrsta pakiranja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Postotak alkohola";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Vaša narudžba : ";
            // 
            // labelVrijednost
            // 
            this.labelVrijednost.AutoSize = true;
            this.labelVrijednost.Location = new System.Drawing.Point(549, 190);
            this.labelVrijednost.Name = "labelVrijednost";
            this.labelVrijednost.Size = new System.Drawing.Size(0, 13);
            this.labelVrijednost.TabIndex = 19;
            this.labelVrijednost.Click += new System.EventHandler(this.labelVrijednost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelVrijednost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_pakiranje);
            this.Controls.Add(this.textBox_cijena);
            this.Controls.Add(this.textBox_naziv);
            this.Controls.Add(this.richTextBox_ispis);
            this.Controls.Add(this.trackBar_postotak);
            this.Controls.Add(this.labelNaslov);
            this.Controls.Add(this.radioButton_alkoholna);
            this.Controls.Add(this.radioButton_negazirana);
            this.Controls.Add(this.radioButton_gazirana);
            this.Controls.Add(this.comboBox_količina);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnUnos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_postotak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.ComboBox comboBox_količina;
        private System.Windows.Forms.RadioButton radioButton_gazirana;
        private System.Windows.Forms.RadioButton radioButton_negazirana;
        private System.Windows.Forms.RadioButton radioButton_alkoholna;
        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.TrackBar trackBar_postotak;
        private System.Windows.Forms.RichTextBox richTextBox_ispis;
        private System.Windows.Forms.TextBox textBox_naziv;
        private System.Windows.Forms.TextBox textBox_cijena;
        private System.Windows.Forms.ComboBox comboBox_pakiranje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelVrijednost;
    }
}

