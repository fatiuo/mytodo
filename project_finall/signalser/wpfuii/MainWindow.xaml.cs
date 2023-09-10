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
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.SignalR.Client;

namespace wpfui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>    public partial class TODO : Window

    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            this.button.Click+=showing;
            this.button2.Click+=showdel;
            this.button3.Click+=showtodo;
            this.button4.Click+=showme;
        }
        void showdel(object sender,EventArgs args)
        {
            d.Show();
        }
        void showtodo(object sender,EventArgs args)
        {
            t.Show();
        }
      void showing(object sender,EventArgs args)
        {
            e.Show();
        }
      void showme(object sender,EventArgs args)
        {
            ae.Show();
        }
        open ae=new open();

        FirstPage t=new FirstPage();
        deletepage d=new deletepage();
        editpage e=new editpage();
    }
}
