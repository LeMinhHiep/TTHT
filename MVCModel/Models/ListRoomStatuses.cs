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
    using System.Collections.Generic;
    
    public partial class ListRoomStatuses
    {
        public ListRoomStatuses()
        {
            this.ListRooms = new HashSet<ListRoom>();
        }
    
        public int RoomStatusID { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public string StatusIcon { get; set; }
    
        public virtual ICollection<ListRoom> ListRooms { get; set; }
    }
}