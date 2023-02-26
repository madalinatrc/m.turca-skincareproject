using Microsoft.AspNetCore.Mvc;

namespace SkinCareAPP.API.Controllers
{
    public class RecommendationsController : Controller
    {
        [HttpGet]
        [Route("recommendations")]
        public async Task<IActionResult> GetRecommendations([FromQuery] int userId, int years)
        {
            // Call the service layer to get product recommendations
            var recommendations = await _service.GetProductRecommendationsAsync(userId, years);

            return Ok(recommendations);
        }
    }
}
