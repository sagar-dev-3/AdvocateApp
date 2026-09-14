namespace AdvocateApp.Data
{
    /// <summary>
    /// Central static content store for the Ravindra Prasad Advocate website.
    /// Update this file to change website content without touching HTML files.
    /// </summary>
    public class SiteContent
    {
        public AdvocateProfile Profile { get; } = new AdvocateProfile
        {
            Name = "Y Ravindra Prasad",
            ShortName = "Ravindra Prasad",
            Designation = "High Court Advocate",
            Qualifications = "BA + LLB + LLM + PhD",
            ExperienceYears = 19,
            Since = 2007,
            Mobile = "9949218307",
            MobileWithCountryCode = "+919949218307",
            Email = "ravi1808@hotmail.com",
            WhatsAppUrl = "https://wa.me/919949218307",
            WhatsAppMessage = "Hello Y Ravindra Prasad, I would like to discuss a legal matter.",
            CallUrl = "tel:+919949218307",
            EmailUrl = "mailto:ravi1808@hotmail.com"
        };

        public List<PracticeArea> PracticeAreas { get; } = new()
        {
            new("Civil Litigation", "fa-gavel", "Professional representation in civil disputes including suits, injunctions and civil proceedings before courts."),
            new("Criminal Matters", "fa-scale-balanced", "Experienced legal assistance in criminal cases including bail, trial and defence proceedings."),
            new("High Court Matters", "fa-landmark", "Representation and legal assistance in matters pending before the High Court."),
            new("Constitutional Matters", "fa-book-open", "Legal assistance in constitutional law including fundamental rights and constitutional remedies."),
            new("Property Disputes", "fa-house", "Professional legal guidance in property, real estate and land-related disputes."),
            new("Family & Matrimonial Matters", "fa-people-roof", "Sensitive and professional assistance in matrimonial disputes, divorce and family matters."),
            new("Corporate & Commercial Matters", "fa-briefcase", "Legal counsel for business disputes, contracts and commercial legal matters."),
            new("Writ Petitions", "fa-file-contract", "Preparation and filing of writ petitions including mandamus, certiorari and habeas corpus."),
            new("Appeals & Revisions", "fa-arrows-rotate", "Legal assistance in filing and arguing appeals and revision petitions before courts."),
            new("Legal Consultation", "fa-comments", "Professional legal consultation based on the facts and circumstances of your matter.")
        };

        public List<LegalService> Services { get; } = new()
        {
            new("Legal Consultation", "fa-comments", "Professional legal consultation based on the facts and circumstances of a matter."),
            new("Court Representation", "fa-landmark", "Representation and assistance in legal proceedings before the High Court and subordinate courts."),
            new("Legal Documentation", "fa-file-lines", "Assistance with legal notices, petitions, plaints and other legal documentation."),
            new("Case Strategy", "fa-chess", "Structured legal analysis and strategic guidance based on the specific facts of your matter."),
            new("Appeals & Writ Matters", "fa-arrows-rotate", "Professional assistance relating to appeals, revisions and writ proceedings.")
        };

        public List<WhyChooseItem> WhyChooseItems { get; } = new()
        {
            new("19 Years of Experience", "fa-calendar-check", "Nearly two decades of professional practice across diverse areas of law."),
            new("Strong Legal Knowledge", "fa-book", "Extensive academic qualifications combined with practical courtroom experience."),
            new("Professional Representation", "fa-user-tie", "Diligent and professional representation in every matter."),
            new("Client-Focused Approach", "fa-handshake", "Every client receives attentive, personalised legal assistance."),
            new("Confidential & Ethical Practice", "fa-shield-halved", "Strict adherence to professional ethics and client confidentiality."),
            new("Clear Legal Guidance", "fa-lightbulb", "Plain language explanations of legal processes and options.")
        };
    }

    public record AdvocateProfile
    {
        public string Name { get; init; } = "";
        public string ShortName { get; init; } = "";
        public string Designation { get; init; } = "";
        public string Qualifications { get; init; } = "";
        public int ExperienceYears { get; init; }
        public int Since { get; init; }
        public string Mobile { get; init; } = "";
        public string MobileWithCountryCode { get; init; } = "";
        public string Email { get; init; } = "";
        public string WhatsAppUrl { get; init; } = "";
        public string WhatsAppMessage { get; init; } = "";
        public string CallUrl { get; init; } = "";
        public string EmailUrl { get; init; } = "";
    }

    public record PracticeArea(string Title, string Icon, string Description);
    public record LegalService(string Title, string Icon, string Description);
    public record WhyChooseItem(string Title, string Icon, string Description);
}
