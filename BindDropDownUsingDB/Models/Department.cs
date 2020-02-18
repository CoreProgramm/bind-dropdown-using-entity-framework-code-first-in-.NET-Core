using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BindDropDownUsingDB.Models
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int DeptId { get; set; }

        [Display(Name = "Department Name")]
        public string DeptName { get; set; }
    }
}
