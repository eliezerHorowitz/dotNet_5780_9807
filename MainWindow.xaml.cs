using dotNet5781_02_9807;
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


namespace dotNet5781_03_9807

{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            int a = 5;

            busLinesSystem mySystem = new busLinesSystem();
            InitializeComponent(mySystem);
                cbBusLines.ItemsSource = busLines;
                cbBusLines.DisplayMemberPath = " BusLineNum ";
                cbBusLines.SelectedIndex = 0;
            
            Console.ReadKey();
           
        }

        private void InitializeComponent(busLinesSystem ms)
        {
            
            

            for (int i = 0; i < 10; ++i)
            {
                ms.allBus.Add(new busLine(i + 1, new BusLineStation(new busStation(i + 6), i, new busStation(i + 11)), new BusLineStation(new busStation(i + 6), i, new busStation(i + 8))));
            }
           
        }
    }
}
