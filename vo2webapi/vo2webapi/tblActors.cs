using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vo2webapi
{
    [Table("Actor")]
    public class tblActors
    {
        [Key]
        public int ActorId { get; set; }
        public string ActorFirstName { get; set; }
        public string ActorLastName { get; set; }        
        public DateTime ActorDOB { get; set; }
        public int MovieBudget { get; set; }
        public DateTime ActorCreatedDate { get; set; }
        public string ActorCreatedBy { get; set; }
        public DateTime ActorUpdatedDate { get; set; }
        public string ActorUpdatedBy { get; set; }
    }
}
