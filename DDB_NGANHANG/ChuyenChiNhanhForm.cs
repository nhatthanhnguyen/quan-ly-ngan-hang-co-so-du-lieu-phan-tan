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
    public partial class ChuyenChiNhanhForm : DevExpress.XtraEditors.XtraForm
    {
        String manv, chinhanh;
        public ChuyenChiNhanhForm(String manv, String chinhanh)
        {
            InitializeComponent();
            this.manv = manv;
            this.chinhanh = chinhanh;
            if (chinhanh.Equals("BENTHANH"))
            {
                chiNhanhCombobox.Items.Add("Chi nhánh Tân Định");
            }
            else
            {
                chiNhanhCombobox.Items.Add("Chi nhánh Bến Thành");
            }
            chiNhanhCombobox.SelectedIndex = 0;
        }

        private void xacNhanChuyenBtn_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(manvChuyenTxt.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Mã nhân viên chỉ nhận số");
                manvChuyenTxt.Text = "";
                manvChuyenTxt.Focus();
                return;
            }
            else
            {
                if (DAO.ExecSqlKiemTra1("SP_KIEMTRANHANVIEN", manvChuyenTxt.Text) == 1)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại");
                    manvChuyenTxt.Text = "";
                    manvChuyenTxt.Focus();
                    return;
                }
            }
            String chinhanhChuyen = chinhanh.Equals("BENTHANH") ? "TANDINH" : "BENTHANH";
            String cmd = $"EXEC SP_CHUYENNHANVIEN {manv}, {chinhanhChuyen}, {manvChuyenTxt.Text}";
            //MessageBox.Show(cmd);
            if (DAO.ExecSqlNonQuery(cmd, DAO.connstr) == 0)
            {
                MessageBox.Show("Thành công");
                this.Close();
            }
        }

        private void thoatChuyenBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}