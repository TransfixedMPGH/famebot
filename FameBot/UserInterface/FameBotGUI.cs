﻿using FameBot.Core;
using FameBot.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FameBot.UserInterface
{
    public partial class FameBotGUI : Form
    {
        public FameBotGUI()
        {
            InitializeComponent();

            FormClosed += (s, e) =>
            {
                Plugin.GuiEventCallback(GuiEvent.GuiClosed);
            };
        }
        
        private void onButton_Click(object sender, EventArgs e)
        {
            Plugin.GuiEventCallback(GuiEvent.StartBot);
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            Plugin.GuiEventCallback(GuiEvent.StopBot);
        }

        private void windowOnTopBox_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = windowOnTopBox.Checked;
        }

        private void showHealthBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HealthBarGUI healthBarGUI = new HealthBarGUI();
            healthBarGUI.Show();
        }

        private void showKeyPressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeyPressGUI keyPressGUI = new KeyPressGUI();
            keyPressGUI.Show();
        }

        private void openConfigManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsGUI settingsGUI = new SettingsGUI();
            settingsGUI.Show();
        }
    }
}
