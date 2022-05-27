using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DDB_NGANHANG
{
    public static class DAO
    {
        public static String conn_publisher = "Data Source=DESKTOP-18L9IFI;Initial Catalog=NGANHANG;Integrated Security=true";

        public static SqlDataReader myReader;

        public static String servername = "DESKTOP-18L9IFI";
        public static String username = "sa";
        public static String password = "123";
        public static String database = "NGANHANG";
        public static String remoteLogin = "HTKN";
        public static String remotePassword = "123";
        public static String connstr = $"Data Source = {servername}; Initial Catalog = NGANHANG;Persist Security Info=True; User ID = {username}; password = {password}";
        public static SqlConnection conn = new SqlConnection(conn_publisher);

        public static String mlogin;
        public static String mGroup;
        public static String mHoten;
        public static int mChiNhanh;
        public static Dictionary<String, String> DSPM = new Dictionary<String, String>();
        public static DataTable chiNhanhDT = new DataTable();
        public static DataGridViewRow nvChuaTaiKhoan = null;
        //public static frmMain frmChinh;

        public static BindingSource bds_dspm = new BindingSource();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static int KetNoi()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                connstr = $"Data Source = {servername}; Initial Catalog = NGANHANG; User ID = {username}; password = {password}";
                conn.ConnectionString = connstr;
                conn.Open();
                return 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
        }
        public static int ketNoiDBGoc()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                conn = new SqlConnection(conn_publisher);
                conn.Open();
                return 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 1;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, conn);
            sqlcmd.CommandType = CommandType.Text;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static SqlDataReader ExecSqlDataReaderPublisher(String strLenh)
        {
            if (conn != null && conn.State == ConnectionState.Open) conn.Close();
            conn = new SqlConnection(conn_publisher);
            SqlCommand sqlcmd = new SqlCommand(strLenh, conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 300;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                return sqlcmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                //errstr = ex.Message.ToString();
                conn.Close();
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd, bool isPub)
        {
            if (conn != null && conn.State == ConnectionState.Open) conn.Close();
            if (isPub)
            {
                conn = new SqlConnection(conn_publisher);
            }
            else
            {
                conn = new SqlConnection(connstr);
            }
            DataTable dt = new DataTable();
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static int ExecSqlNonQuery(String cmd, String connectionstring)
        {
            conn = new SqlConnection(connectionstring);
            SqlCommand Sqlcmd = new SqlCommand();
            Sqlcmd.Connection = conn;
            Sqlcmd.CommandText = cmd;
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 300;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close(); return 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return 1;
            }
        }
        public static int ExecSqlGiaoDichCT(String tenSP, String tkn, String tkc, Double st)
        {
            String sql = "DECLARE @return_value int " +
                         "EXEC @return_value = [dbo].[" + tenSP + "] " +
                         "@a, @b, @c " +
                         "SELECT 'Return Value' = @return_value";

            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            sqlCommand.Parameters.AddWithValue("@a", tkn);
            sqlCommand.Parameters.AddWithValue("@b", tkc);
            sqlCommand.Parameters.AddWithValue("@c", st);
            SqlDataReader dataReader = null;
            try
            {
                dataReader = sqlCommand.ExecuteReader();
                dataReader.Read();
                int result_value = int.Parse(dataReader.GetValue(0).ToString());
                conn.Close();
                return result_value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return 0;
            }
        }
        public static int ExecSqlGiaoDichGR(String tenSP, String type, Double st, String stk)
        {
            String sql = "DECLARE @return_value int " +
                         "EXEC @return_value = [dbo].[" + tenSP + "] " +
                         "@a, @b, @c " +
                         "SELECT 'Return Value' = @return_value";

            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            sqlCommand.Parameters.AddWithValue("@a", type);
            sqlCommand.Parameters.AddWithValue("@b", st);
            sqlCommand.Parameters.AddWithValue("@c", stk);
            SqlDataReader dataReader = null;
            try
            {
                dataReader = sqlCommand.ExecuteReader();
                dataReader.Read();
                int result_value = int.Parse(dataReader.GetValue(0).ToString());
                conn.Close();
                return result_value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return 0;
            }
        }
        public static int ExecSqlKiemTra1(String tenSP, String a)
        {
            String sql = $"DECLARE @return_value int EXEC @return_value = [dbo].[{tenSP}] @a SELECT 'Return Value' = @return_value";

            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            sqlCommand.Parameters.AddWithValue("@a", a);
            SqlDataReader dataReader = null;
            try
            {
                dataReader = sqlCommand.ExecuteReader();
                dataReader.Read();
                int result_value = int.Parse(dataReader.GetValue(0).ToString());
                conn.Close();
                return result_value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return -1;
            }
        }
        public static int ExecSqlKiemTra2(String tenSP, String a, Double b)
        {
            String sql = "DECLARE @return_value int " +
                         "EXEC @return_value = [dbo].[" + tenSP + "] " +
                         "@a, @b " +
                         "SELECT 'Return Value' = @return_value";

            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            sqlCommand.Parameters.AddWithValue("@a", a);
            sqlCommand.Parameters.AddWithValue("@b", b);
            SqlDataReader dataReader = null;
            try
            {
                dataReader = sqlCommand.ExecuteReader();
                dataReader.Read();
                int result_value = int.Parse(dataReader.GetValue(0).ToString());
                conn.Close();
                return result_value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return -1;
            }
        }
        public static void SetEnableOfButton(Form frm, Boolean Active)
        {

            foreach (Control ctl in frm.Controls)
                if ((ctl) is Button)
                    ctl.Enabled = Active;
        }
    }
}
