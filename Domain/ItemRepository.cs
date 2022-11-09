using Model;
using Model.Configuration;

namespace Domain;

public class ItemRepository : ARepository<Item>{
    public ItemRepository(FlutterDbContext context) : base(context){
    }
}