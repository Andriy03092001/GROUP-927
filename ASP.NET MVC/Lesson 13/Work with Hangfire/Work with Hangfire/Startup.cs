using Hangfire;
using Microsoft.Owin;
using Owin;
using System;
using Work_with_Hangfire.Helper;

[assembly: OwinStartupAttribute(typeof(Work_with_Hangfire.Startup))]
namespace Work_with_Hangfire
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            GlobalConfiguration.Configuration.UseSqlServerStorage("DefaultConnection");
            app.UseHangfireDashboard("/HangfireDashboard", new DashboardOptions
            {
                Authorization = new[] {
                new AuthorizationHangfireFiler()
            }

            });
            //var jobId = BackgroundJob.Enqueue(() => Console.WriteLine(" Запустить и забыть!"));

            RecurringJob.AddOrUpdate(
       () => SendEmail.SendMail("Hello group", "zaietsmikola.21@gmail.com", "cuanid236316@gmail.com"),
       Cron.Minutely()); 

            app.UseHangfireServer();
        }
    }
}
