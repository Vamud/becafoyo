using Umbraco.Cms.Core.Models.PublishedContent;

namespace becafoyo.Models.Responses
{
    public class VehiclesResponse
    {
        public string Name { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public IPublishedContent? Image { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Color { get; set; } = string.Empty;
        public string FuelType { get; set; } = string.Empty;
    }
}
