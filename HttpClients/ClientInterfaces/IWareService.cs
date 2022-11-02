using Shared.DTOs;
using Shared.Model;

namespace HttpClients.ClientInterfaces; 

public interface IWareService {



    Task<Ware> Create(WareCreationDto dto);

}