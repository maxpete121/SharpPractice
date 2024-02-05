namespace SharpPractice.Services;

public class CatService(CatsRepository repo){
    private readonly CatsRepository repo = repo;

    internal List<Cats> GetCats(){
        List<Cats> cats = repo.GetCats();
        return cats;
    }
}