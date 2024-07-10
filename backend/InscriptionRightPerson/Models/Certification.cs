using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InscriptionRightPerson.Models
{
    public class Certification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ?ID { get; set; }

        [Required]
        public  string CertificationName { get; set; }

        [Required]
        public  string Organization { get; set; }

        [Required]
        public DateOnly DateOfCompletion { get; set; }

        public int ?PersonID { get; set; }
      //  public Person Person { get; set; }
    }
}
