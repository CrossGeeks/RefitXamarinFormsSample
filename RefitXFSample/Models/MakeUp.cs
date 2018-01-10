using System;
using System.Collections.Generic;

namespace RefitXFSample.Models
{
    public class MakeUp
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public object PriceSign { get; set; }
        public object Currency { get; set; }
        public string ImageLink { get; set; }
        public string ProductLink { get; set; }
        public string WebsiteLink { get; set; }
        public string Description { get; set; }
        public double? Rating { get; set; }
        public string Category { get; set; }
        public string ProductType { get; set; }
        public IList<object> TagList { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string ProductApiUrl { get; set; }
        public string ApiFeaturedImage { get; set; }
        public IList<ProductColor> ProductColors { get; set; }
    }

    public class ProductColor
    {
        public string HexValue { get; set; }
        public string ColourName { get; set; }
    }
}
