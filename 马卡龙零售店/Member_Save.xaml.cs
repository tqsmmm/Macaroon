using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace 马卡龙零售店
{
    /// <summary>
    /// Member_Save.xaml 的交互逻辑
    /// </summary>
    public partial class Member_Save : Window
    {
        public Member_Save()
        {
            InitializeComponent();

            tb_Save.PreviewMouseDown += new MouseButtonEventHandler(tb_Save_PreviewMouseDown);
            tb_Save.GotFocus += new RoutedEventHandler(tb_Save_GotFocus);
            tb_Save.LostFocus += new RoutedEventHandler(tb_Save_LostFocus);
        }

        private void Commit()
        {
            try
            {
                tb_Remain.Text = (Convert.ToDecimal(tb_Balance.Text) + Convert.ToDecimal(tb_Save.Text)).ToString();
            }
            catch
            {

            }
        }

        private void tb_Save_LostFocus(object sender, RoutedEventArgs e)
        {
            tb_Save.PreviewMouseDown += new MouseButtonEventHandler(tb_Save_PreviewMouseDown);

            tb_Save.Background = Brushes.White;
        }

        private void tb_Save_GotFocus(object sender, RoutedEventArgs e)
        {
            tb_Save.SelectAll();
            tb_Save.PreviewMouseDown -= new MouseButtonEventHandler(tb_Save_PreviewMouseDown);

            tb_Save.Background = Brushes.LightPink;
        }

        private void tb_Save_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            tb_Save.Focus();

            e.Handled = true;
        }

        private void l_1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Save.Background == Brushes.LightPink)
            {
                tb_Save.Text = tb_Save.Text + "1";
            }
        }

        private void l_2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Save.Background == Brushes.LightPink)
            {
                tb_Save.Text = tb_Save.Text + "2";
            }
        }

        private void l_3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Save.Background == Brushes.LightPink)
            {
                tb_Save.Text = tb_Save.Text + "3";
            }
        }

        private void l_4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Save.Background == Brushes.LightPink)
            {
                tb_Save.Text = tb_Save.Text + "4";
            }
        }

        private void l_5_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Save.Background == Brushes.LightPink)
            {
                tb_Save.Text = tb_Save.Text + "5";
            }
        }

        private void l_6_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Save.Background == Brushes.LightPink)
            {
                tb_Save.Text = tb_Save.Text + "6";
            }
        }

        private void l_7_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Save.Background == Brushes.LightPink)
            {
                tb_Save.Text = tb_Save.Text + "7";
            }
        }

        private void l_8_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Save.Background == Brushes.LightPink)
            {
                tb_Save.Text = tb_Save.Text + "8";
            }
        }

        private void l_9_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Save.Background == Brushes.LightPink)
            {
                tb_Save.Text = tb_Save.Text + "9";
            }
        }

        private void l_0_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Save.Background == Brushes.LightPink)
            {
                tb_Save.Text = tb_Save.Text + "0";
            }
        }

        private void l_BackSpace_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Save.Background == Brushes.LightPink)
            {
                tb_Save.Text = string.Empty;
            }
        }

        private void l_Commit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Hide();

            CheckOut co = new CheckOut();
            co.gMember.Visibility = System.Windows.Visibility.Hidden;
            co.tb_Amount.Text = co.tb_Total.Text = tb_Save.Text;
            co.ShowDialog();

            if (co.DialogResult.Value)
            {
                DB_Work.ExecuteCmd(string.Format("Insert_Save '{0}',{1},{2},{3},{4},{5}", tb_Code.Text, tb_Save.Text, co.tb_Pay_Cash.Text, co.tb_Pay_Bank.Text, co.tb_Pay_Coupon.Text, co.tb_Pay_Exempt.Text));

                Close();
            }
            else
            {
                ShowDialog();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Commit();

            tb_Save.TextChanged += tb_Save_TextChanged;
        }

        private void tb_Save_TextChanged(object sender, TextChangedEventArgs e)
        {
            Commit();
        }
    }
}
