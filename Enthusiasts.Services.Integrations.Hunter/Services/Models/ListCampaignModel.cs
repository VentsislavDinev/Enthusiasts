namespace Enthusiasts.Services.Integrations.Hunter.Services.Models
{
    public class ListCampaignModel
    {
            public ListCampaign data { get; set; }
            public Meta meta { get; set; }
    }

    public class ListCampaign
    {
        public Campaign[] campaigns { get; set; }
    }


    public class Campaign
    {
        public int id { get; set; }
        public string name { get; set; }
        public int recipients_count { get; set; }
        public bool editable { get; set; }
        public bool started { get; set; }
        public bool archived { get; set; }
        public bool paused { get; set; }
    }

    public class Meta
    {
        public int limit { get; set; }
        public int offset { get; set; }
    }
}
