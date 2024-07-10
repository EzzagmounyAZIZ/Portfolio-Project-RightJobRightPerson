using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Person
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

    public List<Certification> Certifications
    {
        get; set;
    } = new List<Certification>();

    public List<Education> Educations
    {
        get; set;
    } = new List<Education>();



    public List<Experience> Experiences
    {
        get; set;
    } = new List<Experience>();



    public List<Language> Languages
    {
        get; set;
    } = new List<Language>();


    public List<Skill> Skills
    {
        get; set;
    } = new List<Skill>();


    public List<Interest_Hobbie> Interest_Hobbies
    {
        get; set;
    } = new List<Interest_Hobbie>();

}

public class Certification
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

    public class Education
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

public class Experience
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

public class Language
{
    public int? ID { get; set; }
    public required string langage { get; set; }
    public required string Level { get; set; }
    // Foreign key
    public required int? PersonID { get; set; }
}

public class Skill
{
    public int? ID { get; set; }
    public string skill { get; set; }

    // Foreign key
    public int? PersonID { get; set; }
}

public class Interest_Hobbie
{
    public int? ID { get; set; }
    public required string interestAndHobbie { get; set; }


    // Foreign key
    public required int? PersonID { get; set; }
}
