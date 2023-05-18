using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
    /// Логика взаимодействия для ReportCardControl.xaml
    /// </summary>
    public partial class ReportCardControl : UserControl
    {
        public int DepartamentID
        {
            get { return (int)GetValue(DepartamentIDProperty); }
            set { SetValue(DepartamentIDProperty, value); }
        }

        public static readonly DependencyProperty DepartamentIDProperty =
                DependencyProperty.Register("DepartamentID", typeof(int), typeof(ReportCardControl), new UIPropertyMetadata());
        public ReportCardControl()
        {
            InitializeComponent();
            DataContext = this;
            List<PhonesList> phonesList = new List<PhonesList>
            {
                new  PhonesList { Title="iPhone 6S", Company="Apple", Price=54990, Type = TypesGG.End },
                new PhonesList { Title = "Lumia 950", Company = "Microsoft", Price = 39990, Type = TypesGG.None },
                new PhonesList { Title = "Nexus 5X", Company = "Google", Price = DepartamentID, Type = TypesGG.Cool }
            };
            // ReportGrid.Columns.Add(new DataGridColumn());
            ReportGrid.ItemsSource = phonesList;
            ReportGrid.IsReadOnly = false;
            // ReportGrid.o
        }

        private void ReportGrid_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {

        }
    }

    public class PhonesList
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
        public TypesGG Type { get; set; }

        public PhonesList()
        {

        }
    }

    public enum TypesGG
    {
        None = 0,
        Cool = 1,
        End = 2,
    }
}
