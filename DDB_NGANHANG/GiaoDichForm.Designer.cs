
namespace DDB_NGANHANG
{
    partial class GiaoDichForm
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
            this.GDTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.thoatGuiTxt = new System.Windows.Forms.Button();
            this.xacNhanGuiTxt = new System.Windows.Forms.Button();
            this.soTienGuiTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.thoatRutGDBtn = new System.Windows.Forms.Button();
            this.xacNhanRutGDBtn = new System.Windows.Forms.Button();
            this.soTienRutGDTxt = new System.Windows.Forms.TextBox();
            this.label1GD = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.soTaiKhoanNhanGDTxt = new System.Windows.Forms.TextBox();
            this.soTienChuyenGDTxt = new System.Windows.Forms.TextBox();
            this.label5GD = new System.Windows.Forms.Label();
            this.thoatChuyenGDBtn = new System.Windows.Forms.Button();
            this.xacNhanChuyenGDBtn = new System.Windows.Forms.Button();
            this.label4GD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taiKhoanGDTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.soDuGDTxt = new System.Windows.Forms.TextBox();
            this.label3GD = new System.Windows.Forms.Label();
            this.kiemTraBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GDTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GDTabControl
            // 
            this.GDTabControl.Controls.Add(this.tabPage1);
            this.GDTabControl.Controls.Add(this.tabPage2);
            this.GDTabControl.Controls.Add(this.tabPage3);
            this.GDTabControl.Font = new System.Drawing.Font("Markazi Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GDTabControl.ItemSize = new System.Drawing.Size(235, 40);
            this.GDTabControl.Location = new System.Drawing.Point(8, 19);
            this.GDTabControl.Multiline = true;
            this.GDTabControl.Name = "GDTabControl";
            this.GDTabControl.SelectedIndex = 0;
            this.GDTabControl.Size = new System.Drawing.Size(710, 307);
            this.GDTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.GDTabControl.TabIndex = 93;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.thoatGuiTxt);
            this.tabPage1.Controls.Add(this.xacNhanGuiTxt);
            this.tabPage1.Controls.Add(this.soTienGuiTxt);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(702, 259);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gửi tiền";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // thoatGuiTxt
            // 
            this.thoatGuiTxt.Location = new System.Drawing.Point(388, 163);
            this.thoatGuiTxt.Name = "thoatGuiTxt";
            this.thoatGuiTxt.Size = new System.Drawing.Size(134, 45);
            this.thoatGuiTxt.TabIndex = 3;
            this.thoatGuiTxt.Text = "Thoát";
            this.thoatGuiTxt.UseVisualStyleBackColor = true;
            this.thoatGuiTxt.Click += new System.EventHandler(this.thoatGuiTxt_Click);
            // 
            // xacNhanGuiTxt
            // 
            this.xacNhanGuiTxt.Location = new System.Drawing.Point(164, 163);
            this.xacNhanGuiTxt.Name = "xacNhanGuiTxt";
            this.xacNhanGuiTxt.Size = new System.Drawing.Size(134, 45);
            this.xacNhanGuiTxt.TabIndex = 2;
            this.xacNhanGuiTxt.Text = "Xác nhận";
            this.xacNhanGuiTxt.UseVisualStyleBackColor = true;
            this.xacNhanGuiTxt.Click += new System.EventHandler(this.xacNhanGuiTxt_Click);
            // 
            // soTienGuiTxt
            // 
            this.soTienGuiTxt.Location = new System.Drawing.Point(302, 41);
            this.soTienGuiTxt.Name = "soTienGuiTxt";
            this.soTienGuiTxt.Size = new System.Drawing.Size(252, 40);
            this.soTienGuiTxt.TabIndex = 1;
            this.soTienGuiTxt.TextChanged += new System.EventHandler(this.soTienGuiTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tiền";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.thoatRutGDBtn);
            this.tabPage2.Controls.Add(this.xacNhanRutGDBtn);
            this.tabPage2.Controls.Add(this.soTienRutGDTxt);
            this.tabPage2.Controls.Add(this.label1GD);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(702, 259);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rút tiền";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // thoatRutGDBtn
            // 
            this.thoatRutGDBtn.Location = new System.Drawing.Point(388, 163);
            this.thoatRutGDBtn.Name = "thoatRutGDBtn";
            this.thoatRutGDBtn.Size = new System.Drawing.Size(134, 45);
            this.thoatRutGDBtn.TabIndex = 3;
            this.thoatRutGDBtn.Text = "Thoát";
            this.thoatRutGDBtn.UseVisualStyleBackColor = true;
            this.thoatRutGDBtn.Click += new System.EventHandler(this.thoatRutGDBtn_Click);
            // 
            // xacNhanRutGDBtn
            // 
            this.xacNhanRutGDBtn.Location = new System.Drawing.Point(164, 163);
            this.xacNhanRutGDBtn.Name = "xacNhanRutGDBtn";
            this.xacNhanRutGDBtn.Size = new System.Drawing.Size(134, 45);
            this.xacNhanRutGDBtn.TabIndex = 2;
            this.xacNhanRutGDBtn.Text = "Xác nhận";
            this.xacNhanRutGDBtn.UseVisualStyleBackColor = true;
            this.xacNhanRutGDBtn.Click += new System.EventHandler(this.xacNhanRutGDBtn_Click);
            // 
            // soTienRutGDTxt
            // 
            this.soTienRutGDTxt.Location = new System.Drawing.Point(302, 41);
            this.soTienRutGDTxt.Name = "soTienRutGDTxt";
            this.soTienRutGDTxt.Size = new System.Drawing.Size(252, 40);
            this.soTienRutGDTxt.TabIndex = 1;
            // 
            // label1GD
            // 
            this.label1GD.AutoSize = true;
            this.label1GD.Location = new System.Drawing.Point(124, 46);
            this.label1GD.Name = "label1GD";
            this.label1GD.Size = new System.Drawing.Size(81, 35);
            this.label1GD.TabIndex = 0;
            this.label1GD.Text = "Số tiền";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.soTaiKhoanNhanGDTxt);
            this.tabPage3.Controls.Add(this.soTienChuyenGDTxt);
            this.tabPage3.Controls.Add(this.label5GD);
            this.tabPage3.Controls.Add(this.thoatChuyenGDBtn);
            this.tabPage3.Controls.Add(this.xacNhanChuyenGDBtn);
            this.tabPage3.Controls.Add(this.label4GD);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(702, 259);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Chuyển tiền ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // soTaiKhoanNhanGDTxt
            // 
            this.soTaiKhoanNhanGDTxt.Location = new System.Drawing.Point(278, 20);
            this.soTaiKhoanNhanGDTxt.Name = "soTaiKhoanNhanGDTxt";
            this.soTaiKhoanNhanGDTxt.Size = new System.Drawing.Size(340, 40);
            this.soTaiKhoanNhanGDTxt.TabIndex = 9;
            // 
            // soTienChuyenGDTxt
            // 
            this.soTienChuyenGDTxt.Location = new System.Drawing.Point(278, 82);
            this.soTienChuyenGDTxt.Name = "soTienChuyenGDTxt";
            this.soTienChuyenGDTxt.Size = new System.Drawing.Size(340, 40);
            this.soTienChuyenGDTxt.TabIndex = 5;
            // 
            // label5GD
            // 
            this.label5GD.AutoSize = true;
            this.label5GD.Location = new System.Drawing.Point(46, 23);
            this.label5GD.Name = "label5GD";
            this.label5GD.Size = new System.Drawing.Size(187, 35);
            this.label5GD.TabIndex = 8;
            this.label5GD.Text = "Số tài khoản nhận";
            // 
            // thoatChuyenGDBtn
            // 
            this.thoatChuyenGDBtn.Location = new System.Drawing.Point(388, 156);
            this.thoatChuyenGDBtn.Name = "thoatChuyenGDBtn";
            this.thoatChuyenGDBtn.Size = new System.Drawing.Size(134, 45);
            this.thoatChuyenGDBtn.TabIndex = 7;
            this.thoatChuyenGDBtn.Text = "Thoát";
            this.thoatChuyenGDBtn.UseVisualStyleBackColor = true;
            this.thoatChuyenGDBtn.Click += new System.EventHandler(this.thoatChuyenGDBtn_Click);
            // 
            // xacNhanChuyenGDBtn
            // 
            this.xacNhanChuyenGDBtn.Location = new System.Drawing.Point(164, 156);
            this.xacNhanChuyenGDBtn.Name = "xacNhanChuyenGDBtn";
            this.xacNhanChuyenGDBtn.Size = new System.Drawing.Size(134, 45);
            this.xacNhanChuyenGDBtn.TabIndex = 6;
            this.xacNhanChuyenGDBtn.Text = "Xác nhận";
            this.xacNhanChuyenGDBtn.UseVisualStyleBackColor = true;
            this.xacNhanChuyenGDBtn.Click += new System.EventHandler(this.xacNhanChuyenGDBtn_Click);
            // 
            // label4GD
            // 
            this.label4GD.AutoSize = true;
            this.label4GD.Location = new System.Drawing.Point(46, 87);
            this.label4GD.Name = "label4GD";
            this.label4GD.Size = new System.Drawing.Size(81, 35);
            this.label4GD.TabIndex = 4;
            this.label4GD.Text = "Số tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Markazi Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 35);
            this.label2.TabIndex = 94;
            this.label2.Text = "Số dư";
            // 
            // taiKhoanGDTxt
            // 
            this.taiKhoanGDTxt.Font = new System.Drawing.Font("Markazi Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taiKhoanGDTxt.Location = new System.Drawing.Point(271, 137);
            this.taiKhoanGDTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.taiKhoanGDTxt.Name = "taiKhoanGDTxt";
            this.taiKhoanGDTxt.Size = new System.Drawing.Size(282, 40);
            this.taiKhoanGDTxt.TabIndex = 95;
            this.taiKhoanGDTxt.TextChanged += new System.EventHandler(this.taiKhoanGDTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Markazi Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 35);
            this.label3.TabIndex = 96;
            this.label3.Text = "Tài khoản";
            // 
            // soDuGDTxt
            // 
            this.soDuGDTxt.Font = new System.Drawing.Font("Markazi Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soDuGDTxt.Location = new System.Drawing.Point(271, 210);
            this.soDuGDTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.soDuGDTxt.Name = "soDuGDTxt";
            this.soDuGDTxt.ReadOnly = true;
            this.soDuGDTxt.Size = new System.Drawing.Size(282, 40);
            this.soDuGDTxt.TabIndex = 97;
            // 
            // label3GD
            // 
            this.label3GD.Font = new System.Drawing.Font("Markazi Text", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3GD.Image = global::DDB_NGANHANG.Properties.Resources.transaction__1_;
            this.label3GD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3GD.Location = new System.Drawing.Point(198, -3);
            this.label3GD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3GD.Name = "label3GD";
            this.label3GD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3GD.Size = new System.Drawing.Size(336, 108);
            this.label3GD.TabIndex = 66;
            this.label3GD.Text = "Giao dịch";
            this.label3GD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3GD.UseCompatibleTextRendering = true;
            // 
            // kiemTraBtn
            // 
            this.kiemTraBtn.Font = new System.Drawing.Font("Markazi Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kiemTraBtn.Location = new System.Drawing.Point(578, 136);
            this.kiemTraBtn.Name = "kiemTraBtn";
            this.kiemTraBtn.Size = new System.Drawing.Size(106, 42);
            this.kiemTraBtn.TabIndex = 98;
            this.kiemTraBtn.Text = "Kiểm tra";
            this.kiemTraBtn.UseVisualStyleBackColor = true;
            this.kiemTraBtn.Click += new System.EventHandler(this.kiemTraBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GDTabControl);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 329);
            this.panel1.TabIndex = 99;
            // 
            // GiaoDichForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kiemTraBtn);
            this.Controls.Add(this.soDuGDTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.taiKhoanGDTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3GD);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GiaoDichForm";
            this.Text = "GiaoDichForm";
            this.GDTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3GD;
        private System.Windows.Forms.TabControl GDTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button thoatGuiTxt;
        private System.Windows.Forms.Button xacNhanGuiTxt;
        private System.Windows.Forms.TextBox soTienGuiTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button thoatRutGDBtn;
        private System.Windows.Forms.Button xacNhanRutGDBtn;
        private System.Windows.Forms.TextBox soTienRutGDTxt;
        private System.Windows.Forms.Label label1GD;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox soTaiKhoanNhanGDTxt;
        private System.Windows.Forms.TextBox soTienChuyenGDTxt;
        private System.Windows.Forms.Label label5GD;
        private System.Windows.Forms.Button thoatChuyenGDBtn;
        private System.Windows.Forms.Button xacNhanChuyenGDBtn;
        private System.Windows.Forms.Label label4GD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox taiKhoanGDTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox soDuGDTxt;
        private System.Windows.Forms.Button kiemTraBtn;
        private System.Windows.Forms.Panel panel1;
    }
}