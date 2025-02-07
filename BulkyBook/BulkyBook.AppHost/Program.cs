var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BulkyBookWeb>("bulkybookweb");

builder.Build().Run();
