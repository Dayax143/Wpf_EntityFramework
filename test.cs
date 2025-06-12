using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEntityFramework
{
    public class Test
    {
        [Key] // Primary key
        public int? id { get; set; }
        public string? Name { get; set; }
        public int? Quantity { get; set; }
        public string? audit_user { get; set; }
    }
}
