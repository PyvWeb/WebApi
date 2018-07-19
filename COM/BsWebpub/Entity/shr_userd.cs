using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BsWebpub.Entity
{
    [Table("shr_userd")]
    public class shr_userd
    {
        [Key]
        public decimal user_id { get; set; }
        public string fact_no { get; set; }
        public string user_nm { get; set; }
        public string user_desc { get; set; }
        public string end_mk { get; set; }
    }
}
