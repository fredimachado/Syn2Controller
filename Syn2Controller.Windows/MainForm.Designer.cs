using System.Windows.Forms;

namespace Syn2Controller.Windows
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.MuteButton = new System.Windows.Forms.Button();
            this.BypassButton = new System.Windows.Forms.Button();
            this.Channel2BButton = new System.Windows.Forms.Button();
            this.Channel2AButton = new System.Windows.Forms.Button();
            this.Channel1BButton = new System.Windows.Forms.Button();
            this.Channel1AButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DevicesCombo = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.linkLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.MuteButton, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.BypassButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.Channel2BButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Channel2AButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Channel1BButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Channel1AButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DevicesCombo, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(63, 32, 63, 56);
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 724);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel.Location = new System.Drawing.Point(66, 646);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.linkLabel.Size = new System.Drawing.Size(316, 40);
            this.linkLabel.TabIndex = 2;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "github.com/fredimachado/Syn2Controller";
            this.linkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MuteButton
            // 
            this.MuteButton.BackColor = System.Drawing.Color.Black;
            this.MuteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MuteButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.MuteButton.ForeColor = System.Drawing.Color.White;
            this.MuteButton.Location = new System.Drawing.Point(66, 572);
            this.MuteButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.MuteButton.Name = "MuteButton";
            this.MuteButton.Size = new System.Drawing.Size(316, 64);
            this.MuteButton.TabIndex = 7;
            this.MuteButton.Text = "Mute";
            this.MuteButton.UseVisualStyleBackColor = false;
            this.MuteButton.Click += new System.EventHandler(this.MuteButton_Click);
            // 
            // BypassButton
            // 
            this.BypassButton.BackColor = System.Drawing.Color.Black;
            this.BypassButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BypassButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BypassButton.ForeColor = System.Drawing.Color.White;
            this.BypassButton.Location = new System.Drawing.Point(66, 488);
            this.BypassButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.BypassButton.Name = "BypassButton";
            this.BypassButton.Size = new System.Drawing.Size(316, 64);
            this.BypassButton.TabIndex = 6;
            this.BypassButton.Text = "Bypass";
            this.BypassButton.UseVisualStyleBackColor = false;
            this.BypassButton.Click += new System.EventHandler(this.BypassButton_Click);
            // 
            // Channel2BButton
            // 
            this.Channel2BButton.BackColor = System.Drawing.Color.Black;
            this.Channel2BButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Channel2BButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Channel2BButton.ForeColor = System.Drawing.Color.White;
            this.Channel2BButton.Location = new System.Drawing.Point(66, 404);
            this.Channel2BButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.Channel2BButton.Name = "Channel2BButton";
            this.Channel2BButton.Size = new System.Drawing.Size(316, 64);
            this.Channel2BButton.TabIndex = 5;
            this.Channel2BButton.Text = "Channel 2B";
            this.Channel2BButton.UseVisualStyleBackColor = false;
            this.Channel2BButton.Click += new System.EventHandler(this.Channel2BButton_Click);
            // 
            // Channel2AButton
            // 
            this.Channel2AButton.BackColor = System.Drawing.Color.Black;
            this.Channel2AButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Channel2AButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Channel2AButton.ForeColor = System.Drawing.Color.White;
            this.Channel2AButton.Location = new System.Drawing.Point(66, 320);
            this.Channel2AButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.Channel2AButton.Name = "Channel2AButton";
            this.Channel2AButton.Size = new System.Drawing.Size(316, 64);
            this.Channel2AButton.TabIndex = 4;
            this.Channel2AButton.Text = "Channel 2A";
            this.Channel2AButton.UseVisualStyleBackColor = false;
            this.Channel2AButton.Click += new System.EventHandler(this.Channel2AButton_Click);
            // 
            // Channel1BButton
            // 
            this.Channel1BButton.BackColor = System.Drawing.Color.Black;
            this.Channel1BButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Channel1BButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Channel1BButton.ForeColor = System.Drawing.Color.White;
            this.Channel1BButton.Location = new System.Drawing.Point(66, 236);
            this.Channel1BButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.Channel1BButton.Name = "Channel1BButton";
            this.Channel1BButton.Size = new System.Drawing.Size(316, 64);
            this.Channel1BButton.TabIndex = 3;
            this.Channel1BButton.Text = "Channel 1B";
            this.Channel1BButton.UseVisualStyleBackColor = false;
            this.Channel1BButton.Click += new System.EventHandler(this.Channel1BButton_Click);
            // 
            // Channel1AButton
            // 
            this.Channel1AButton.BackColor = System.Drawing.Color.Black;
            this.Channel1AButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Channel1AButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Channel1AButton.ForeColor = System.Drawing.Color.White;
            this.Channel1AButton.Location = new System.Drawing.Point(66, 136);
            this.Channel1AButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.Channel1AButton.Name = "Channel1AButton";
            this.Channel1AButton.Size = new System.Drawing.Size(316, 80);
            this.Channel1AButton.TabIndex = 2;
            this.Channel1AButton.Text = "Channel 1A";
            this.Channel1AButton.UseVisualStyleBackColor = false;
            this.Channel1AButton.Click += new System.EventHandler(this.Channel1AButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(66, 32);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label1.Size = new System.Drawing.Size(316, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select MIDI Device:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DevicesCombo
            // 
            this.DevicesCombo.BackColor = System.Drawing.Color.Black;
            this.DevicesCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DevicesCombo.DropDownHeight = 200;
            this.DevicesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DevicesCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DevicesCombo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.DevicesCombo.ForeColor = System.Drawing.Color.White;
            this.DevicesCombo.FormattingEnabled = true;
            this.DevicesCombo.IntegralHeight = false;
            this.DevicesCombo.Location = new System.Drawing.Point(66, 80);
            this.DevicesCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DevicesCombo.Name = "DevicesCombo";
            this.DevicesCombo.Size = new System.Drawing.Size(316, 36);
            this.DevicesCombo.TabIndex = 1;
            this.DevicesCombo.SelectedIndexChanged += new System.EventHandler(this.DevicesCombo_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 724);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 780);
            this.MinimumSize = new System.Drawing.Size(470, 780);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Synergy SYN2 Controller";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button MuteButton;
        private Button BypassButton;
        private Button Channel2BButton;
        private Button Channel2AButton;
        private Button Channel1BButton;
        private Button Channel1AButton;
        private Label label1;
        private LinkLabel linkLabel;
        private ComboBox DevicesCombo;
    }
}

