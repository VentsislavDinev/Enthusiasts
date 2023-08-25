namespace Enthusiasts.Services.Integration.Coresignal.Services.Models
{
    public class CompanyResponseModel
    {
        public int id { get; set; }
        public string url { get; set; }
        public string hash { get; set; }
        public string name { get; set; }
        public string website { get; set; }
        public string size { get; set; }
        public string industry { get; set; }
        public string description { get; set; }
        public int followers { get; set; }
        public int founded { get; set; }
        public object headquarters_city { get; set; }
        public object headquarters_country { get; set; }
        public object headquarters_state { get; set; }
        public object headquarters_street1 { get; set; }
        public object headquarters_street2 { get; set; }
        public object headquarters_zip { get; set; }
        public string logo_url { get; set; }
        public string created { get; set; }
        public string last_updated { get; set; }
        public int last_response_code { get; set; }
        public string type { get; set; }
        public object headquarters_new_address { get; set; }
        public object employees_count { get; set; }
        public object headquarters_country_restored { get; set; }
        public string headquarters_country_parsed { get; set; }
        public string company_shorthand_name { get; set; }
        public string company_shorthand_name_hash { get; set; }
        public string canonical_url { get; set; }
        public string canonical_hash { get; set; }
        public string canonical_shorthand_name { get; set; }
        public string canonical_shorthand_name_hash { get; set; }
        public int deleted { get; set; }
        public int last_updated_ux { get; set; }
        public int source_id { get; set; }
        public object[] company_affiliated_collection { get; set; }
        public Company_Also_Viewed_Collection[] company_also_viewed_collection { get; set; }
        public object[] company_crunchbase_info_collection { get; set; }
        public object[] company_featured_employees_collection { get; set; }
        public object[] company_featured_investors_collection { get; set; }
        public object[] company_funding_rounds_collection { get; set; }
        public object[] company_locations_collection { get; set; }
        public object[] company_similar_collection { get; set; }
        public Company_Specialties_Collection[] company_specialties_collection { get; set; }
        public object[] company_stock_info_collection { get; set; }
        public object[] company_updates_collection { get; set; }
    }

    public class Company_Also_Viewed_Collection
    {
        public int id { get; set; }
        public int company_id { get; set; }
        public string viewed_company_url { get; set; }
        public object viewed_company_id { get; set; }
        public string created { get; set; }
        public string last_updated { get; set; }
        public int deleted { get; set; }
    }

    public class Company_Specialties_Collection
    {
        public int id { get; set; }
        public int company_id { get; set; }
        public string specialty { get; set; }
        public string created { get; set; }
        public string last_updated { get; set; }
        public int deleted { get; set; }
    }

}
