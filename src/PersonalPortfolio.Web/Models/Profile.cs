namespace PersonalPortfolio.Web.Models;

public static class Profile
{
    public const string Name = "Fatemeh Ghasemi";
    public const string Title = "Backend Developer";
    public const string Location = "Tehran, Iran";
    public const string Tagline = "C# • .NET Core • Microservices • DDD • Distributed Systems";

    public const string Intro =
        "Backend Developer with 6+ years of experience designing and deploying scalable, " +
        "maintainable software systems. I improve performance through database optimization and caching.";

    public const string AboutText =
        "I'm a backend-focused software engineer with over 6 years of experience building scalable " +
        "and maintainable systems with C#, .NET Core and EF Core. I've improved system performance by " +
        "up to 30% through database optimization and caching, and I work with microservices, RESTful APIs, " +
        "and serverless solutions. I apply patterns like CQRS and Onion/DDD architecture, and I'm " +
        "comfortable with containerized deployments using Docker. I enjoy solving complex technical " +
        "challenges and shipping high-quality software in collaborative teams.";

    public const string Email = "fatemeh.ghasemi.email@gmail.com";
    public const string Phone = "+98 903 279 9523";
    public const string GitHubUrl = "https://github.com/fatemehghasemi";
    public const string LinkedInUrl = "https://www.linkedin.com/in/fatemehghasem1/";
    public const string ResumePath = "files/resume.pdf";

    public static readonly string[] Skills =
    [
        "C#", ".NET Core", "EF Core", "Dapper ORM", "T-SQL",
        "RESTful APIs", "DDD", "CQRS", "Microservices", "RabbitMQ",
        "Redis", "Elasticsearch", "Docker", "Unit Testing", "Git",
    ];

    public static readonly TimelineItem[] Timeline =
    [
        new("Nov 2025 — Present", "Back End Developer · Hese Tazegi", "Remote, Tehran",
            "Designed scalable backend services with .NET Core following DDD. Used Dapper for efficient " +
            "data access, improved Elasticsearch search performance by ~50%, and integrated Redis caching " +
            "to cut response times and database load."),
        new("Sep 2024 — Aug 2025", "Back End Developer · Mores Software", "Remote, Tehran",
            "Built high-performance backend systems with .NET Core and Dapper. Applied CQRS, integrated " +
            "AWS Lambda and Amazon S3, practiced TDD, and deployed with Docker."),
        new("Jan 2022 — Jan 2024", "Back End Developer · Chargoon", "Remote, Tehran",
            "Migrated legacy systems to scalable microservices on the Zagros platform. Built APIs with " +
            "ASP.NET Core, EF Core and Dapper, and tuned SQL Server performance with indexing and Redis."),
        new("Apr 2018 — Feb 2021", "Back End Developer · Simorgh HR Systems", "On-site, Qom",
            "Built APIs and ASP.NET MVC applications for HR process automation, and optimized SQL Server " +
            "stored procedures and indexing."),
        new("Jan 2017 — Jun 2018", "Software Developer · Mohaymen ICT Group", "On-site, Qom",
            "Developed Windows Forms applications and backend logic in C#, using LINQ and optimized " +
            "stored procedures."),
    ];

    public static readonly EducationItem[] Education =
    [
        new("Bachelor's Degree, Computer Software Technology Engineering",
            "Technical and Vocational University", "2016 — 2020"),
    ];

    public static readonly AwardItem[] Awards =
    [
        new("Silver Medal — 19th Iran National Skills",
            "World Skills Competition, issued by Iran TVTO", "Oct 2021"),
    ];

    public static readonly ProjectItem[] Projects =
    [
        new(
            Name: "PersonalPortfolio",
            Description: "This website — a minimal, fast personal portfolio built with Blazor.",
            Status: "In Progress",
            Tech: ["Blazor", ".NET 10", "Bootstrap"],
            RepoUrl: "https://github.com/fatemehghasemi/PersonalPortfolio"),
        new(
            Name: "PartyBox",
            Description: "A real-time multiplayer party game backend. My main long-term project.",
            Status: "Planned",
            Tech: [".NET", "DDD", "Redis", "Docker"],
            RepoUrl: "https://github.com/fatemehghasemi/PartyBox"),
        new(
            Name: "dotnet-clean-architecture-sample",
            Description: "Enterprise-grade ASP.NET Core Web API using Clean Architecture, " +
                "DDD-inspired design, and real-world university business rules.",
            Status: "Done",
            Tech: ["ASP.NET Core", "Clean Architecture", "DDD"],
            RepoUrl: "https://github.com/fatemehghasemi/dotnet-clean-architecture-sample"),
        new(
            Name: "URL-Shortener",
            Description: "High-performance URL shortener with collision-safe generation and " +
                "click analytics. Production-ready with Docker deployment.",
            Status: "Done",
            Tech: ["ASP.NET Core 9", "Minimal APIs", "PostgreSQL", "Docker"],
            RepoUrl: "https://github.com/fatemehghasemi/URL-Shortener"),
        new(
            Name: "JwtAuth.API",
            Description: "Minimal ASP.NET Core Web API with JWT authentication.",
            Status: "Done",
            Tech: ["ASP.NET Core", "Minimal API", "JWT"],
            RepoUrl: "https://github.com/fatemehghasemi/JwtAuth.API"),
        new(
            Name: "blog",
            Description: "A modern blog platform built with Blazor and Clean Architecture, " +
                "focusing on scalability, CQRS, and event-driven design.",
            Status: "In Progress",
            Tech: ["Blazor", "CQRS", "Event-Driven", "Clean Architecture"],
            RepoUrl: "https://github.com/fatemehghasemi/blog"),
        new(
            Name: "Notely",
            Description: "A Clean Architecture template for a modern Blazor WebAssembly " +
                "note-taking app.",
            Status: "Done",
            Tech: ["Blazor WASM", "Clean Architecture", ".NET"],
            RepoUrl: "https://github.com/fatemehghasemi/Notely"),
    ];
}

public record TimelineItem(string Period, string Title, string Location, string Description);

public record EducationItem(string Degree, string Institution, string Period);

public record AwardItem(string Title, string Issuer, string Date);

public record ProjectItem(string Name, string Description, string Status, string[] Tech, string? RepoUrl);
