using ApiFakezap.Models;
using ApiFakezap.Mutations;
using ApiFakezap.Queries;
using ApiFakezap.Repositories;
using ApiFakezap.Subscription;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IMessageReposiroty, MessageRepository>();

builder.Services.AddGraphQLServer()
    .AddType<Message>()
    //.AddType<User>()
    //.AddType<Group>()

    .AddQueryType()
        .AddTypeExtension<ChatQuery>()

    .AddMutationType()
        .AddTypeExtension<MessagesMutation>()

    .AddSubscriptionType()
        .AddTypeExtension<ChatSubscription>();



builder.Services.AddCors(p => p.AddPolicy("CorsPolicy", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseCors("CorsPolicy");
}


app.UseWebSockets()
    .UseRouting()
    .UseEndpoints(endpoint => endpoint.MapGraphQL());

app.Run();
