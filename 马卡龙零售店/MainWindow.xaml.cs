using System;
using System.Windows;

namespace 马卡龙零售店
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fMain.Source = new Uri("Items.xaml", UriKind.Relative);
        }
    }
}
