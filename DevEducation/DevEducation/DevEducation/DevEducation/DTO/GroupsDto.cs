using System;
using Newtonsoft.Json;

namespace DevEducation.DTO
{
    public class GroupsDto
    {

        [JsonProperty("groupId")] //имя в "" пишется, как в сваггере на бэке
        public int? GroupId { get; set; }

        [JsonProperty("startDate")]
        public DateTimeOffset? StartDate { get; set; }

        [JsonProperty("endDate")]
        public DateTimeOffset? EndDate { get; set; }

        [JsonProperty("timeStartString")]
        public string TimeStartString { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }


    }
}
