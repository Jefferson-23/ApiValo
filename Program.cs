var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var agents = new[]
{
    new Agent(
        "Jett",
        "Duelist",
        new Ability[]
        {
            new Ability("Tailwind", "Immediately dash a short distance in the direction she's moving."),
            new Ability("Updraft", "Propel upwards after a brief delay.")
        },
        "Jett's agile and acrobatic moves make her hard to hit.",
        "https://cmsassets.rgpub.io/sanity/images/dsfx7636/news/d41286dc9017bf79c0b4d907b7a260c27b0adb69-616x822.png?auto=format&fit=fill&q=80&w=415"
    ),
    new Agent(
        "Sova",
        "Initiator",
        new Ability[]
        {
            new Ability("Recon Bolt", "Deploy a bolt that reveals the location of nearby enemies."),
            new Ability("Shock Bolt", "Fire a bolt that explodes upon impact or after a delay.")
        },
        "Sova tracks, finds, and eliminates enemies with ruthless efficiency.",
        "https://cmsassets.rgpub.io/sanity/images/dsfx7636/news/08b3d8822544bd327ebed0768c8b90fcec83d1a5-616x822.png?auto=format&fit=fill&q=80&w=415"
    )
};

app.MapGet("/agents", () => agents)
   .WithName("GetAgents")
   .WithOpenApi();

app.Run();

record Ability(string Name, string Description);

record Agent(
    string Name,
    string Role,
    Ability[] Abilities,
    string Description,
    string ImageUrl
);
