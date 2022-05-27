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
    public partial class NhanVienForm : DevExpress.XtraEditors.XtraForm
    {
        bool isAdd;
        DataGridViewRow dt;
        String chinhanh = "";
        public NhanVienForm(DataGridViewRow dt, bool isAdd, String chinhanh)
        {
            this.isAdd = isAdd;
            this.dt = dt;
            this.chinhanh = chinhanh;
            InitializeComponent();
            hoThemNVTxt.Focus();
            namNVRadio.Checked = true;
            if (isAdd) return;
            maNVThemNVTxt.Enabled = false;
            maNVThemNVTxt.Text = dt.Cells[0].Value.ToString();
            hoThemNVTxt.Text = dt.Cells[1].Value.ToString();
            tenThemNVTxt.Text = dt.Cells[2].Value.ToString();
            diaChiThemNVTxt.Text = dt.Cells[3].Value.ToString();
            sdtThemNVTxt.Text = dt.Cells[5].Value.ToString();
            if (dt.Cells[4].Value.ToString().Equals("Nam"))
            {
                namNVRadio.Checked = true;
                nuNVRadio.Checked = !(namNVRadio.Checked);
            }
            else
            {
                nuNVRadio.Checked = true;
                namNVRadio.Checked = !nuNVRadio.Checked;
            }
        }

        private void thoatThemNVBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xacNhanThemNVBtn_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(hoThemNVTxt.Text, @"^[aAàÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬbBcCdDđĐeEèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆfFgGhHiIìÌỉỈĩĨíÍịỊjJkKlLmMnNoOòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢpPqQrRsStTuUùÙủỦũŨúÚụỤưƯừỪửỬữỮứỨựỰvVwWxXyYỳỲỷỶỹỸýÝỵỴzZ ]+$") == false)
            {
                MessageBox.Show("Họ chỉ nhận chữ cái và số");
                hoThemNVTxt.Text = "";
                hoThemNVTxt.Focus();
                return;
            }
            if (Regex.IsMatch(tenThemNVTxt.Text, @"^[aAàÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬbBcCdDđĐeEèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆfFgGhHiIìÌỉỈĩĨíÍịỊjJkKlLmMnNoOòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢpPqQrRsStTuUùÙủỦũŨúÚụỤưƯừỪửỬữỮứỨựỰvVwWxXyYỳỲỷỶỹỸýÝỵỴzZ ]+$") == false)
            {
                MessageBox.Show("Tên chỉ nhận chữ cái và số");
                tenThemNVTxt.Text = "";
                tenThemNVTxt.Focus();
                return;
            }
            if (isAdd)
            {
                if (Regex.IsMatch(maNVThemNVTxt.Text, @"^[0-9]+$") == false)
                {
                    MessageBox.Show("Mã nhân viên chỉ nhận số");
                    maNVThemNVTxt.Text = "";
                    maNVThemNVTxt.Focus();
                    return;
                }
                else
                {
                    if (DAO.ExecSqlKiemTra1("SP_KIEMTRANHANVIEN", maNVThemNVTxt.Text) == 1)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại");
                        maNVThemNVTxt.Text = "";
                        maNVThemNVTxt.Focus();
                        return;
                    }
                }
            }
            if (Regex.IsMatch(sdtThemNVTxt.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Số điện thoại chỉ nhận số");
                sdtThemNVTxt.Text = "";
                sdtThemNVTxt.Focus();
                return;
            }
            else
            {
                if (sdtThemNVTxt.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải có đúng 10 số");
                    return;
                }
            }
            if (Regex.IsMatch(diaChiThemNVTxt.Text, @"^[aAàÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬbBcCdDđĐeEèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆfFgGhHiIìÌỉỈĩĨíÍịỊjJkKlLmMnNoOòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢpPqQrRsStTuUùÙủỦũŨúÚụỤưƯừỪửỬữỮứỨựỰvVwWxXyYỳỲỷỶỹỸýÝỵỴzZ0-9, ]+$") == false)
            {
                MessageBox.Show("Địa chỉ chỉ nhận chữ cái và số");
                diaChiThemNVTxt.Text = "";
                diaChiThemNVTxt.Focus();
                return;
            }
            String gioiTinh = namNVRadio.Checked ? "Nam" : "Nữ";
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ff");
            String Ho = dt.Cells[1].Value.ToString();
            String Ten = dt.Cells[2].Value.ToString();
            String DiaChi = dt.Cells[3].Value.ToString();
            String GioiTinh = dt.Cells[4].Value.ToString().Equals("Nam") ? "Nam" : "Nữ";
            String SoDT = dt.Cells[5].Value.ToString();
            String cmd1 = $"INSERT INTO DBO.NhanVien (MANV, HO, TEN, DIACHI, PHAI, SODT, MACN, TrangThaiXoa) VALUES ({maNVThemNVTxt.Text}, N'{Extension.CapitalizeFirstLetter(hoThemNVTxt.Text)}', N'{Extension.CapitalizeFirstLetter(tenThemNVTxt.Text)}', N'{diaChiThemNVTxt.Text}', N'{gioiTinh}', {sdtThemNVTxt.Text}, N'{chinhanh}', {0})";
            String cmd2 = $"UPDATE DBO.NhanVien SET HO = N'{Extension.CapitalizeFirstLetter(hoThemNVTxt.Text)}', TEN = N'{Extension.CapitalizeFirstLetter(tenThemNVTxt.Text)}', DIACHI = N'{diaChiThemNVTxt.Text}', PHAI = N'{gioiTinh}', SODT = {sdtThemNVTxt.Text} WHERE MANV = {maNVThemNVTxt.Text}";
            //MessageBox.Show(cmd);
            if (DAO.ExecSqlNonQuery(isAdd ? cmd1 : cmd2, DAO.connstr) == 0)
            {
                if (isAdd)
                {
                    MainForm.undoNhanVien.Push($"DELETE FROM DBO.NhanVien WHERE MANV = {maNVThemNVTxt.Text}");
                }
                else
                {
                    MainForm.undoNhanVien.Push($"UPDATE DBO.NhanVien SET HO = N'{Ho}', TEN = N'{Ten}', DIACHI = N'{DiaChi}', PHAI = N'{GioiTinh}', SODT = N'{SoDT}', MACN = N'{chinhanh}' WHERE MANV = N'{maNVThemNVTxt.Text}'");
                }
                MessageBox.Show("Thành công");
                this.Close();
            }
        }
    }
}