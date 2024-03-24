using Microsoft.EntityFrameworkCore;
using Project.Application.Mapper;
using Project.Domail.Abstractions;
using Project.Infrastructure.DataContext;
using Project.Infrastructure.Implementation;
using School.Application;
using School.Infrastructiure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUnitOfWorkDb, UnitOfWorkDb>();
builder.Services.AddApplication().AddInfrastructure();
builder.Services.AddAutoMapper(
    typeof(ProductSizeMappingProfile),
    typeof(RetaileMappingProfile),
    typeof(CompanyMappingProfile),
    typeof(DeliveryAddressMappingProfile),
    typeof(OrderMappingProfile),
    typeof(ProdReturnMappingProfile),
    typeof(ProductMappingProfile),
    typeof(StockMappingProfile),
    typeof(TraderMappingProfile)
    );
builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("dbcs"));
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
