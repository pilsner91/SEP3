using System.Text.Json;
using GRPCClient;
using GrpcService1;
using Logic.LogicInterfaces;
using Shared.DTOs;
using Shared.Model;

namespace Logic.Logic; 

public class WareLogic : IWareLogic {
    public async Task<Ware> CreateAsync(WareCreationDto dto) {

        HelloRequest request = new HelloRequest();

        request.Name = "Test";
        
        Task<HelloReply> reply = EtellerAndet.PingServerAsync(request);

        Ware ware = new Ware();

        return ware;
    }
}