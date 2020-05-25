using Autofac;
using DevEducation.Container;
using DevEducation.DTO;
using DevEducation.Models;
using DevEducation.RestApi;
using DevEducation.RestApiInterfaces;
using Refit;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Services
{
   public class GroupsService : IGroupsService
    {

        private HttpClient _client;
        private IGroupsApi _httpGroupApi;
        private string _token;
        private int userId;
        public GroupsService(string token)
        {
            _token = token;
            _client = new HttpClient
            {
                BaseAddress = new Uri("http://80.78.240.16:5100/")
            };

            _httpGroupApi = RestService.For<IGroupsApi>(_client);
        }

        public Task<List<GroupsDto>> GetAllGroups()
        {
            userId = App.container.Resolve<ITokenManager>().UserId;
            return _httpGroupApi.GetAllGroups(_token, userId); 
        }

        //public Task<GroupsDto> GetGroupById()
        //{
        //    return _httpGroupApi.GetGroupById("1303", /*"Bearer " +*/ App.container.Resolve<ITokenManager>().GroupId);
        //}
    }
}
