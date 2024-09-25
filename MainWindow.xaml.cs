using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Homework4_Lab1
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

        private void Button_Click(object sender, RoutedEventArgs e) {
            double Speed = Convert.ToDouble(speed.Text);
            double Speedlim = Convert.ToDouble(speedlim.Text);
            double speedover = Speed - Speedlim;

            if (Speed > Speedlim + 5) {
                double fine = 60 + speedover * 7;
                fine = speedover > 25 ? fine + 250 : fine;
                output.Content = "Over speed limit by " + speedover + " miles, resulting in a $" + fine + ".00 fine.";
                canvas.Background = Brushes.Red;
            } else if (Speed > Speedlim) {
                output.Content = "Over speed limit by " + speedover + " miles, no penalty.";
                canvas.Background = Brushes.Orange;
            } else {
                output.Content = "Under speed limit.";
                canvas.Background = Brushes.Green;
            }
        }
    }
}