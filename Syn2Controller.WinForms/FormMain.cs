namespace Syn2Controller.WinForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            var devices = Midi.GetDevices();
            DevicesCombo.Items.AddRange(devices.Select(device => device.Value).ToArray());
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

        private void SwaggerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void DevicesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Midi.SetMidiDevice(DevicesCombo.SelectedIndex);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Midi.DisposeDevice();
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            CheckDevice();
        }

        private void FormMain_LocationChanged(object sender, EventArgs e)
        {
            CheckDevice();
        }

        private void CheckDevice()
        {
            if (DevicesCombo.SelectedIndex != Midi.DeviceIndex)
            {
                DevicesCombo.SelectedIndex = Midi.DeviceIndex;
            }
        }
    }
}