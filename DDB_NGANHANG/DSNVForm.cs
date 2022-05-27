using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDB_NGANHANG
{
    public partial class DSNVForm : DevExpress.XtraEditors.XtraForm
    {
        int idx = 0;
        public DSNVForm()
        {
            InitializeComponent();
            String cmd = "EXEC [DBO].[SP_DANHSACHNHANVIENCHUADANGKY]";
            DataTable dt = DAO.ExecSqlDataTable(cmd, false);
            nhanVienTable.DataSource = dt;
        }

        private void xacNhanTraCuuBtn_Click(object sender, EventArgs e)
        {
            DAO.nvChuaTaiKhoan = nhanVienTable.Rows[idx];
            this.Close();
        }

        private void thoatTraCuuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nhanVienTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = nhanVienTable.CurrentRow.Index;
        }
    }
}