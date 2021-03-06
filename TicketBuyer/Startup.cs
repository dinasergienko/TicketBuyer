using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using TicketBuyer.BusinessLogicLayer.Interfaces;
using TicketBuyer.BusinessLogicLayer.Services;
using TicketBuyer.DataAccessLayer;
using TicketBuyer.DataAccessLayer.Entities;
using TicketBuyer.DataAccessLayer.Interfaces;
using TicketBuyer.DataAccessLayer.Repositories;

namespace TicketBuyer
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;  
            }).AddCookie();

            services.AddMvc();

            services.AddScoped<IRepository<EventComment>, EventCommentRepository>();
            services.AddScoped<IRepository<EventPhoto>, EventPhotoRepository>();
            services.AddScoped<IRepository<Event>, EventRepository>();
            services.AddScoped<IRepository<Order>, OrderRepository>();
            services.AddScoped<IRepository<Payment>, PaymentRepository>();
            services.AddScoped<IRepository<PlacePhoto>, PlacePhotoRepository>();
            services.AddScoped<IRepository<Place>, PlaceRepository>();
            services.AddScoped<IRepository<Seating>, SeatingRepository>();
            services.AddScoped<IRepository<Sector>, SectorRepository>();
            services.AddScoped<IRepository<Ticket>, TicketRepository>();
            services.AddScoped<IRepository<Price>, PriceRepository>();
            services.AddScoped<IRepository<WishEvent>, WishEventRepository>();
            services.AddScoped<IRepository<User>, UserRepository>();
            services.AddScoped<IRepository<EventType>, EventTypeRepository>();
            services.AddScoped<IRepository<EventStatus>, EventStatusRepository>();
            services.AddScoped<IRepository<OrderStatus>, OrderStatusRepository>();
            services.AddScoped<IRepository<Auth>, AuthRepository>();
            services.AddScoped<IRepository<SectorType>, SectorTypeRepository>();
            services.AddScoped<IRepository<CompanyNews>, CompanyNewsRepository>();
            services.AddScoped<IRepository<EventNews>, EventNewsRepository>();
            services.AddScoped<IRepository<SalePlace>, SalePlaceRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ITypeService, TypeService>();
            services.AddScoped<IEventCommentService, EventCommentService>();
            services.AddScoped<IEventSectorsService, EventSectorsService>();
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IPlaceService, PlaceService>();
            //services.AddScoped<IPriceService, PriceService>();
            //services.AddScoped<ISectorService, SectorService>();
            services.AddScoped<ITicketService, TicketService>();
            services.AddScoped<IWishEventService, WishEventService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAboutService, AboutService>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseAuthentication();
            
            app.UseMvc(routes =>
                  {
                      routes.MapRoute(
                          name: "default",
                          template: "{controller=Home}/{action=Index}/{id?}");
                      routes.MapSpaFallbackRoute(
                          name: "spa-fallback",
                          defaults: new { controller = "Home", action = "Index" });
                  });
        }
    }
}
