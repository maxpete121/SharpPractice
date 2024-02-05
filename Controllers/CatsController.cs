namespace SharpPractice.Controllers;

[ApiController]
[Route("api/cats")]

public class CatsController : ControllerBase{
    private readonly CatService catService;

    public CatsController(CatService catService){
        this.catService = catService;
    }
    [HttpGet]
    public ActionResult<List<Cats>> GetCats(){
        try
        {
            List<Cats> cats = catService.GetCats();
            return Ok(cats);
        }
        catch (Exception error)
        {
            
            return BadRequest(error.Message);
        }
    }
}