using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vo2webapi
{
    [Table("Movie")]
    public class tblMovies
    {
        [Key]
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int MovieBudget { get; set; }
        public DateTime MovieReleasedDate { get; set; }
        public DateTime MovieCreatedDate { get; set; }
        public string MovieCreatedBy { get; set; }
        public DateTime MovieUpdatedDate { get; set; }
        public string MovieUpdatedBy { get; set; }
    }
}
