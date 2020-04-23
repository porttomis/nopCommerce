using System;
using System.Collections.Generic;
using System.Text;
using Nop.Web.Framework.Models;

namespace Nop.Web.Framework.Events
{
    public class EntityModelQueryEvent<T> where T : BaseNopEntityModel
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="entity">Entity</param>
        public EntityModelQueryEvent(T model)
        {
            Model = model;
        }

        /// <summary>
        /// Entity
        /// </summary>
        public T Model { get; }
    }
}
