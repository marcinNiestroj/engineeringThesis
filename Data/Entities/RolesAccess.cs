﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektInzynierskiBlazor.Data.Entities
{
    public class RolesAccess
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string UrlAddress { get; set; }
        public string AccessString { get; set; }

    }
}
