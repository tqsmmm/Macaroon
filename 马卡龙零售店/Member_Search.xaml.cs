using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace 马卡龙零售店
{
    /// <summary>
    /// Member_Search.xaml 的交互逻辑
    /// </summary>
    public partial class Member_Search : Window
    {
        public Member_Search()
        {
            InitializeComponent();

            tbMember_Code.PreviewMouseDown += new MouseButtonEventHandler(tbMember_Code_PreviewMouseDown);
            tbMember_Code.GotFocus += new RoutedEventHandler(tbMember_Code_GotFocus);
            tbMember_Code.LostFocus += new RoutedEventHandler(tbMember_Code_LostFocus);

            tbMember_Mobile.PreviewMouseDown += new MouseButtonEventHandler(tbMember_Mobile_PreviewMouseDown);
            tbMember_Mobile.GotFocus += new RoutedEventHandler(tbMember_Mobile_GotFocus);
            tbMember_Mobile.LostFocus += new RoutedEventHandler(tbMember_Mobile_LostFocus);
        }

        public string Member_ID = string.Empty;
        public string Member_Name = string.Empty;
        public string Member_Mobile = string.Empty;
        public bool Member_Membered = false;
        public decimal Member_Discount = 0;
        public decimal Member_Balance = 0;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void tbMember_Code_GotFocus(object sender, RoutedEventArgs e)
        {
            tbMember_Code.SelectAll();
            tbMember_Code.PreviewMouseDown -= new MouseButtonEventHandler(tbMember_Code_PreviewMouseDown);

            tbMember_Code.Background = Brushes.LightPink;
        }

        private void tbMember_Code_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            tbMember_Code.Focus();

            e.Handled = true;
        }

        private void tbMember_Code_LostFocus(object sender, RoutedEventArgs e)
        {
            tbMember_Code.PreviewMouseDown += new MouseButtonEventHandler(tbMember_Code_PreviewMouseDown);

            tbMember_Code.Background = Brushes.White;
        }

        private void tbMember_Mobile_GotFocus(object sender, RoutedEventArgs e)
        {
            tbMember_Mobile.SelectAll();
            tbMember_Mobile.PreviewMouseDown -= new MouseButtonEventHandler(tbMember_Mobile_PreviewMouseDown);

            tbMember_Mobile.Background = Brushes.LightPink;
        }

        private void tbMember_Mobile_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            tbMember_Mobile.Focus();

            e.Handled = true;
        }

        private void tbMember_Mobile_LostFocus(object sender, RoutedEventArgs e)
        {
            tbMember_Mobile.PreviewMouseDown += new MouseButtonEventHandler(tbMember_Mobile_PreviewMouseDown);

            tbMember_Mobile.Background = Brushes.White;
        }

        private void l_1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tbMember_Code.Background == Brushes.LightPink)
            {
                tbMember_Code.Text = tbMember_Code.Text + "1";
            }
            else if (tbMember_Mobile.Background == Brushes.LightPink)
            {
                tbMember_Mobile.Text = tbMember_Mobile.Text + "1";
            }
        }

        private void l_2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tbMember_Code.Background == Brushes.LightPink)
            {
                tbMember_Code.Text = tbMember_Code.Text + "2";
            }
            else if (tbMember_Mobile.Background == Brushes.LightPink)
            {
                tbMember_Mobile.Text = tbMember_Mobile.Text + "2";
            }
        }

        private void l_3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tbMember_Code.Background == Brushes.LightPink)
            {
                tbMember_Code.Text = tbMember_Code.Text + "3";
            }
            else if (tbMember_Mobile.Background == Brushes.LightPink)
            {
                tbMember_Mobile.Text = tbMember_Mobile.Text + "3";
            }
        }

        private void l_4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tbMember_Code.Background == Brushes.LightPink)
            {
                tbMember_Code.Text = tbMember_Code.Text + "4";
            }
            else if (tbMember_Mobile.Background == Brushes.LightPink)
            {
                tbMember_Mobile.Text = tbMember_Mobile.Text + "4";
            }
        }

        private void l_5_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tbMember_Code.Background == Brushes.LightPink)
            {
                tbMember_Code.Text = tbMember_Code.Text + "5";
            }
            else if (tbMember_Mobile.Background == Brushes.LightPink)
            {
                tbMember_Mobile.Text = tbMember_Mobile.Text + "5";
            }
        }

        private void l_6_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tbMember_Code.Background == Brushes.LightPink)
            {
                tbMember_Code.Text = tbMember_Code.Text + "6";
            }
            else if (tbMember_Mobile.Background == Brushes.LightPink)
            {
                tbMember_Mobile.Text = tbMember_Mobile.Text + "6";
            }
        }

        private void l_7_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tbMember_Code.Background == Brushes.LightPink)
            {
                tbMember_Code.Text = tbMember_Code.Text + "7";
            }
            else if (tbMember_Mobile.Background == Brushes.LightPink)
            {
                tbMember_Mobile.Text = tbMember_Mobile.Text + "7";
            }
        }

        private void l_8_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tbMember_Code.Background == Brushes.LightPink)
            {
                tbMember_Code.Text = tbMember_Code.Text + "8";
            }
            else if (tbMember_Mobile.Background == Brushes.LightPink)
            {
                tbMember_Mobile.Text = tbMember_Mobile.Text + "8";
            }
        }

        private void l_9_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tbMember_Code.Background == Brushes.LightPink)
            {
                tbMember_Code.Text = tbMember_Code.Text + "9";
            }
            else if (tbMember_Mobile.Background == Brushes.LightPink)
            {
                tbMember_Mobile.Text = tbMember_Mobile.Text + "9";
            }
        }

        private void l_0_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tbMember_Code.Background == Brushes.LightPink)
            {
                tbMember_Code.Text = tbMember_Code.Text + "0";
            }
            else if (tbMember_Mobile.Background == Brushes.LightPink)
            {
                tbMember_Mobile.Text = tbMember_Mobile.Text + "0";
            }
        }

        private void l_BackSpace_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tbMember_Code.Background == Brushes.LightPink)
            {
                tbMember_Code.Text = string.Empty;
            }
            else if (tbMember_Mobile.Background == Brushes.LightPink)
            {
                tbMember_Mobile.Text = string.Empty;
            }
        }

        private void l_Commit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            System.Data.DataSet Ds;

            if (tbMember_Code.Text != string.Empty)
            {
                Ds = DB_Work.DataSetCmd(string.Format("SELECT Code,Name,Mobile,Membered,Discount,Balance FROM Members WHERE Code='{0}'", tbMember_Code.Text));
            }
            else
            {
                Ds = DB_Work.DataSetCmd(string.Format("SELECT Code,Name,Mobile,Membered,Discount,Balance FROM Members WHERE Mobile='{0}'", tbMember_Mobile.Text));
            }
            

            if (Ds.Tables[0].Rows.Count > 0)
            {
                Member_ID = Ds.Tables[0].Rows[0][0].ToString();
                Member_Name = Ds.Tables[0].Rows[0][1].ToString();
                Member_Mobile = Ds.Tables[0].Rows[0][2].ToString();
                Member_Membered = Convert.ToBoolean(Ds.Tables[0].Rows[0][3]);
                Member_Discount = Convert.ToDecimal(Ds.Tables[0].Rows[0][4]);
                Member_Balance = Convert.ToDecimal(Ds.Tables[0].Rows[0][5]);

                DialogResult = true;
                Close();
            }
        }
    }
}
