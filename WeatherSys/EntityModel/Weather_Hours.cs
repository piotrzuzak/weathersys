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
    
    public partial class Weather_Hours
    {
        public int ID { get; set; }
        public int weather_days_id { get; set; }
        public Nullable<System.DateTime> weather_date { get; set; }
        public Nullable<int> temperature { get; set; }
        public Nullable<int> weather_descriptions_id { get; set; }
        public Nullable<int> real_feel_temperature { get; set; }
        public Nullable<decimal> rain { get; set; }
        public Nullable<int> wind { get; set; }
        public Nullable<int> pressure { get; set; }
    
        public virtual Weather_Days Weather_Days { get; set; }
        public virtual Weather_Descriptions Weather_Descriptions { get; set; }
    }
}