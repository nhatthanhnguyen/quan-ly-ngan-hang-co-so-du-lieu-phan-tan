using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DDB_NGANHANG
{
    public partial class ReportSaoKeGiaoDichTrongKhoangThoiGian : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportSaoKeGiaoDichTrongKhoangThoiGian(string ngayBD, string ngayKT, string soTK, string chiNhanhViet)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = DAO.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = soTK;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ngayBD;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = ngayKT;
            this.sqlDataSource1.Fill();
            this.xrLabel1.Text = "Từ ngày " + ngayBD;
            this.xrLabel2.Text = "Đến ngày " + ngayKT;
            this.xrLabel3.Text = "Số tài khoản: " + soTK;
            this.xrLabel4.Text = "Chi nhánh: " + chiNhanhViet;
        }

    }
}
