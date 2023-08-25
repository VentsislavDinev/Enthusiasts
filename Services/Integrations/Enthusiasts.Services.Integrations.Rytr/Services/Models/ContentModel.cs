namespace Enthusiasts.Services.Integrations.Rytr.Services.Models
{
    public class ContentModel
    {
            public string languageId { get; set; }
            public string toneId { get; set; }
            public string useCaseId { get; set; }
            public Inputcontexts inputContexts { get; set; }
            public int variations { get; set; }
            public string userId { get; set; }
            public string format { get; set; }
            public string creativityLevel { get; set; }
            public string translate { get; set; }
    }

    public class Inputcontexts
    {
        public string USECASECONTEXTINPUTKEYLABEL { get; set; }
    }
}
