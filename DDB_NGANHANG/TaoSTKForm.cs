using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDB_NGANHANG
{
    public partial class TaoSTKForm : DevExpress.XtraEditors.XtraForm
    {
        String chinhanh;
        public TaoSTKForm(String chinhanh)
        {
            this.chinhanh = chinhanh;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xacNhanThemKhachHangTxt_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(cmndThemKHTxt.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Chứng minh chỉ nhận số");
                cmndThemKHTxt.Text = "";
                cmndThemKHTxt.Focus();
                return;
            }
            else
            {
                if (DAO.ExecSqlKiemTra1("SP_KIEMTRAKHACHHANG", cmndThemKHTxt.Text) == 0)
                {
                    MessageBox.Show("Chứng minh không tồn tại");
                    cmndThemKHTxt.Text = "";
                    cmndThemKHTxt.Focus();
                    return;
                }
            }
            if (Regex.IsMatch(STKTxt.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Số tài khoản chỉ nhận số");
                STKTxt.Text = "";
                STKTxt.Focus();
                return;
            }
            else
            {
                if(STKTxt.Text.Length != 9)
                {
                    MessageBox.Show("Số tài khoản phải đủ 9 số");
                }
                if (DAO.ExecSqlKiemTra1("SP_KIEMTRASOTK", STKTxt.Text) == 1)
                {
                    MessageBox.Show("Số tài khoản đã tồn tại tồn tại");
                    STKTxt.Text = "";
                    STKTxt.Focus();
                    return;
                }
            }
            if (Regex.IsMatch(soDuTxt.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Số dư chỉ nhận số");
                soDuTxt.Text = "";
                soDuTxt.Focus();
                return;
            }
            else
            {
                if(Int64.Parse(soDuTxt.Text.ToString()) < 100000)
                {
                    MessageBox.Show("Số dư phải lớn hơn 100000");
                    soDuTxt.Text = "";
                    soDuTxt.Focus();
                    return;
                }
            }
            ////
            String cmd = $"EXEC SP_TAOSOTAIKHOANKHACCHINHANH {STKTxt.Text}, {cmndThemKHTxt.Text}, {soDuTxt.Text}, {chinhanh}";
            if (DAO.ExecSqlNonQuery(cmd, DAO.connstr) == 0)
            {
                MessageBox.Show("Thành công");
                this.Close();
            }
        }

        private void thoatThemKhachHangTxt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}