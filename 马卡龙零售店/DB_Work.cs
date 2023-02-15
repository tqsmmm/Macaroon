using System;
using System.Data;
using System.Data.SqlClient;

namespace 马卡龙零售店
{
    class DB_Work
    {
        public static SqlConnection SqlConn = new SqlConnection($"Server={"192.168.49.100"},{"1433"};Database={"Home-Major"};Uid={"sa"};Pwd={"23long"};Persist Security Info=True");

        public static bool ExecuteCmd(string strSQL)
        {
            try
            {
                var CmdObj = new SqlCommand(strSQL, SqlConn);
                SqlConn.Open();
                CmdObj.ExecuteNonQuery();
                SqlConn.Close();

                return true;
            }
            catch (Exception Ex)
            {
                Public.Sys_MsgBox(Ex.Message);
                return false;
            }
            finally
            {
                if (SqlConn.State != ConnectionState.Closed)
                {
                    SqlConn.Close();
                }
            }
        }
        public static DataSet DataSetCmd(string strSQL)
        {
            try
            {
                var Ds = new DataSet();
                var DaPayType = new SqlDataAdapter(strSQL, SqlConn);
                DaPayType.Fill(Ds, "Table");
                SqlConn.Close();

                return Ds;
            }
            catch (Exception e)
            {
                Public.Sys_MsgBox(e.Message);
                return null;
            }
            finally
            {
                if (SqlConn.State != ConnectionState.Closed)
                {
                    SqlConn.Close();
                }
            }
        }
    }
}
