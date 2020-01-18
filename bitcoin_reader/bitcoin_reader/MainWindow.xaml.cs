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

            Rest r = new Rest();
            JSonRetreival jsr = new JSonRetreival();
            string data = r.GetBTC();
            jsr.FryTheJson(data);
           
            InitializeComponent();

            BTC.Content = Math.Round(System.Convert.ToDouble(JSonRetreival.coinAndPrice["Bitcoin"]),2);
            ETH.Content = Math.Round(System.Convert.ToDouble(JSonRetreival.coinAndPrice["Ethereum"]), 2);
            B1.Content = JSonRetreival.coinAndPrice["Bitcoin_percent_change_1h"];
            B2.Content = JSonRetreival.coinAndPrice["Bitcoin_percent_change_24h"];
            B3.Content = JSonRetreival.coinAndPrice["Bitcoin_percent_change_7d"];

            ETH1.Content = JSonRetreival.coinAndPrice["Ethereum_percent_change_1h"];
            ETH2.Content = JSonRetreival.coinAndPrice["Ethereum_percent_change_24h"];
            ETH3.Content = JSonRetreival.coinAndPrice["Ethereum_percent_change_7d"];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

             

                

            }
          catch ( Exception ex)
            {
                string message = ex.Message;
                Console.WriteLine(message);

            }
          

        }

    }
}
