using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAPI.ServiceExtention
{
    public static class CorsConfiguration
    {
        public static void CorsConfig(this IServiceCollection service)
        {

            service.AddCors(option =>
            {
                option.AddPolicy("policy", op =>
                {

                    op.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();

                });

            });

            service.AddCors(option =>
            {
                option.AddPolicy("specificPolicy", op =>
                {

                    op.WithOrigins("http://localhost:5001")
                     .AllowAnyHeader()
                     .AllowCredentials()
                     .AllowAnyMethod();
                });

            });
        }
    }
}
