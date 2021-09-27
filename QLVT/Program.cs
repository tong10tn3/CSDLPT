using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLVT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher = "Data source=THANHTONG;Initial Catalog=QLVT;Integrated Security=True";

        public static SqlDataReader myReader;
        public static String serverName = "";
        public static String userName = "";
        public static String mlogin = "lt";
        public static String password = "123";

        public static String database = "QLVT";
        public static String remotelogin = "htkn";
        public static String remotepassword = "123";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mChinhanh = 0;

        public static BindingSource bds_dspm = new BindingSource();//giu bdsPM khi dang nhap
        public static frmMain frmChinh;

        public static int KetNoi(SqlConnection conn)
        {
            Console.WriteLine("tong1");
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("tong2");
                conn.Close();
                Console.WriteLine("tong3");
            }
            try
            {

                Console.WriteLine("tongkka1");
                Console.WriteLine(Program.serverName);
                Console.WriteLine(Program.database);
                Console.WriteLine(Program.mlogin);
                Console.WriteLine(Program.password);
                Console.WriteLine("tongkka");

                conn.ConnectionString = Program.connstr;
                conn.Open();
                Console.WriteLine("tong6");
                return 1;

            }

            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Loi ket noi  CSDL.\nXem lai User va Password\n" + ex.Message);
                return 0;
            }

        }
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == System.Data.ConnectionState.Open)
            {
                Program.conn.Close();
            }
            try
            {
                
                Program.connstr = "Data Source= " + Program.serverName+ ";Initial Catalog=" +
                    Program.database + ";User ID=" +
                    Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;

            }

            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Loi ket noi  CSDL.\nXem lai User va Password\n" + ex.Message);
                return 0;
            }

        }
        public static System.Data.SqlClient.SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = System.Data.CommandType.Text;
            if (Program.conn.State == System.Data.ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException e)
            {
                    MessageBox.Show(e.Message);
                    return null;
                
            }
        }
        public static System.Data.SqlClient.SqlDataReader ExecSqlDataReader(String strLenh, SqlConnection conn)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, conn);
            sqlcmd.CommandType = System.Data.CommandType.Text;
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return null;

            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;

            }
            catch (SqlException e)
            {
                if (e.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Format cell lai cot\n Ngaythi\n qa kieu number hoac mo file excel");
                else MessageBox.Show(e.Message);
                conn.Close();
                return e.State;
            }
        }
        public static int ExecSqlNonQuery(String strlenh,SqlConnection conn)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;

            }
            catch (SqlException e)
            {
                if (e.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Format cell lai cot\n Ngaythi\n qa kieu number hoac mo file excel");
                else MessageBox.Show(e.Message);
                conn.Close();
                return e.State;
            }
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            frmChinh = new frmMain();
            Application.Run(new DangNhap());
           
        }
    }
}
