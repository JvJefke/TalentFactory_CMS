﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalentFactory_CMS.Models
{
    public class JuryLid
    {

        public int ID { get; set; }
        public String Naam { get; set; }
        public String Email { get; set; }
        public String Functie { get; set; }
        public String Bedrijf { get; set; }
        public String Key { get; set; }
        public Boolean isActive { get; set; }
        public String Password { get; set; }
        public virtual List<JuryKeuze> JuryKeuzes { get; set; }
    }
}