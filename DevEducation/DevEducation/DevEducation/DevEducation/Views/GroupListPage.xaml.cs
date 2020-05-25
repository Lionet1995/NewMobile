using Autofac;
using DevEducation.Container;
using DevEducation.DTO.Models;
using DevEducation.RestApi;
using DevEducation.RestApiInterfaces;
using DevEducation.Services;
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
    public partial class GroupListPage : ContentPage
    {
        //private ILessonsApi _httpO;
        GroupsService groupsService = new GroupsService(App.container.Resolve<ITokenManager>().GetToken());
        public GroupListPage()
        {
            InitializeComponent();
            BindingContext = new GroupListViewModel(groupsService) { Navigation = this.Navigation };
        }

    }
}