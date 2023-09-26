using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Model;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {

        private static string _theme;
        public static string theme
        {
            get => _theme;
            set
            {
                _theme = value;
                var dict = new ResourceDictionary
                {
                    Source = new Uri($"Themes/store/{_theme}.xaml", UriKind.Relative)
                };

                Current.Resources.MergedDictionaries.RemoveAt(0);
                Current.Resources.MergedDictionaries.Insert(0, dict);


            }
        }

        public App()
        {
            InitializeComponent();

            Task.Run(() =>
            {
                while (true)
                {
                    int data = Convert.ToInt32(DateTime.Now.Hour);

                    if (data >= 0 && data < 4)
                    {
                        theme = "Night";
                    }
                    else if (data >= 4 && data < 12)
                    {
                        theme = "Evening";  
                    }
                    else if (data >= 12 && data < 17)
                    {
                        theme = "Day";
                    }
                    else if (data >= 17 && data < 0)
                    {
                        theme = "Evening";
                    }

                    Thread.Sleep(10000);
                }
            });
        }
    }
}
