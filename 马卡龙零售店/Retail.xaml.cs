using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace 马卡龙零售店
{
    /// <summary>
    /// Retail.xaml 的交互逻辑
    /// </summary>
    public partial class Retail : Page
    {
        public Retail()
        {
            InitializeComponent();
        }

        ObservableCollection<Item> Items = new ObservableCollection<Item>();

        ObservableCollection<Selected> Selecteds = new ObservableCollection<Selected>();

        Bills Bill = new Bills();

        private class Bills
        {
            public string Order_ID = string.Empty;
            public string Member_ID = string.Empty;
            public string Member_Name = string.Empty;
            public bool Member_Membered = false;
            public decimal Member_Discount = 0;
            public decimal Member_Balance = 0;
            public decimal Amount = 0;
            public decimal Total = 0;

            public decimal Pay_Cash = 0;
            public decimal Pay_Bank = 0;
            public decimal Pay_Exempt = 0;
            public decimal Pay_Coupon = 0;
            public decimal Pay_Member = 0;

            public decimal Member_Remain = 0;
        }

        public class Item
        {
            public int Item_ID { get; set; }
            public BitmapImage Image { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Type { get; set; }
        }

        public class Selected
        {
            public int Item_ID { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public decimal Num { get; set; }
            public decimal Amount { get; set; }
            public string Type { get; set; }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Load_Items(false);
        }

        private void lvItems_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (lvItems.SelectedItems.Count > 0)
            {
                Item i = (Item)lvItems.SelectedItem;

                bool b = false;

                for (int j = 0; j < lvSelected.Items.Count; j++)
                {
                    if (((Selected)lvSelected.Items[j]).Item_ID == i.Item_ID)
                    {
                        Selecteds.Insert(j, new Selected
                        {
                            Item_ID = i.Item_ID,
                            Name = i.Name,
                            Price = i.Price,
                            Num = ((Selected)lvSelected.Items[j]).Num + 1,
                            Amount = i.Price * (((Selected)lvSelected.Items[j]).Num + 1),
                            Type = ((Selected)lvSelected.Items[j]).Type
                        });

                        Selecteds.RemoveAt(j + 1);

                        b = true;
                    }
                }

                if (!b)
                {
                    Selecteds.Add(new Selected
                    {
                        Item_ID = i.Item_ID,
                        Name = i.Name,
                        Price = i.Price,
                        Num = 1,
                        Amount = i.Price,
                        Type = i.Type
                    });
                }

                lvSelected.ItemsSource = Selecteds;

                Total_Selecteds();
            }
        }

        private void Load_Items(bool Member)
        {
            DataSet Ds;

            if (Member)
                Ds = DB_Work.DataSetCmd("SELECT id,Image,Name,Member_Price AS [Price],Type FROM Items");
            else
                Ds = DB_Work.DataSetCmd("SELECT id,Image,Name,Sell_Price AS [Price],Type FROM Items");

            Items.Clear();

            byte[] br = null;

            for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                if (Ds.Tables[0].Rows[i][1] == DBNull.Value)
                {
                    Items.Add(new Item
                    {
                        Item_ID = Convert.ToInt32(Ds.Tables[0].Rows[i][0]),
                        Image = null,
                        Name = Ds.Tables[0].Rows[i][2].ToString(),
                        Price = Convert.ToDecimal(Ds.Tables[0].Rows[i][3]),
                        Type = Ds.Tables[0].Rows[i][4].ToString()
                    });
                }
                else
                {
                    br = (byte[])(Ds.Tables[0].Rows[i][1]);

                    BitmapImage img = ImageConverter.ByteArrayToBitmapImage(br);

                    Items.Add(new Item
                    {
                        Item_ID = Convert.ToInt32(Ds.Tables[0].Rows[i][0]),
                        Image = img,
                        Name = Ds.Tables[0].Rows[i][2].ToString(),
                        Price = Convert.ToDecimal(Ds.Tables[0].Rows[i][3]),
                        Type = Ds.Tables[0].Rows[i][4].ToString()
                    });
                }
            }

            lvItems.ItemsSource = Items;
        }

        private void Init_Bill()
        {
            Bill = new Bills();

            Load_Items(false);

            tb_Member_Code.Text = "";
            tb_Member_Balance.Text = "0.00";

            lvSelected.ItemsSource = null;

            Selecteds.Clear();

            tb_Total.Text = "0.00";
            tb_Amount.Text = "0.00";
        }

        private void Total_Selecteds()
        {
            tb_Amount.Text = "0.00";
            tb_Total.Text = "0.00";

            decimal Num_Macaron = 0;
            decimal Num_Rose = 0;

            for (int l = 0; l < lvSelected.Items.Count; l++)
            {
                tb_Amount.Text = (Convert.ToDecimal(tb_Amount.Text) + ((Selected)lvSelected.Items[l]).Price * ((Selected)lvSelected.Items[l]).Num).ToString();

                if (((Selected)lvSelected.Items[l]).Type == "马卡龙")
                {
                    Num_Macaron = Num_Macaron + ((Selected)lvSelected.Items[l]).Num;
                }

                if (((Selected)lvSelected.Items[l]).Name == "玫瑰花糖")
                {
                    Num_Rose = Num_Rose + ((Selected)lvSelected.Items[l]).Num;
                }
            }

            if (!Bill.Member_Membered || Bill.Member_ID == string.Empty)
            {
                if (Num_Macaron == 9)
                {
                    tb_Total.Text = (Convert.ToDecimal(tb_Amount.Text) - 6).ToString();
                }
                else if (Num_Macaron >= 6 && Num_Macaron < 8)
                {
                    tb_Total.Text = (Convert.ToDecimal(tb_Amount.Text) - 14).ToString();
                }
                else if (Num_Macaron >= 8 && Num_Macaron < 12)
                {
                    tb_Total.Text = (Convert.ToDecimal(tb_Amount.Text) - 17).ToString();
                }
                else if (Num_Macaron >= 12 && Num_Macaron < 20)
                {
                    tb_Total.Text = (Convert.ToDecimal(tb_Amount.Text) - 28).ToString();
                }
                else if (Num_Macaron >= 20 && Num_Macaron < 25)
                {
                    tb_Total.Text = (Convert.ToDecimal(tb_Amount.Text) - 50).ToString();
                }
                else if (Num_Macaron >= 25)
                {
                    tb_Total.Text = (Convert.ToDecimal(tb_Amount.Text) - 84).ToString();
                }
                else
                {
                    tb_Total.Text = tb_Amount.Text;
                }

                if (Num_Rose == 11)
                {
                    tb_Total.Text = (Convert.ToDecimal(tb_Total.Text) - 32).ToString();
                }
                else if (Num_Rose == 5)
                {
                    tb_Total.Text = (Convert.ToDecimal(tb_Total.Text) - 10).ToString();
                }
            }
            else
            {
                tb_Total.Text = tb_Amount.Text;
            }
        }

        private void gMember_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Member_Search ms = new Member_Search();
            ms.ShowDialog();

            if (ms.DialogResult.Value)
            {
                Bill.Member_ID = ms.Member_ID;
                Bill.Member_Name = ms.Member_Name;
                Bill.Member_Membered = ms.Member_Membered;
                Bill.Member_Discount = ms.Member_Discount;
                Bill.Member_Balance = ms.Member_Balance;

                tb_Member_Code.Text = Bill.Member_ID + " " + Bill.Member_Name;
                tb_Member_Balance.Text = Bill.Member_Balance.ToString();

                if (Bill.Member_Membered || Bill.Member_Discount != 1)
                {
                    Load_Items(true);

                    for (int i = 0; i < lvSelected.Items.Count; i++)
                    {
                        Selected j = (Selected)lvSelected.Items[0];

                        DataSet Ds = DB_Work.DataSetCmd(string.Format("SELECT Member_Price FROM Items WHERE id = {0}", j.Item_ID));

                        Selecteds.Insert(lvSelected.Items.Count, new Selected
                        {
                            Item_ID = j.Item_ID,
                            Name = j.Name,
                            Price = Convert.ToDecimal(Ds.Tables[0].Rows[0][0]),
                            Num = j.Num,
                            Amount = Convert.ToDecimal(Ds.Tables[0].Rows[0][0]) * j.Num
                        });

                        Selecteds.RemoveAt(0);
                    }

                    lvSelected.ItemsSource = Selecteds;

                    Total_Selecteds();
                }
            }
        }

        private void gTotal_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CheckOut co = new CheckOut();
            co.tb_Amount.Text = tb_Amount.Text;
            co.tb_Total.Text = tb_Total.Text;
            co.tb_Member_Balance.Text = tb_Member_Balance.Text;

            co.ShowDialog();

            if (co.DialogResult.Value)
            {
                if (lvSelected.Items.Count > 0)
                {
                    Bill.Amount = Convert.ToDecimal(tb_Amount.Text);
                    Bill.Total = Convert.ToDecimal(tb_Total.Text);

                    Bill.Pay_Cash = Convert.ToDecimal(co.tb_Pay_Cash.Text);
                    Bill.Pay_Bank = Convert.ToDecimal(co.tb_Pay_Bank.Text);
                    Bill.Pay_Exempt = Convert.ToDecimal(co.tb_Pay_Exempt.Text);
                    Bill.Pay_Coupon = Convert.ToDecimal(co.tb_Pay_Coupon.Text);
                    Bill.Pay_Member = Convert.ToDecimal(co.tb_Pay_Member.Text);

                    Bill.Member_Remain = Convert.ToDecimal(co.tb_Member_Remain.Text);

                    Bill.Order_ID = DB_Work.DataSetCmd(string.Format("Insert_Bills '{0}',{1},{2},{3},{4},{5},{6},{7}", Bill.Member_ID, Bill.Amount, Bill.Total, 
                        Convert.ToDecimal(co.tb_Pay_Cash.Text), Convert.ToDecimal(co.tb_Pay_Bank.Text), Convert.ToDecimal(co.tb_Pay_Coupon.Text), 
                        Convert.ToDecimal(co.tb_Pay_Exempt.Text), Convert.ToDecimal(co.tb_Pay_Member.Text))).Tables[0].Rows[0][0].ToString();

                    Selected j = null;

                    for (int i = 0; i < lvSelected.Items.Count; i++)
                    {
                        j = (Selected)lvSelected.Items[i];

                        DB_Work.ExecuteCmd(string.Format("INSERT INTO Bills_Detail(Order_ID,Item_ID,Price,Num,Amount) VALUES('{0}',{1},{2},{3},{4})", Bill.Order_ID, j.Item_ID, j.Price, j.Num, j.Amount));
                    }

                    PrintDocument PrintCheckout = new PrintDocument();
                    PrintCheckout.PrinterSettings.PrinterName = "GP-5890X";

                    PrintCheckout.PrintPage += new PrintPageEventHandler(PrintCheckout_PrintPage);

                    PrintCheckout.Print();
                    PrintCheckout.Print();

                    Init_Bill();
                }
            }
        }

        private void PrintCheckout_PrintPage(object sender, PrintPageEventArgs e)
        {
            var pen = new Pen(Brushes.Black, 1);

            e.Graphics.DrawString("结算单", new Font("微软雅黑", 12, System.Drawing.FontStyle.Bold), Brushes.Black, 50, 0);

            e.Graphics.DrawString("客单编码：" + Bill.Order_ID, new Font("微软雅黑", 10), Brushes.Black, 0, 20);
            e.Graphics.DrawString("客单时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm"), new Font("微软雅黑", 10), Brushes.Black, 0, 40);

            e.Graphics.DrawString(string.Format("会员：{0}", Bill.Member_ID), new Font("微软雅黑", 10), Brushes.Black, 0, 60);

            e.Graphics.DrawLine(pen, new System.Drawing.Point(0, 80), new System.Drawing.Point(200, 80));
            e.Graphics.DrawString("名称", new Font("微软雅黑", 10, System.Drawing.FontStyle.Underline), Brushes.Black, 0, 80);
            e.Graphics.DrawString("单价", new Font("微软雅黑", 10, System.Drawing.FontStyle.Underline), Brushes.Black, 0, 100);
            e.Graphics.DrawString("数量", new Font("微软雅黑", 10, System.Drawing.FontStyle.Underline), Brushes.Black, 80, 100);
            e.Graphics.DrawString("金额", new Font("微软雅黑", 10, System.Drawing.FontStyle.Underline), Brushes.Black, 140, 100);

            var intX = 100;

            DataSet Ds = DB_Work.DataSetCmd(string.Format("SELECT Items.Name,Items.Type,Bills_Detail.Price,Bills_Detail.Num,Bills_Detail.Amount FROM Bills_Detail LEFT JOIN Items ON Items.id = Bills_Detail.Item_ID WHERE Order_ID = '{0}'", Bill.Order_ID));

            for (var i = 0; i < Ds.Tables[0].Rows.Count; i++)
            {
                intX = intX + 20;

                e.Graphics.DrawString(Ds.Tables[0].Rows[i][0].ToString(), new Font("微软雅黑", 10), Brushes.Black, 0, intX);

                intX = intX + 20;

                e.Graphics.DrawString(Ds.Tables[0].Rows[i][2].ToString(), new Font("微软雅黑", 10), Brushes.Black, 0, intX);
                e.Graphics.DrawString(Ds.Tables[0].Rows[i][3].ToString(), new Font("微软雅黑", 10), Brushes.Black, 80, intX);
                e.Graphics.DrawString(Ds.Tables[0].Rows[i][4].ToString(), new Font("微软雅黑", 10), Brushes.Black, 140, intX);
            }

            e.Graphics.DrawLine(pen, new System.Drawing.Point(0, intX + 20), new System.Drawing.Point(200, intX + 20));

            e.Graphics.DrawString("消费：" + string.Format("{0:N}", Bill.Amount), new Font("微软雅黑", 10, System.Drawing.FontStyle.Bold), Brushes.Black, 0, intX + 20);
            e.Graphics.DrawString("应付：" + string.Format("{0:N}", Bill.Total), new Font("微软雅黑", 10, System.Drawing.FontStyle.Bold), Brushes.Black, 100, intX + 20);

            e.Graphics.DrawString("现金：" + string.Format("{0:N}", Bill.Pay_Cash), new Font("微软雅黑", 10, System.Drawing.FontStyle.Bold), Brushes.Black, 0, intX + 40);
            e.Graphics.DrawString("刷卡：" + string.Format("{0:N}", Bill.Pay_Bank), new Font("微软雅黑", 10, System.Drawing.FontStyle.Bold), Brushes.Black, 100, intX + 40);
            e.Graphics.DrawString("免单：" + string.Format("{0:N}", Bill.Pay_Exempt), new Font("微软雅黑", 10, System.Drawing.FontStyle.Bold), Brushes.Black, 0, intX + 60);
            e.Graphics.DrawString("代卷：" + string.Format("{0:N}", Bill.Pay_Coupon), new Font("微软雅黑", 10, System.Drawing.FontStyle.Bold), Brushes.Black, 100, intX + 60);

            e.Graphics.DrawString("会员：" + string.Format("{0:N}", Bill.Pay_Member), new Font("微软雅黑", 10, System.Drawing.FontStyle.Bold), Brushes.Black, 0, intX + 80);
            e.Graphics.DrawString("结余：" + string.Format("{0:N}", Bill.Member_Remain), new Font("微软雅黑", 10, System.Drawing.FontStyle.Bold), Brushes.Black, 100, intX + 80);
        }

        private void lvSelected_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (lvSelected.SelectedItems.Count > 0)
            {
                Selected i = (Selected)lvSelected.SelectedItem;

                Selecteds.Remove(i);

                Total_Selecteds();
            }
        }

        private void tb_Handle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Member_Handle mh = new Member_Handle();
            mh.ShowDialog();
        }

        private void tb_Save_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Member_Search ms = new Member_Search();
            ms.ShowDialog();

            if (ms.DialogResult.Value)
            {
                Member_Save m = new Member_Save();
                m.tb_Code.Text = ms.Member_ID;
                m.tb_Name.Text = ms.Member_Name;
                m.tb_Mobile.Text = ms.Member_Mobile;
                m.tb_Balance.Text = ms.Member_Balance.ToString();
                m.ShowDialog();
            }
        }
    }
}
