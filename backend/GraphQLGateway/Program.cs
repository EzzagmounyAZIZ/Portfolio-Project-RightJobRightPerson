using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Playground;
using HotChocolate.Types;
using GraphQLGateway;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient(); // Add IHttpClientFactory
builder.Services.AddScoped<MutationResolver>();
builder.Services.AddGraphQLServer()
    .AddQueryType<QueryType>()
    .AddType<PersonType>()
    .AddType<CertificationType>()
    .AddType<EducationType>()
    .AddType<ExperienceType>()
    .AddType<LanguageType>()
    .AddType<SkillType>()
    .AddType<InterestHobbieType>()
.AddMutationType<MutationType>();

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularDev",
        builder =>
        {
            builder.WithOrigins("http://localhost:4200")
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UsePlayground(new PlaygroundOptions
    {
        QueryPath = "/graphql",
        Path = "/playground"
    });
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors("AllowAngularDev");

app.UseEndpoints(endpoints =>
{
   endpoints.MapGraphQLHttp("/graphql");
});

app.Run();

