using Autofac;
using DevEducation.Adapters;
using DevEducation.Container;
using DevEducation.DTO.Models;
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

namespace DevEducation.ViewModels
{
   public class LessonListViewModel : INotifyPropertyChanged
    {
        
        public ICommand CreateLessonCommand { protected set; get; }
        public ICommand SaveLessonCommand { protected set; get; }
        public ICommand LoadLessonsCommand { protected set; get; }
        public ObservableCollection<LessonViewModel> Lessons { get; set; }

        public readonly LessonsService _service;
        public INavigation Navigation { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public int _groupId;

        LessonViewModel selectedLesson;

        public LessonListViewModel(LessonsService service, int groupId)
        {
            _groupId = groupId;
            _service = service;
            Lessons = new ObservableCollection<LessonViewModel>();
            GetAllLessonsByGroup();
            LoadLessonsCommand = new Command(async () => await GetAllLessonsByGroup());
            CreateLessonCommand = new Command(CreateLesson);
            SaveLessonCommand = new Command(SaveLesson);
        }

        public LessonViewModel SelectedLesson
        {
            get { return selectedLesson; }
            set
            {
                if (selectedLesson != value)
                {
                    LessonViewModel tempLesson = value;
                    selectedLesson = null;
                    OnPropertyChanged("selectedLesson");
                    Navigation.PushAsync(new LessonPage(tempLesson));
                }
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        private void CreateLesson()
        {
            Navigation.PushAsync(new LessonPage(new LessonViewModel() { ListViewModel = this }));
        }

        private void SaveLesson(object lessonObject)
        {
            LessonViewModel lesson = lessonObject as LessonViewModel;
            if (lesson != null && lesson.IsValid)
            {
                Lessons.Add(lesson);
            }
            Back();
        }

        private void Back()
        {
            Navigation.PopAsync();
        }

        private async Task GetAllLessonsByGroup()
        {
            var lessons = await _service.GetAllLessonsByGroup(_groupId.ToString());
            Lessons.Clear();
            lessons.ForEach(lesson =>
            {
                Lessons.Add(new LessonViewModel() { Lesson = lesson });
            });
        }
    }
}
