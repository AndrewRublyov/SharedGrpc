# SharedGrpc
Example of .NET Core 3 gRPC client-server solution using shared *.proto files

## Notes
This example configured to use untrusted connection due to development environment (TLS not working on macOS)

There are also problems in IDE support and even build would be successful, there will be errors in your IDE due to invalid cache (gRPC uses code generation of .NET classes)
