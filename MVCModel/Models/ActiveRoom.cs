//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCModel.Models
{
    using System;
    
    public partial class ActiveRoom
    {
        public int RoomID { get; set; }
        public string Description { get; set; }
        public int HotelID { get; set; }
        public int RoomTypeID { get; set; }
        public int RoomCategoryID { get; set; }
        public int RoomStatusID { get; set; }
        public string FloorLevel { get; set; }
        public int NoBed { get; set; }
        public int NoPerson { get; set; }
        public string Remarks { get; set; }
    }
}
