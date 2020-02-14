﻿using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Plugin.Payments.PurchaseOrder.Models
{
    public class PaymentInfoModel : BaseNopModel
    {
        [NopResourceDisplayName("Plugins.Payment.PurchaseOrder.PurchaseOrderNumber")]
        public string PurchaseOrderNumber { get; set; }
    }
}