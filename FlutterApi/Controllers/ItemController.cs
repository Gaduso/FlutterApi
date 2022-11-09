using Domain;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace FlutterApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemController : ControllerBase{
    public IRepository<Item> ItemRepository;

    public ItemController(IRepository<Item> itemRepository){
        ItemRepository = itemRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<Item>> Get(){
        return await ItemRepository.ReadAllAsync();
    }
    [HttpGet("/done")]
    public async Task<IEnumerable<Item>> GetDone(){
        return await ItemRepository.ReadAsync(e=>e.IsDone);
    }
    [HttpGet("/notdone")]
    public async Task<IEnumerable<Item>> GetNotDone(){
        return await ItemRepository.ReadAsync(e=>!e.IsDone);
    }

    [HttpGet("{id}")]
    public async Task<Item?> Get(int id){
        return await ItemRepository.ReadAsync(id);
    }

    [HttpPost]
    public async Task Create(ItemDto item){
        await ItemRepository.CreateAsync(item.ToItem());
    }

    [HttpPut]
    public async Task Update(Item item){
        await ItemRepository.UpdateAsync(item);
    }
    [HttpPut("/toggle/{id}")]
    public async Task Toggle(int id){
        var item = await ItemRepository.ReadAsync(id);
        if (item == null) return;
        item.IsDone = !item.IsDone;
        await ItemRepository.UpdateAsync(item);
    }
}