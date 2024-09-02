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
            new Ability("UPDRAFT", "INSTANTLY propel Jett high into the air."),
            new Ability("TAILWIND", "ACTIVATE to prepare a gust of wind for a limited time. RE-USE the wind to propel Jett in the direction she is moving. If Jett is standing still, she propels forward. Tailwind charge resets every two kills."),
            new Ability("CLOUDBURST", "INSTANTLY throw a projectile that expands into a brief vision-blocking cloud on impact with a surface. HOLD the ability key to curve the smoke in the direction of your crosshair."),
            new Ability("BLADE STORM", "EQUIP a set of highly accurate throwing knives. FIRE to throw a single knife and recharge knives on a kill. ALT FIRE to throw all remaining daggers but does not recharge on a kill.")
        },
        "Representing her home country of South Korea, Jett's agile and evasive fighting style lets her take risks no one else can. She runs circles around every skirmish, cutting enemies before they even know what hit them.",
        "https://cmsassets.rgpub.io/sanity/images/dsfx7636/news/d41286dc9017bf79c0b4d907b7a260c27b0adb69-616x822.png?auto=format&fit=fill&q=80&w=415"
    ),
    new Agent(
        "Phoenix",
        "Duelist",
        new Ability[]
        {
            new Ability("CURVEBALL", "EQUIP a flare orb that takes a curving path and detonates shortly after throwing. FIRE to curve the flare orb to the left, detonating and blinding any player who sees the orb."),
            new Ability("HOT HANDS", "EQUIP a fireball. FIRE to throw a fireball that explodes after a set amount of time or upon hitting the ground, creating a lingering fire zone that damages enemies."),
            new Ability("BLAZE", "EQUIP a flame wall. FIRE to create a line of flame that moves forward, creating a wall of fire that blocks vision and damages players passing through it."),
            new Ability("RUN IT BACK", "INSTANTLY place a marker at Phoenix’s location. While this ability is active, dying or allowing the timer to expire will end this ability and bring Phoenix back to the marker with full health.")
        },
        "Hailing from the U.K., Phoenix's star power shines through in his fighting style, igniting the battlefield with flash and flare. Whether he's got backup or not, he's rushing into the fight on his own terms.",
        "https://cmsassets.rgpub.io/sanity/images/dsfx7636/news/47387e354c34d51b84066bc47af3c5755b92b9c5-616x822.png?auto=format&fit=fill&q=80&w=415"
    ),
    new Agent(
        "Omen",
        "Controller",
        new Ability[]
        {
            new Ability("SHROUDED STEP", "EQUIP a shadow walk ability. FIRE to begin a brief channel, then teleport to the marked location."),
            new Ability("PARANOIA", "EQUIP a blinding orb. FIRE to send it forward, reducing the vision range of all it touches."),
            new Ability("DARK COVER", "EQUIP a shadow orb and see its range indicator. FIRE to throw it to the marked location, creating a long-lasting shadow sphere that blocks vision. HOLD FIRE to move the marker further away."),
            new Ability("FROM THE SHADOWS", "EQUIP a tactical map. FIRE to begin teleporting to the selected location. While teleporting, Omen will appear as a Shade that can be killed by enemies to cancel his teleport.")
        },
        "Omen hunts in the shadows. He renders enemies blind, teleports across the field, then lets paranoia take hold as his foe scrambles to uncover where he might strike next.",
        "https://cmsassets.rgpub.io/sanity/images/dsfx7636/news/015a083717e9687de8a741cfceddb836775b5f9f-616x822.png?auto=format&fit=fill&q=80&w=415"
    ),
    new Agent(
        "Sova",
        "Initiator",
        new Ability[]
        {
            new Ability("RECON BOLT", "EQUIP a bow with a recon bolt. FIRE to send the recon bolt forward, activating upon collision and revealing nearby enemies in its line of sight."),
            new Ability("SHOCK BOLT", "EQUIP a bow with a shock bolt. FIRE to send the shock bolt forward, exploding on impact and dealing damage to enemies in the vicinity."),
            new Ability("OWL DRONE", "EQUIP an Owl Drone. FIRE to deploy and pilot the drone, which can fire a dart that reveals the location of any player struck."),
            new Ability("HUNTER'S FURY", "EQUIP a bow with three long-range wall-piercing energy blasts. FIRE to release an energy blast in a line in front of Sova, dealing damage and revealing the location of enemies caught in the line. This ability can be RE-USED up to two more times while the ability timer is active.")
        },
        "Born from the eternal winter of Russia's tundra, Sova tracks, finds, and eliminates enemies with ruthless efficiency and precision. His custom bow and incredible scouting abilities ensure that even if you run, you cannot hide.",
        "https://cmsassets.rgpub.io/sanity/images/dsfx7636/news/08b3d8822544bd327ebed0768c8b90fcec83d1a5-616x822.png?auto=format&fit=fill&q=80&w=415"
    ),
    new Agent(
        "Deadlock",
        "Controller",
        new Ability[]
        {
            new Ability("SONIC SENSOR", "EQUIP a Sonic Sensor. FIRE to deploy. The sensor monitors an area for enemies making sound. It concusses that area if footsteps, weapons fire, or significant noise are detected."),
            new Ability("BARRIER MESH", "EQUIP a Barrier Mesh disc. FIRE to throw forward. Upon landing, the disc generates barriers from the origin point that block character movement."),
            new Ability("GRAVNET", "EQUIP a GravNet grenade. FIRE to throw. ALT FIRE to lob the grenade underhand. The GravNet detonates upon landing, forcing any enemies caught within to crouch and move slowly."),
            new Ability("ANNIHILATION", "EQUIP a Nanowire Accelerator. FIRE to unleash a pulse of nanowires that captures the first enemy contacted. The cocooned enemy is pulled along a nanowire path and will die if they reach the end, unless they are freed. The nanowire cocoon is destructible.")
        },
        "Norwegian operative Deadlock deploys an array of cutting-edge nanowire to secure the battlefield from even the most lethal assault. No one escapes her vigilant watch, nor survives her unyielding ferocity.",
        "https://cmsassets.rgpub.io/sanity/images/dsfx7636/news/477284dfe402a85abcf6b07512bcd6f01c8fe60e-616x822.png?auto=format&fit=fill&q=80&w=415"
    ),
    new Agent(
        "Yoru",
        "Duelist",
        new Ability[]
        {
            new Ability("FAKEOUT", "EQUIP an echo that mimics footsteps when activated. FIRE to send the echo forward."),
            new Ability("BLINDSIDE", "EQUIP a fragment that unravels and explodes after a brief delay, blinding all caught in the blast."),
            new Ability("GATECRASH", "EQUIP to harness a rift tether. FIRE to send the tether out moving forward. ALT FIRE to place a tether in place. ACTIVATE to teleport to the tether's location."),
            new Ability("DIMENSIONAL DRIFT", "EQUIP a mask that can see between dimensions. FIRE to drift into Yoru's dimension, making him unable to be affected or seen by enemies.")
        },
        "Japanese native Yoru rips holes straight through reality to infiltrate enemy lines unseen. Using deception and aggression in equal measure, he gets the drop on each target before they know where to look.",
        "https://cmsassets.rgpub.io/sanity/images/dsfx7636/news/05e1a996814dd10d7179efee327d29a7be00e912-616x822.png?auto=format&fit=fill&q=80&w=415"
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
