using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Cesi.IntroCS.WpfApp.Annotations;

namespace Cesi.IntroCS.WpfApp
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private bool isBtnPiActive;
        private double piResult;
        private string buttonText;

        public string ButtonText
        {
            get => buttonText;
            set
            {
                buttonText = value;
                OnPropertyChanged();
            }
        }

        public bool IsBtnPiActive
        {
            get => isBtnPiActive;
            set
            {
                isBtnPiActive = value;
                OnPropertyChanged();
            }
        }

        public double PiResult
        {
            get => piResult;
            set
            {
                piResult = value;
                OnPropertyChanged();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            ButtonText = "Mon bouton";
            IsBtnPiActive = true;
        }

        private void Btn_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello WPF");
        }

        private async void BtnPi_OnClick(object sender, RoutedEventArgs e)
        {
            IsBtnPiActive = false;

            try
            {
                PiResult = await ComputePi();
            }
            finally
            {
                IsBtnPiActive = true;
            }
        }

        private Task<double> ComputePi()
        {
            return Task.Run(() =>
            {
                var sum = 0.0;
                var step = 1e-9;

                for (var i = 0; i < 1000000000; i++)
                {
                    var x = (i + 0.5) * step;
                    sum = sum + 4.0 / (1.0 + x * x);
                }

                return sum * step;
            });

        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class MyRecord : INotifyPropertyChanged
    {
        private string buttonText;
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string ButtonText
        {
            get
            {
                return buttonText;
            }
            set
            {

                buttonText = value;
                OnPropertyChanged();
            }
        }
    }
}
