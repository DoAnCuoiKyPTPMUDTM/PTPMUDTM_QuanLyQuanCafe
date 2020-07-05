namespace Control_QuanLyCoffee
{
    partial class ctrl_HienThiSanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTenSanPham = new System.Windows.Forms.Label();
            this.lbGiaSanPham = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 81);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbTenSanPham
            // 
            this.lbTenSanPham.AutoSize = true;
            this.lbTenSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSanPham.Location = new System.Drawing.Point(102, 14);
            this.lbTenSanPham.Name = "lbTenSanPham";
            this.lbTenSanPham.Size = new System.Drawing.Size(119, 21);
            this.lbTenSanPham.TabIndex = 1;
            this.lbTenSanPham.Text = "Tên Sản Phẩm";
            // 
            // lbGiaSanPham
            // 
            this.lbGiaSanPham.AutoSize = true;
            this.lbGiaSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaSanPham.Location = new System.Drawing.Point(102, 45);
            this.lbGiaSanPham.Name = "lbGiaSanPham";
            this.lbGiaSanPham.Size = new System.Drawing.Size(103, 19);
            this.lbGiaSanPham.TabIndex = 2;
            this.lbGiaSanPham.Text = "Giá Sản Phẩm";
            // 
            // ctrl_HienThiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbGiaSanPham);
            this.Controls.Add(this.lbTenSanPham);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ctrl_HienThiSanPham";
            this.Size = new System.Drawing.Size(305, 87);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTenSanPham;
        private System.Windows.Forms.Label lbGiaSanPham;
    }
}
