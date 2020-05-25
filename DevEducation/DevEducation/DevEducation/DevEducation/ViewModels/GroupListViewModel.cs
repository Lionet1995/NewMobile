using DevEducation.Adapters;
using DevEducation.RestApi;
using DevEducation.RestApiInterfaces;
using DevEducation.Services;
using DevEducation.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DevEducation.DTO.Models
{
  public class GroupListViewModel 
    {
        public ObservableCollection<GroupModel> Groups { get; set; }

        public readonly GroupsService _service;

        GroupModel selectedGroup;
        public ICommand LoadGroupsCommand { protected set; get; }

        public INavigation Navigation { get; set; }

        public GroupListViewModel(GroupsService service)
        {
            _service = service;
            Groups = new ObservableCollection<GroupModel>();
            GetAllLoadGroups();
            LoadGroupsCommand = new Command(async () =>  await GetAllLoadGroups());
        }

        public GroupModel SelectedGroup
        {
            get { return selectedGroup; }
            set
            {
                if(selectedGroup != value)
                {
                    GroupModel temp = value;
                    selectedGroup = null;
                    Navigation.PushAsync(new LessonListPage(temp));
                }
            }
        }

        private async Task GetAllLoadGroups()
        {
            var groups = await _service.GetAllGroups();
            Groups.Clear();
            groups.ForEach(group =>
            {
                var g = GroupModelAdapter.Convert(group);
                Groups.Add(g);
            });
        }

    }
}
