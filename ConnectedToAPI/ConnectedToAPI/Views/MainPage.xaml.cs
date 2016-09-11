using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ConnectedToAPI.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewEmployeePage());
        }

        private async void Login_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }
    }
}
