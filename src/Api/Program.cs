using Microsoft.AspNetCore.Mvc;
using Application.UseCases.CriarProjeto;
using Application.UseCases.AdicionarTarefa;
using Domain;
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using Api;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseSwagger();
app.UseSwaggerUI();

app.MapPost("/projetos", ([FromBody] CriarProjetoCommand command) =>
{
    var handler = new CriarProjetoHandler();
    var projeto = handler.Handle(command);
    return Results.Ok(Result<Projeto>.Success(projeto));
});

app.MapPost("/projetos/{id}/tarefas", ([FromRoute] Guid id, [FromBody] AdicionarTarefaCommand command) =>
{
    // Simula repositório
    var projeto = new Projeto("Simulado") { };
    command.Projeto = projeto;

    var handler = new AdicionarTarefaHandler();
    var resultado = handler.Handle(command);

    return resultado.IsSucesso
        ? Results.Ok(Result.Success())
        : Results.BadRequest(Result.Fail(resultado.Erro!));
});

app.Run();
