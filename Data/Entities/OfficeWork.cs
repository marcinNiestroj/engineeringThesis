using ProjektInzynierskiBlazor.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektInzynierskiBlazor.Data.Entities
{
    public class OfficeWork
    {
        [Key]
        public string Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime From { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime To { get; set; }

        public Statuses Status { get; set; }

        public string WhatToDo { get; set; }

        public string Informations { get; set; }



        public Order Order { get; set; }
        public Employee Employee { get; set; }
        public Department Department { get; set; }
    }
}
