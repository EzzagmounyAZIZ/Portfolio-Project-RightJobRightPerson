using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InscriptionRightPerson.Models
{
    public class Experience
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ?ID { get; set; }
        public required string CompanyName { get; set; }
        public required string Position { get; set; }
        public required string Location { get; set; }
        public required string Type { get; set; }
        public required DateOnly StartDate { get; set; }
        public required DateOnly EndDate { get; set; }
        public required string CompanyDescription { get; set; }

        // Foreign key
        public required int ?PersonID { get; set; }
      //  public required Person Person { get; set; }
    }
}
