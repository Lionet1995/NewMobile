using Autofac;
using DevEducation.RestApiInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DevEducation
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //private async void Button_Clicked(object sender, EventArgs e)  //закомментила, такой же метод засунула в LoginPage
        //{
        //    await App.container.Resolve<IUserService>().Auth(new DTO.LoginDto()
        //    {
        //        Password = "123",
        //        Login = "TestYourLuck"

        //    });
        //}
    }
}
