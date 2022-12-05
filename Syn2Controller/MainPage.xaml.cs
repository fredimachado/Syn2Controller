using Microsoft.Maui.Animations;
using NAudio.Midi;

namespace Syn2Controller;

public partial class MainPage : ContentPage
{
    private MidiOut midiOut;

    private const string DevicePreference = "Device";
    private const string WidthPreference = "Width";
    private const string HeightPreference = "Height";

    public MainPage()
    {
        InitializeComponent();

        this.Loaded += OnPageLoaded;
    }

    private void OnPageLoaded(object sender, EventArgs e)
    {
        var devicePreference = Preferences.Default.Get(DevicePreference, string.Empty);
        var selectedIndex = -1;

        var devices = new List<string>();
        for (int device = 0; device < MidiOut.NumberOfDevices; device++)
        {
            var deviceName = MidiOut.DeviceInfo(device).ProductName;
            devices.Add(deviceName);

            if (deviceName == devicePreference)
            {
                selectedIndex = device;
            }
        }

        if (devices.Count == 0)
        {
            DisplayAlert("Error", "Could not find a MIDI device.", "OK");
            return;
        }

        midiDevice.ItemsSource = devices;
        midiDevice.SelectedIndex = selectedIndex;

        Window.Destroying += (s, e) =>
        {
            midiOut?.Dispose();

            Preferences.Default.Set(WidthPreference, Window.Width);
            Preferences.Default.Set(HeightPreference, Window.Height);
        };

        SetWindowSize();
    }

    private void SetWindowSize()
    {
        Window.MinimumWidth = 340;
        Window.MaximumWidth = 400;
        Window.MinimumHeight = 600;
        Window.MaximumHeight = 660;

        Window.Width = Preferences.Default.Get(WidthPreference, 400d);
        Window.Height = Preferences.Default.Get(HeightPreference, 660d);
    }

    private void OnChannel1AClicked(object sender, EventArgs e)
    {
        var ccEvent = new ControlChangeEvent(0, 1, (MidiController)56, 64);
        midiOut.Send(ccEvent.GetAsShortMessage());
    }

    private void OnChannel1BClicked(object sender, EventArgs e)
    {
        var ccEvent = new ControlChangeEvent(0, 1, (MidiController)57, 64);
        midiOut.Send(ccEvent.GetAsShortMessage());
    }

    private void OnChannel2AClicked(object sender, EventArgs e)
    {
        var ccEvent = new ControlChangeEvent(0, 1, (MidiController)58, 64);
        midiOut.Send(ccEvent.GetAsShortMessage());
    }

    private void OnChannel2BClicked(object sender, EventArgs e)
    {
        var ccEvent = new ControlChangeEvent(0, 1, (MidiController)59, 64);
        midiOut.Send(ccEvent.GetAsShortMessage());
    }

    private void OnBypassClicked(object sender, EventArgs e)
    {
        var ccEvent = new ControlChangeEvent(0, 1, (MidiController)60, 64);
        midiOut.Send(ccEvent.GetAsShortMessage());
    }

    private void OnMuteClicked(object sender, EventArgs e)
    {
        var ccEvent = new ControlChangeEvent(0, 1, (MidiController)64, 64);
        midiOut.Send(ccEvent.GetAsShortMessage());
    }

    private void midiDevice_SelectedIndexChanged(object sender, EventArgs e)
    {
        midiOut?.Dispose();

        midiOut = new MidiOut(midiDevice.SelectedIndex);

        Preferences.Default.Set(DevicePreference, midiDevice.SelectedItem as string);
    }
}

