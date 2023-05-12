﻿using FMS.Entities.DTOs;
using FMS.Entities.Models.Base;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FMS.Entities.Models
{
    public class PhotoDetails : BaseAuditableModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [ForeignKey(nameof(PhotoType))]
        public int Type { get; set; }

        public virtual PhotoType PhotoType { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "varchar")]
        public string ImageData { get; set; }

        public int? LocationId { get; set; }
        public virtual LocationDetail LocationDetail { get; set; }

        public int? BuildingId { get; set; }
        public virtual BuildingDetail BuildingDetail { get; set; }
        
        public int? FloorId { get; set; }
        public virtual FloorDetail FloorDetail { get; set; }
        
        public int? WingId { get; set; }
        public virtual WingDetail WingDetail { get; set; }
        
        public string OtherDetails { get; set; }

        public string MetaKeys { get; set; }

        public DateTime? Date { get; set; }
    }
}
