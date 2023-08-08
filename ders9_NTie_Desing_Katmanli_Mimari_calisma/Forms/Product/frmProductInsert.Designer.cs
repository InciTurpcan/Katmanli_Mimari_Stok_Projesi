namespace ders9_NTie_Desing_Katmanli_Mimari_calisma.Forms.Product
{
    partial class frmProductInsert
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.thx_ProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.cmb_markalar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_kategoriler = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Save.Location = new System.Drawing.Point(314, 378);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(165, 47);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "KAYDET";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.TextChanged += new System.EventHandler(this.btn_Save_TextChanged);
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // thx_ProductName
            // 
            this.thx_ProductName.Location = new System.Drawing.Point(314, 124);
            this.thx_ProductName.MaxLength = 25;
            this.thx_ProductName.Name = "thx_ProductName";
            this.thx_ProductName.Size = new System.Drawing.Size(242, 22);
            this.thx_ProductName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(89, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "ÜRÜN ADI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(144, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "ÜRÜN BİLGİLERİNİ GİRİNİZ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(89, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "FİYAT";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(314, 266);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(242, 22);
            this.txt_Price.TabIndex = 9;
            // 
            // cmb_markalar
            // 
            this.cmb_markalar.FormattingEnabled = true;
            this.cmb_markalar.Location = new System.Drawing.Point(314, 169);
            this.cmb_markalar.Name = "cmb_markalar";
            this.cmb_markalar.Size = new System.Drawing.Size(242, 24);
            this.cmb_markalar.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(89, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "MARKA SEÇİNİZ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(89, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "KATEGORİ SEÇİNİZ";
            // 
            // cmb_kategoriler
            // 
            this.cmb_kategoriler.FormattingEnabled = true;
            this.cmb_kategoriler.Location = new System.Drawing.Point(314, 217);
            this.cmb_kategoriler.Name = "cmb_kategoriler";
            this.cmb_kategoriler.Size = new System.Drawing.Size(242, 24);
            this.cmb_kategoriler.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(89, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "STOK";
            // 
            // txt_stok
            // 
            this.txt_stok.Location = new System.Drawing.Point(314, 321);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(242, 22);
            this.txt_stok.TabIndex = 15;
            // 
            // frmProductInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_stok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_kategoriler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_markalar);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.thx_ProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProductInsert";
            this.Text = "frmProductInsert";
            this.Load += new System.EventHandler(this.frmProductInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox thx_ProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.ComboBox cmb_markalar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_kategoriler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_stok;
    }
}