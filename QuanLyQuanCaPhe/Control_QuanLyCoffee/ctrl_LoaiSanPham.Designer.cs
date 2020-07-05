namespace Control_QuanLyCoffee
{
    partial class ctrl_LoaiSanPham
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
            this.lbLoaiSP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLoaiSP
            // 
            this.lbLoaiSP.AutoSize = true;
            this.lbLoaiSP.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiSP.Location = new System.Drawing.Point(21, 12);
            this.lbLoaiSP.Name = "lbLoaiSP";
            this.lbLoaiSP.Size = new System.Drawing.Size(179, 31);
            this.lbLoaiSP.TabIndex = 0;
            this.lbLoaiSP.Text = "Loại Sản Phẩm";
            // 
            // ctrl_LoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbLoaiSP);
            this.Name = "ctrl_LoaiSanPham";
            this.Size = new System.Drawing.Size(228, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLoaiSP;


    }
}
