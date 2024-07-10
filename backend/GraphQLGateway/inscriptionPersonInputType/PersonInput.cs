using System.ComponentModel.DataAnnotations;

namespace GraphQLGateway.inscriptionPersonInputType
{
    public class PersonInput
    {
        public int? ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string LinkedIn { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Website { get; set; }
        public string TargetTitle { get; set; }
        public string ProfessionalSummary { get; set; }
        public string Password { get; set; }
        public DateTime LastConnection { get; set; }

        public List<CertificationInput> Certifications
        {
            get; set;
        } = new List<CertificationInput>();

        public List<EducationInput> Educations
        {
            get; set;
        } = new List<EducationInput>();



        public List<ExperienceInput> Experiences
        {
            get; set;
        } = new List<ExperienceInput>();



        public List<LanguageInput> Languages
        {
            get; set;
        } = new List<LanguageInput>();


        public List<SkillInput> Skills
        {
            get; set;
        } = new List<SkillInput>();


        public List<Interest_HobbieInput> Interest_Hobbies
        {
            get; set;
        } = new List<Interest_HobbieInput>();
    }

}








/**/



public class CertificationInput
{
    public int? ID { get; set; }

    [Required]
    public string CertificationName { get; set; }

    [Required]
    public string Organization { get; set; }

    [Required]
    public DateOnly DateOfCompletion { get; set; }

    public int? PersonID { get; set; }
}

public class EducationInput
{
    public int? ID { get; set; }
    public required string InstitutionName { get; set; }
    public required string FieldOfStudy { get; set; }
    public required string Location { get; set; }
    public required string Type { get; set; }
    public required DateOnly StartDate { get; set; }
    public required DateOnly EndDate { get; set; }

    // Foreign key
    public required int? PersonID { get; set; }
}

public class ExperienceInput
{
    public int? ID { get; set; }
    public required string CompanyName { get; set; }
    public required string Position { get; set; }
    public required string Location { get; set; }
    public required string Type { get; set; }
    public required DateOnly StartDate { get; set; }
    public required DateOnly EndDate { get; set; }
    public required string CompanyDescription { get; set; }

    // Foreign key
    public required int? PersonID { get; set; }
}

public class LanguageInput
{
    public int? ID { get; set; }
    public required string langage { get; set; }
    public required string Level { get; set; }
    // Foreign key
    public required int? PersonID { get; set; }
}

public class SkillInput
{
    public int? ID { get; set; }
    public string skill { get; set; }

    // Foreign key
    public int? PersonID { get; set; }
}

public class Interest_HobbieInput
{
    public int? ID { get; set; }
    public required string interestAndHobbie { get; set; }


    // Foreign key
    public required int? PersonID { get; set; }
}
