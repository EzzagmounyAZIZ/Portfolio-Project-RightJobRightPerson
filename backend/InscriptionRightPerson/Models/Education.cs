using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InscriptionRightPerson.Models
{
    public class Education
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ?ID { get; set; }
        public required string InstitutionName { get; set; }
        public required string FieldOfStudy { get; set; }
        public required string Location { get; set; }
        public required string Type { get; set; }
        public required DateOnly StartDate { get; set; }
        public required DateOnly EndDate { get; set; }

        // Foreign key
        public required int ?PersonID { get; set; }
      //  public required Person Person { get; set; }
    }
}
