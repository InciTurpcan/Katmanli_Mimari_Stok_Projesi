namespace ders9_NTie_Desing_Katmanli_Mimari_calisma.Forms.Product
{
    partial class frmProductUpdateDelete
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
            this.label1 = new System.Windows.Forms.Label();
            this.lst_product = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_product_update = new System.Windows.Forms.Button();
            this.btn_product_delete = new System.Windows.Forms.Button();
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.cmb_kategoriler = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_markalar = new System.Windows.Forms.ComboBox();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜN GÜNCELLE/SİL FORMU";
            // 
            // lst_product
            // 
            this.lst_product.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lst_product.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lst_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_product.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lst_product.FullRowSelect = true;
            this.lst_product.GridLines = true;
            this.lst_product.HideSelection = false;
            this.lst_product.Location = new System.Drawing.Point(439, 38);
            this.lst_product.Name = "lst_product";
            this.lst_product.Size = new System.Drawing.Size(721, 335);
            this.lst_product.TabIndex = 1;
            this.lst_product.UseCompatibleStateImageBehavior = false;
            this.lst_product.View = System.Windows.Forms.View.Details;
            this.lst_product.Click += new System.EventHandler(this.lst_product_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ProductID";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Name";
            this.columnHeader2.Width = 132;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Company Name";
            this.columnHeader3.Width = 132;
            // 
            // btn_product_update
            // 
            this.btn_product_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_product_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_product_update.Location = new System.Drawing.Point(67, 377);
            this.btn_product_update.Name = "btn_product_update";
            this.btn_product_update.Size = new System.Drawing.Size(193, 61);
            this.btn_product_update.TabIndex = 2;
            this.btn_product_update.Text = "GÜNCELLE";
            this.btn_product_update.UseVisualStyleBackColor = false;
            this.btn_product_update.Click += new System.EventHandler(this.btn_product_update_Click);
            // 
            // btn_product_delete
            // 
            this.btn_product_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_product_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_product_delete.Location = new System.Drawing.Point(383, 379);
            this.btn_product_delete.Name = "btn_product_delete";
            this.btn_product_delete.Size = new System.Drawing.Size(211, 59);
            this.btn_product_delete.TabIndex = 3;
            this.btn_product_delete.Text = "SİL";
            this.btn_product_delete.UseVisualStyleBackColor = false;
            this.btn_product_delete.Click += new System.EventHandler(this.btn_product_delete_Click);
            // 
            // txt_productname
            // 
            this.txt_productname.Location = new System.Drawing.Point(236, 67);
            this.txt_productname.Multiline = true;
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(197, 25);
            this.txt_productname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "ÜRÜN ADI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "FİYATI";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(236, 246);
            this.txt_Price.Multiline = true;
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(197, 24);
            this.txt_Price.TabIndex = 7;
            // 
            // cmb_kategoriler
            // 
            this.cmb_kategoriler.FormattingEnabled = true;
            this.cmb_kategoriler.Location = new System.Drawing.Point(250, 182);
            this.cmb_kategoriler.Name = "cmb_kategoriler";
            this.cmb_kategoriler.Size = new System.Drawing.Size(153, 24);
            this.cmb_kategoriler.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "KATEGORİ SEÇİNİZ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "MARKA SEÇİNİZ";
            // 
            // cmb_markalar
            // 
            this.cmb_markalar.FormattingEnabled = true;
            this.cmb_markalar.Location = new System.Drawing.Point(250, 124);
            this.cmb_markalar.Name = "cmb_markalar";
            this.cmb_markalar.Size = new System.Drawing.Size(153, 24);
            this.cmb_markalar.TabIndex = 14;
            // 
            // txt_stok
            // 
            this.txt_stok.Location = new System.Drawing.Point(236, 294);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(153, 22);
            this.txt_stok.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "STOK";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Categories";
            this.columnHeader4.Width = 93;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Unit Price";
            this.columnHeader5.Width = 103;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Stok  ";
            this.columnHeader6.Width = 85;
            // 
            // frmProductUpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 507);
            this.Controls.Add(this.txt_stok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_kategoriler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_markalar);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_productname);
            this.Controls.Add(this.btn_product_delete);
            this.Controls.Add(this.btn_product_update);
            this.Controls.Add(this.lst_product);
            this.Controls.Add(this.label1);
            this.Name = "frmProductUpdateDelete";
            this.Text = "frmProductUpdateDelete";
            this.Load += new System.EventHandler(this.frmProductUpdateDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lst_product;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btn_product_update;
        private System.Windows.Forms.Button btn_product_delete;
        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.ComboBox cmb_kategoriler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_markalar;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}