using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace 马卡龙零售店
{
    /// <summary>
    /// Statistic_Members.xaml 的交互逻辑
    /// </summary>
    public partial class Statistic_Members : Page
    {
        public Statistic_Members()
        {
            InitializeComponent();
        }

        ObservableCollection<Member> Members = new ObservableCollection<Member>();

        public class Member
        {
            public string Code { get; set; }
            public string Name { get; set; }
            public string Mobile { get; set; }
            public bool Membered { get; set; }
            public decimal Discount { get; set; }
            public decimal Balance { get; set; }
            public string DateTime { get; set; }
        }

        private void Load_Members()
        {
            System.Data.DataSet Ds = DB_Work.DataSetCmd("SELECT Code,Name,Mobile,Membered,Discount,Balance,DateTime FROM Members ORDER BY Code");

            Members.Clear();

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                Members.Add(new Member
                {
                    Code = Ds.Tables[0].Rows[i][0].ToString(),
                    Name = Ds.Tables[0].Rows[i][1].ToString(),
                    Mobile = Ds.Tables[0].Rows[i][2].ToString(),
                    Membered = Convert.ToBoolean(Ds.Tables[0].Rows[i][3]),
                    Discount = Convert.ToDecimal(Ds.Tables[0].Rows[i][4]),
                    Balance = Convert.ToDecimal(Ds.Tables[0].Rows[i][5]),
                    DateTime = Convert.ToDateTime(Ds.Tables[0].Rows[i][6]).ToString("yyyy-MM-dd HH:mm")
                });
            }

            lv_Members.ItemsSource = Members;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Load_Members();
        }

        private void tb_Back_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Statistic s = new Statistic();
            NavigationService.Navigate(s);
        }
    }
}
