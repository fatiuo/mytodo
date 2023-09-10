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
    public partial class editpage : Window
    {
        
        public editpage()
        {
            InitializeComponent();
            this.button.Click+=singIn;
        }



        async void singIn(object sender,EventArgs args)
        {

            await client.EditpageAsync(int.Parse(this.id.Text),this.title.Text,this.hobby1.Text,this.hobby2.Text,this.hobby3.Text);                                  
        }
        static HttpClient httpClient = new HttpClient();
        swaggerClient client = new swaggerClient("http://localhost:5000/", httpClient);

    }
}
