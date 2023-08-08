namespace ders9_NTie_Desing_Katmanli_Mimari_calisma.Forms.Supplier
{
    partial class frmSupplierUpdateDelete
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
            this.txt_SuppliersName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lst_supplier = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_SuppliersName
            // 
            this.txt_SuppliersName.Location = new System.Drawing.Point(329, 322);
            this.txt_SuppliersName.MaxLength = 25;
            this.txt_SuppliersName.Name = "txt_SuppliersName";
            this.txt_SuppliersName.Size = new System.Drawing.Size(242, 22);
            this.txt_SuppliersName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(140, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "MARKA ADI";
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Delete.Location = new System.Drawing.Point(382, 374);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(173, 53);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "SİL";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Update.Location = new System.Drawing.Point(140, 374);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(169, 53);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "GÜNCELLE";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lst_supplier
            // 
            this.lst_supplier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lst_supplier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lst_supplier.FullRowSelect = true;
            this.lst_supplier.GridLines = true;
            this.lst_supplier.HideSelection = false;
            this.lst_supplier.Location = new System.Drawing.Point(140, 76);
            this.lst_supplier.Name = "lst_supplier";
            this.lst_supplier.Size = new System.Drawing.Size(525, 222);
            this.lst_supplier.TabIndex = 7;
            this.lst_supplier.UseCompatibleStateImageBehavior = false;
            this.lst_supplier.View = System.Windows.Forms.View.Details;
            this.lst_supplier.Click += new System.EventHandler(this.lst_categoy_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SUPPLİERS ID";
            this.columnHeader1.Width = 137;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "COMPANY NAME";
            this.columnHeader2.Width = 153;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(137, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "MARKA GÜNCELLE/SİL FORMU";
            // 
            // frmSupplierUpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_SuppliersName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.lst_supplier);
            this.Controls.Add(this.label1);
            this.Name = "frmSupplierUpdateDelete";
            this.Text = "frmSupplierUpdateDelete";
            this.Load += new System.EventHandler(this.frmSupplierUpdateDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SuppliersName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ListView lst_supplier;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
    }
}