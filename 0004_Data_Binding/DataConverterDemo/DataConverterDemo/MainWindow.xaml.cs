using System;
using System.Windows;

namespace DataConverterDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Employee emp = new Employee("Mohit", "Sharma", new DateTime(2010, 01, 01));

            DataContext = emp;
        }
    }
}
