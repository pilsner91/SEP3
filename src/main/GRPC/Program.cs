using System.Threading.Tasks;
using GRPC;
using Grpc.Net.Client;
using GRPCGreeterClient;

using var channel = GrpcChannel.ForAddress("https://localhost:9090");
var Client = new Greeter.GRPC(channel);