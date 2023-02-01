var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/",
    () => "Ola fiap!"
    );
app.Run();