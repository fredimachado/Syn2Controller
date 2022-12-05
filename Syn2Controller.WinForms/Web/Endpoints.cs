using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using NAudio.Midi;

namespace Syn2Controller.WinForms.Web;

internal static class Endpoints
{
    public static void MapSyn2Endpoints(this WebApplication app)
    {
        app.MapGet("/device", () =>
        {
            var devices = Midi.GetDevices();

            return devices.Select(device => new
            {
                Index = device.Key,
                DeviceName = device.Value,
                Active = device.Key == Midi.DeviceIndex
            });
        })
        .WithName("GetDevices")
        .WithOpenApi();

        app.MapPost("/device/{index}", (int index) =>
        {
            Midi.SetMidiDevice(index);

            return Results.Accepted();
        })
        .WithName("SetDevice")
        .WithOpenApi();

        app.MapPost("/channel/{name:channel}", (string name) =>
        {
            var index = Array.IndexOf(Constants.ChannelNames, name.ToUpper());

            var result = Midi.SendCommand(56 + index);

            return result.Success ? Results.Accepted() : Results.Problem(result.Message);
        })
        .WithName("SetChannel")
        .WithOpenApi();

        app.MapPost("/bypass", () =>
        {
            var result = Midi.SendCommand(60);

            return result.Success ? Results.Accepted() : Results.Problem(result.Message);
        })
        .WithName("SetBypass")
        .WithOpenApi();

        app.MapPost("/mute", () =>
        {
            var result = Midi.SendCommand(64);

            return result.Success ? Results.Accepted() : Results.Problem(result.Message);
        })
        .WithName("SetMute")
        .WithOpenApi();
    }
}
