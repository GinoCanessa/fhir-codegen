// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This example value set defines a set of codes that can be used to indicate a type of organization.
  /// </summary>
  public static class OrganizationTypeCodes
  {
    /// <summary>
    /// An organization that is a registered business or corporation but not identified by other types.
    /// </summary>
    public static readonly Coding NonHealthcareBusinessOrCorporation = new Coding
    {
      Code = "bus",
      Display = "Non-Healthcare Business or Corporation",
      System = "http://terminology.hl7.org/CodeSystem/organization-type"
    };
    /// <summary>
    /// An un-incorporated community group.
    /// </summary>
    public static readonly Coding CommunityGroup = new Coding
    {
      Code = "cg",
      Display = "Community Group",
      System = "http://terminology.hl7.org/CodeSystem/organization-type"
    };
    /// <summary>
    /// An organization that is identified as a Pharmaceutical/Clinical Research Sponsor.
    /// </summary>
    public static readonly Coding ClinicalResearchSponsor = new Coding
    {
      Code = "crs",
      Display = "Clinical Research Sponsor",
      System = "http://terminology.hl7.org/CodeSystem/organization-type"
    };
    /// <summary>
    /// A department or ward within a hospital (Generally is not applicable to top level organizations)
    /// </summary>
    public static readonly Coding HospitalDepartment = new Coding
    {
      Code = "dept",
      Display = "Hospital Department",
      System = "http://terminology.hl7.org/CodeSystem/organization-type"
    };
    /// <summary>
    /// An educational institution that provides education or research facilities.
    /// </summary>
    public static readonly Coding EducationalInstitute = new Coding
    {
      Code = "edu",
      Display = "Educational Institute",
      System = "http://terminology.hl7.org/CodeSystem/organization-type"
    };
    /// <summary>
    /// A political body, often used when including organization records for government bodies such as a Federal Government, State or Local Government.
    /// </summary>
    public static readonly Coding Government = new Coding
    {
      Code = "govt",
      Display = "Government",
      System = "http://terminology.hl7.org/CodeSystem/organization-type"
    };
    /// <summary>
    /// A company that provides insurance to its subscribers that may include healthcare related policies.
    /// </summary>
    public static readonly Coding InsuranceCompany = new Coding
    {
      Code = "ins",
      Display = "Insurance Company",
      System = "http://terminology.hl7.org/CodeSystem/organization-type"
    };
    /// <summary>
    /// Other type of organization not already specified.
    /// </summary>
    public static readonly Coding Other = new Coding
    {
      Code = "other",
      Display = "Other",
      System = "http://terminology.hl7.org/CodeSystem/organization-type"
    };
    /// <summary>
    /// A company, charity, or governmental organization, which processes claims and/or issues payments to providers on behalf of patients or groups of patients.
    /// </summary>
    public static readonly Coding Payer = new Coding
    {
      Code = "pay",
      Display = "Payer",
      System = "http://terminology.hl7.org/CodeSystem/organization-type"
    };
    /// <summary>
    /// An organization that provides healthcare services.
    /// </summary>
    public static readonly Coding HealthcareProvider = new Coding
    {
      Code = "prov",
      Display = "Healthcare Provider",
      System = "http://terminology.hl7.org/CodeSystem/organization-type"
    };
    /// <summary>
    /// An organization that is identified as a part of a religious institution.
    /// </summary>
    public static readonly Coding ReligiousInstitution = new Coding
    {
      Code = "reli",
      Display = "Religious Institution",
      System = "http://terminology.hl7.org/CodeSystem/organization-type"
    };
    /// <summary>
    /// An organizational team is usually a grouping of practitioners that perform a specific function within an organization (which could be a top level organization, or a department).
    /// </summary>
    public static readonly Coding OrganizationalTeam = new Coding
    {
      Code = "team",
      Display = "Organizational team",
      System = "http://terminology.hl7.org/CodeSystem/organization-type"
    };

    /// <summary>
    /// Literal for code: NonHealthcareBusinessOrCorporation
    /// </summary>
    public const string LiteralNonHealthcareBusinessOrCorporation = "bus";

    /// <summary>
    /// Literal for code: OrganizationTypeNonHealthcareBusinessOrCorporation
    /// </summary>
    public const string LiteralOrganizationTypeNonHealthcareBusinessOrCorporation = "http://terminology.hl7.org/CodeSystem/organization-type#bus";

    /// <summary>
    /// Literal for code: CommunityGroup
    /// </summary>
    public const string LiteralCommunityGroup = "cg";

    /// <summary>
    /// Literal for code: OrganizationTypeCommunityGroup
    /// </summary>
    public const string LiteralOrganizationTypeCommunityGroup = "http://terminology.hl7.org/CodeSystem/organization-type#cg";

    /// <summary>
    /// Literal for code: ClinicalResearchSponsor
    /// </summary>
    public const string LiteralClinicalResearchSponsor = "crs";

    /// <summary>
    /// Literal for code: OrganizationTypeClinicalResearchSponsor
    /// </summary>
    public const string LiteralOrganizationTypeClinicalResearchSponsor = "http://terminology.hl7.org/CodeSystem/organization-type#crs";

    /// <summary>
    /// Literal for code: HospitalDepartment
    /// </summary>
    public const string LiteralHospitalDepartment = "dept";

    /// <summary>
    /// Literal for code: OrganizationTypeHospitalDepartment
    /// </summary>
    public const string LiteralOrganizationTypeHospitalDepartment = "http://terminology.hl7.org/CodeSystem/organization-type#dept";

    /// <summary>
    /// Literal for code: EducationalInstitute
    /// </summary>
    public const string LiteralEducationalInstitute = "edu";

    /// <summary>
    /// Literal for code: OrganizationTypeEducationalInstitute
    /// </summary>
    public const string LiteralOrganizationTypeEducationalInstitute = "http://terminology.hl7.org/CodeSystem/organization-type#edu";

    /// <summary>
    /// Literal for code: Government
    /// </summary>
    public const string LiteralGovernment = "govt";

    /// <summary>
    /// Literal for code: OrganizationTypeGovernment
    /// </summary>
    public const string LiteralOrganizationTypeGovernment = "http://terminology.hl7.org/CodeSystem/organization-type#govt";

    /// <summary>
    /// Literal for code: InsuranceCompany
    /// </summary>
    public const string LiteralInsuranceCompany = "ins";

    /// <summary>
    /// Literal for code: OrganizationTypeInsuranceCompany
    /// </summary>
    public const string LiteralOrganizationTypeInsuranceCompany = "http://terminology.hl7.org/CodeSystem/organization-type#ins";

    /// <summary>
    /// Literal for code: Other
    /// </summary>
    public const string LiteralOther = "other";

    /// <summary>
    /// Literal for code: OrganizationTypeOther
    /// </summary>
    public const string LiteralOrganizationTypeOther = "http://terminology.hl7.org/CodeSystem/organization-type#other";

    /// <summary>
    /// Literal for code: Payer
    /// </summary>
    public const string LiteralPayer = "pay";

    /// <summary>
    /// Literal for code: OrganizationTypePayer
    /// </summary>
    public const string LiteralOrganizationTypePayer = "http://terminology.hl7.org/CodeSystem/organization-type#pay";

    /// <summary>
    /// Literal for code: HealthcareProvider
    /// </summary>
    public const string LiteralHealthcareProvider = "prov";

    /// <summary>
    /// Literal for code: OrganizationTypeHealthcareProvider
    /// </summary>
    public const string LiteralOrganizationTypeHealthcareProvider = "http://terminology.hl7.org/CodeSystem/organization-type#prov";

    /// <summary>
    /// Literal for code: ReligiousInstitution
    /// </summary>
    public const string LiteralReligiousInstitution = "reli";

    /// <summary>
    /// Literal for code: OrganizationTypeReligiousInstitution
    /// </summary>
    public const string LiteralOrganizationTypeReligiousInstitution = "http://terminology.hl7.org/CodeSystem/organization-type#reli";

    /// <summary>
    /// Literal for code: OrganizationalTeam
    /// </summary>
    public const string LiteralOrganizationalTeam = "team";

    /// <summary>
    /// Literal for code: OrganizationTypeOrganizationalTeam
    /// </summary>
    public const string LiteralOrganizationTypeOrganizationalTeam = "http://terminology.hl7.org/CodeSystem/organization-type#team";

    /// <summary>
    /// Dictionary for looking up OrganizationType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "bus", NonHealthcareBusinessOrCorporation }, 
      { "http://terminology.hl7.org/CodeSystem/organization-type#bus", NonHealthcareBusinessOrCorporation }, 
      { "cg", CommunityGroup }, 
      { "http://terminology.hl7.org/CodeSystem/organization-type#cg", CommunityGroup }, 
      { "crs", ClinicalResearchSponsor }, 
      { "http://terminology.hl7.org/CodeSystem/organization-type#crs", ClinicalResearchSponsor }, 
      { "dept", HospitalDepartment }, 
      { "http://terminology.hl7.org/CodeSystem/organization-type#dept", HospitalDepartment }, 
      { "edu", EducationalInstitute }, 
      { "http://terminology.hl7.org/CodeSystem/organization-type#edu", EducationalInstitute }, 
      { "govt", Government }, 
      { "http://terminology.hl7.org/CodeSystem/organization-type#govt", Government }, 
      { "ins", InsuranceCompany }, 
      { "http://terminology.hl7.org/CodeSystem/organization-type#ins", InsuranceCompany }, 
      { "other", Other }, 
      { "http://terminology.hl7.org/CodeSystem/organization-type#other", Other }, 
      { "pay", Payer }, 
      { "http://terminology.hl7.org/CodeSystem/organization-type#pay", Payer }, 
      { "prov", HealthcareProvider }, 
      { "http://terminology.hl7.org/CodeSystem/organization-type#prov", HealthcareProvider }, 
      { "reli", ReligiousInstitution }, 
      { "http://terminology.hl7.org/CodeSystem/organization-type#reli", ReligiousInstitution }, 
      { "team", OrganizationalTeam }, 
      { "http://terminology.hl7.org/CodeSystem/organization-type#team", OrganizationalTeam }, 
    };
  };
}
