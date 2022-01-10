using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektInzynierskiBlazor.Data
{
    public class Order
    {
        [Key]
        public string Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd H:mm}", ApplyFormatInEditMode = true)]
        public DateTime OrderFrom { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd H:mm}", ApplyFormatInEditMode = true)]
        public DateTime OrderTo { get; set; }

        public Statuses Status { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd H:mm}", ApplyFormatInEditMode = true)]
        public DateTime? DoneFrom { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd H:mm}", ApplyFormatInEditMode = true)]
        public DateTime? DoneTo { get; set; }

        public string LocationName { get; set; }

        public string OrdererName { get; set; }

        public string OrdererCompany { get; set; }

        public string? OrdererPhone { get; set; }

        public string? OrdererEmail { get; set; }

        public string WhatToDo { get; set; }

        public string? Informations { get; set; }

        public string FirstEmployeeName { get; set; }

        public string? SecondEmployeeName { get; set; }

        public string CarName { get; set; }

        public string FirstEqiupmentNumber { get; set; }

        public string? SecondEqiupmentNumber { get; set; }


        public Location Location { get; set; }
        public Orderer Orderer { get; set; }
        public User Employee { get; set; }
        public Equipment Equipment { get; set; }
        public Car Car { get; set; }

    }
}
