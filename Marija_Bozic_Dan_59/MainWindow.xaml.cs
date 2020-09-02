using Marija_Bozic_Dan_59.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Marija_Bozic_Dan_59
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel model;
        public MainWindow()
        {
            model = new MainWindowViewModel(this);
            this.DataContext = model;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            model.CloseAll();
            model.Filde_10.IsShown = true;           
            model.counter++;           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            model.CloseAll();
            model.Filde_20.IsShown = true;            
            model.counter++;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            model.CloseAll();
            model.Filde_30.IsShown = true;            
            model.counter++;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            model.CloseAll();
            model.Filde_01.IsShown = true;
            model.counter++;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            model.CloseAll();
            model.Filde_11.IsShown = true;
            model.counter++;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            model.CloseAll();
            model.Filde_21.IsShown = true;
            model.counter++;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            model.CloseAll();
            model.Filde_31.IsShown = true;
            model.counter++;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            model.CloseAll();
            model.Filde_02.IsShown = true;
            model.counter++;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            model.CloseAll();
            model.Filde_12.IsShown = true;
            model.counter++;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            model.CloseAll();
            model.Filde_22.IsShown = true;
            model.counter++;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            model.CloseAll();
            model.Filde_32.IsShown = true;
            model.counter++;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            model.CloseAll();
            model.Filde_03.IsShown = true;
            model.counter++;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            model.CloseAll();
            model.Filde_13.IsShown = true;
            model.counter++;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            model.CloseAll();
            model.Filde_23.IsShown = true;
            model.counter++;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            model.CloseAll();
            model.Filde_33.IsShown = true;
            model.counter++;
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            model.CloseAll();
            model.Filde_00.IsShown = true;
            model.counter++;
        }
    }
}
