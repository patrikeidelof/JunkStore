namespace SportsStore.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// This class will be the model for Product items.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets ProductID.
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets Category.
        /// </summary>
        public string Category { get; set; }    

    }
}
