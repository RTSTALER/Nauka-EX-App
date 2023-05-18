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

namespace Nauka_EX_App
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> depts = new List<string>() { "Test1", "Test2", "Test3" };
            depatrList.ItemsSource = depts;
        }

        private void depatrList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(depatrList.SelectedIndex.ToString() + " name " + depatrList.Items[depatrList.SelectedIndex].ToString());
        }
    }
}
