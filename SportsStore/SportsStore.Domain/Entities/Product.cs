namespace SportsStore.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Data.Linq.Mapping;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// This class will be the model for Product items.
    /// </summary>
    [Table(Name = "Products")]
    public class Product
    {
        /// <summary>
        /// Gets or sets ProductID.
        /// </summary>
        [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
        public int ProductID { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [Column]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [Column]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Price.
        /// </summary>
        [Column]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets Category.
        /// </summary>
        [Column]
        public string Category { get; set; }
    }
}
