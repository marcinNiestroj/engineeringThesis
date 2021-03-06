using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektInzynierskiBlazor.Data.Entities
{
    public class Orderer
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Company { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Informations { get; set; }

    }
}
