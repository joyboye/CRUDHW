using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDHW.Data
{
    public class Manufacturers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ManuID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLocation { get; set; }

        public int CarID { get; set; }
        [ForeignKey("CarID")]
        public Cars Car { get; set; }
    }
}
