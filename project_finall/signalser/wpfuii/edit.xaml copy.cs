using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using project.Client;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.SignalR.Client;

namespace wpfui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class edit : Window
    {
        
        public edit()
        {
            InitializeComponent();
            this.button.Click+=singIn;
            this.CALen.Click+=CALend;
        }


        private void CALend(object sender, RoutedEventArgs e)
        {
            if (calendar.Visibility == Visibility.Collapsed)
            {
                calendar.Visibility = Visibility.Visible;
            }
            else
            {
                calendar.Visibility = Visibility.Collapsed;
            }
        }
        async void singIn(object sender,EventArgs args)
        {
            await client.EditTodoAsync(int.Parse(this.id.Text),this.title.Text,this.detail.Text,DateTime.Now.ToString(),DateTime.Now.AddDays(int.Parse(this.dayhave.Text)).ToString());                                  
        }
        static HttpClient httpClient = new HttpClient();
        swaggerClient client = new swaggerClient("http://localhost:5000/", httpClient);
        // var con=new HubConnectionBuilder ().WithUrl("http://localhost:5000/chathub").Build();

        // con.StartAsync().Wait();
    }
}
