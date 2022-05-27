using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DDB_NGANHANG
{
    public partial class ReportLietKeTaiKhoanTrongKhoangThoiGianChiNhanh : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportLietKeTaiKhoanTrongKhoangThoiGianChiNhanh()
        {

        }
        public ReportLietKeTaiKhoanTrongKhoangThoiGianChiNhanh(string ngayBD, string ngayKT, string macn, string chiNhanhViet)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = DAO.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = ngayBD;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ngayKT;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = macn;
            this.sqlDataSource1.Fill();
            this.xrLabel1.Text = "Từ ngày " + ngayBD;
            this.xrLabel2.Text = "Đến ngày " + ngayKT;
            this.label1.Text = "TÀI KHOẢN ĐƯỢC MỞ Ở " + chiNhanhViet;
        }
    }
}
