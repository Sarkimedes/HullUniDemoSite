using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HullUniDemoSite.Models
{
    public class Score
    {
        [Key]
        public int Id { get; set; }

        public string PlayerName { get; set; }

        public int Moves { get; set;  }
    }
}