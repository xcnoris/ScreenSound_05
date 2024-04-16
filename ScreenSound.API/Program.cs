using ScreenSound.Banco;
using ScreenSound.Modelos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.AddEndPointsArtistas();
app.AddEndPointsMusicas();


app.Run();
