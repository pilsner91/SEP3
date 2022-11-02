using Shared.DTOs;
using Shared.Model;

namespace HttpClients.ClientInterfaces; 

public interface IItemService {



    Task<Item> Create(ItemCreationDto dto);

}