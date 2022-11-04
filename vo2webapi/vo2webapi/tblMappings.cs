using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vo2webapi
{
    [Table("Mapping")]
    public class tblMappings
    {
        [Key]
        public int MappingId { get; set; }
        public int MovieId { get; set; }
        public int ActorId { get; set; }
    }
}
