using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace 马卡龙零售店
{
    /// <summary>
    /// Statistic_Save.xaml 的交互逻辑
    /// </summary>
    public partial class Statistic_Save : Page
    {
        public Statistic_Save()
        {
            InitializeComponent();

            tb_From.PreviewMouseDown += new MouseButtonEventHandler(tb_From_PreviewMouseDown);
            tb_From.GotFocus += new RoutedEventHandler(tb_From_GotFocus);
            tb_From.LostFocus += new RoutedEventHandler(tb_From_LostFocus);

            tb_To.PreviewMouseDown += new MouseButtonEventHandler(tb_To_PreviewMouseDown);
            tb_To.GotFocus += new RoutedEventHandler(tb_To_GotFocus);
            tb_To.LostFocus += new RoutedEventHandler(tb_To_LostFocus);
        }

        private void tb_To_LostFocus(object sender, RoutedEventArgs e)
        {
            tb_To.PreviewMouseDown += new MouseButtonEventHandler(tb_To_PreviewMouseDown);

            tb_To.Background = Brushes.White;
        }

        private void tb_To_GotFocus(object sender, RoutedEventArgs e)
        {
            tb_To.SelectAll();
            tb_To.PreviewMouseDown -= new MouseButtonEventHandler(tb_To_PreviewMouseDown);

            tb_To.Background = Brushes.LightPink;
        }

        private void tb_To_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            tb_To.Focus();

            e.Handled = true;
        }

        private void tb_From_LostFocus(object sender, RoutedEventArgs e)
        {
            tb_From.PreviewMouseDown += new MouseButtonEventHandler(tb_From_PreviewMouseDown);

            tb_From.Background = Brushes.White;
        }

        private void tb_From_GotFocus(object sender, RoutedEventArgs e)
        {
            tb_From.SelectAll();
            tb_From.PreviewMouseDown -= new MouseButtonEventHandler(tb_From_PreviewMouseDown);

            tb_From.Background = Brushes.LightPink;
        }

        private void tb_From_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            tb_From.Focus();

            e.Handled = true;
        }

        ObservableCollection<Save> Saves = new ObservableCollection<Save>();

        public class Save
        {
            public string Order_ID { get; set; }
            public string Member_ID { get; set; }
            public string DateTime { get; set; }
            public decimal Before_Balance { get; set; }
            public decimal After_Balance { get; set; }
            public decimal Amount { get; set; }
        }

        private void Load_Saves()
        {
            System.Data.DataSet Ds = DB_Work.DataSetCmd(string.Format("SELECT Members_Handle.Order_ID,Members_Handle.Member_ID,DateTime,Before_Balance,After_Balance,Amount FROM Members_Handle LEFT JOIN Members_Log ON Members_Handle.Order_ID=Members_Log.Order_ID AND Members_Handle.Type=Members_Log.Type WHERE Members_Handle.Type='充值' AND CONVERT(VARCHAR(10),Members_Log.DateTime,120)>='{0}' AND CONVERT(VARCHAR(10),Members_Log.DateTime,120)<='{1}' ORDER BY Members_Handle.Order_ID", tb_From.Text, tb_To.Text));

            Saves.Clear();

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                Saves.Add(new Save
                {
                    Order_ID = Ds.Tables[0].Rows[i][0].ToString(),
                    Member_ID = Ds.Tables[0].Rows[i][1].ToString(),
                    DateTime = Convert.ToDateTime(Ds.Tables[0].Rows[i][2]).ToString("yyyy-MM-dd HH:mm"),
                    Before_Balance = Convert.ToDecimal(Ds.Tables[0].Rows[i][3]),
                    After_Balance = Convert.ToDecimal(Ds.Tables[0].Rows[i][4]),
                    Amount = Convert.ToDecimal(Ds.Tables[0].Rows[i][5])
                });
            }

            lv_Saves.ItemsSource = Saves;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            tb_From.Text = tb_To.Text = DateTime.Now.ToString("yyyy-MM-dd");

            Load_Saves();
        }

        private void tb_Month_Before_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_From.Background == Brushes.LightPink)
            {
                tb_From.Text = Convert.ToDateTime(tb_From.Text).AddMonths(-1).ToString("yyyy-MM-dd");
            }
            else if (tb_To.Background == Brushes.LightPink)
            {
                tb_To.Text = Convert.ToDateTime(tb_To.Text).AddMonths(-1).ToString("yyyy-MM-dd");
            }
            else
            {
                tb_From.Text = Convert.ToDateTime(tb_From.Text).AddMonths(-1).ToString("yyyy-MM-dd");

                tb_To.Text = Convert.ToDateTime(tb_To.Text).AddMonths(-1).ToString("yyyy-MM-dd");
            }

            Load_Saves();
        }

        private void tb_Month_Now_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_From.Background == Brushes.LightPink)
            {
                tb_From.Text = Convert.ToDateTime(tb_From.Text).ToString("yyyy-") + DateTime.Now.ToString("MM-") + Convert.ToDateTime(tb_From.Text).ToString("dd");
            }
            else if (tb_To.Background == Brushes.LightPink)
            {
                tb_To.Text = Convert.ToDateTime(tb_To.Text).ToString("yyyy-") + DateTime.Now.ToString("MM-") + Convert.ToDateTime(tb_To.Text).ToString("dd");
            }
            else
            {
                tb_From.Text = Convert.ToDateTime(tb_From.Text).ToString("yyyy-") + DateTime.Now.ToString("MM-") + Convert.ToDateTime(tb_From.Text).ToString("dd");

                tb_To.Text = Convert.ToDateTime(tb_To.Text).ToString("yyyy-") + DateTime.Now.ToString("MM-") + Convert.ToDateTime(tb_To.Text).ToString("dd");
            }

            Load_Saves();
        }

        private void tb_Month_After_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_From.Background == Brushes.LightPink)
            {
                tb_From.Text = Convert.ToDateTime(tb_From.Text).AddMonths(1).ToString("yyyy-MM-dd");
            }
            else if (tb_To.Background == Brushes.LightPink)
            {
                tb_To.Text = Convert.ToDateTime(tb_To.Text).AddMonths(1).ToString("yyyy-MM-dd");
            }
            else
            {
                tb_From.Text = Convert.ToDateTime(tb_From.Text).AddMonths(1).ToString("yyyy-MM-dd");

                tb_To.Text = Convert.ToDateTime(tb_To.Text).AddMonths(1).ToString("yyyy-MM-dd");
            }

            Load_Saves();
        }

        private void tb_Day_Before_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_From.Background == Brushes.LightPink)
            {
                tb_From.Text = Convert.ToDateTime(tb_From.Text).AddDays(-1).ToString("yyyy-MM-dd");
            }
            else if (tb_To.Background == Brushes.LightPink)
            {
                tb_To.Text = Convert.ToDateTime(tb_To.Text).AddDays(-1).ToString("yyyy-MM-dd");
            }
            else
            {
                tb_From.Text = Convert.ToDateTime(tb_From.Text).AddDays(-1).ToString("yyyy-MM-dd");

                tb_To.Text = Convert.ToDateTime(tb_To.Text).AddDays(-1).ToString("yyyy-MM-dd");
            }

            Load_Saves();
        }

        private void tb_Day_Now_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_From.Background == Brushes.LightPink)
            {
                tb_From.Text = Convert.ToDateTime(tb_From.Text).ToString("yyyy-MM-") + DateTime.Now.ToString("dd");
            }
            else if (tb_To.Background == Brushes.LightPink)
            {
                tb_To.Text = Convert.ToDateTime(tb_To.Text).ToString("yyyy-MM-") + DateTime.Now.ToString("dd");
            }
            else
            {
                tb_From.Text = Convert.ToDateTime(tb_From.Text).ToString("yyyy-MM-") + DateTime.Now.ToString("dd");

                tb_To.Text = Convert.ToDateTime(tb_To.Text).ToString("yyyy-MM-") + DateTime.Now.ToString("dd");
            }

            Load_Saves();
        }

        private void tb_Day_After_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_From.Background == Brushes.LightPink)
            {
                tb_From.Text = Convert.ToDateTime(tb_From.Text).AddDays(1).ToString("yyyy-MM-dd");
            }
            else if (tb_To.Background == Brushes.LightPink)
            {
                tb_To.Text = Convert.ToDateTime(tb_To.Text).AddDays(1).ToString("yyyy-MM-dd");
            }
            else
            {
                tb_From.Text = Convert.ToDateTime(tb_From.Text).AddDays(1).ToString("yyyy-MM-dd");

                tb_To.Text = Convert.ToDateTime(tb_To.Text).AddDays(1).ToString("yyyy-MM-dd");
            }

            Load_Saves();
        }

        private void tb_Back_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Statistic s = new Statistic();
            NavigationService.Navigate(s);
        }
    }
}
