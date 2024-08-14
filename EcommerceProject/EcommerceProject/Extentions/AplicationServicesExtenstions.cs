namespace EcommerceProject.Extentions
{
    public static class AplicationServicesExtenstions
    {
        public static IServiceCollection AddAplicationServices(this IServiceCollection services)
        {
           /* services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IInvoiceService, InvoiceService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IUserWithRoleService, UserWithRoleService>();

            services.AddAutoMapper(typeof(ProductProfile));
            services.AddAutoMapper(typeof(CustomerProfile));
            services.AddAutoMapper(typeof(OrderProfile));
            services.AddAutoMapper(typeof(InvoiceService));*/
            return services;
        }
    }
}
