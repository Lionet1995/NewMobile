using Autofac;
using DevEducation.RestApiInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DevEducation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Button1_Clicked(object sender, EventArgs e)
        {
            await App.container.Resolve<IUserService>().Auth(new DTO.LoginDto()
            {
                Password = EntryPassword.Text,
                Login = EntryLogin.Text

            });

            await Navigation.PushAsync(new GroupListPage());
        }
    }
}