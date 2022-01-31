using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektInzynierskiBlazor.Data.Entities
{
    public class Location
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Shortcut { get; set; }

        public string Address { get; set; }

        public string Informations { get; set; }


    }
}
