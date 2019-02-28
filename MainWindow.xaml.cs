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

namespace _184905Math
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Global Vairables
        int x;
        int y;
        int answer;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddInt_Click(object sender, RoutedEventArgs e)
        {
            setXandY();
            answer = x + y;
            lblOutput.Content = answer.ToString();
        }

        private void setXandY()
        {
            /*This method was created by
             * highlighting these two lines of code,
             * then clicking - Edit - Refactor - Extract Method
             */
            int.TryParse(txtX.Text, out x);
            int.TryParse(txtY.Text, out y);
        }

        private void btnSubtractInt_Click(object sender, RoutedEventArgs e)
        {
            setXandY();
            answer = x - y;
            lblOutput.Content = answer.ToString();
        }

        private void btnMultiplyInt_Click(object sender, RoutedEventArgs e)
        {
            setXandY();
            answer = x * y;
            lblOutput.Content = answer.ToString();
        }

        private void btnDivisionInt_Click(object sender, RoutedEventArgs e)
        {
            setXandY();
            answer = x / y;
            lblOutput.Content = answer.ToString();
        }

        private void btnModulusInt_Click(object sender, RoutedEventArgs e)
        {         
            int.TryParse(txtX.Text, out x);
            int.TryParse(txtY.Text, out y);
            answer = x % y;
            lblOutput.Content = answer.ToString();
        }
    }
}
