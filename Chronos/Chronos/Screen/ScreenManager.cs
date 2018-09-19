using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos
{
    public class ScreenManager
    {
        public static void Initialize(MainWindow window)
        {
            window.Width = (Properties.Settings.Default.UserScreenWidth < 0) ?
                System.Windows.SystemParameters.PrimaryScreenWidth * 0.6 : 
                Properties.Settings.Default.UserScreenWidth;

            window.Height = (Properties.Settings.Default.UserScreenHeight < 0) ?
                System.Windows.SystemParameters.PrimaryScreenHeight * 0.6 :
                Properties.Settings.Default.UserScreenHeight;
        }

        public static void SaveScreenSetting(MainWindow window)
        {
            Properties.Settings.Default.UserScreenWidth = window.Width;
            Properties.Settings.Default.UserScreenHeight = window.Height;
            Properties.Settings.Default.Save();
        }
    }
}