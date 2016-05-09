namespace FMRadioUI
{
    partial class Form1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chbMute = new System.Windows.Forms.CheckBox();
            this.rbPre1 = new System.Windows.Forms.RadioButton();
            this.rbPre2 = new System.Windows.Forms.RadioButton();
            this.rbPre3 = new System.Windows.Forms.RadioButton();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.trbVolume = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVol = new System.Windows.Forms.Label();
            this.udFreq = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreq)).BeginInit();
            this.SuspendLayout();
            // 
            // chbMute
            // 
            this.chbMute.AutoSize = true;
            this.chbMute.Location = new System.Drawing.Point(344, 303);
            this.chbMute.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chbMute.Name = "chbMute";
            this.chbMute.Size = new System.Drawing.Size(95, 26);
            this.chbMute.TabIndex = 0;
            this.chbMute.Text = "Ton aus";
            this.chbMute.UseVisualStyleBackColor = true;
            this.chbMute.CheckedChanged += new System.EventHandler(this.chbMute_CheckedChanged);
            // 
            // rbPre1
            // 
            this.rbPre1.AutoSize = true;
            this.rbPre1.Location = new System.Drawing.Point(44, 64);
            this.rbPre1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbPre1.Name = "rbPre1";
            this.rbPre1.Size = new System.Drawing.Size(77, 26);
            this.rbPre1.TabIndex = 1;
            this.rbPre1.Text = "92,05";
            this.rbPre1.UseVisualStyleBackColor = true;
            this.rbPre1.CheckedChanged += new System.EventHandler(this.rbPre1_CheckedChanged);
            // 
            // rbPre2
            // 
            this.rbPre2.AutoSize = true;
            this.rbPre2.Location = new System.Drawing.Point(44, 100);
            this.rbPre2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbPre2.Name = "rbPre2";
            this.rbPre2.Size = new System.Drawing.Size(77, 26);
            this.rbPre2.TabIndex = 2;
            this.rbPre2.Text = "89,75";
            this.rbPre2.UseVisualStyleBackColor = true;
            this.rbPre2.CheckedChanged += new System.EventHandler(this.rbPre2_CheckedChanged);
            // 
            // rbPre3
            // 
            this.rbPre3.AutoSize = true;
            this.rbPre3.Location = new System.Drawing.Point(44, 136);
            this.rbPre3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbPre3.Name = "rbPre3";
            this.rbPre3.Size = new System.Drawing.Size(77, 26);
            this.rbPre3.TabIndex = 3;
            this.rbPre3.Text = "104,0";
            this.rbPre3.UseVisualStyleBackColor = true;
            this.rbPre3.CheckedChanged += new System.EventHandler(this.rbPre3_CheckedChanged);
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Checked = true;
            this.rbManual.Location = new System.Drawing.Point(44, 172);
            this.rbManual.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(93, 26);
            this.rbManual.TabIndex = 4;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "manuell";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.rbManual_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Frequenz";
            // 
            // trbVolume
            // 
            this.trbVolume.Location = new System.Drawing.Point(92, 257);
            this.trbVolume.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.trbVolume.Maximum = 20;
            this.trbVolume.Name = "trbVolume";
            this.trbVolume.Size = new System.Drawing.Size(347, 45);
            this.trbVolume.TabIndex = 7;
            this.trbVolume.ValueChanged += new System.EventHandler(this.trbVolume_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 307);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lautstärke";
            // 
            // lblVol
            // 
            this.lblVol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVol.Location = new System.Drawing.Point(466, 241);
            this.lblVol.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(73, 61);
            this.lblVol.TabIndex = 10;
            this.lblVol.Text = "0";
            this.lblVol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // udFreq
            // 
            this.udFreq.DecimalPlaces = 2;
            this.udFreq.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.udFreq.Location = new System.Drawing.Point(417, 113);
            this.udFreq.Maximum = new decimal(new int[] {
            108,
            0,
            0,
            0});
            this.udFreq.Minimum = new decimal(new int[] {
            87,
            0,
            0,
            0});
            this.udFreq.Name = "udFreq";
            this.udFreq.Size = new System.Drawing.Size(120, 29);
            this.udFreq.TabIndex = 11;
            this.udFreq.Value = new decimal(new int[] {
            97,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 387);
            this.Controls.Add(this.udFreq);
            this.Controls.Add(this.lblVol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trbVolume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbManual);
            this.Controls.Add(this.rbPre3);
            this.Controls.Add(this.rbPre2);
            this.Controls.Add(this.rbPre1);
            this.Controls.Add(this.chbMute);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFreq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbMute;
        private System.Windows.Forms.RadioButton rbPre1;
        private System.Windows.Forms.RadioButton rbPre2;
        private System.Windows.Forms.RadioButton rbPre3;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trbVolume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVol;
        private System.Windows.Forms.NumericUpDown udFreq;
    }
}

