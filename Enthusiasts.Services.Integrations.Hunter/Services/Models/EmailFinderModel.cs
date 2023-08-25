namespace Enthusiasts.Services.Integrations.Hunter.Services.Models
{
    public class EmailFinderModel
    {

        public EmailFinderData data { get; set; }
        public EmailFinderMeta meta { get; set; }
    }

    public class EmailFinderData
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public int score { get; set; }
        public string domain { get; set; }
        public bool accept_all { get; set; }
        public string position { get; set; }
        public object twitter { get; set; }
        public object linkedin_url { get; set; }
        public object phone_number { get; set; }
        public string company { get; set; }
        public EmailFinderSource[] sources { get; set; }
        public EmailFinderVerification verification { get; set; }
    }

    public class EmailFinderVerification
    {
        public string date { get; set; }
        public string status { get; set; }
    }

    public class EmailFinderSource
    {
        public string domain { get; set; }
        public string uri { get; set; }
        public string extracted_on { get; set; }
        public string last_seen_on { get; set; }
        public bool still_on_page { get; set; }
    }

    public class EmailFinderMeta
    {
        public EmailFinderParams _params { get; set; }
    }

    public class EmailFinderParams
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public object full_name { get; set; }
        public string domain { get; set; }
        public object company { get; set; }
        public object max_duration { get; set; }
    }
}