using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbms.models
{
    public class Award
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Reason { get; set; }

        public DateTime Date { get; set; }

        public int? EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

        public override string ToString()
        {
            return $"{Reason} {Date.ToShortDateString()}";
        }
    }
}
