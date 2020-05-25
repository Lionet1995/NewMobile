using DevEducation.DTO;
using DevEducation.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.RestApiInterfaces
{
    interface IGroupsService
    {
        Task<List<GroupsDto>> GetAllGroups();
        //Task<GroupsDto> GetGroupById();
        
    }
}
