using Shared.DTOs;
using Shared.Model;

namespace Logic.LogicInterfaces; 

public interface IItemLogic {
    Task<Item> CreateAsync(ItemCreationDto dto);
}