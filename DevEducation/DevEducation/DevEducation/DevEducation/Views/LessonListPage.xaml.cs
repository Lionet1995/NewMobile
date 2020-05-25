using Autofac;
using DevEducation.Container;
using DevEducation.DTO.Models;
using DevEducation.Services;
using DevEducation.ViewModels;
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
    public partial class LessonListPage : ContentPage
    {
        LessonsService lessonsService = new LessonsService(App.container.Resolve<ITokenManager>().GetToken());
        int groupId;
        public LessonListPage(GroupModel group)
        {
            groupId = (int)group.GroupId;
            InitializeComponent();
            BindingContext = new LessonListViewModel(lessonsService, groupId) { Navigation = this.Navigation };
            Title = group.Title;
        }
    }
}