﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMRadioUI
{
    public partial class Form1 : Form
    {
        int savedVolume = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void trbVolume_ValueChanged(object sender, EventArgs e)
        {
            lblVol.Text = trbVolume.Value.ToString();
        }

        private void chbMute_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMute.Checked)
            {
                savedVolume = trbVolume.Value;
                trbVolume.Value = 0;
            }
            else
            {
                trbVolume.Value = savedVolume;
            }
            trbVolume.Enabled = !chbMute.Checked;
        }

        private void rbPre1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                udFreq.Value = Convert.ToDecimal(rb.Text);
                udFreq.Enabled = false;
            }
        }

        private void rbPre2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                udFreq.Value = Convert.ToDecimal(rb.Text);
                udFreq.Enabled = false;
            }

        }

        private void rbPre3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                udFreq.Value = Convert.ToDecimal(rb.Text);
                udFreq.Enabled = false;
            }

        }

        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
               udFreq.Enabled = true;
            }


        }
    }
}
