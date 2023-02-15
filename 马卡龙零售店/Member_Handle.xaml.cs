using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace 马卡龙零售店
{
    /// <summary>
    /// Member_Handle.xaml 的交互逻辑
    /// </summary>
    public partial class Member_Handle : Window
    {
        public Member_Handle()
        {
            InitializeComponent();

            tb_Code.PreviewMouseDown += new MouseButtonEventHandler(tb_Code_PreviewMouseDown);
            tb_Code.GotFocus += new RoutedEventHandler(tb_Code_GotFocus);
            tb_Code.LostFocus += new RoutedEventHandler(tb_Code_LostFocus);

            tb_Name.PreviewMouseDown += new MouseButtonEventHandler(tb_Name_PreviewMouseDown);
            tb_Name.GotFocus += new RoutedEventHandler(tb_Name_GotFocus);
            tb_Name.LostFocus += new RoutedEventHandler(tb_Name_LostFocus);

            tb_Mobile.PreviewMouseDown += new MouseButtonEventHandler(tb_Mobile_PreviewMouseDown);
            tb_Mobile.GotFocus += new RoutedEventHandler(tb_Mobile_GotFocus);
            tb_Mobile.LostFocus += new RoutedEventHandler(tb_Mobile_LostFocus);
        }

        private void tb_Mobile_LostFocus(object sender, RoutedEventArgs e)
        {
            tb_Mobile.PreviewMouseDown += new MouseButtonEventHandler(tb_Mobile_PreviewMouseDown);

            tb_Mobile.Background = Brushes.White;
        }

        private void tb_Mobile_GotFocus(object sender, RoutedEventArgs e)
        {
            tb_Mobile.SelectAll();
            tb_Mobile.PreviewMouseDown -= new MouseButtonEventHandler(tb_Mobile_PreviewMouseDown);

            tb_Mobile.Background = Brushes.LightPink;
        }

        private void tb_Mobile_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            tb_Mobile.Focus();

            e.Handled = true;
        }

        private void tb_Name_LostFocus(object sender, RoutedEventArgs e)
        {
            tb_Name.PreviewMouseDown += new MouseButtonEventHandler(tb_Name_PreviewMouseDown);

            tb_Name.Background = Brushes.White;
        }

        private void tb_Name_GotFocus(object sender, RoutedEventArgs e)
        {
            tb_Name.SelectAll();
            tb_Name.PreviewMouseDown -= new MouseButtonEventHandler(tb_Name_PreviewMouseDown);

            tb_Name.Background = Brushes.LightPink;
        }

        private void tb_Name_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            tb_Name.Focus();

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
            else if (tb_Name.Background == Brushes.LightPink)
            {
                tb_Name.Text = tb_Name.Text + "1";
            }
            else if (tb_Mobile.Background == Brushes.LightPink)
            {
                tb_Mobile.Text = tb_Mobile.Text + "1";
            }
        }

        private void l_2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Code.Background == Brushes.LightPink)
            {
                tb_Code.Text = tb_Code.Text + "2";
            }
            else if (tb_Name.Background == Brushes.LightPink)
            {
                tb_Name.Text = tb_Name.Text + "2";
            }
            else if (tb_Mobile.Background == Brushes.LightPink)
            {
                tb_Mobile.Text = tb_Mobile.Text + "2";
            }
        }

        private void l_3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Code.Background == Brushes.LightPink)
            {
                tb_Code.Text = tb_Code.Text + "3";
            }
            else if (tb_Name.Background == Brushes.LightPink)
            {
                tb_Name.Text = tb_Name.Text + "3";
            }
            else if (tb_Mobile.Background == Brushes.LightPink)
            {
                tb_Mobile.Text = tb_Mobile.Text + "3";
            }
        }

        private void l_4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Code.Background == Brushes.LightPink)
            {
                tb_Code.Text = tb_Code.Text + "4";
            }
            else if (tb_Name.Background == Brushes.LightPink)
            {
                tb_Name.Text = tb_Name.Text + "4";
            }
            else if (tb_Mobile.Background == Brushes.LightPink)
            {
                tb_Mobile.Text = tb_Mobile.Text + "4";
            }
        }

        private void l_5_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Code.Background == Brushes.LightPink)
            {
                tb_Code.Text = tb_Code.Text + "5";
            }
            else if (tb_Name.Background == Brushes.LightPink)
            {
                tb_Name.Text = tb_Name.Text + "5";
            }
            else if (tb_Mobile.Background == Brushes.LightPink)
            {
                tb_Mobile.Text = tb_Mobile.Text + "5";
            }
        }

        private void l_6_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Code.Background == Brushes.LightPink)
            {
                tb_Code.Text = tb_Code.Text + "6";
            }
            else if (tb_Name.Background == Brushes.LightPink)
            {
                tb_Name.Text = tb_Name.Text + "6";
            }
            else if (tb_Mobile.Background == Brushes.LightPink)
            {
                tb_Mobile.Text = tb_Mobile.Text + "6";
            }
        }

        private void l_7_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Code.Background == Brushes.LightPink)
            {
                tb_Code.Text = tb_Code.Text + "7";
            }
            else if (tb_Name.Background == Brushes.LightPink)
            {
                tb_Name.Text = tb_Name.Text + "7";
            }
            else if (tb_Mobile.Background == Brushes.LightPink)
            {
                tb_Mobile.Text = tb_Mobile.Text + "7";
            }
        }

        private void l_8_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Code.Background == Brushes.LightPink)
            {
                tb_Code.Text = tb_Code.Text + "8";
            }
            else if (tb_Name.Background == Brushes.LightPink)
            {
                tb_Name.Text = tb_Name.Text + "8";
            }
            else if (tb_Mobile.Background == Brushes.LightPink)
            {
                tb_Mobile.Text = tb_Mobile.Text + "8";
            }
        }

        private void l_9_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Code.Background == Brushes.LightPink)
            {
                tb_Code.Text = tb_Code.Text + "9";
            }
            else if (tb_Name.Background == Brushes.LightPink)
            {
                tb_Name.Text = tb_Name.Text + "9";
            }
            else if (tb_Mobile.Background == Brushes.LightPink)
            {
                tb_Mobile.Text = tb_Mobile.Text + "9";
            }
        }

        private void l_0_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Code.Background == Brushes.LightPink)
            {
                tb_Code.Text = tb_Code.Text + "0";
            }
            else if (tb_Name.Background == Brushes.LightPink)
            {
                tb_Name.Text = tb_Name.Text + "0";
            }
            else if (tb_Mobile.Background == Brushes.LightPink)
            {
                tb_Mobile.Text = tb_Mobile.Text + "0";
            }
        }

        private void l_BackSpace_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Code.Background == Brushes.LightPink)
            {
                tb_Code.Text = string.Empty;
            }
            else if (tb_Name.Background == Brushes.LightPink)
            {
                tb_Name.Text = string.Empty;
            }
            else if (tb_Mobile.Background == Brushes.LightPink)
            {
                tb_Mobile.Text = string.Empty;
            }
        }

        private void l_Commit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            System.Data.DataSet Ds = DB_Work.DataSetCmd(string.Format("SELECT id FROM Members WHERE Code='{0}'", tb_Code.Text));

            if (Ds.Tables[0].Rows.Count > 0)
            {
                Public.Sys_MsgBox("会员编码已存在，请检查后重试！");
                return;
            }

            Hide();

            CheckOut co = new CheckOut();
            co.gMember.Visibility = System.Windows.Visibility.Hidden;
            co.tb_Amount.Text = co.tb_Total.Text = tb_Price.Text;
            co.ShowDialog();

            if (co.DialogResult.Value)
            {
                bool bMembered = false;

                if (rb_True.IsChecked.Value)
                {
                    bMembered = true;
                }

                DB_Work.ExecuteCmd(string.Format("Insert_Handle '{0}','{1}','{2}',{3},{4},{5},{6},{7},{8},{9}", tb_Code.Text, tb_Name.Text, tb_Mobile.Text, bMembered, tb_Discount.Text, tb_Balance.Text, co.tb_Pay_Cash.Text, co.tb_Pay_Bank.Text, co.tb_Pay_Coupon.Text, co.tb_Pay_Exempt.Text));

                Close();
            }
            else
            {
                ShowDialog();
            }
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cb_Type.ItemsSource = DB_Work.DataSetCmd("SELECT id,Name FROM Members_Type").Tables[0].DefaultView;
            cb_Type.SelectedValuePath = "id";
            cb_Type.DisplayMemberPath = "Name";
        }

        private void cb_Type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cb_Type.SelectedIndex != -1)
            {
                System.Data.DataSet Ds = DB_Work.DataSetCmd(string.Format("SELECT Discount,Price,Balance FROM Members_Type WHERE id={0}", cb_Type.SelectedValue));

                tb_Discount.Text = Ds.Tables[0].Rows[0][0].ToString();
                tb_Price.Text = Ds.Tables[0].Rows[0][1].ToString();
                tb_Balance.Text = Ds.Tables[0].Rows[0][2].ToString();
            }
        }
    }
}
