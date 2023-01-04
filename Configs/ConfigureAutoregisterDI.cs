

using NetCore.AutoRegisterDi;

public static partial class ServiceInitializer {
    public static IServiceCollection ConfigureAutoregisterDI(this IServiceCollection services) {
        services.RegisterAssemblyPublicNonGenericClasses()
            .AsPublicImplementedInterfaces();
        return services;
    }
}