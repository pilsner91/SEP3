// See https://aka.ms/new-console-template for more information

using Grpc.Net.Client;
using GrpcServer;

var channel = GrpcChannel.ForAddress("https://localhost:9090");