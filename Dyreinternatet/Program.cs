using Dyreinternatet.Repository;
using Dyreinternatet.Service;

namespace Dyreinternatet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
      
            
            builder.Services.AddSingleton<IAnimalRepo, AnimalRepo>();
            builder.Services.AddSingleton<AnimalService>();
            builder.Services.AddSingleton<ICustomerRepo, CustomerRepo>();
            builder.Services.AddSingleton<CustomerService>();
            builder.Services.AddSingleton<IWorkerRepo, WorkerRepo>();
            builder.Services.AddSingleton<WorkerService>();
            builder.Services.AddSingleton<IBlogRepo, BlogRepo>();
            builder.Services.AddSingleton<BlogService>();
            builder.Services.AddSingleton<IActivityRepo, ActivityRepo>();
            builder.Services.AddSingleton<ActivityService>();
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
