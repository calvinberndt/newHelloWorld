using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (lblDisplay.Text == "Hello World")
            {
                lblDisplay.Text = "Close Application";
            }

            else
            {
                lblDisplay.Text = "Hello World";
            }
        }
    }

}
