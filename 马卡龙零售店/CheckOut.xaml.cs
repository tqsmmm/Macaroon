using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace 马卡龙零售店
{
    /// <summary>
    /// CheckOut.xaml 的交互逻辑
    /// </summary>
    public partial class CheckOut : Window
    {
        public CheckOut()
        {
            InitializeComponent();

            tb_Pay_Cash.PreviewMouseDown += new MouseButtonEventHandler(tb_Pay_Cash_PreviewMouseDown);
            tb_Pay_Cash.GotFocus += new RoutedEventHandler(tb_Pay_Cash_GotFocus);
            tb_Pay_Cash.LostFocus += new RoutedEventHandler(tb_Pay_Cash_LostFocus);

            tb_Pay_Bank.PreviewMouseDown += new MouseButtonEventHandler(tb_Pay_Bank_PreviewMouseDown);
            tb_Pay_Bank.GotFocus += new RoutedEventHandler(tb_Pay_Bank_GotFocus);
            tb_Pay_Bank.LostFocus += new RoutedEventHandler(tb_Pay_Bank_LostFocus);

            tb_Pay_Exempt.PreviewMouseDown += new MouseButtonEventHandler(tb_Pay_Exempt_PreviewMouseDown);
            tb_Pay_Exempt.GotFocus += new RoutedEventHandler(tb_Pay_Exempt_GotFocus);
            tb_Pay_Exempt.LostFocus += new RoutedEventHandler(tb_Pay_Exempt_LostFocus);

            tb_Pay_Coupon.PreviewMouseDown += new MouseButtonEventHandler(tb_Pay_Coupon_PreviewMouseDown);
            tb_Pay_Coupon.GotFocus += new RoutedEventHandler(tb_Pay_Coupon_GotFocus);
            tb_Pay_Coupon.LostFocus += new RoutedEventHandler(tb_Pay_Coupon_LostFocus);

            tb_Pay_Member.PreviewMouseDown += new MouseButtonEventHandler(tb_Pay_Member_PreviewMouseDown);
            tb_Pay_Member.GotFocus += new RoutedEventHandler(tb_Pay_Member_GotFocus);
            tb_Pay_Member.LostFocus += new RoutedEventHandler(tb_Pay_Member_LostFocus);
        }

        private void Commit_Pay()
        {
            try
            {
                tb_Pay.Text = (Convert.ToDecimal(tb_Pay_Cash.Text) +
                Convert.ToDecimal(tb_Pay_Bank.Text) +
                Convert.ToDecimal(tb_Pay_Coupon.Text) +
                Convert.ToDecimal(tb_Pay_Exempt.Text) +
                Convert.ToDecimal(tb_Pay_Member.Text)).ToString();

                tb_Change.Text = (Convert.ToDecimal(tb_Pay.Text) - Convert.ToDecimal(tb_Total.Text)).ToString();

                tb_Member_Remain.Text = (Convert.ToDecimal(tb_Member_Balance.Text) - Convert.ToDecimal(tb_Pay_Member.Text)).ToString();
            }
            catch
            {

            }
        }

        private void l_1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Pay_Bank.Background == Brushes.LightPink)
            {
                tb_Pay_Bank.Text = tb_Pay_Bank.Text + "1";
            }
            else if (tb_Pay_Cash.Background == Brushes.LightPink)
            {
                tb_Pay_Cash.Text = tb_Pay_Cash.Text + "1";
            }
            else if (tb_Pay_Exempt.Background == Brushes.LightPink)
            {
                tb_Pay_Exempt.Text = tb_Pay_Exempt.Text + "1";
            }
            else if (tb_Pay_Coupon.Background == Brushes.LightPink)
            {
                tb_Pay_Coupon.Text = tb_Pay_Coupon.Text + "1";
            }
            else if (tb_Pay_Member.Background == Brushes.LightPink)
            {
                tb_Pay_Member.Text = tb_Pay_Member.Text + "1";
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Commit_Pay();

            tb_Pay_Cash.TextChanged += tb_TextChanged;
            tb_Pay_Bank.TextChanged += tb_TextChanged;
            tb_Pay_Coupon.TextChanged += tb_TextChanged;
            tb_Pay_Exempt.TextChanged += tb_TextChanged;
            tb_Pay_Member.TextChanged += tb_TextChanged;
        }

        private void tb_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            Commit_Pay();
        }

        private void l_Commit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Convert.ToDecimal(tb_Change.Text) >= 0)
            {
                if (Convert.ToDecimal(tb_Member_Remain.Text) >= 0)
                {
                    DialogResult = true;
                    Close();
                }
            }
        }

        private void tb_Pay_Cash_GotFocus(object sender, RoutedEventArgs e)
        {
            tb_Pay_Cash.SelectAll();
            tb_Pay_Cash.PreviewMouseDown -= new MouseButtonEventHandler(tb_Pay_Cash_PreviewMouseDown);

            tb_Pay_Cash.Background = Brushes.LightPink;
        }

        private void tb_Pay_Cash_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            tb_Pay_Cash.Focus();

            e.Handled = true;
        }

        private void tb_Pay_Cash_LostFocus(object sender, RoutedEventArgs e)
        {
            tb_Pay_Cash.PreviewMouseDown += new MouseButtonEventHandler(tb_Pay_Cash_PreviewMouseDown);

            tb_Pay_Cash.Background = Brushes.White;
        }

        private void l_BackSpace_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Pay_Bank.Background == Brushes.LightPink)
            {
                tb_Pay_Bank.Text = string.Empty;
            }
            else if (tb_Pay_Cash.Background == Brushes.LightPink)
            {
                tb_Pay_Cash.Text = string.Empty;
            }
            else if (tb_Pay_Exempt.Background == Brushes.LightPink)
            {
                tb_Pay_Exempt.Text = string.Empty;
            }
            else if (tb_Pay_Coupon.Background == Brushes.LightPink)
            {
                tb_Pay_Coupon.Text = string.Empty;
            }
            else if (tb_Pay_Member.Background == Brushes.LightPink)
            {
                tb_Pay_Member.Text = string.Empty;
            }
        }

        private void tb_Pay_Bank_GotFocus(object sender, RoutedEventArgs e)
        {
            tb_Pay_Bank.SelectAll();
            tb_Pay_Bank.PreviewMouseDown -= new MouseButtonEventHandler(tb_Pay_Bank_PreviewMouseDown);

            tb_Pay_Bank.Background = Brushes.LightPink;
        }

        private void tb_Pay_Bank_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            tb_Pay_Bank.Focus();

            e.Handled = true;
        }

        private void tb_Pay_Bank_LostFocus(object sender, RoutedEventArgs e)
        {
            tb_Pay_Bank.PreviewMouseDown += new MouseButtonEventHandler(tb_Pay_Bank_PreviewMouseDown);

            tb_Pay_Bank.Background = Brushes.White;
        }

        private void tb_Pay_Exempt_GotFocus(object sender, RoutedEventArgs e)
        {
            tb_Pay_Exempt.SelectAll();
            tb_Pay_Exempt.PreviewMouseDown -= new MouseButtonEventHandler(tb_Pay_Exempt_PreviewMouseDown);

            tb_Pay_Exempt.Background = Brushes.LightPink;
        }

        private void tb_Pay_Exempt_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            tb_Pay_Exempt.Focus();

            e.Handled = true;
        }

        private void tb_Pay_Exempt_LostFocus(object sender, RoutedEventArgs e)
        {
            tb_Pay_Exempt.PreviewMouseDown += new MouseButtonEventHandler(tb_Pay_Exempt_PreviewMouseDown);

            tb_Pay_Exempt.Background = Brushes.White;
        }

        private void tb_Pay_Coupon_GotFocus(object sender, RoutedEventArgs e)
        {
            tb_Pay_Coupon.SelectAll();
            tb_Pay_Coupon.PreviewMouseDown -= new MouseButtonEventHandler(tb_Pay_Coupon_PreviewMouseDown);

            tb_Pay_Coupon.Background = Brushes.LightPink;
        }

        private void tb_Pay_Coupon_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            tb_Pay_Coupon.Focus();

            e.Handled = true;
        }

        private void tb_Pay_Coupon_LostFocus(object sender, RoutedEventArgs e)
        {
            tb_Pay_Coupon.PreviewMouseDown += new MouseButtonEventHandler(tb_Pay_Coupon_PreviewMouseDown);

            tb_Pay_Coupon.Background = Brushes.White;
        }

        private void tb_Pay_Member_GotFocus(object sender, RoutedEventArgs e)
        {
            tb_Pay_Member.SelectAll();
            tb_Pay_Member.PreviewMouseDown -= new MouseButtonEventHandler(tb_Pay_Member_PreviewMouseDown);

            tb_Pay_Member.Background = Brushes.LightPink;
        }

        private void tb_Pay_Member_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            tb_Pay_Member.Focus();

            e.Handled = true;
        }

        private void tb_Pay_Member_LostFocus(object sender, RoutedEventArgs e)
        {
            tb_Pay_Member.PreviewMouseDown += new MouseButtonEventHandler(tb_Pay_Member_PreviewMouseDown);

            tb_Pay_Member.Background = Brushes.White;
        }

        private void l_2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Pay_Bank.Background == Brushes.LightPink)
            {
                tb_Pay_Bank.Text = tb_Pay_Bank.Text + "2";
            }
            else if (tb_Pay_Cash.Background == Brushes.LightPink)
            {
                tb_Pay_Cash.Text = tb_Pay_Cash.Text + "2";
            }
            else if (tb_Pay_Exempt.Background == Brushes.LightPink)
            {
                tb_Pay_Exempt.Text = tb_Pay_Exempt.Text + "2";
            }
            else if (tb_Pay_Coupon.Background == Brushes.LightPink)
            {
                tb_Pay_Coupon.Text = tb_Pay_Coupon.Text + "2";
            }
            else if (tb_Pay_Member.Background == Brushes.LightPink)
            {
                tb_Pay_Member.Text = tb_Pay_Member.Text + "2";
            }
        }

        private void l_3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Pay_Bank.Background == Brushes.LightPink)
            {
                tb_Pay_Bank.Text = tb_Pay_Bank.Text + "3";
            }
            else if (tb_Pay_Cash.Background == Brushes.LightPink)
            {
                tb_Pay_Cash.Text = tb_Pay_Cash.Text + "3";
            }
            else if (tb_Pay_Exempt.Background == Brushes.LightPink)
            {
                tb_Pay_Exempt.Text = tb_Pay_Exempt.Text + "3";
            }
            else if (tb_Pay_Coupon.Background == Brushes.LightPink)
            {
                tb_Pay_Coupon.Text = tb_Pay_Coupon.Text + "3";
            }
            else if (tb_Pay_Member.Background == Brushes.LightPink)
            {
                tb_Pay_Member.Text = tb_Pay_Member.Text + "3";
            }
        }

        private void l_4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Pay_Bank.Background == Brushes.LightPink)
            {
                tb_Pay_Bank.Text = tb_Pay_Bank.Text + "4";
            }
            else if (tb_Pay_Cash.Background == Brushes.LightPink)
            {
                tb_Pay_Cash.Text = tb_Pay_Cash.Text + "4";
            }
            else if (tb_Pay_Exempt.Background == Brushes.LightPink)
            {
                tb_Pay_Exempt.Text = tb_Pay_Exempt.Text + "4";
            }
            else if (tb_Pay_Coupon.Background == Brushes.LightPink)
            {
                tb_Pay_Coupon.Text = tb_Pay_Coupon.Text + "4";
            }
            else if (tb_Pay_Member.Background == Brushes.LightPink)
            {
                tb_Pay_Member.Text = tb_Pay_Member.Text + "4";
            }
        }

        private void l_5_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Pay_Bank.Background == Brushes.LightPink)
            {
                tb_Pay_Bank.Text = tb_Pay_Bank.Text + "5";
            }
            else if (tb_Pay_Cash.Background == Brushes.LightPink)
            {
                tb_Pay_Cash.Text = tb_Pay_Cash.Text + "5";
            }
            else if (tb_Pay_Exempt.Background == Brushes.LightPink)
            {
                tb_Pay_Exempt.Text = tb_Pay_Exempt.Text + "5";
            }
            else if (tb_Pay_Coupon.Background == Brushes.LightPink)
            {
                tb_Pay_Coupon.Text = tb_Pay_Coupon.Text + "5";
            }
            else if (tb_Pay_Member.Background == Brushes.LightPink)
            {
                tb_Pay_Member.Text = tb_Pay_Member.Text + "5";
            }
        }

        private void l_6_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Pay_Bank.Background == Brushes.LightPink)
            {
                tb_Pay_Bank.Text = tb_Pay_Bank.Text + "6";
            }
            else if (tb_Pay_Cash.Background == Brushes.LightPink)
            {
                tb_Pay_Cash.Text = tb_Pay_Cash.Text + "6";
            }
            else if (tb_Pay_Exempt.Background == Brushes.LightPink)
            {
                tb_Pay_Exempt.Text = tb_Pay_Exempt.Text + "6";
            }
            else if (tb_Pay_Coupon.Background == Brushes.LightPink)
            {
                tb_Pay_Coupon.Text = tb_Pay_Coupon.Text + "6";
            }
            else if (tb_Pay_Member.Background == Brushes.LightPink)
            {
                tb_Pay_Member.Text = tb_Pay_Member.Text + "6";
            }
        }

        private void l_7_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Pay_Bank.Background == Brushes.LightPink)
            {
                tb_Pay_Bank.Text = tb_Pay_Bank.Text + "7";
            }
            else if (tb_Pay_Cash.Background == Brushes.LightPink)
            {
                tb_Pay_Cash.Text = tb_Pay_Cash.Text + "7";
            }
            else if (tb_Pay_Exempt.Background == Brushes.LightPink)
            {
                tb_Pay_Exempt.Text = tb_Pay_Exempt.Text + "7";
            }
            else if (tb_Pay_Coupon.Background == Brushes.LightPink)
            {
                tb_Pay_Coupon.Text = tb_Pay_Coupon.Text + "7";
            }
            else if (tb_Pay_Member.Background == Brushes.LightPink)
            {
                tb_Pay_Member.Text = tb_Pay_Member.Text + "7";
            }
        }

        private void l_8_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Pay_Bank.Background == Brushes.LightPink)
            {
                tb_Pay_Bank.Text = tb_Pay_Bank.Text + "8";
            }
            else if (tb_Pay_Cash.Background == Brushes.LightPink)
            {
                tb_Pay_Cash.Text = tb_Pay_Cash.Text + "8";
            }
            else if (tb_Pay_Exempt.Background == Brushes.LightPink)
            {
                tb_Pay_Exempt.Text = tb_Pay_Exempt.Text + "8";
            }
            else if (tb_Pay_Coupon.Background == Brushes.LightPink)
            {
                tb_Pay_Coupon.Text = tb_Pay_Coupon.Text + "8";
            }
            else if (tb_Pay_Member.Background == Brushes.LightPink)
            {
                tb_Pay_Member.Text = tb_Pay_Member.Text + "8";
            }
        }

        private void l_9_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Pay_Bank.Background == Brushes.LightPink)
            {
                tb_Pay_Bank.Text = tb_Pay_Bank.Text + "9";
            }
            else if (tb_Pay_Cash.Background == Brushes.LightPink)
            {
                tb_Pay_Cash.Text = tb_Pay_Cash.Text + "9";
            }
            else if (tb_Pay_Exempt.Background == Brushes.LightPink)
            {
                tb_Pay_Exempt.Text = tb_Pay_Exempt.Text + "9";
            }
            else if (tb_Pay_Coupon.Background == Brushes.LightPink)
            {
                tb_Pay_Coupon.Text = tb_Pay_Coupon.Text + "9";
            }
            else if (tb_Pay_Member.Background == Brushes.LightPink)
            {
                tb_Pay_Member.Text = tb_Pay_Member.Text + "9";
            }
        }

        private void l_0_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Pay_Bank.Background == Brushes.LightPink)
            {
                tb_Pay_Bank.Text = tb_Pay_Bank.Text + "0";
            }
            else if (tb_Pay_Cash.Background == Brushes.LightPink)
            {
                tb_Pay_Cash.Text = tb_Pay_Cash.Text + "0";
            }
            else if (tb_Pay_Exempt.Background == Brushes.LightPink)
            {
                tb_Pay_Exempt.Text = tb_Pay_Exempt.Text + "0";
            }
            else if (tb_Pay_Coupon.Background == Brushes.LightPink)
            {
                tb_Pay_Coupon.Text = tb_Pay_Coupon.Text + "0";
            }
            else if (tb_Pay_Member.Background == Brushes.LightPink)
            {
                tb_Pay_Member.Text = tb_Pay_Member.Text + "0";
            }
        }
    }
}