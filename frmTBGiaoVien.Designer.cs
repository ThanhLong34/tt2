namespace Lab02_Vidu2
{
    partial class frmTBGiaoVien
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
            this.lblTBGiaoVien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTBGiaoVien
            // 
            this.lblTBGiaoVien.AutoSize = true;
            this.lblTBGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTBGiaoVien.Location = new System.Drawing.Point(12, 23);
            this.lblTBGiaoVien.Name = "lblTBGiaoVien";
            this.lblTBGiaoVien.Size = new System.Drawing.Size(65, 17);
            this.lblTBGiaoVien.TabIndex = 0;
            this.lblTBGiaoVien.Text = "message";
            // 
            // frmTBGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(370, 144);
            this.Controls.Add(this.lblTBGiaoVien);
            this.Name = "frmTBGiaoVien";
            this.Text = "frmTBGiaoVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTBGiaoVien;
    }
}