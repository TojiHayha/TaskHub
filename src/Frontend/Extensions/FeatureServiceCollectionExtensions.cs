using MudBlazor.Services;

namespace TaskHub.Extensions;

internal static class FeatureServiceCollectionExtensions
{
    public static IServiceCollection AddFeatures(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMudServices(); // Necessário para MudCheckBox, Dialogs, Snackbar, etc.


        // ==============================
        // Configurações (exemplo)
        // ==============================
        // services.AddSingleton(configuration.GetSection("FileUpload").Get<FileUploadConfig>()!);


        // ==============================
        // Features da aplicação
        // ==============================
        services
        .AddBusinessServices()
        .AddValidators();


        return services;
    }


    // =====================================================
    // VALIDATORS
    // =====================================================
    private static IServiceCollection AddValidators(this IServiceCollection services)
    {
        // Exemplos — crie essas classes quando precisar
        // services.AddScoped<TodoItemFormValidator>();
        // services.AddScoped<TaskFormValidator>();
        // services.AddScoped<UserSettingsValidator>();


        return services;
    }


    // =====================================================
    // BUSINESS / DOMAIN SERVICES
    // =====================================================
    private static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        // Exemplos de services de domínio
        // services.AddScoped<TodoService>();
        // services.AddScoped<TaskService>();
        // services.AddScoped<NotificationService>();


        return services;
    }
}
