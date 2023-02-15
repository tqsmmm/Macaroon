using Microsoft.Win32;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace 马卡龙零售店
{
    /// <summary>
    /// Items.xaml 的交互逻辑
    /// </summary>
    public partial class Items : Page
    {
        public Items()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*|*.*";

            if (ofd.ShowDialog().Value)
            {
                string filePath = ofd.FileName;//图片路径
                FileStream fs = new FileStream(filePath, FileMode.Open);
                byte[] imageBytes = new byte[fs.Length];
                BinaryReader br = new BinaryReader(fs);
                imageBytes = br.ReadBytes(Convert.ToInt32(fs.Length));//图片转换成二进制流

                string strSql = string.Format("UPDATE Items SET Image = @image WHERE id = 73");
                int count = Write(strSql, imageBytes);

                if (count > 0)
                {
                    MessageBox.Show("success");
                }
                else
                {
                    MessageBox.Show("failed");
                }
            }
        }

        private int Write(string strSql, byte[] imageBytes)
        {
            using (SqlCommand cmd = new SqlCommand(strSql, DB_Work.SqlConn))
            {
                try
                {
                    DB_Work.SqlConn.Open();

                    SqlParameter sqlParameter = new SqlParameter("@image", SqlDbType.Image)
                    {
                        Value = imageBytes
                    };

                    cmd.Parameters.Add(sqlParameter);
                    int rows = cmd.ExecuteNonQuery();
                    return rows;
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
