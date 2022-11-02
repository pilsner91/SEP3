package server;

import dk.via.hello.HelloRequest;
import dk.via.hello.HelloResponse;
import dk.via.hello.HelloServiceGrpc;
import io.grpc.stub.StreamObserver;

public class HelloServiceImpl extends HelloServiceGrpc.HelloServiceImplBase {
    @Override
    public void hello (HelloRequest request, StreamObserver<HelloResponse> responseObserver) {
        String greeting = String.format("Hello, %s %s!", request.getFirstName(), request.getLastName());
        HelloResponse response = HelloResponse.newBuilder().setGreeting(greeting).build();
        responseObserver.onNext(response);
        responseObserver.onCompleted();
    }
}



