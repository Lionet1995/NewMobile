using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducation.DTO.Models
{
   public class GroupModel
    {
        public int? GroupId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string TimeStartString { get; set; }
        public string Title { get; set; }
    }
}
