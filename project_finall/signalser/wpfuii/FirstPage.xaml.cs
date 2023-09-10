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
    public partial class FirstPage : Window
    {
        
        public FirstPage()
        {
            InitializeComponent();
            this.button.Click+=singIn;
           this.button1.Click+=showing;
        }



        async void singIn(object sender,EventArgs args)
        {
            await client.CreatpageAsync(new Mypage(this.userBox.Text,this.pwBox.TabIndex,this.enjoy1.Text,this.enjoy2.Text,this.enjoy2.Text));
                                         
        }
        void showing(object sender,EventArgs args)
        {
            tw.Show();
        }
        static HttpClient httpClient = new HttpClient();
        swaggerClient client = new swaggerClient("http://localhost:5000/", httpClient);
        TODO tw=new TODO();
    }
}