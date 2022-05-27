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
    public partial class GiaoDichForm : DevExpress.XtraEditors.XtraForm
    {
        //DataGridViewRow dt;
        String chinhanh = "";
        String manv = "";
        public GiaoDichForm(String manv, String chinhanh)
        {
            this.manv = manv;
            //this.dt = dt;
            this.chinhanh = chinhanh;
            InitializeComponent();
        }

        private void xacNhanChuyenGDBtn_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(soTaiKhoanNhanGDTxt.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Số tài khoản chỉ nhận số");
                soTaiKhoanNhanGDTxt.Text = "";
                soTaiKhoanNhanGDTxt.Focus();
                return;
            }
            else
            {
                if(soTaiKhoanNhanGDTxt.Text.Equals(taiKhoanGDTxt.Text))
                {
                    MessageBox.Show("Không thể chuyển cho chính mình");
                    soTaiKhoanNhanGDTxt.Text = "";
                    soTaiKhoanNhanGDTxt.Focus();
                    soTienChuyenGDTxt.Text = "";
                    return;
                }
                if (DAO.ExecSqlKiemTra1("SP_KIEMTRASOTK", soTaiKhoanNhanGDTxt.Text) == 0)
                {
                    MessageBox.Show("Số tài khoản không tồn tại tồn tại");
                    soTaiKhoanNhanGDTxt.Text = "";
                    soTaiKhoanNhanGDTxt.Focus();
                    return;
                }
            }
            if (Int64.Parse(soTienChuyenGDTxt.Text) < 100000)
            {
                MessageBox.Show("Số tiền chuyển phải lớn hơn 100000");
                soTienChuyenGDTxt.Text = "";
                soTienChuyenGDTxt.Focus();
                return;
            }
            if (Int64.Parse(soTienChuyenGDTxt.Text) > Int64.Parse(soDuGDTxt.Text))
            {
                MessageBox.Show("Chê");
                soTienChuyenGDTxt.Text = "";
                soTienChuyenGDTxt.Focus();
                return;
            }
            String cmd = $"EXEC SP_GIAODICHCHUYENTIEN {soTaiKhoanNhanGDTxt.Text}, {taiKhoanGDTxt.Text}, {soTienChuyenGDTxt.Text}, {manv}";
            if (DAO.ExecSqlNonQuery(cmd, DAO.connstr) == 0)
            {
                MessageBox.Show("Giao dịch thành công");
                showTien();
            }
            soTaiKhoanNhanGDTxt.Text = "";
            soTienChuyenGDTxt.Text = "";
        }

        private void xacNhanGuiTxt_Click(object sender, EventArgs e)
        {
            if(Int64.Parse(soTienGuiTxt.Text) < 100000)
            {
                MessageBox.Show("Số tiền gửi phải lớn hơn 100000");
                soTienGuiTxt.Text = "";
                soTienGuiTxt.Focus();
                return;
            }
            String cmd = $"EXEC SP_GIAODICHGUIRUT {"'GT'"}, {soTienGuiTxt.Text}, {taiKhoanGDTxt.Text}, {manv}";
            if (DAO.ExecSqlNonQuery(cmd, DAO.connstr) == 0)
            {
                MessageBox.Show("Giao dịch thành công");
                showTien();
            }
            soTienGuiTxt.Text = "";
        }

        private void thoatGuiTxt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xacNhanRutGDBtn_Click(object sender, EventArgs e)
        {
            if (Int64.Parse(soTienRutGDTxt.Text) < 100000)
            {
                MessageBox.Show("Số tiền rút phải lớn hơn 100000");
                soTienRutGDTxt.Text = "";
                soTienRutGDTxt.Focus();
                return;
            }
            if(Int64.Parse(soTienRutGDTxt.Text) > Int64.Parse(soDuGDTxt.Text))
            {
                MessageBox.Show("Chê");
                soTienRutGDTxt.Text = "";
                soTienRutGDTxt.Focus();
                return;
            }
            String cmd = $"EXEC SP_GIAODICHGUIRUT {"'RT'"}, {soTienRutGDTxt.Text}, {taiKhoanGDTxt.Text}, {manv}";
            if (DAO.ExecSqlNonQuery(cmd, DAO.connstr) == 0)
            {
                MessageBox.Show("Giao dịch thành công");
                showTien();
            }
            soTienRutGDTxt.Text = "";
        }

        private void thoatRutGDBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thoatChuyenGDBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kiemTraBtn_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(taiKhoanGDTxt.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Số tài khoản chỉ nhận số");
                taiKhoanGDTxt.Text = "";
                taiKhoanGDTxt.Focus();
                return;
            }
            else
            {
                if (DAO.ExecSqlKiemTra1("SP_KIEMTRASOTK", taiKhoanGDTxt.Text) == 0)
                {
                    MessageBox.Show("Số tài khoản không tồn tại tồn tại");
                    taiKhoanGDTxt.Text = "";
                    taiKhoanGDTxt.Focus();
                    return;
                }
                showTien();
                panel1.Enabled = true;
            }
        }
        private void showTien()
        {
            String cmd = $"SELECT FORMAT(SODU, '#') FROM [DBO].[TAIKHOAN] WHERE SOTK = {taiKhoanGDTxt.Text}";
            DataTable dt = DAO.ExecSqlDataTable(cmd, false);
            soDuGDTxt.Text = dt.Rows[0][0].ToString();
            String tien = soDuGDTxt.Text.ToString();
            soDuGDTxt.Text = tien;
        }

        private void soTienGuiTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void taiKhoanGDTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}