﻿namespace QLTV_GUI
{
    partial class pp_PhieuThuTienPhat
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
            this.cr_Viewer.Size = new System.Drawing.Size(777, 445);
            this.cr_Viewer.TabIndex = 0;
            // 
            // pp_PhieuThuTienPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 445);
            this.Controls.Add(this.cr_Viewer);
            this.Name = "pp_PhieuThuTienPhat";
            this.Text = "Phiếu thu tiền phạt";
            this.Load += new System.EventHandler(this.pp_PhieuThuTienPhat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cr_Viewer;
    }
}