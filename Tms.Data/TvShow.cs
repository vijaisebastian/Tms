//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tms.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TvShow
    {
        public int Id { get; set; }
        public int TvShowId { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> Premiered { get; set; }
        public Nullable<System.DateTime> Ended { get; set; }
        public Nullable<System.DateTime> UpdatedWhen { get; set; }
        public string Image { get; set; }
        public string OttPlatform { get; set; }
        public Nullable<System.DateTime> NewSeasonReleaseDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<bool> IsManualAddition { get; set; }
        public Nullable<System.DateTime> TrailerDate { get; set; }
    }
}
