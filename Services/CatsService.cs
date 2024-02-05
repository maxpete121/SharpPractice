namespace SharpPractice.Services;

public class CatService(CatsRepository repo){
    private readonly CatsRepository repo = repo;

    internal List<Cats> GetCats(){
        List<Cats> cats = repo.GetCats();
        return cats;
    }

    internal Cats CreateCat(Cats catData){
        Cats cats = repo.CreateCat(catData);
        return cats;
    }

    internal Cats GetCatById(string catId){
        Cats cats = repo.GetCatById(catId);
        return cats;
    }

    // internal string DeleteCat(string catId){
    //     Cats catToRemove = 
    // }
}