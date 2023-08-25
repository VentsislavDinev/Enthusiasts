namespace Enthusiasts.Services.Integration.Coresignal.Services.Models
{
    public class CompanyRequestModel
    {
        public string name { get; set; }
        public string website { get; set; }
        public string exact_website { get; set; }
        public string size { get; set; }
        public string industry { get; set; }
        public string country { get; set; }
        public string created_at_gte { get; set; }
        public string created_at_lte { get; set; }
        public string last_updated_gte { get; set; }
        public string last_updated_lte { get; set; }
        public int employees_count_gte { get; set; }
        public int employees_count_lte { get; set; }
        public int source_id { get; set; }
        public int founded_year_gte { get; set; }
        public int founded_year_lte { get; set; }
        public int funding_total_rounds_count_gte { get; set; }
        public int funding_total_rounds_count_lte { get; set; }
        public string funding_last_round_type { get; set; }
        public string funding_last_round_date_gte { get; set; }
        public string funding_last_round_date_lte { get; set; }
    }
}
