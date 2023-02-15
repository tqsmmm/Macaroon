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
    /// Statistic_Items.xaml 的交互逻辑
    /// </summary>
    public partial class Statistic_Items : Page
    {
        public Statistic_Items()
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

        ObservableCollection<Item> Items = new ObservableCollection<Item>();

        public class Item
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public decimal Num { get; set; }
            public decimal Amount { get; set; }
        }

        private void Load_Items()
        {
            System.Data.DataSet Ds = DB_Work.DataSetCmd(string.Format("SELECT Items.Name,Bills_Detail.Price,SUM(Num),SUM(Bills_Detail.Amount) FROM Bills_Detail LEFT JOIN Bills ON Bills.Order_ID=Bills_Detail.Order_ID LEFT JOIN Items ON Bills_Detail.Item_ID = Items.id WHERE CONVERT(VARCHAR(10),Bills.DateTime,120)>='{0}' AND CONVERT(VARCHAR(10),Bills.DateTime,120)>='{1}' GROUP BY Items.Name,Bills_Detail.Price", tb_From.Text, tb_To.Text));

            Items.Clear();

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                Items.Add(new Item
                {
                    Name = Ds.Tables[0].Rows[i][0].ToString(),
                    Price = Convert.ToDecimal(Ds.Tables[0].Rows[i][1]),
                    Num = Convert.ToDecimal(Ds.Tables[0].Rows[i][2]),
                    Amount = Convert.ToDecimal(Ds.Tables[0].Rows[i][3])
                });
            }

            lv_Items.ItemsSource = Items;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            tb_From.Text = tb_To.Text = DateTime.Now.ToString("yyyy-MM-dd");

            Load_Items();
        }

        private void tb_Back_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Statistic s = new Statistic();
            NavigationService.Navigate(s);
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

            Load_Items();
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

            Load_Items();
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

            Load_Items();
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

            Load_Items();
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

            Load_Items();
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

            Load_Items();
        }
    }
}
