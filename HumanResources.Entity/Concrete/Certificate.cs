﻿using HumanResources.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Entities.Concrete
{
    public class Certificate : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string CertificateName { get; set; }
        public string Points { get; set; }
        public DateTime ValidityDate { get; set; }

    }
}