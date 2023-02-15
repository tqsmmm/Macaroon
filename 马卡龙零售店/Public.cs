using System.Windows;

namespace 马卡龙零售店
{
    class Public
    {
        static string strApplicationName = "新玛特马卡龙";

        public static void Sys_MsgBox(string strMsg)
        {
            MessageBox.Show(strMsg, strApplicationName, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static bool Sys_MsgYN(string strMsg)
        {
            if (MessageBox.Show(strMsg, strApplicationName, MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
