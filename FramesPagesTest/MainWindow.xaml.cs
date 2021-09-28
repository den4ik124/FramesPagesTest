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

namespace FramesPagesTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TestFrame.Source = new Uri(@"Pages/TestPage1.xaml", UriKind.Relative);
        }

        private void btnPage1_Click(object sender, RoutedEventArgs e)
        {
            TestFrame.Source = new Uri(@"Pages/TestPage1.xaml", UriKind.Relative);
        }

        private void btnPage2_Click(object sender, RoutedEventArgs e)
        {
            TestFrame.Source = new Uri(@"Pages/TestPage2.xaml", UriKind.Relative);
        }

        private void expMenu_MouseEnter(object sender, MouseEventArgs e)
        {
            expMenu.IsExpanded = true;
        }

        private void expMenu_MouseLeave(object sender, MouseEventArgs e)
        {
            expMenu.IsExpanded = false;
        }
    }
}