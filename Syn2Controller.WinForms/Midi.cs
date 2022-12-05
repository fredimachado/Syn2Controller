using NAudio.Midi;

namespace Syn2Controller.WinForms
{
    internal static class Midi
    {
        private static MidiOut? MidiOut;
        public static int DeviceIndex = -1;

        public static Dictionary<int, string> GetDevices()
        {
            var devices = new Dictionary<int, string>();
            for (int index = 0; index < MidiOut.NumberOfDevices; index++)
            {
                devices.Add(index, MidiOut.DeviceInfo(index).ProductName);
            }

            return devices;
        }

        public static void SetMidiDevice(int index)
        {
            if (index == DeviceIndex)
            {
                return;
            }

            DisposeDevice();

            DeviceIndex = index;
            MidiOut = new MidiOut(index);
        }

        public static MidiCommandResult SendCommand(int cc)
        {
            if (MidiOut is null)
            {
                return MidiCommandResult.Error("No MIDI device selected.");
            }

            var ccEvent = new ControlChangeEvent(0, 1, (MidiController)cc, 64);
            MidiOut.Send(ccEvent.GetAsShortMessage());

            return MidiCommandResult.Ok();
        }

        public static void DisposeDevice()
        {
            MidiOut?.Dispose();
        }
    }

    internal class MidiCommandResult
    {
        public bool Success { get; }
        public string Message { get; }

        public MidiCommandResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public static MidiCommandResult Ok() => new MidiCommandResult(true, null!);
        public static MidiCommandResult Error(string message) => new MidiCommandResult(false, message);
    }
}
