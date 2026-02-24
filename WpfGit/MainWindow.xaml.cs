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

namespace WpfGit
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

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            tbRes.Text = $"Результат сложения: {int.Parse(tbOne.Text)+int.Parse(tbTwo.Text)}";
        }

        private void btMultiply_Click(object sender, RoutedEventArgs e)
        {
            tbRes.Text = $"Результат: {int.Parse(tbOne.Text) * int.Parse(tbTwo.Text)}";
        }
    }
}