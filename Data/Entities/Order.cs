using ProjektInzynierskiBlazor.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektInzynierskiBlazor.Data.Entities
{
    public class Order
    {
        [Key]
        public string Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime OrderFrom { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime OrderTo { get; set; }

        public Statuses Status { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? DoneFrom { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? DoneTo { get; set; }

        public string WhatToDo { get; set; }

        public string Informations { get; set; }



        public Location Location { get; set; }
        public Orderer Orderer { get; set; }
        public Employee FirstEmployee { get; set; }
        public Employee? SecondEmployee { get; set; }
        public Equipment FirstEquipment { get; set; }
        public Equipment? SecondEquipment { get; set; }
        public Car Car { get; set; }
        public Department Department { get; set; }
    }
}
