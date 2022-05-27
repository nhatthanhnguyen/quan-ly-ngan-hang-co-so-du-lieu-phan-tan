
namespace DDB_NGANHANG
{
    partial class DSNVForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.thoatTraCuuBtn = new System.Windows.Forms.Button();
            this.xacNhanTraCuuBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nhanVienTable = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Markazi Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::DDB_NGANHANG.Properties.Resources.search__1_;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(309, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 107);
            this.label1.TabIndex = 102;
            this.label1.Text = "Tra cứu nhân viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // thoatTraCuuBtn
            // 
            this.thoatTraCuuBtn.Font = new System.Drawing.Font("Markazi Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoatTraCuuBtn.Location = new System.Drawing.Point(583, 616);
            this.thoatTraCuuBtn.Name = "thoatTraCuuBtn";
            this.thoatTraCuuBtn.Size = new System.Drawing.Size(133, 41);
            this.thoatTraCuuBtn.TabIndex = 105;
            this.thoatTraCuuBtn.Text = "Thoát";
            this.thoatTraCuuBtn.UseVisualStyleBackColor = true;
            this.thoatTraCuuBtn.Click += new System.EventHandler(this.thoatTraCuuBtn_Click);
            // 
            // xacNhanTraCuuBtn
            // 
            this.xacNhanTraCuuBtn.Font = new System.Drawing.Font("Markazi Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xacNhanTraCuuBtn.Location = new System.Drawing.Point(320, 616);
            this.xacNhanTraCuuBtn.Name = "xacNhanTraCuuBtn";
            this.xacNhanTraCuuBtn.Size = new System.Drawing.Size(133, 41);
            this.xacNhanTraCuuBtn.TabIndex = 104;
            this.xacNhanTraCuuBtn.Text = "Xác nhận";
            this.xacNhanTraCuuBtn.UseVisualStyleBackColor = true;
            this.xacNhanTraCuuBtn.Click += new System.EventHandler(this.xacNhanTraCuuBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nhanVienTable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.thoatTraCuuBtn);
            this.panel1.Controls.Add(this.xacNhanTraCuuBtn);
            this.panel1.Font = new System.Drawing.Font("Markazi Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 698);
            this.panel1.TabIndex = 106;
            // 
            // nhanVienTable
            // 
            this.nhanVienTable.AllowUserToAddRows = false;
            this.nhanVienTable.AllowUserToDeleteRows = false;
            this.nhanVienTable.AllowUserToResizeColumns = false;
            this.nhanVienTable.AllowUserToResizeRows = false;
            this.nhanVienTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nhanVienTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.nhanVienTable.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Markazi Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nhanVienTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.nhanVienTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Markazi Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.nhanVienTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.nhanVienTable.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.nhanVienTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nhanVienTable.Location = new System.Drawing.Point(12, 171);
            this.nhanVienTable.MultiSelect = false;
            this.nhanVienTable.Name = "nhanVienTable";
            this.nhanVienTable.ReadOnly = true;
            this.nhanVienTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Markazi Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nhanVienTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.nhanVienTable.RowHeadersVisible = false;
            this.nhanVienTable.RowHeadersWidth = 50;
            this.nhanVienTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.nhanVienTable.RowTemplate.Height = 24;
            this.nhanVienTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nhanVienTable.Size = new System.Drawing.Size(995, 411);
            this.nhanVienTable.TabIndex = 106;
            this.nhanVienTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nhanVienTable_CellClick);
            // 
            // DSNVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 707);
            this.Controls.Add(this.panel1);
            this.Name = "DSNVForm";
            this.Text = "DSNVForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button thoatTraCuuBtn;
        private System.Windows.Forms.Button xacNhanTraCuuBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView nhanVienTable;
    }
}