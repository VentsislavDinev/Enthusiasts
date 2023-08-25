namespace Enthusiasts.Services.Integrations.Appolo.Services.Models
{
    public class PeopleEnrichResponseModel
    {
        public string status { get; set; }
        public object error_code { get; set; }
        public object error_message { get; set; }
        public int total_requested_enrichments { get; set; }
        public int unique_enriched_records { get; set; }
        public int missing_records { get; set; }
        public float credits_consumed { get; set; }
        public Match[] matches { get; set; }
        public string[] personal_emails { get; set; }
        public string[] departments { get; set; }
        public string[] subdepartments { get; set; }
        public string[] functions { get; set; }
        public string seniority { get; set; }
    }

    public class Match
    {
        public bool revealed_for_current_team { get; set; }
        public string email { get; set; }
        public string email_status { get; set; }
        public string id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string name { get; set; }
        public string linkedin_url { get; set; }
        public string title { get; set; }
        public string photo_url { get; set; }
        public string twitter_url { get; set; }
        public object github_url { get; set; }
        public object facebook_url { get; set; }
        public object extrapolated_email_confidence { get; set; }
        public string headline { get; set; }
        public string organization_id { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public OrganizationEnrich organization { get; set; }
        public string account_id { get; set; }
        public Account account { get; set; }
        public Phone_Numbers[] phone_numbers { get; set; }
    }

    public class OrganizationEnrich
    {
        public string id { get; set; }
        public string name { get; set; }
        public string website_url { get; set; }
        public object blog_url { get; set; }
        public object angellist_url { get; set; }
        public string linkedin_url { get; set; }
        public string twitter_url { get; set; }
        public string facebook_url { get; set; }
        public Primary_PhoneEnrich primary_phone { get; set; }
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
        public string industry { get; set; }
        public string[] keywords { get; set; }
        public int estimated_num_employees { get; set; }
        public bool snippets_loaded { get; set; }
        public string industry_tag_id { get; set; }
        public int retail_location_count { get; set; }
        public string raw_address { get; set; }
        public string street_address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postal_code { get; set; }
        public string country { get; set; }
    }

    public class Primary_PhoneEnrich
    {
        public string number { get; set; }
        public string source { get; set; }
    }

    public class Persona_CountsEnrich
    {
    }

    public class AccountEnrich
    {
        public string id { get; set; }
        public string name { get; set; }
        public string website_url { get; set; }
        public object blog_url { get; set; }
        public object angellist_url { get; set; }
        public string linkedin_url { get; set; }
        public string twitter_url { get; set; }
        public string facebook_url { get; set; }
        public Primary_PhoneEnrich primary_phone { get; set; }
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
        public Persona_CountsEnrich persona_counts { get; set; }
        public string domain { get; set; }
        public string team_id { get; set; }
        public string organization_id { get; set; }
        public string account_stage_id { get; set; }
        public string source { get; set; }
        public string original_source { get; set; }
        public string owner_id { get; set; }
        public DateTime created_at { get; set; }
        public string phone_status { get; set; }
        public object test_predictive_score { get; set; }
        public object hubspot_id { get; set; }
        public object salesforce_id { get; set; }
        public object crm_owner_id { get; set; }
        public object parent_account_id { get; set; }
        public string sanitized_phone { get; set; }
        public Account_Playbook_StatusesEnrich[] account_playbook_statuses { get; set; }
        public string existence_level { get; set; }
        public object[] label_ids { get; set; }
        public Typed_Custom_FieldsEnrich typed_custom_fields { get; set; }
        public string modality { get; set; }
    }

    public class Typed_Custom_FieldsEnrich
    {
        public string _618438b906b01300da086546 { get; set; }
    }

    public class Account_Playbook_StatusesEnrich
    {
        public string _id { get; set; }
        public string added_by_id { get; set; }
        public DateTime added_on { get; set; }
        public string[] completed_step_ids { get; set; }
        public object created_at { get; set; }
        public string current_step_id { get; set; }
        public string finished_reason_cd { get; set; }
        public object paused_reason_cd { get; set; }
        public string playbook_id { get; set; }
        public int position { get; set; }
        public string status_cd { get; set; }
        public object updated_at { get; set; }
        public string id { get; set; }
        public string key { get; set; }
    }

    public class Phone_Numbers
    {
        public string raw_number { get; set; }
        public string sanitized_number { get; set; }
        public string type { get; set; }
        public int position { get; set; }
        public string status { get; set; }
    }

}
