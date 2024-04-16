namespace Connect4
{
    partial class Intro
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
            this.label1 = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.ButtonContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Theme";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(105, 131);
            this.LabelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(64, 25);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "Name";
            // 
            // ButtonContinue
            // 
            this.ButtonContinue.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ButtonContinue.Font = new System.Drawing.Font("Sitka Banner", 8.142857F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonContinue.Location = new System.Drawing.Point(415, 390);
            this.ButtonContinue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ButtonContinue.Name = "ButtonContinue";
            this.ButtonContinue.Size = new System.Drawing.Size(209, 48);
            this.ButtonContinue.TabIndex = 4;
            this.ButtonContinue.Text = "Continue";
            this.ButtonContinue.UseVisualStyleBackColor = false;
            this.ButtonContinue.Click += new System.EventHandler(this.ButtonContinue_Click);
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(691, 502);
            this.Controls.Add(this.ButtonContinue);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Intro";
            this.Text = "Settings ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Button ButtonContinue;
    }
}