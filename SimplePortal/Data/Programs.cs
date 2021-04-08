using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimplePortal.Data
{
    [Table("Programs", Schema ="public")]
    public class Programs

    {
        [Key]
        public int Id { get; set; }
        public string NameP { get; set; }
        public string CreatorName { get; set; }
        public DateTime? DateRelease { get; set; }
        public string About { get; set; }
        public string OS { get; set; }
        public int Price { get; set; }
        public int Creator_id { get; set; }
    }
}
