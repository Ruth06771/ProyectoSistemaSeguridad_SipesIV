using ProyectoFinalSS.Datos.AccesoDatos;
// Revisa si tus interfaces, repositorios y servicios usan 'ProyectoFinalSS' o 'ProyectoFinalSistemaSeguridad'
using ProyectoFinalSS.Datos.Interfaces;
using ProyectoFinalSS.Datos.Repository;
using ProyectoFinalSS.Negocio.Interfaces;
using ProyectoFinalSS.Negocio.Servicios;    
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Configuración de Controladores y Swagger/OpenAPI
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

// Base de datos
builder.Services.AddScoped<SistemaSeguridadDatabase>();


// Repositorios
builder.Services.AddScoped<ITblAcademicoRepository, TblAcademicoRepository>();
builder.Services.AddScoped<ITblAccesoPersonaRepository, TblAccesoPersonaRepository>();
builder.Services.AddScoped<ITblAreaRepository, TblAreaRepository>();
builder.Services.AddScoped<ITblBloqueadosRepository, TblBloqueadosRepository>();
builder.Services.AddScoped<ITblCentroAlertasRepository, TblCentroAlertasRepository>();
builder.Services.AddScoped<ITblConfiguracionSistemaRepository, TblConfiguracionSistemaRepository>();
builder.Services.AddScoped<ITblContactoEmergenciaRepository, TblContactoEmergenciaRepository>();
builder.Services.AddScoped<ITblDetalleHorarioRepository, TblDetalleHorarioRepository>();
builder.Services.AddScoped<ITblEdificiosRepository, TblEdificiosRepository>();
builder.Services.AddScoped<ITblExternoRepository, TblExternoRepository>();
builder.Services.AddScoped<ITblGrupoDetalleRepository, TblGrupoDetalleRepository>();
builder.Services.AddScoped<ITblGrupoRepository, TblGrupoRepository>();
builder.Services.AddScoped<ITblHorarioRepository, TblHorarioRepository>();
builder.Services.AddScoped<ITblLectoresRepository, TblLectoresRepository>();
builder.Services.AddScoped<ITblLogsSistemaRepository, TblLogsSistemaRepository>();
builder.Services.AddScoped<ITblMateriasRepository, TblMateriasRepository>();
builder.Services.AddScoped<ITblModulosRepository, TblModulosRepository>();
builder.Services.AddScoped<ITblPasesEspecialesRepository, TblPasesEspecialesRepository>();
builder.Services.AddScoped<ITblPerfilesRepository, TblPerfilesRepository>();
builder.Services.AddScoped<ITblPermisosRepository, TblPermisosRepository>();
builder.Services.AddScoped<ITblPersonasRepository, TblPersonasRepository>();
builder.Services.AddScoped<ITblPisosRepository, TblPisosRepository>();
builder.Services.AddScoped<ITblRegistroAccesosRepository, TblRegistroAccesoRepository>();
builder.Services.AddScoped<ITblTiposAccesoRepository, TblTiposAccesoRepository>();
builder.Services.AddScoped<ITblUsuariosRepository, TblUsuariosRepository>();

// Servicios 
builder.Services.AddScoped<ITblAcademicoService, TblAcademicoService>();
builder.Services.AddScoped<ITblAccesoPersonaService, TblAccesoPersonaService>();
builder.Services.AddScoped<ITblAreaService, TblAreaService>();
builder.Services.AddScoped<ITblBloqueadosService, TblBloqueadosService>();
builder.Services.AddScoped<ITblCentroAlertasService, TblCentroAlertasService>();
builder.Services.AddScoped<ITblConfiguracionSistemaService, TblConfiguracionSistemaService>();
builder.Services.AddScoped<ITblContactoEmergenciaService, TblContactoEmergenciaService>();
builder.Services.AddScoped<ITblDetalleHorarioService, TblDetalleHorarioService>();
builder.Services.AddScoped<ITblEdificiosService, TblEdificioService>();
builder.Services.AddScoped<ITblExternoService, TblExternoService>();
builder.Services.AddScoped<ITblGrupoDetalleService, TblGrupoDetalleService>();
builder.Services.AddScoped<ITblGrupoService, TblGrupoService>();
builder.Services.AddScoped<ITblHorarioService, TblHorarioService>();
builder.Services.AddScoped<ITblLectoresService, TblLectoresService>();
builder.Services.AddScoped<ITblLogsSistemaService, TblLogsSistemaService>();
builder.Services.AddScoped<ITblMateriasService, TblMateriasService>();
builder.Services.AddScoped<ITblModulosService, TblModulosService>();
builder.Services.AddScoped<ITblPasesEspecialesService, TblPasesEspecialesService>();
builder.Services.AddScoped<ITblPerfilesService, TblPerfilesService>();
builder.Services.AddScoped<ITblPermisosService, TblPermisosService>();
builder.Services.AddScoped<ITblPersonasService, TblPersonasService>();
builder.Services.AddScoped<ITblPisosService, TblPisosService>();
builder.Services.AddScoped<ITblRegistroAccesosService, TblRegistroAccesosService>();
builder.Services.AddScoped<ITblTiposAccesoService, TblTiposAccesoService>();
builder.Services.AddScoped<ITblUsuariosService, TblUsuariosService>();
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
