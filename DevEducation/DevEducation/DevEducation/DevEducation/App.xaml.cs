using Autofac;
using DevEducation.Container;
using DevEducation.Models;
using DevEducation.RestApiInterfaces;
using DevEducation.Services;
using DevEducation.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DevEducation
{
    public partial class App : Application
    {
        public static IContainer container;
        public App()
        {
            InitializeComponent();

            ContainerBuilder builder = new ContainerBuilder();
            RegisterTypes(builder);
            container = builder.Build();
            MainPage = new NavigationPage(new LoginPage()); // исправила 
        }

        private void RegisterTypes(ContainerBuilder builder) // добавляем сюда в контейнер
        {
            builder.RegisterType<TokenManager>()
                .As<ITokenManager>()
                .SingleInstance();
            builder.Register<UserService>(c => new UserService())
                .As<IUserService>();
        }

        protected override void OnStart()
        {
          
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
