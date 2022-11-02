using System.Net.NetworkInformation;
using Grpc.Net.Client;
using GrpcService1;

namespace GRPCClient; 

public class EtellerAndet {
    
    private static Greeter.GreeterClient client;

    public EtellerAndet() {
        
        using var channel = GrpcChannel.ForAddress("http://localhost:9090");
        client = new Greeter.GreeterClient(channel); 
    }
    
    public static async Task<HelloReply> PingServerAsync(HelloRequest request) {
        
        return await client.SayHelloAsync(request);
    } 
}