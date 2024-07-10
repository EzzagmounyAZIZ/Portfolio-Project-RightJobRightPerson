using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InscriptionRightPerson.Models
{
    public class Skill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  int ?ID { get; set; }
        public   string skill { get; set; }

        // Foreign key
        public int ?PersonID { get; set; }
      //  public Person Person { get; set; }
    }
}
