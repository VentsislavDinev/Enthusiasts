namespace Enthusiasts.Services.Integrations.Voilanorbert.Services.Model
{
    public class SearchDomain
    {
        public bool has_next { get; set; }
        public SearchDomainResult[] result { get; set; }
        public bool credits_available { get; set; }
        public int total { get; set; }
    }

    public class SearchDomainResult
    {
        public SearchDomainCompany company { get; set; }
        public long created { get; set; }
        public SearchDomainEmail email { get; set; }
        public int id { get; set; }
        public object[] lists { get; set; }
        public string name { get; set; }
        public SearchDomainOwner owner { get; set; }
        public bool is_new { get; set; }
        public bool searching { get; set; }
        public string status { get; set; }
    }

    public class SearchDomainCompany
    {
        public object description { get; set; }
        public bool is_done { get; set; }
        public string[] keywords { get; set; }
        public string logo { get; set; }
        public string name { get; set; }
        public string raw_url { get; set; }
        public string title { get; set; }
        public string url { get; set; }
    }

    public class SearchDomainEmail
    {
        public string avatar_url { get; set; }
        public string email { get; set; }
        public bool is_done { get; set; }
        public int score { get; set; }
    }

    public class SearchDomainOwner
    {
        public bool admin { get; set; }
        public string avatar_url { get; set; }
        public string email { get; set; }
        public string firstname { get; set; }
        public string language { get; set; }
        public string name { get; set; }
    }
}
