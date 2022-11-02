using System.Text.Json;
using GRPCClient;
using GrpcService1;
using Logic.LogicInterfaces;
using Shared.DTOs;
using Shared.Model;

namespace Logic.Logic; 

public class ItemLogic : IItemLogic {
    public async Task<Item> CreateAsync(ItemCreationDto dto) {

        HelloRequest request = new HelloRequest();

        request.Name = "Test";
        
        Task<HelloReply> reply = EtellerAndet.PingServerAsync(request);

        Item ware = new Item();

        return ware;
    }
}