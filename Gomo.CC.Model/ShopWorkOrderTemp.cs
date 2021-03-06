﻿using System;
using System.Collections.Generic;

namespace Gomo.CC.Model
{
    public partial class ShopWorkOrderTemp
    {
        public ShopWorkOrderTemp()
        {
            WorkOrderDetailTemp = new HashSet<WorkOrderDetailTemp>();
            WorkOrderPhotoTemp = new HashSet<WorkOrderPhotoTemp>();
        }

        public int Id { get; set; }
        public int? RsaId { get; set; }
        public int? CaId { get; set; }
        public int? CvId { get; set; }
        public string WorkOrderNumber { get; set; }
        public sbyte? Maintenance { get; set; }
        public sbyte? Overhaul { get; set; }
        public sbyte? Insurance { get; set; }
        public sbyte? Claim { get; set; }
        public sbyte? Pdi { get; set; }
        public sbyte? Courtesy { get; set; }
        public sbyte? Towing { get; set; }
        public string CourtesyLicenseplateNumber { get; set; }
        public int? TssaId { get; set; }
        public int? WssaId { get; set; }
        public string WorkPurpose { get; set; }
        public string Wpdescription { get; set; }
        public string MaintenanceAdvice { get; set; }
        public DateTime? NextMaintenanceDate { get; set; }
        public DateTime? DateIn { get; set; }
        public string MileageIn { get; set; }
        public DateTime? DateOut { get; set; }
        public string MileageOut { get; set; }
        public string PlannedHours { get; set; }
        public string RealHours { get; set; }
        public int? WorkStatus { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int? PaymentType { get; set; }
        public string Balance { get; set; }
        public int? DelFlag { get; set; }
        public string DiscountAgain { get; set; }

        public ICollection<WorkOrderDetailTemp> WorkOrderDetailTemp { get; set; }
        public ICollection<WorkOrderPhotoTemp> WorkOrderPhotoTemp { get; set; }
    }
}
