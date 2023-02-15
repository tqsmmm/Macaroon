using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace 马卡龙零售店
{
    /// <summary>
    /// Statistic.xaml 的交互逻辑
    /// </summary>
    public partial class Statistic : Page
    {
        public Statistic()
        {
            InitializeComponent();
        }
        
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void tb_Items_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Statistic_Items si = new Statistic_Items();
            NavigationService.Navigate(si);
        }

        private void tb_Bills_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Statistic_Bills sb = new Statistic_Bills();
            NavigationService.Navigate(sb);
        }

        private void tb_Handle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Statistic_Handle sh = new Statistic_Handle();
            NavigationService.Navigate(sh);
        }

        private void tb_Save_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Statistic_Save ss = new Statistic_Save();
            NavigationService.Navigate(ss);
        }

        private void tb_Statement_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Statistic_Statement ss = new Statistic_Statement();
            NavigationService.Navigate(ss);
        }

        private void tb_Members_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Statistic_Members sm = new Statistic_Members();
            NavigationService.Navigate(sm);
        }
    }
}
