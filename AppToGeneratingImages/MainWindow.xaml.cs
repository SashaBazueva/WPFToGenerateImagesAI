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

namespace AppToGeneratingImages
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Об авторе!!!");
        }

        private void BtnUp_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(numericUpDownTextBox.Text);
            number++;
            numericUpDownTextBox.Text = number.ToString();
        }

        private void BtnDown_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(numericUpDownTextBox.Text);
            number--;
            numericUpDownTextBox.Text = number.ToString();
        }
    }
}
