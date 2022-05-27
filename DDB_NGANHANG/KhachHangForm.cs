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
    public partial class KhachHangForm : DevExpress.XtraEditors.XtraForm
    {
        bool isAdd;
        DataGridViewRow dt;
        String chinhanh = "";
        public KhachHangForm(DataGridViewRow dt, bool isAdd, String chinhanh)
        {
            this.isAdd = isAdd;
            this.dt = dt;
            this.chinhanh = chinhanh;
            InitializeComponent();
            hoThemKHTxt.Focus();
            namKhachHangFormRadio.Checked = true;
            if (isAdd) return;
            cmndThemKHTxt.Enabled = false;
            cmndThemKHTxt.Text = dt.Cells[2].Value.ToString();
            hoThemKHTxt.Text = dt.Cells[0].Value.ToString();
            tenThemKHTxt.Text = dt.Cells[1].Value.ToString();
            diaChiThemKHTxt.Text = dt.Cells[3].Value.ToString();
            sdtThemKHTxt.Text = dt.Cells[5].Value.ToString();
            if (dt.Cells[4].Value.ToString().Equals("Nam"))
            {
                namKhachHangFormRadio.Checked = true;
                nuKhachHangFormRadio.Checked = !(namKhachHangFormRadio.Checked);
            }
            else
            {
                nuKhachHangFormRadio.Checked = true;
                namKhachHangFormRadio.Checked = !nuKhachHangFormRadio.Checked;
            }
        }

        private void xacNhanThemKhachHangTxt_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(hoThemKHTxt.Text, @"^[aAàÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬbBcCdDđĐeEèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆfFgGhHiIìÌỉỈĩĨíÍịỊjJkKlLmMnNoOòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢpPqQrRsStTuUùÙủỦũŨúÚụỤưƯừỪửỬữỮứỨựỰvVwWxXyYỳỲỷỶỹỸýÝỵỴzZ ]+$") == false)
            {
                MessageBox.Show("Họ chỉ nhận chữ cái và số");
                hoThemKHTxt.Text = "";
                hoThemKHTxt.Focus();
                return;
            }
            if (Regex.IsMatch(tenThemKHTxt.Text, @"^[aAàÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬbBcCdDđĐeEèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆfFgGhHiIìÌỉỈĩĨíÍịỊjJkKlLmMnNoOòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢpPqQrRsStTuUùÙủỦũŨúÚụỤưƯừỪửỬữỮứỨựỰvVwWxXyYỳỲỷỶỹỸýÝỵỴzZ ]+$") == false)
            {
                MessageBox.Show("Tên chỉ nhận chữ cái và số");
                tenThemKHTxt.Text = "";
                tenThemKHTxt.Focus();
                return;
            }
            if (isAdd)
            {
                if (Regex.IsMatch(cmndThemKHTxt.Text, @"^[0-9]+$") == false)
                {
                    MessageBox.Show("Số chứng minh chỉ nhận số");
                    cmndThemKHTxt.Text = "";
                    cmndThemKHTxt.Focus();
                    return;
                }
                else
                {
                    if (DAO.ExecSqlKiemTra1("SP_KIEMTRANHANVIEN", cmndThemKHTxt.Text) == 1)
                    {
                        MessageBox.Show("Số chứng minh đã tồn tại");
                        cmndThemKHTxt.Text = "";
                        cmndThemKHTxt.Focus();
                        return;
                    }
                }
            }
            if (Regex.IsMatch(sdtThemKHTxt.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Số điện thoại chỉ nhận số");
                sdtThemKHTxt.Text = "";
                sdtThemKHTxt.Focus();
                return;
            }
            else
            {
                if (sdtThemKHTxt.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải có đúng 10 số");
                    return;
                }
            }
            if (Regex.IsMatch(diaChiThemKHTxt.Text, @"^[aAàÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬbBcCdDđĐeEèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆfFgGhHiIìÌỉỈĩĨíÍịỊjJkKlLmMnNoOòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢpPqQrRsStTuUùÙủỦũŨúÚụỤưƯừỪửỬữỮứỨựỰvVwWxXyYỳỲỷỶỹỸýÝỵỴzZ0-9, ]+$") == false)
            {
                MessageBox.Show("Địa chỉ chỉ nhận chữ cái và số");
                diaChiThemKHTxt.Text = "";
                diaChiThemKHTxt.Focus();
                return;
            }
            String gioiTinh = namKhachHangFormRadio.Checked ? "Nam" : "Nữ";
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            String cmnd = dt.Cells[2].Value.ToString();
            String ho = dt.Cells[0].Value.ToString();
            String ten = dt.Cells[1].Value.ToString();
            String diaChi = dt.Cells[3].Value.ToString();
            String phai = (dt.Cells[4].Value.ToString().Equals("Nam") ? "Nam" : "Nữ");
            String sdt = dt.Cells[5].Value.ToString();
            String cmd1 = $"INSERT INTO DBO.KhachHang (CMND, HO, TEN, DIACHI, PHAI, NGAYCAP, SODT, MACN) VALUES (N'{cmndThemKHTxt.Text}', N'{Extension.CapitalizeFirstLetter(hoThemKHTxt.Text)}', N'{Extension.CapitalizeFirstLetter(tenThemKHTxt.Text)}', N'{diaChiThemKHTxt.Text}', N'{gioiTinh}', N'{date}', {sdtThemKHTxt.Text}, N'{chinhanh}')";
            String cmd2 = $"UPDATE DBO.KhachHang SET HO = N'{Extension.CapitalizeFirstLetter(hoThemKHTxt.Text)}', TEN = N'{Extension.CapitalizeFirstLetter(tenThemKHTxt.Text)}', DIACHI = N'{diaChiThemKHTxt.Text}', PHAI = N'{gioiTinh}', SODT = {sdtThemKHTxt.Text} WHERE CMND = {cmndThemKHTxt.Text}";
            if (DAO.ExecSqlNonQuery(isAdd ? cmd1 : cmd2, DAO.connstr) == 0)
            {
                if (isAdd)
                {
                    MainForm.undoKhachHang.Push($"DELETE FROM DBO.KhachHang WHERE CMND = {cmndThemKHTxt.Text}");
                }
                else
                {
                    MainForm.undoKhachHang.Push($"UPDATE DBO.KhachHang SET HO = N'{Extension.CapitalizeFirstLetter(ho)}', TEN = N'{Extension.CapitalizeFirstLetter(ten)}', DIACHI = N'{diaChi}', PHAI = N'{phai}', NGAYCAP = N'{date}', SODT = N'{sdt}', MACN = N'{chinhanh}' WHERE CMND = N'{cmndThemKHTxt.Text}'");
                }
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