namespace QLTV_GUI
{
    partial class rp_MuonTheoTheLoai
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
            this.cr_Viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cr_Viewer
            // 
            this.cr_Viewer.ActiveViewIndex = -1;
            this.cr_Viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr_Viewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cr_Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cr_Viewer.Location = new System.Drawing.Point(0, 0);
            this.cr_Viewer.Name = "cr_Viewer";
            this.cr_Viewer.Size = new System.Drawing.Size(1064, 598);
            this.cr_Viewer.TabIndex = 0;
            // 
            // rp_MuonTheoTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 598);
            this.Controls.Add(this.cr_Viewer);
            this.Name = "rp_MuonTheoTheLoai";
            this.Text = "Báo cáo mượn theo thể loại";
            this.Load += new System.EventHandler(this.rp_MuonTheoTheLoai_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cr_Viewer;
    }
}