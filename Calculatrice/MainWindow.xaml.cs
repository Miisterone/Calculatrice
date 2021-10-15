using System.Globalization;
using System.Windows;

namespace Calculatrice
{
    public partial class MainWindow
    {

        private float _total = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TxtName_OnLoaded(object sender, RoutedEventArgs e)
        {
            Result.Content = _total.ToString(CultureInfo.InvariantCulture);
        }

        private void Add_1(object sender, RoutedEventArgs e)
        {
            _total += 1;
            Result.Content = _total.ToString(CultureInfo.InvariantCulture);
        }

        private void Add_2(object sender, RoutedEventArgs e)
        {
            _total += 2;
            Result.Content = _total.ToString(CultureInfo.InvariantCulture);
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            _total = 0;
            Result.Content = _total.ToString(CultureInfo.InvariantCulture);
        }

        private void Add_3(object sender, RoutedEventArgs e)
        {
            _total += 3;
            Result.Content = _total.ToString(CultureInfo.InvariantCulture);
        }

        private void Add_4(object sender, RoutedEventArgs e)
        {
            _total += 4;
            Result.Content = _total.ToString(CultureInfo.InvariantCulture);
        }
        private void Add_5(object sender, RoutedEventArgs e)
        {
            _total += 5;
            Result.Content = _total.ToString(CultureInfo.InvariantCulture);
        }
        private void Add_6(object sender, RoutedEventArgs e)
        {
            _total += 6;
            Result.Content = _total.ToString(CultureInfo.InvariantCulture);
        }

        private void Add_7(object sender, RoutedEventArgs e)
        {
            _total += 7;
            Result.Content = _total.ToString(CultureInfo.InvariantCulture);
        }

        private void Add_8(object sender, RoutedEventArgs e)
        {
            _total += 8;
            Result.Content = _total.ToString(CultureInfo.InvariantCulture);
        }
        private void Add_9(object sender, RoutedEventArgs e)
        {
            _total += 9;
            Result.Content = _total.ToString(CultureInfo.InvariantCulture);
        }
    }
}