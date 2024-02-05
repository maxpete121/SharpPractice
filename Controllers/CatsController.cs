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

    [HttpPost]
    public ActionResult<Cats> CreateCat([FromBody] Cats catData){
        try
        {
            Cats cats = catService.CreateCat(catData);
            return Ok(cats);
        }
        catch (Exception error)
        {
            
            return BadRequest(error.Message);
        }
    }

    [HttpGet("{catId}")]

    public ActionResult<Cats> GetCatById(string catId){
        try
        {
            Cats cats = catService.GetCatById(catId);
            return Ok(cats);
        }
        catch (Exception error)
        {
            
            return BadRequest(error.Message);
        }
    }

    // [HttpDelete("{catId}")]
    // public ActionResult<string> DeleteCat(string catId){
    //     try
    //     {
    //         string message = catService.DeleteCat(catId);
    //         return Ok(message);
    //     }
    //     catch (Exception)
    //     {
            
    //         throw;
    //     }
    // }
}