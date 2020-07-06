namespace GUI
{
    partial class GUI_POS
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnLoai = new System.Windows.Forms.Panel();
            this.pnHienThiSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnButton = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnThemHoaDon = new System.Windows.Forms.Button();
            this.pnHoaDon = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.54808F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.45192F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel1.Controls.Add(this.pnLoai, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnHienThiSanPham, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.62356F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.37644F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1100, 497);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pnLoai
            // 
            this.pnLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLoai.Location = new System.Drawing.Point(835, 49);
            this.pnLoai.Name = "pnLoai";
            this.pnLoai.Size = new System.Drawing.Size(262, 381);
            this.pnLoai.TabIndex = 2;
            // 
            // pnHienThiSanPham
            // 
            this.pnHienThiSanPham.AutoScroll = true;
            this.pnHienThiSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHienThiSanPham.Location = new System.Drawing.Point(357, 49);
            this.pnHienThiSanPham.Name = "pnHienThiSanPham";
            this.pnHienThiSanPham.Size = new System.Drawing.Size(472, 381);
            this.pnHienThiSanPham.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pnButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnHoaDon, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 49);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(348, 381);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // pnButton
            // 
            this.pnButton.Controls.Add(this.button2);
            this.pnButton.Controls.Add(this.btnThemHoaDon);
            this.pnButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnButton.Location = new System.Drawing.Point(3, 3);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(425, 30);
            this.pnButton.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.Location = new System.Drawing.Point(261, 4);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(101, 23);
            this.btnThemHoaDon.TabIndex = 0;
            this.btnThemHoaDon.Text = "Thêm Hóa Đơn";
            this.btnThemHoaDon.UseVisualStyleBackColor = true;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
            // 
            // pnHoaDon
            // 
            this.pnHoaDon.AutoScroll = true;
            this.pnHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHoaDon.Location = new System.Drawing.Point(3, 39);
            this.pnHoaDon.Name = "pnHoaDon";
            this.pnHoaDon.Size = new System.Drawing.Size(425, 339);
            this.pnHoaDon.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTongTien);
            this.panel1.Location = new System.Drawing.Point(3, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 58);
            this.panel1.TabIndex = 5;
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(174, 13);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(62, 13);
            this.lbTongTien.TabIndex = 0;
            this.lbTongTien.Text = "Tổng Tiền: ";
            // 
            // GUI_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 497);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GUI_POS";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnButton.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnLoai;
        private System.Windows.Forms.FlowLayoutPanel pnHienThiSanPham;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.FlowLayoutPanel pnHoaDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTongTien;

    }
}

