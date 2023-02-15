using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace 马卡龙零售店
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();

            tb_Code.PreviewMouseDown += new MouseButtonEventHandler(tb_Code_PreviewMouseDown);
            tb_Code.GotFocus += new RoutedEventHandler(tb_Code_GotFocus);
            tb_Code.LostFocus += new RoutedEventHandler(tb_Code_LostFocus);

            tb_Password.PreviewMouseDown += new MouseButtonEventHandler(tb_Password_PreviewMouseDown);
            tb_Password.GotFocus += new RoutedEventHandler(tb_Password_GotFocus);
            tb_Password.LostFocus += new RoutedEventHandler(tb_Password_LostFocus);
        }

        private void tb_Password_LostFocus(object sender, RoutedEventArgs e)
        {
            tb_Password.PreviewMouseDown += new MouseButtonEventHandler(tb_Password_PreviewMouseDown);

            tb_Password.Background = Brushes.White;
        }

        private void tb_Password_GotFocus(object sender, RoutedEventArgs e)
        {
            tb_Password.SelectAll();
            tb_Password.PreviewMouseDown -= new MouseButtonEventHandler(tb_Password_PreviewMouseDown);

            tb_Password.Background = Brushes.LightPink;
        }

        private void tb_Password_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            tb_Password.Focus();

            e.Handled = true;
        }

        private void tb_Code_LostFocus(object sender, RoutedEventArgs e)
        {
            tb_Code.PreviewMouseDown += new MouseButtonEventHandler(tb_Code_PreviewMouseDown);

            tb_Code.Background = Brushes.White;
        }

        private void tb_Code_GotFocus(object sender, RoutedEventArgs e)
        {
            tb_Code.SelectAll();
            tb_Code.PreviewMouseDown -= new MouseButtonEventHandler(tb_Code_PreviewMouseDown);

            tb_Code.Background = Brushes.LightPink;
        }

        private void tb_Code_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            tb_Code.Focus();

            e.Handled = true;
        }

        private void l_1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Code.Background == Brushes.LightPink)
            {
                tb_Code.Text = tb_Code.Text + "1";
            }
            else if (tb_Password.Background == Brushes.LightPink)
            {
                tb_Password.Text = tb_Password.Text + "1";
            }
        }

        private void l_2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Code.Background == Brushes.LightPink)
            {
                tb_Code.Text = tb_Code.Text + "2";
            }
            else if (tb_Password.Background == Brushes.LightPink)
            {
                tb_Password.Text = tb_Password.Text + "2";
            }
        }

        private void l_3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Code.Background == Brushes.LightPink)
            {
                tb_Code.Text = tb_Code.Text + "3";
            }
            else if (tb_Password.Background == Brushes.LightPink)
            {
                tb_Password.Text = tb_Password.Text + "3";
            }
        }

        private void l_4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Code.Background == Brushes.LightPink)
            {
                tb_Code.Text = tb_Code.Text + "4";
            }
            else if (tb_Password.Background == Brushes.LightPink)
            {
                tb_Password.Text = tb_Password.Text + "4";
            }
        }

        private void l_5_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Code.Background == Brushes.LightPink)
            {
                tb_Code.Text = tb_Code.Text + "5";
            }
            else if (tb_Password.Background == Brushes.LightPink)
            {
                tb_Password.Text = tb_Password.Text + "5";
            }
        }

        private void l_6_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Code.Background == Brushes.LightPink)
            {
                tb_Code.Text = tb_Code.Text + "6";
            }
            else if (tb_Password.Background == Brushes.LightPink)
            {
                tb_Password.Text = tb_Password.Text + "6";
            }
        }

        private void l_7_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Code.Background == Brushes.LightPink)
            {
                tb_Code.Text = tb_Code.Text + "7";
            }
            else if (tb_Password.Background == Brushes.LightPink)
            {
                tb_Password.Text = tb_Password.Text + "7";
            }
        }

        private void l_8_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Code.Background == Brushes.LightPink)
            {
                tb_Code.Text = tb_Code.Text + "8";
            }
            else if (tb_Password.Background == Brushes.LightPink)
            {
                tb_Password.Text = tb_Password.Text + "8";
            }
        }

        private void l_9_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Code.Background == Brushes.LightPink)
            {
                tb_Code.Text = tb_Code.Text + "9";
            }
            else if (tb_Password.Background == Brushes.LightPink)
            {
                tb_Password.Text = tb_Password.Text + "9";
            }
        }

        private void l_0_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Code.Background == Brushes.LightPink)
            {
                tb_Code.Text = tb_Code.Text + "0";
            }
            else if (tb_Password.Background == Brushes.LightPink)
            {
                tb_Password.Text = tb_Password.Text + "0";
            }
        }

        private void l_BackSpace_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Code.Background == Brushes.LightPink)
            {
                tb_Code.Text = string.Empty;
            }
            else if (tb_Password.Background == Brushes.LightPink)
            {
                tb_Password.Text = string.Empty;
            }
        }

        private void l_Commit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            System.Data.DataSet Ds = DB_Work.DataSetCmd(string.Format("SELECT Master FROM Users WHERE Code='{0}' AND Password='{1}'", tb_Code.Text, tb_Password.Text));

            if (Ds.Tables[0].Rows.Count > 0)
            {
                if (Convert.ToBoolean(Ds.Tables[0].Rows[0][0]))
                {
                    Statistic s = new Statistic();
                    NavigationService.Navigate(s);
                }
                else
                {
                    Retail r = new Retail();
                    NavigationService.Navigate(r);
                }
            }
        }
    }
}