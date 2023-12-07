using becafoyo.Models.Responses;
using becafoyo.Services.Interfaces;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common;

namespace becafoyo.Services
{
    public class UmbracoContentService : IUmbracoContentService
    {
        private readonly UmbracoHelper _umbracoHelper;
        public UmbracoContentService(UmbracoHelper umbracoHelper)
        {
            _umbracoHelper = umbracoHelper;
        }
        public PagedListResponse<VehiclesResponse> GetPagedVehicles(int page, int pageSize)
        {
            var rootNode = _umbracoHelper.ContentSingleAtXPath("//vehicles")!;

            var items = rootNode
                .Children()
                .Select(v => new VehiclesResponse
                {
                    Name = v.Value<string>("modelName") ?? "",
                    Brand = v.Value<IPublishedContent>("brand")?.Name ?? "",
                    Image = v.Value<IPublishedContent>("mainImage"),
                    ImageUrl = v.Value<IPublishedContent>("mainImage")?.Url() ?? "",
                    Price = v.Value<decimal>("price"),
                    Color = v.Value<string>("color") ?? "",
                    FuelType = v.Value<string>("fuelType") ?? ""
                })
                .ToList();

            var vehicles = PagedListResponse<VehiclesResponse>.Create(items, page, pageSize);

            return vehicles;
        }

        public List<BrandResponse> GetAllBrands()
        {
            var rootNode = _umbracoHelper.ContentSingleAtXPath("//brands")!;

            var brands = rootNode
                .Children()
                .Select(b => new BrandResponse
                {
                    Name = b.Name,
                    Image = b.Value<IPublishedContent>("image")?.Url() ?? "",
                    OriginCountry = b.Value<string>("originCountry") ?? ""
                })
                .ToList();

            return brands;
        }
    }
}
