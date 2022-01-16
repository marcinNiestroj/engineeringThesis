using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektInzynierskiBlazor.Data.Entities
{
    public class Equipment
    {
        [Key]
        public string Id { get; set; }

        public string Number { get; set; }

        public string Elements { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Review { get; set; }

        public string? Informations { get; set; }

    }
}
