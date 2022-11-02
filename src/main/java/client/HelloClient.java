package client;

import dk.via.hello.HelloRequest;
import dk.via.hello.HelloResponse;
import dk.via.hello.HelloServiceGrpc;
import io.grpc.ManagedChannel;
import io.grpc.ManagedChannelBuilder;

public class HelloClient {
    public static void main (String[] args) {
        ManagedChannel managedChannel = ManagedChannelBuilder.forAddress("localhost", 9090).usePlaintext().build();
        HelloServiceGrpc.HelloServiceBlockingStub helloStub = HelloServiceGrpc.newBlockingStub(managedChannel);
        HelloRequest request = HelloRequest.newBuilder().setFirstName("Ole").setLastName("Hougaard").build();
        HelloResponse response = helloStub.hello(request);
        System.out.println(response.getGreeting());
        managedChannel.shutdown();
    }
}