﻿using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class Room
    {
        public int Id { get; set; }
        public int? RoomNumber { get; set; }
        public int? Square { get; set; }
        public int? Status { get; set; }
        public int? BuildingId { get; set; }
        public int? CustomerId { get; set; }

        public virtual Building Building { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Garden Garden { get; set; }
    }
}
