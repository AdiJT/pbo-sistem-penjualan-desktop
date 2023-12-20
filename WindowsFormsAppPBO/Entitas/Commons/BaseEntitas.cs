using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPBO.Entitas.Commons
{
    public abstract class BaseEntitas
    {
        [Key]
        public string Id {  get; set; }
    }
}
