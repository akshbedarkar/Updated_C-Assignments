﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesC
{
    #region CustomAttribute

    
    public sealed class SoftwareattributeAttribute:Attribute
    {
        public string description { get; set; }
        public string projectname { get; set; }

        public string clientname { get; set; }
        public string startdate { get; set; }

        public string enddate { get; set; }
     

        public SoftwareattributeAttribute() { }

        public SoftwareattributeAttribute(string description, string projectname,string clientname,string startdate,string enddate)
        {
            this.description = description;
            this.projectname = projectname;
            this.clientname = clientname;
            this.startdate = startdate;
            this.enddate = enddate;

        }

    }

    #endregion
}
