namespace Enthusiasts.Services.Integrations.Hunter.Services.Models
{
    public class ListRecipientsCampaignModel
    {
        public RecipientData data { get; set; }
        public Meta meta { get; set; }
    }

    public class RecipientData
    {
        public Recipient[] recipients { get; set; }
    }

    public class Recipient
    {
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string position { get; set; }
        public string company { get; set; }
        public string website { get; set; }
        public string sending_status { get; set; }
        public int lead_id { get; set; }
    }
}
