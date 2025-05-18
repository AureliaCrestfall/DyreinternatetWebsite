using Dyreinternatet.Repository;
using Dyreinternatet.Service;

namespace Dyreinternatet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
      
            
            builder.Services.AddScoped<IAnimalRepo, AnimalRepo>();
            builder.Services.AddScoped<AnimalService>();
            builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();
            builder.Services.AddScoped<CustomerService>();
            builder.Services.AddScoped<IWorkerRepo, WorkerRepo>();
            builder.Services.AddScoped<WorkerService>();
            builder.Services.AddScoped<IBlogRepo, BlogRepo>();
            builder.Services.AddScoped<BlogService>();
            builder.Services.AddScoped<IActivityRepo, ActivityRepo>();
            builder.Services.AddScoped<ActivityService>();
            // Add services to the container.
            builder.Services.AddRazorPages();

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
