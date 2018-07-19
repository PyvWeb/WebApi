using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BsWebpub.Entity
{
    [Table("pub_fact")]
    public class pub_fact
    {
        [Key]
        public decimal fact_id { get; set; }
        public string fact_no { get; set; }
        public string fact_nm { get; set; }
        public string out_date { get; set; }

    }
}
