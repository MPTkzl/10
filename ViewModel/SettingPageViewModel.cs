using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using WpfApp1.ViewModel.Help;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    public class SettingPageViewModel : INotifyPropertyChanged
    {

        public ICommand SaveSettingsCommand { get; set; }

        public ICommand AddFavoriteCityCommand { get; set; }
        public ObservableCollection<string> FavoriteCities { get; set; } = new ObservableCollection<string>();

        private string _mainCity;
        public string MainCity
        {
            get
            {
                return _mainCity;
            }
            set
            {
                OnPropertyChanged();
                _mainCity = value;
            }
        }

        private string _cityToAdd;
        public string CityToAdd
        {
            get
            {
                return _cityToAdd;
            }
            set
            {
               OnPropertyChanged();
            _cityToAdd = value;
            }
        }

        private bool _isFahrenheit;
        public bool IsFahrenheit
        {
            get
            {
                return _isFahrenheit;
            }
            set
            {
               OnPropertyChanged();
                _isFahrenheit = value;
            }
        }

        private bool _isCelsius;
        public bool IsCelsius
        {
            get
            {
                return _isCelsius;
            }
            set
            {
                OnPropertyChanged();
                _isCelsius = value;
            }
        }


        public SettingPageViewModel()
        {
            IsCelsius = Properties.Settings.Default.IsCelsius;
            IsFahrenheit = Properties.Settings.Default.IsFahrenheit;
            MainCity = Properties.Settings.Default.MainCity;
            if(Properties.Settings.Default.FavoriteCities != null && Properties.Settings.Default.FavoriteCities?.Count != 0)
            {
                FavoriteCities = new ObservableCollection<string>(Properties.Settings.Default.FavoriteCities);
            }
            else
            {
                FavoriteCities = new ObservableCollection<string>();
            }
            
            SaveSettingsCommand = new bindableCommand(obj => SaveSettings());
            AddFavoriteCityCommand = new bindableCommand(obj => AddFavoriteCity());
        }

        public void SaveSettings()
        {
           
                if (string.IsNullOrEmpty(MainCity))
                {
                    MessageBox.Show("Выберите город!");
                    return;
                }
                Properties.Settings.Default.MainCity = MainCity;
                Properties.Settings.Default.FavoriteCities = FavoriteCities.ToList();

                if (IsCelsius)
                {
                    Properties.Settings.Default.IsCelsius = true;
                    Properties.Settings.Default.IsFahrenheit = false;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Настройки сохранены");
                    return;
                }
                if (IsFahrenheit)
                {
                    Properties.Settings.Default.IsCelsius = false;
                    Properties.Settings.Default.IsFahrenheit = true;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Настройки сохранены");
                    return;
                }
                MessageBox.Show("Выберите меру измерения температуры!");
            
           
        }

        public void AddFavoriteCity()
        {
            if (string.IsNullOrWhiteSpace(CityToAdd))
            {
                MessageBox.Show("Введите город!");
                return;
            }
            FavoriteCities.Add(CityToAdd);
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    internal class SettingPageViewModel
    {

    }
}
