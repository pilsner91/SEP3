using Shared.DTOs;
using Shared.Model;

namespace Logic.LogicInterfaces; 

public interface IWareLogic {
    Task<Ware> CreateAsync(WareCreationDto dto);
}