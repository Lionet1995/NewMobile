using DevEducation.DTO;
using DevEducation.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.RestApi
{
    [Headers("Content-Type: application/json")]
    interface IGroupsApi
    {
        [Get("/api/Group/groups-by-teacher-with-course-program/{userId}")]
        Task<List<GroupsDto>> GetAllGroups([Header("Authorization")] string token, int userId); 

        [Get("/api/Group/get/{id}")]
        Task<GroupsDto> GetGroupById(string id, [Header("Authorization")] string token);
    }
}
