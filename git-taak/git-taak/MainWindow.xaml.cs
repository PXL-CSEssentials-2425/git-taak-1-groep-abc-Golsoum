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

namespace git_taak
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
        private void yellowEvent(object sender, EventArgs e)
        {
            mainWindow.Background = Brushes.Yellow;
        } 
        private void leaveYellow(object sender, EventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }
       
        private void greenEvent(object sender, EventArgs e)
        {
            mainWindow.Background = Brushes.Green; 
        }
        private void leaveGreen(object sender, EventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }
        private void blueEvent(object sender,EventArgs e)
        {
            mainWindow.Background = Brushes.Blue; 
        }
        private void leaveBlue(object sender, EventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }
        private void redEvent(object sender, EventArgs e)
        {
            mainWindow.Background = Brushes.Red; 
        }
        private void leaveRed(object sender, EventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }
         private void yellowClick(object sender, EventArgs e)
        {
            colorCodeTextBox.Text = "#FFFF00";
        }
        private void greenClick(object sender, EventArgs e)
        {
            colorCodeTextBox.Text = "#008000";
        }
        private void blueClick(object sender, EventArgs e)
        {
            colorCodeTextBox.Text = "#0000FF";
        }
        private void redClick(object sender, EventArgs e)
        {
            colorCodeTextBox.Text = "#FF0000";
        }



    }
}