namespace QLTV_GUI
{
    partial class XoaDocGia
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
            this.tb_maDocGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_maDocGia
            // 
            this.tb_maDocGia.Location = new System.Drawing.Point(146, 67);
            this.tb_maDocGia.Name = "tb_maDocGia";
            this.tb_maDocGia.Size = new System.Drawing.Size(100, 20);
            this.tb_maDocGia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã độc giả";
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(132, 124);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 23);
            this.bt_xoa.TabIndex = 2;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.Bt_xoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(71, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "(Vui lòng nhập chính xác mã độc giả)";
            // 
            // XoaDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 199);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_maDocGia);
            this.MaximumSize = new System.Drawing.Size(352, 238);
            this.MinimumSize = new System.Drawing.Size(352, 238);
            this.Name = "XoaDocGia";
            this.Text = "Xóa độc giả";
            this.Load += new System.EventHandler(this.XoaDocGia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_maDocGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Label label2;
    }
}