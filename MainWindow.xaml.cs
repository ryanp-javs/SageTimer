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
using System.Windows.Threading;

namespace StageTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer WorkerTimer;

        public MainWindow()
        {
            InitializeComponent();

            this.Background = Brushes.Black;

            WorkerTimer = new DispatcherTimer();
            WorkerTimer.Interval = new TimeSpan(0, 0, 1);
            WorkerTimer.Tick += WorkerTimer_Tick;
            WorkerTimer.Start();
        }

        private void WorkerTimer_Tick(object sender, EventArgs e)
        {
            TimeOfDay.Content = DateTime.Now.ToString();
        }
    }
}
