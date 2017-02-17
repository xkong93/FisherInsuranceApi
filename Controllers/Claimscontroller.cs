using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Data;
using FisherInsuranceApi.Claims;



namespace FisherInsuranceApi.Controllers {


[Route("api/claims")]
public class ClaimsController : Controller
{

    private IMemoryStore db;
    public ClaimsController(IMemoryStore  repo ){
        db=repo;
    }
         [HttpPost]
            public IActionResult Post([FromBody] Claim claim) {
            return Ok(db.CreateClaim(claim));
        }

             [HttpGet("{id}")]
            public IActionResult Get(int id) {
          return Ok(db.RetrieveClaim(id));
       }

            [HttpPut("{id}")]
            public IActionResult Put([FromBody] Claim claim) {
      
        return Ok(db.UpdateClaim(claim));
        }
             [HttpDelete("{id}")]
            public IActionResult Delete(int id, [FromBody] Claim claim) {
        db.DeleteClaim(id);
         return Ok();
        }

           [HttpGet]
        public IActionResult GetClaim() {
        return Ok(db.RetrieveAllClaims);
}

}}