using becafoyo.Models.Responses;

namespace becafoyo.Services.Interfaces
{
    public interface IUmbracoContentService
    {
        PagedListResponse<VehiclesResponse> GetPagedVehicles(int page, int pageSize);
        List<BrandResponse> GetAllBrands();
    }
}
