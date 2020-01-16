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
using bitcoin_reader;
using Newtonsoft.Json;

namespace bitcoin_reader
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Rest r = new Rest();
                
                JSonRetreival jsr = new JSonRetreival();
                string data = r.GetBTC();
                jsr.FryTheJson(data);
                txb.Text = data;

                

            }
          catch ( Exception ex)
            {
                string message = ex.Message;
                Console.WriteLine(message);

            }
          

        }

    }
}
