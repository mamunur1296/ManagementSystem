using Project.Domail.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domail.Entities
{
    public class Valve : BaseEntity
    {
        public string ? Name { get; set; }
        public string ? Unit { get; set; }
        public bool IsActive { get; set; }

    }
}
