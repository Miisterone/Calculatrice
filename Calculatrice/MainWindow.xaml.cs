using System.Diagnostics;
using System.Globalization;
using System.Windows;

namespace Calculatrice
{
    public partial class MainWindow
    {

        private float _total;
        private string number;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TxtName_OnLoaded(object sender, RoutedEventArgs e)
        {
            Result.Content = number;
        }
        
        private void Add_0(object sender, RoutedEventArgs e)
        {
            number += "0";
            
            Result.Content = number.ToString(CultureInfo.InvariantCulture);
        }
        private void Add_1(object sender, RoutedEventArgs e)
        {
            number += "1";
            Result.Content = number.ToString(CultureInfo.InvariantCulture);
        }
        private void Add_2(object sender, RoutedEventArgs e)
        {
            number += "2";
            Result.Content = number.ToString(CultureInfo.InvariantCulture);
        }
        private void Add_3(object sender, RoutedEventArgs e)
        {
            number += "3";
            Result.Content = _total.ToString(CultureInfo.InvariantCulture);
        }
        private void Add_4(object sender, RoutedEventArgs e)
        {
            number += "4";
            Result.Content = _total.ToString(CultureInfo.InvariantCulture);
        }
        private void Add_5(object sender, RoutedEventArgs e)
        {
            number += "5";
            Result.Content = _total.ToString(CultureInfo.InvariantCulture);
        }
        private void Add_6(object sender, RoutedEventArgs e)
        {
            number += "6";
            Result.Content = _total.ToString(CultureInfo.InvariantCulture);
        }
        private void Add_7(object sender, RoutedEventArgs e)
        {
            number += "7";
            Result.Content = _total.ToString(CultureInfo.InvariantCulture);
        }
        private void Add_8(object sender, RoutedEventArgs e)
        {
            number += "8";
            Result.Content = _total.ToString(CultureInfo.InvariantCulture);
        }
        private void Add_9(object sender, RoutedEventArgs e)
        {
            number += "9";
            Result.Content = _total.ToString(CultureInfo.InvariantCulture);
        }
        private void Clear(object sender, RoutedEventArgs e)
        {
            number = "";
            _total = 0;
            Result.Content = _total.ToString(CultureInfo.InvariantCulture);
        }
        private void ClearData()
        {
            number = "";
            _total = 0;
        }
        private void Equal(object sender, RoutedEventArgs e)
        {
            if (number == "") return;
            _total += float.Parse(number);
            LastNumber.Content = _total.ToString(CultureInfo.InvariantCulture);
            Result.Content = _total;
            ClearData();
        }
        private void Addition(object sender, RoutedEventArgs e)
        {
            LastNumber.Content = number.ToString(CultureInfo.InvariantCulture);
            _total += float.Parse(number);
            number = "";
        }
        private void Substraction(object sender, RoutedEventArgs e){}
        private void Division(object sender, RoutedEventArgs e){}
        private void Float(object sender, RoutedEventArgs e){}
        private void DeleteLastNumber(object sender, RoutedEventArgs e){}
        private void ClearLastAdd(object sender, RoutedEventArgs e){}
    }
}