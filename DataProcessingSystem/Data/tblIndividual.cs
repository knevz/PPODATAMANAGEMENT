//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataProcessingSystem.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblIndividual
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string Gender { get; set; }
        public System.DateTime birthDay { get; set; }
        public int Age { get; set; }
        public string civilStatus { get; set; }
        public int occupationID { get; set; }
        public decimal Income { get; set; }
        public string Relationship { get; set; }
        public string Head { get; set; }
        public string member4ps { get; set; }
        public string wantsTo { get; set; }
        public string Pregnant { get; set; }
        public int fpmID { get; set; }
        public int reasonID { get; set; }
        public int houseID { get; set; }
    
        public virtual tblFamilyPlanningMethod tblFamilyPlanningMethod { get; set; }
        public virtual tblHouse tblHouse { get; set; }
        public virtual tblOccupation tblOccupation { get; set; }
        public virtual tblReason tblReason { get; set; }
    }
}
