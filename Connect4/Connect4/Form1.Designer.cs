namespace Connect4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ButtonCollumn1 = new System.Windows.Forms.Button();
            this.ButtonCollomn2 = new System.Windows.Forms.Button();
            this.ButtonColomn3 = new System.Windows.Forms.Button();
            this.ButtonColomn7 = new System.Windows.Forms.Button();
            this.ButtonColomn4 = new System.Windows.Forms.Button();
            this.ButtonColomn6 = new System.Windows.Forms.Button();
            this.ButtonCollomn5 = new System.Windows.Forms.Button();
            this.LabelGameName = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LabelCurrentTurn = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonColumn6 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCollumn1
            // 
            this.ButtonCollumn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonCollumn1.Location = new System.Drawing.Point(71, 75);
            this.ButtonCollumn1.Name = "ButtonCollumn1";
            this.ButtonCollumn1.Size = new System.Drawing.Size(53, 23);
            this.ButtonCollumn1.TabIndex = 0;
            this.ButtonCollumn1.UseVisualStyleBackColor = false;
            this.ButtonCollumn1.Click += new System.EventHandler(this.ButtonCollumn1_Click);
            // 
            // ButtonCollomn2
            // 
            this.ButtonCollomn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonCollomn2.Location = new System.Drawing.Point(182, 77);
            this.ButtonCollomn2.Name = "ButtonCollomn2";
            this.ButtonCollomn2.Size = new System.Drawing.Size(53, 23);
            this.ButtonCollomn2.TabIndex = 1;
            this.ButtonCollomn2.UseVisualStyleBackColor = false;
            this.ButtonCollomn2.Click += new System.EventHandler(this.ButtonCollumn2_Click);
            // 
            // ButtonColomn3
            // 
            this.ButtonColomn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonColomn3.Location = new System.Drawing.Point(302, 77);
            this.ButtonColomn3.Name = "ButtonColomn3";
            this.ButtonColomn3.Size = new System.Drawing.Size(53, 23);
            this.ButtonColomn3.TabIndex = 2;
            this.ButtonColomn3.UseVisualStyleBackColor = false;
            this.ButtonColomn3.Click += new System.EventHandler(this.ButtonColumn3_Click);
            // 
            // ButtonColomn7
            // 
            this.ButtonColomn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonColomn7.Location = new System.Drawing.Point(757, 77);
            this.ButtonColomn7.Name = "ButtonColomn7";
            this.ButtonColomn7.Size = new System.Drawing.Size(53, 23);
            this.ButtonColomn7.TabIndex = 5;
            this.ButtonColomn7.UseVisualStyleBackColor = false;
            this.ButtonColomn7.Click += new System.EventHandler(this.ButtonColumn7_Click);
            // 
            // ButtonColomn4
            // 
            this.ButtonColomn4.Location = new System.Drawing.Point(0, 0);
            this.ButtonColomn4.Name = "ButtonColomn4";
            this.ButtonColomn4.Size = new System.Drawing.Size(75, 23);
            this.ButtonColomn4.TabIndex = 13;
            // 
            // ButtonColomn6
            // 
            this.ButtonColomn6.Location = new System.Drawing.Point(0, 0);
            this.ButtonColomn6.Name = "ButtonColomn6";
            this.ButtonColomn6.Size = new System.Drawing.Size(75, 23);
            this.ButtonColomn6.TabIndex = 11;
            // 
            // ButtonCollomn5
            // 
            this.ButtonCollomn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonCollomn5.Location = new System.Drawing.Point(536, 75);
            this.ButtonCollomn5.Name = "ButtonCollomn5";
            this.ButtonCollomn5.Size = new System.Drawing.Size(53, 23);
            this.ButtonCollomn5.TabIndex = 6;
            this.ButtonCollomn5.UseVisualStyleBackColor = false;
            this.ButtonCollomn5.Click += new System.EventHandler(this.ButtonCollomn5_Click);
            // 
            // LabelGameName
            // 
            this.LabelGameName.AutoSize = true;
            this.LabelGameName.BackColor = System.Drawing.Color.MediumOrchid;
            this.LabelGameName.Font = new System.Drawing.Font("Wide Latin", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGameName.ForeColor = System.Drawing.Color.Blue;
            this.LabelGameName.Location = new System.Drawing.Point(91, 9);
            this.LabelGameName.Name = "LabelGameName";
            this.LabelGameName.Size = new System.Drawing.Size(369, 50);
            this.LabelGameName.TabIndex = 8;
            this.LabelGameName.Text = "Connect 4";
            this.LabelGameName.Click += new System.EventHandler(this.label1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LabelCurrentTurn
            // 
            this.LabelCurrentTurn.AutoSize = true;
            this.LabelCurrentTurn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelCurrentTurn.Font = new System.Drawing.Font("Wide Latin", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCurrentTurn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LabelCurrentTurn.Location = new System.Drawing.Point(899, 77);
            this.LabelCurrentTurn.Name = "LabelCurrentTurn";
            this.LabelCurrentTurn.Size = new System.Drawing.Size(194, 21);
            this.LabelCurrentTurn.TabIndex = 9;
            this.LabelCurrentTurn.Text = "Current Turn";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "SeekPng.com_pacman-sprite-png_3777584.png");
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 130);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(489, 424);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 696);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonColumn6
            // 
            this.ButtonColumn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonColumn6.Location = new System.Drawing.Point(643, 75);
            this.ButtonColumn6.Name = "ButtonColumn6";
            this.ButtonColumn6.Size = new System.Drawing.Size(53, 23);
            this.ButtonColumn6.TabIndex = 12;
            this.ButtonColumn6.UseVisualStyleBackColor = false;
            this.ButtonColumn6.Click += new System.EventHandler(this.ButtonColumn6_Click_1);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Button4.Location = new System.Drawing.Point(408, 78);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(52, 22);
            this.Button4.TabIndex = 14;
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1815, 1013);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.ButtonColumn6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelCurrentTurn);
            this.Controls.Add(this.LabelGameName);
            this.Controls.Add(this.ButtonCollomn5);
            this.Controls.Add(this.ButtonColomn7);
            this.Controls.Add(this.ButtonColomn4);
            this.Controls.Add(this.ButtonColomn6);
            this.Controls.Add(this.ButtonColomn3);
            this.Controls.Add(this.ButtonCollomn2);
            this.Controls.Add(this.ButtonCollumn1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCollumn1;
        private System.Windows.Forms.Button ButtonCollomn2;
        private System.Windows.Forms.Button ButtonColomn3;
        private System.Windows.Forms.Button ButtonColomn7;
        private System.Windows.Forms.Button ButtonColomn4;
        private System.Windows.Forms.Button ButtonColomn6;
        private System.Windows.Forms.Button ButtonCollomn5;
        private System.Windows.Forms.Label LabelGameName;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label LabelCurrentTurn;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonColumn6;
        private System.Windows.Forms.Button Button4;
    }
}

