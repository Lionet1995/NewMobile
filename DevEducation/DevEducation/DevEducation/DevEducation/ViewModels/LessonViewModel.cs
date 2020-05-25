using DevEducation.DTO;
using DevEducation.DTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DevEducation.ViewModels
{
   public class LessonViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        LessonListViewModel lvm;

        public LessonsDto Lesson { get; set; }

        public LessonViewModel()
        {
            Lesson = new LessonsDto();
        }

        public LessonListViewModel ListViewModel
        {
            get { return lvm; }
            set
            {
                if (lvm != value)
                {
                    lvm = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }

        public string Date
        {
            get { return Lesson.Date; }

            set
            {
                if (Lesson.Date != value)
                {
                    Lesson.Date = value;
                    OnPropertyChanged("Date");

                }
            }
        }

        public string Hometask
        {
            get { return Lesson.Hometask; }

            set
            {
                if (Lesson.Hometask != value)
                {
                    Lesson.Hometask = value;
                    OnPropertyChanged("Hometask");

                }
            }
        }

        public string Videos
        {
            get { return Lesson.Videos; }

            set
            {
                if (Lesson.Videos != value)
                {
                    Lesson.Videos = value;
                    OnPropertyChanged("Videos");

                }
            }
        }

        public string ToRead
        {
            get { return Lesson.ToRead; }

            set
            {
                if (Lesson.ToRead != value)
                {
                    Lesson.ToRead = value;
                    OnPropertyChanged("ToRead");

                }
            }
        }

        public bool IsValid
        {
            get
            {
                return ((!string.IsNullOrEmpty(Hometask.Trim())) ||
                    (!string.IsNullOrEmpty(Videos.Trim())) ||
                    (!string.IsNullOrEmpty(ToRead.Trim())));


            }
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
