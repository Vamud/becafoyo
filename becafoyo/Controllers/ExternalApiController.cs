using becafoyo.Models.Responses;
using becafoyo.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.Common.Controllers;

namespace becafoyo.Controllers
{
    [Route("api")]
    [ApiController]
    public class ExternalApiController : UmbracoApiController
    {
        private readonly IUmbracoContentService _contentService;
        public ExternalApiController(IUmbracoContentService contentService)
        {
            _contentService = contentService;
        }

        [HttpGet("vehicles")]
        public PagedListResponse<VehiclesResponse> GetVehicles(int page, int pageSize)
        {
            return _contentService.GetPagedVehicles(page, pageSize);
        }

        [HttpGet("brands")]
        public List<BrandResponse> GetBrands()
        {
            return _contentService.GetAllBrands();
        }
    }
}
