using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Syn2Controller.WinForms.Web;

internal static class WebApp
{
    public static WebApplication Build()
    {
        var builder = WebApplication.CreateBuilder(new[] { "--urls", "http://localhost:5050;http://0.0.0.0:5050" });

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddRouting(options =>
            options.ConstraintMap.Add("channel", typeof(ChannelRouteConstraint)));

        var app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI();

        app.MapSyn2Endpoints();

        return app;
    }
}
