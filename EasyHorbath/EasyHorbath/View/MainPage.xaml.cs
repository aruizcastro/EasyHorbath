using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EasyHorbath.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //reemplazar la llave de google Maps
            InitializeComponent();
        }

        public void SayHelloButton_OnClicked(object sender,EventArgs e) {
            var name = NameEntry.Text;
            var greeting = "Hola " + name;
            GreetingLabel.Text = greeting;

        }

    }
}
