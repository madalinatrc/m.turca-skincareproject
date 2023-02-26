using Microsoft.AspNetCore.Mvc;
using SkinCareAPP.Application;

namespace SkinCareAPP.API.Controllers
{
    public class PurchasesController : Controller
    {
        [HttpPost]
        [Route("purchases")]
        public async Task<IActionResult> AddPurchase([FromBody] Purchase purchase)
        {
            // Call the service layer to add a new purchase
            await _service.AddPurchaseAsync(purchase);

            return Ok();
        }

    }
   
}
