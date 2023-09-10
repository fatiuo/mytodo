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
     public partial class add : Window
    {
        public bool iscomp{get;set;}
        public add()
        {
            InitializeComponent();
            this.button.Click+=ClickBotten;
            this.CALen.Click+=CALend;

        }
        void ClickBotten(object sender,EventArgs args)
        {
            if(this.iscompleted.Text=="yes")
                iscomp=true;
            else
                iscomp=false;

            client.CreatToDoAsync((new TODo(this.title.Text,this.detail.Text,DateTime.Now,DateTime.Now.AddDays(int.Parse(this.dayhave.Text)),this.iscomp,int.Parse(this.id.Text))));

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
        static HttpClient httpClient = new HttpClient();
        swaggerClient client = new swaggerClient("http://localhost:5000/", httpClient);


    }
}
