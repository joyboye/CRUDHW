using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDHW.Data
{
    public class Cars
    {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int CarID{ get; set; }
        public string CarBrand { get; set; }
        public int Model{ get; set; }
        public double Caryear { get; set; }
        public string color { get; set; }
        


    }
}
