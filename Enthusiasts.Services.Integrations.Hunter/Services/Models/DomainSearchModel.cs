namespace Enthusiasts.Services.Integrations.Hunter.Services.Models
{
    public class DomainSearchModel
    {

        public DataDoamainSearch data { get; set; }
        public MetaDomainSearch meta { get; set; }
    }

    public class DataDoamainSearch
    {
        public string domain { get; set; }
        public bool disposable { get; set; }
        public bool webmail { get; set; }
        public bool accept_all { get; set; }
        public string pattern { get; set; }
        public string organization { get; set; }
        public object description { get; set; }
        public string industry { get; set; }
        public object twitter { get; set; }
        public object facebook { get; set; }
        public object linkedin { get; set; }
        public object instagram { get; set; }
        public object youtube { get; set; }
        public string[] technologies { get; set; }
        public object country { get; set; }
        public object state { get; set; }
        public object city { get; set; }
        public object postal_code { get; set; }
        public object street { get; set; }
        public Email[] emails { get; set; }
        public object[] linked_domains { get; set; }
    }

    public class Email
    {
        public string value { get; set; }
        public string type { get; set; }
        public int confidence { get; set; }
        public Source[] sources { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string position { get; set; }
        public string seniority { get; set; }
        public string department { get; set; }
        public object linkedin { get; set; }
        public string twitter { get; set; }
        public object phone_number { get; set; }
        public Verification verification { get; set; }
    }

    public class Verification
    {
        public string date { get; set; }
        public string status { get; set; }
    }

    public class Source
    {
        public string domain { get; set; }
        public string uri { get; set; }
        public string extracted_on { get; set; }
        public string last_seen_on { get; set; }
        public bool still_on_page { get; set; }
    }

}

public class MetaDomainSearch
{
    public int results { get; set; }
    public int limit { get; set; }
    public int offset { get; set; }
    public Params _params { get; set; }
}

public class Params
{
    public string domain { get; set; }
    public object company { get; set; }
    public object type { get; set; }
    public object seniority { get; set; }
    public object department { get; set; }
}