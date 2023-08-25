namespace Enthusiasts.Services.Integrations.Appolo.Services.Models
{
    public class PeopleEnrichRequestModel
    {
        public string api_key { get; set; }
        public bool reveal_personal_emails { get; set; }
        public Detail[] details { get; set; }
    }
    public class Detail
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string domain { get; set; }
        public string email { get; set; }
        public string hashed_email { get; set; }
        public string organization_name { get; set; }
    }
}
