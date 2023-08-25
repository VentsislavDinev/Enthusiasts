namespace Enthusiasts.Services.Integrations.ClickUp.Services.Model
{
    public class GenerateTextModel
    {
        public string keywords { get; set; }
        public string keywords2 { get; set; }
        public string text { get; set; }
        public string[] tonality { get; set; }
        public string length { get; set; }
        public string output_type { get; set; }
        public string audience_model_id { get; set; }
        public int n_times { get; set; }
        public int n_text_items { get; set; }
        public int personality_id { get; set; }
    }
}
