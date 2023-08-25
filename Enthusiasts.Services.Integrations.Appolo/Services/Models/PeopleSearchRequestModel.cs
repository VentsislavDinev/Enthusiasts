namespace Enthusiasts.Services.Integrations.Appolo.Services.Models
{
    public class PeopleSearchRequestModel
    {   
        public string api_key { get; set; }
        public string q_organization_domains { get; set; }
        public int page { get; set; }
        public string[] person_titles { get; set; }
    }
}
