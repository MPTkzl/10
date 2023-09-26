using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.Model
{
    internal class ChangeTheme
    {
        public static async void Change()
        {
            while (true)
            {
                var data = DateTime.Now.Hour;
                MessageBox.Show(data.ToString());
                Thread.Sleep(10000);
            }
        }
    }
}
