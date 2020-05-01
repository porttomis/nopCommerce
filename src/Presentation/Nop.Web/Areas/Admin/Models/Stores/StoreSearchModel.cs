using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Web.Areas.Admin.Models.Stores
{
    /// <summary>
    /// Represents a store search model
    /// </summary>
    public partial class StoreSearchModel : BaseSearchModel
    {


        #region Properties
        [NopResourceDisplayName("Admin.Catalog.Stores.List.StoreName")]
        public string SearchStoreName { get; set; }

        #endregion
    }
}