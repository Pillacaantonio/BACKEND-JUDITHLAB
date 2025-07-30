using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SGE_BACKEND_JUDITH_LAB.Context;
using SGE_BACKEND_JUDITH_LAB.Extensions;
using SGE_BACKEND_JUDITH_LAB.Interfaces;
using SGE_BACKEND_JUDITH_LAB.Mappers;
using SGE_BACKEND_JUDITH_LAB.Services;

var builder = WebApplication.CreateBuilder(args);
var Configuration = builder.Configuration;

builder.Services.AddAuthentication(Configuration);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwagger();


builder.Services.AddSingleton(new Conexion(builder.Configuration.GetConnectionString("connection")));


builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<ICotizacionService,CotizacionService>();
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<ILogoService, LogoService>();
builder.Services.AddScoped<IVendedorService,VendedorService>();
builder.Services.AddCors(options => options.AddPolicy("AllowWebapp",
                                    builder => builder.AllowAnyOrigin()
                                                    .AllowAnyHeader()
                                                    .AllowAnyMethod()));

var mapperConfig = new MapperConfiguration(m =>
{
     m.AddProfile(new MappinProfile());
});
 
IMapper mapper = mapperConfig.CreateMapper();

builder.Services.AddSingleton(mapper);

var app = builder.Build();



//Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseCors("AllowWebapp");
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

//var app = builder.Build();

//builder.Services.AddSingleton(new Conexion(builder.Configuration.GetConnectionString("connection")));

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
