using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PetTracker.Views.test_area
{
    public partial class test_1 : ContentPage
    {
        public test_1()
        {
            InitializeComponent();
        }

        void cmd_save_Clicked(object sender,EventArgs e)
        {
            msgbox("cmd_save");
        }
        void cmd_count_Clicked(object sender, EventArgs e)
        {
            msgbox("cmd_count");
        }

        void msgbox(string _text)
        {

            DisplayAlert("app", _text, "Cancel");

        }

    }
}
