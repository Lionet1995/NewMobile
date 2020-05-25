using Autofac;
using DevEducation.Container;
using DevEducation.DTO;
using DevEducation.RestApi;
using DevEducation.RestApiInterfaces;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.Services
{
   public class LessonsService : ILessonsService
    {
        private HttpClient _client;
        private ILessonsApi _httpLessonApi;
        private string _token;
        public LessonsService(string token)
        {
            _token = token ?? throw new ArgumentNullException(nameof(token));
            _client = new HttpClient
            {
                BaseAddress = new Uri("http://80.78.240.16:5100/")
            };

            _httpLessonApi = RestService.For<ILessonsApi>(_client);
        }

        public Task<List<LessonsDto>> GetAllLessonsByGroup(string groupId)
        {

            return _httpLessonApi.GetAllLessonsByGroup(_token, groupId);
        }

    }
}
