//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeatherSys.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Weather_Descriptions
    {
        public Weather_Descriptions()
        {
            this.Weather_Hours = new HashSet<Weather_Hours>();
        }
    
        public int ID { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Weather_Hours> Weather_Hours { get; set; }
    }
}
