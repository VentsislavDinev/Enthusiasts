namespace Enthusiasts.Services.Integrations.Voilanorbert.Services.Model
{
    public class SearchName
    {
        public Company company { get; set; }
        public long created { get; set; }
        public Email email { get; set; }
        public int id { get; set; }
        public object[] lists { get; set; }
        public string name { get; set; }
        public Owner owner { get; set; }
        public bool searching { get; set; }
        public string status { get; set; }
    }

    public class Company
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

    public class Email
    {
        public string avatar_url { get; set; }
        public string email { get; set; }
        public bool is_done { get; set; }
        public int score { get; set; }
    }

    public class Owner
    {
        public bool admin { get; set; }
        public string avatar_url { get; set; }
        public string email { get; set; }
        public string firstname { get; set; }
        public string language { get; set; }
        public string name { get; set; }
    }
}
