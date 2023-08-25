namespace Enthusiasts.Services.Integrations.Appolo.Services.Models
{
    public class PeopleSearchResponseModel
    {
        public Breadcrumb[] breadcrumbs { get; set; }
        public bool partial_results_only { get; set; }
        public int partial_results_limit { get; set; }
        public Pagination pagination { get; set; }
        public object[] contacts { get; set; }
        public Person[] people { get; set; }
    }

    public class Pagination
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total_entries { get; set; }
        public int total_pages { get; set; }
    }

    public class Breadcrumb
    {
        public string label { get; set; }
        public string signal_field_name { get; set; }
        public object value { get; set; }
        public string display_name { get; set; }
    }

    public class Person
    {
        public string id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string name { get; set; }
        public string linkedin_url { get; set; }
        public string title { get; set; }
        public string email_status { get; set; }
        public string photo_url { get; set; }
        public object twitter_url { get; set; }
        public object github_url { get; set; }
        public object facebook_url { get; set; }
        public object extrapolated_email_confidence { get; set; }
        public string headline { get; set; }
        public string email { get; set; }
        public Employment_History[] employment_history { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string organization_id { get; set; }
        public Organization organization { get; set; }
        public string account_id { get; set; }
        public Account account { get; set; }
        public string[] departments { get; set; }
        public string[] subdepartments { get; set; }
        public string[] functions { get; set; }
        public string seniority { get; set; }
    }

    public class Organization
    {
        public string id { get; set; }
        public string name { get; set; }
        public string website_url { get; set; }
        public object blog_url { get; set; }
        public object angellist_url { get; set; }
        public string linkedin_url { get; set; }
        public string twitter_url { get; set; }
        public string facebook_url { get; set; }
        public Primary_Phone primary_phone { get; set; }
        public object[] languages { get; set; }
        public int alexa_ranking { get; set; }
        public string phone { get; set; }
        public string linkedin_uid { get; set; }
        public int founded_year { get; set; }
        public object publicly_traded_symbol { get; set; }
        public object publicly_traded_exchange { get; set; }
        public string logo_url { get; set; }
        public object crunchbase_url { get; set; }
        public string primary_domain { get; set; }
        public Persona_Counts persona_counts { get; set; }
    }

    public class Primary_Phone
    {
        public string number { get; set; }
        public string source { get; set; }
    }

    public class Persona_Counts
    {
    }

    public class Account
    {
        public string id { get; set; }
        public string name { get; set; }
        public string website_url { get; set; }
        public object blog_url { get; set; }
        public object angellist_url { get; set; }
        public string linkedin_url { get; set; }
        public string twitter_url { get; set; }
        public string facebook_url { get; set; }
        public Primary_Phone1 primary_phone { get; set; }
        public object[] languages { get; set; }
        public int alexa_ranking { get; set; }
        public string phone { get; set; }
        public string linkedin_uid { get; set; }
        public int founded_year { get; set; }
        public object publicly_traded_symbol { get; set; }
        public object publicly_traded_exchange { get; set; }
        public string logo_url { get; set; }
        public object crunchbase_url { get; set; }
        public string primary_domain { get; set; }
        public Persona_Counts1 persona_counts { get; set; }
        public string domain { get; set; }
        public string team_id { get; set; }
        public string organization_id { get; set; }
        public string account_stage_id { get; set; }
        public string source { get; set; }
        public string original_source { get; set; }
        public object owner_id { get; set; }
        public DateTime created_at { get; set; }
        public string phone_status { get; set; }
        public object test_predictive_score { get; set; }
        public string hubspot_id { get; set; }
        public object salesforce_id { get; set; }
        public string crm_owner_id { get; set; }
        public object parent_account_id { get; set; }
        public string sanitized_phone { get; set; }
        public object[] account_playbook_statuses { get; set; }
        public string existence_level { get; set; }
        public object[] label_ids { get; set; }
        public Typed_Custom_Fields typed_custom_fields { get; set; }
        public string modality { get; set; }
        public string hubspot_record_url { get; set; }
        public string salesloft_id { get; set; }
        public string salesloft_url { get; set; }
    }

    public class Primary_Phone1
    {
        public string number { get; set; }
        public string source { get; set; }
    }

    public class Persona_Counts1
    {
    }

    public class Typed_Custom_Fields
    {
    }

    public class Employment_History
    {
        public string _id { get; set; }
        public DateTime created_at { get; set; }
        public bool current { get; set; }
        public object degree { get; set; }
        public object description { get; set; }
        public object emails { get; set; }
        public string end_date { get; set; }
        public object grade_level { get; set; }
        public object kind { get; set; }
        public object major { get; set; }
        public string organization_id { get; set; }
        public string organization_name { get; set; }
        public object raw_address { get; set; }
        public string start_date { get; set; }
        public string title { get; set; }
        public DateTime updated_at { get; set; }
        public string id { get; set; }
        public string key { get; set; }
    }

}
