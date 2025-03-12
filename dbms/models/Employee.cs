using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbms.models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public int? OrganizationId { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual ICollection<Award> Awards { get; set; } = new List<Award>();

        public override string ToString()
        {
            string str = $"{LastName} {FirstName}";
            if (!string.IsNullOrEmpty(MiddleName)) str += " " + MiddleName;
            return str;
        }

        public static explicit operator string(Employee emp)
        {
            return $"{emp.LastName} {emp.FirstName}";
        }
    }
}
