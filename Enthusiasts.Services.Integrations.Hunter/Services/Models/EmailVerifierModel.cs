namespace Enthusiasts.Services.Integrations.Hunter.Services.Models
{
    public class EmailVerifierModel
    {
        public EmailVerifierData data { get; set; }
        public EmailVerifierMeta meta { get; set; }

    }
}

public class EmailVerifierData
{
    public string status { get; set; }
    public string result { get; set; }
    public string _deprecation_notice { get; set; }
    public int score { get; set; }
    public string email { get; set; }
    public bool regexp { get; set; }
    public bool gibberish { get; set; }
    public bool disposable { get; set; }
    public bool webmail { get; set; }
    public bool mx_records { get; set; }
    public bool smtp_server { get; set; }
    public bool smtp_check { get; set; }
    public bool accept_all { get; set; }
    public bool block { get; set; }
    public EmailVerifierSource[] sources { get; set; }
}

public class EmailVerifierSource
{
    public string domain { get; set; }
    public string uri { get; set; }
    public string extracted_on { get; set; }
    public string last_seen_on { get; set; }
    public bool still_on_page { get; set; }
}

public class EmailVerifierMeta
{
    public EmailVerifierParams _params { get; set; }
}

public class EmailVerifierParams
{
    public string email { get; set; }
}
