using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            lblStart.Content = "Hello! What's up?";
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lblClose.Content = "Why do you want to close me? :(";
        }

        private void Like_Checked(object sender, RoutedEventArgs e)
        {
                lblCheck.Content = "I know you don't...";    
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lblOk.Content = "Why are you asking a program about this?";
            //Asd

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
                pgpMyprogressbar.Value += 20;  
        }
    }
}
