namespace Drummers_metronome_Windows
{
    partial class CounterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMeasure = new System.Windows.Forms.Label();
            this.lblBeat = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Time";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Location = new System.Drawing.Point(5, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 57);
            this.panel2.TabIndex = 30;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Black;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Cyan;
            this.lblTime.Location = new System.Drawing.Point(59, 3);
            this.lblTime.Name = "lblTime";
            this.lblTime.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblTime.Size = new System.Drawing.Size(106, 56);
            this.lblTime.TabIndex = 23;
            this.lblTime.Text = "0:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Beat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Measure";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblMeasure);
            this.panel1.Controls.Add(this.lblBeat);
            this.panel1.Location = new System.Drawing.Point(5, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 64);
            this.panel1.TabIndex = 28;
            // 
            // lblMeasure
            // 
            this.lblMeasure.AutoSize = true;
            this.lblMeasure.BackColor = System.Drawing.Color.Black;
            this.lblMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeasure.ForeColor = System.Drawing.Color.Cyan;
            this.lblMeasure.Location = new System.Drawing.Point(0, 8);
            this.lblMeasure.Name = "lblMeasure";
            this.lblMeasure.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblMeasure.Size = new System.Drawing.Size(46, 56);
            this.lblMeasure.TabIndex = 7;
            this.lblMeasure.Text = "0";
            this.lblMeasure.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBeat
            // 
            this.lblBeat.BackColor = System.Drawing.Color.Black;
            this.lblBeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeat.ForeColor = System.Drawing.Color.Cyan;
            this.lblBeat.Location = new System.Drawing.Point(86, 8);
            this.lblBeat.Name = "lblBeat";
            this.lblBeat.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblBeat.Size = new System.Drawing.Size(79, 56);
            this.lblBeat.TabIndex = 11;
            this.lblBeat.Text = "0";
            this.lblBeat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CounterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "CounterControl";
            this.Size = new System.Drawing.Size(176, 169);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMeasure;
        private System.Windows.Forms.Label lblBeat;
    }
}
