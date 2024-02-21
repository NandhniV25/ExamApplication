using Microsoft.EntityFrameworkCore;
using NiVeTec.ExamRepository.Exam;
using NiVeTech.ExamApi.AutoMapper;
using NiVeTech.ExamApi.Services.Exam;
using NiVeTech.ExamApi.Services.Question;
using NiVeTech.ExamEntity.Data;
using NiVeTech.ExamRepository.Exam;
using NiVeTech.ExamRepository.Question;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(typeof(MapperProfile));

builder.Services.AddTransient<IExamService, ExamService>();
builder.Services.AddTransient<IExamRepository, ExamRepository>();

builder.Services.AddTransient<IQuestionService, QuestionService>();
builder.Services.AddTransient<IQuestionRepository, QuestionRepository>();


#region Configure Database

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

#endregion

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
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
