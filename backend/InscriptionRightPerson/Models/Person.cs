using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InscriptionRightPerson.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ?ID { get; set; }

        [Required]
        public  string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public  string MailAddress { get; set; }

        [Required]
        public  string PhoneNumber { get; set; }

        [Required]
        public  string LinkedIn { get; set; }

        [Required]
        public  string Image { get; set; }

        [Required]
        public  string Address { get; set; }

        [Required]
        public  string Country { get; set; }

        [Required]
        public  string City { get; set; }

        [Required]
        public  string Website { get; set; }

        [Required]
        public  string TargetTitle { get; set; }

        [Required]
        public  string ProfessionalSummary { get; set; }

        [Required]
        public  string Password { get; set; }

        [Required]
        public  DateTime LastConnection { get; set; }

        // Navigation properties for relationships
       
        public  List<Certification> Certifications
        {
            get; set;
        } = new List<Certification>();

        public  List<Education> Educations
        {
            get; set;
        } = new List<Education>();


        
        public  List<Experience> Experiences
        {
            get; set;
        } = new List<Experience>();


       
        public  List<Language> Languages
        {
            get; set;
        } = new List<Language>();

      
        public  List<Skill> Skills
        {
            get; set;
        } = new List<Skill>();

      
        public  List<Interest_Hobbie> Interest_Hobbies
        {
            get; set;
        } = new List<Interest_Hobbie>();

    }
}
