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

namespace Wpf_ListView_grouping
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Employee> items = new List<Employee>();
            items.Add(new Employee() { Name = "Deli Dumrul", Department = DeparmentType.Development });
            items.Add(new Employee() { Name = "Ibo Tatlises", Department = DeparmentType.Development });
            items.Add(new Employee() { Name = "Some Dummy", Department = DeparmentType.IT });
            items.Add(new Employee() { Name = "Lorem Traple", Department = DeparmentType.IT });

            EmployeeList.ItemsSource = items;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(EmployeeList.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Department");
            view.GroupDescriptions.Add(groupDescription);

        }

    }

    public enum DeparmentType { Development, IT}

    public class Employee
    {
        public string Name { get; set; }
        public DeparmentType Department { get; set; }
    }

}
