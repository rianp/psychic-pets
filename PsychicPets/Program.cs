using GraphQL;
using GraphQL.MicrosoftDI;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;
using PsychicPets.Pets;
using PsychicPets.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<PetsContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

// Add Pets Schema.
builder.Services.AddSingleton<ISchema, PetsSchema>(services => new PetsSchema(new SelfActivatingServiceProvider(services)));

// register graphQL
builder.Services.AddGraphQL(options =>
                    options.ConfigureExecution((opt, next) =>
                    {
                        opt.EnableMetrics = true;
                        return next(opt);
                    }).AddSystemTextJson()
                );

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    // add altair UI to development only
    app.UseGraphQLAltair();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseGraphQL();

app.Run();