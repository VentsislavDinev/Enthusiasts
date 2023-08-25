namespace Enthusiasts.Services.Integrations.ClickUp.Services.Model
{
    public class ResponseGenerateTextModel
    {
        public bool status { get; set; }
        public int statusCode { get; set; }
        public ResponseGenerateTextData data { get; set; }
    }

    public class ResponseGenerateTextData
    {
        public string words_renewal_date { get; set; }
        public int words_available { get; set; }
        public int words_limit { get; set; }
        public bool is_unlimited { get; set; }
        public int words_used_current_period { get; set; }
        public int bonus_words_available { get; set; }
        public int n_tokens_used { get; set; }
        public int n_tokens_shown { get; set; }
        public int n_tokens_input { get; set; }
        public int n_words_used { get; set; }
        public int n_words_shown { get; set; }
        public int n_words_input { get; set; }
        public ResponseGenerateTextOutput[] outputs { get; set; }
    }
    public class ResponseGenerateTextOutput
    {
        public string text_item_id { get; set; }
        public long generation_id { get; set; }
        public string text { get; set; }
    }
}
