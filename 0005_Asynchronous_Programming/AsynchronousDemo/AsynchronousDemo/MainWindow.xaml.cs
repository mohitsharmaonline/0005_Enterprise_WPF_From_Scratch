
using System;
using System.Threading.Tasks;
using System.Windows;

namespace AsynchronousDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ComputeStuffAsync();
        }

        private async void ComputeStuffAsync()
        {
            for (;;)
            {
                var sum = 0.0;
                Message.Text = "Computing...";
                await Task.Run(() => 
                {
                    for(int i = 0; i < 200000000; i++)
                    {
                        sum += Math.Sqrt(i);
                    }
                });
                Message.Text = "Sum = " + sum;

                await Task.Run(() =>
                {
                    for (int i = 0; i < 200000000; i++)
                    {
                        sum += Math.Sqrt(i);
                    }
                });
                Message.Text = "Sum = " + sum;
                await Task.Run(() =>
                {
                    for (int i = 0; i < 200000000; i++)
                    {
                        sum += Math.Sqrt(i);
                    }
                });
                Message.Text = "Sum = " + sum;
                await Task.Run(() =>
                {
                    for (int i = 0; i < 200000000; i++)
                    {
                        sum += Math.Sqrt(i);
                    }
                });
                Message.Text = "Sum = " + sum;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Clicked!");
        }
    }
}
