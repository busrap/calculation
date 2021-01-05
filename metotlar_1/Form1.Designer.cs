namespace metotlar_1
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_girilen_1 = new System.Windows.Forms.TextBox();
            this.txt_girilen_2 = new System.Windows.Forms.TextBox();
            this.chexbox_cevre_hesap = new System.Windows.Forms.CheckBox();
            this.checkBox_alan_hesap = new System.Windows.Forms.CheckBox();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "1. kenarı giriniz :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "2. kenarı giriniz:";
            // 
            // txt_girilen_1
            // 
            this.txt_girilen_1.Location = new System.Drawing.Point(226, 72);
            this.txt_girilen_1.Name = "txt_girilen_1";
            this.txt_girilen_1.Size = new System.Drawing.Size(164, 22);
            this.txt_girilen_1.TabIndex = 4;
            // 
            // txt_girilen_2
            // 
            this.txt_girilen_2.Location = new System.Drawing.Point(226, 124);
            this.txt_girilen_2.Name = "txt_girilen_2";
            this.txt_girilen_2.Size = new System.Drawing.Size(164, 22);
            this.txt_girilen_2.TabIndex = 5;
            // 
            // chexbox_cevre_hesap
            // 
            this.chexbox_cevre_hesap.AutoSize = true;
            this.chexbox_cevre_hesap.Location = new System.Drawing.Point(168, 351);
            this.chexbox_cevre_hesap.Name = "chexbox_cevre_hesap";
            this.chexbox_cevre_hesap.Size = new System.Drawing.Size(140, 21);
            this.chexbox_cevre_hesap.TabIndex = 6;
            this.chexbox_cevre_hesap.Text = "çevresini hesapla";
            this.chexbox_cevre_hesap.UseVisualStyleBackColor = true;
            this.chexbox_cevre_hesap.CheckedChanged += new System.EventHandler(this.chexbox_cevre_hesap_CheckedChanged);
            // 
            // checkBox_alan_hesap
            // 
            this.checkBox_alan_hesap.AutoSize = true;
            this.checkBox_alan_hesap.Location = new System.Drawing.Point(168, 309);
            this.checkBox_alan_hesap.Name = "checkBox_alan_hesap";
            this.checkBox_alan_hesap.Size = new System.Drawing.Size(125, 21);
            this.checkBox_alan_hesap.TabIndex = 7;
            this.checkBox_alan_hesap.Text = "alanını hesapla";
            this.checkBox_alan_hesap.UseVisualStyleBackColor = true;
            this.checkBox_alan_hesap.CheckedChanged += new System.EventHandler(this.checkBox_alan_hesap_CheckedChanged);
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(319, 451);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(18, 17);
            this.lbl_sonuc.TabIndex = 8;
            this.lbl_sonuc.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "sonuç :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.checkBox_alan_hesap);
            this.Controls.Add(this.chexbox_cevre_hesap);
            this.Controls.Add(this.txt_girilen_2);
            this.Controls.Add(this.txt_girilen_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_girilen_1;
        private System.Windows.Forms.TextBox txt_girilen_2;
        private System.Windows.Forms.CheckBox chexbox_cevre_hesap;
        private System.Windows.Forms.CheckBox checkBox_alan_hesap;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.Label label1;
    }
}

