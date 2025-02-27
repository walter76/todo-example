# todo-example

Examples for an application using clean architecture, a RESTful microservice and OpenAPI.

## Getting Started

After checking out the repository, switch to the folder `src` and restore the nuget packages with:

```sh
dotnet restore
```

To execute the Microservice you start the application with from the folder `src`:

```sh
dotnet run --project ToDo.Services
```

The Swagger UI will only be available if you run in development mode. For that, you need to set
the environment variable `ASPNETCORE_ENVIRONMENT` before running `ToDo.Services`:

```sh
set ASPNETCORE_ENVIRONMENT=Development
```

If you do that, the Swagger UI will be available with the URL http://localhost:5207/swagger/index.html
