using Syn2Controller.Windows.Properties;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Syn2Controller.Windows
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var savedDevice = Settings.Default.Device;

            var devices = Midi.GetDevices().Select(d => d.Value).ToArray();
            DevicesCombo.Items.AddRange(devices);

            if (devices.Contains(savedDevice))
            {
                DevicesCombo.SelectedIndex = Array.IndexOf(devices, savedDevice);
            }
        }

        private void Channel1AButton_Click(object sender, EventArgs e)
        {
            Midi.SendCommand(56);
        }

        private void Channel1BButton_Click(object sender, EventArgs e)
        {
            Midi.SendCommand(57);
        }

        private void Channel2AButton_Click(object sender, EventArgs e)
        {
            Midi.SendCommand(58);
        }

        private void Channel2BButton_Click(object sender, EventArgs e)
        {
            Midi.SendCommand(59);
        }

        private void BypassButton_Click(object sender, EventArgs e)
        {
            Midi.SendCommand(60);
        }

        private void MuteButton_Click(object sender, EventArgs e)
        {
            Midi.SendCommand(64);
        }

        private void DevicesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Midi.SetMidiDevice(DevicesCombo.SelectedIndex);

            if (Settings.Default.Device != DevicesCombo.Text)
            {
                Settings.Default.Device = DevicesCombo.Text;
                Settings.Default.Save();
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Midi.DisposeDevice();
        }

    }
}
