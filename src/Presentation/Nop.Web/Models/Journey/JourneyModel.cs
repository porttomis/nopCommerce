using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Orders;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;
using Nop.Web.Models.Media;


// Porttomis Inc. - Created for Journey
namespace Nop.Web.Models.Journey
{
    public partial class JourneyModel : BaseNopEntityModel
    {
        public JourneyModel()
        {
            PictureModel = new PictureModel();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string SeName { get; set; }
        
        public PictureModel PictureModel { get; set; }


    }
}