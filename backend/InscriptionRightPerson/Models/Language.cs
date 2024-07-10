using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InscriptionRightPerson.Models
{
    public class Language
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ?ID { get; set; }
        public  required string langage { get; set; }
        public required string Level { get; set; }
        // Foreign key
        public required int ?PersonID { get; set; }
     //   public required Person Person { get; set; }
    }
}
