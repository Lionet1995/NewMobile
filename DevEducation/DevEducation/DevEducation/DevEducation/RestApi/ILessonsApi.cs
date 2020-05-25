using DevEducation.DTO;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevEducation.RestApi
{
    [Headers("Content-Type: application/json")]
    interface ILessonsApi
    {
        [Get("/api/Lesson")]
        Task CreateLesson([Header("Authorization")] string token);

        [Get("/api/Lesson/get-lesson-by-group/{id}")]
        Task<List<LessonsDto>> GetAllLessonsByGroup([Header("Authorization")] string token, string id);
    }
}
