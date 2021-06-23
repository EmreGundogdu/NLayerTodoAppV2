using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TekrarProje.DataAccess.Context;
using TekrarProje.DataAccess.UnitOfWork;
using TekrarProjesi.Business.Interfaces;
using TekrarProjesi.Business.Mapping.AutoMapper;
using TekrarProjesi.Business.Services;
using TekrarProjesi.Business.ValidationRules;
using TekrarProjesi.Dtos.WorkDtos;

namespace TekrarProjesi.Business.DependencyResolvers.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {

            services.AddDbContext<ReTodoContext>(opt =>
            {
                opt.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=ReTodoDb; integrated security=true");
                opt.LogTo(Console.WriteLine, LogLevel.Information);
            });

            var configuration = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new WorkProfile());
            });
            var mapper = configuration.CreateMapper();

            services.AddSingleton(mapper);

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IWorkService, WorkService>();

            services.AddTransient<IValidator<WorkCreateDto>, WorkCreateDtoValidator>();
            services.AddTransient<IValidator<WorkUpdateDto>, WorkUpdateDtoValidator>();
        }
    }
}
