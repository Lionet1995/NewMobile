using DevEducation.DTO;
using DevEducation.DTO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducation.Adapters
{
   public class GroupModelAdapter
    {
        public static GroupModel Convert(GroupsDto inputDto)
        {
            var outputDto = new GroupModel();
            outputDto.GroupId = inputDto.GroupId.HasValue ? inputDto.GroupId.Value : 0;
            outputDto.StartDate = inputDto.StartDate.HasValue ? inputDto.StartDate.Value.ToString("dd/mm/yyyy") : default;
            outputDto.EndDate = inputDto.EndDate.HasValue ? inputDto.EndDate.Value.ToString("dd/mm/yyyy") : default;
            outputDto.TimeStartString = inputDto.TimeStartString;
            outputDto.Title = inputDto.Title;
            return outputDto;

        }
    }
}
