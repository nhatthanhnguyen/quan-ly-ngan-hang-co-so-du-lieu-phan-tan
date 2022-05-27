using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DDB_NGANHANG
{
    public partial class ReportLietKetKhachHangTheoTungChiNhanh : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportLietKetKhachHangTheoTungChiNhanh(int cn, string chiNhanhViet)
        {
            InitializeComponent();
            sqlDataSource1.Connection.ConnectionString = DAO.connstr;
            sqlDataSource1.Queries[0].Parameters[0].Value = cn;
            sqlDataSource1.Fill();
            label1.Text = "DANH SÁCH KHÁCH HÀNG THUỘC CHI NHÁNH " + chiNhanhViet;
        }

    }
}
