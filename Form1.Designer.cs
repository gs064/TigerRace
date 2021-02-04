
namespace TigerRace
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
            this.Track = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SahibBet = new System.Windows.Forms.Label();
            this.AngrejBet = new System.Windows.Forms.Label();
            this.GurpartapBet = new System.Windows.Forms.Label();
            this.BetDetails = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.TigerNumber = new System.Windows.Forms.NumericUpDown();
            this.Tigerno = new System.Windows.Forms.Label();
            this.BettingAmount = new System.Windows.Forms.NumericUpDown();
            this.PlaceBet = new System.Windows.Forms.Button();
            this.btnSahib = new System.Windows.Forms.RadioButton();
            this.btnAngrej = new System.Windows.Forms.RadioButton();
            this.btnGurPartap = new System.Windows.Forms.RadioButton();
            this.MaximumBet = new System.Windows.Forms.Label();
            this.Tiger4 = new System.Windows.Forms.PictureBox();
            this.Tiger3 = new System.Windows.Forms.PictureBox();
            this.Tiger2 = new System.Windows.Forms.PictureBox();
            this.Tiger1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Track)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TigerNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tiger4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tiger3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tiger2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tiger1)).BeginInit();
            this.SuspendLayout();
            // 
            // Track
            // 
            this.Track.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Track.Location = new System.Drawing.Point(134, 14);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(802, 264);
            this.Track.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Track.TabIndex = 1;
            this.Track.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SahibBet);
            this.groupBox1.Controls.Add(this.AngrejBet);
            this.groupBox1.Controls.Add(this.GurpartapBet);
            this.groupBox1.Controls.Add(this.BetDetails);
            this.groupBox1.Controls.Add(this.Start);
            this.groupBox1.Controls.Add(this.TigerNumber);
            this.groupBox1.Controls.Add(this.Tigerno);
            this.groupBox1.Controls.Add(this.BettingAmount);
            this.groupBox1.Controls.Add(this.PlaceBet);
            this.groupBox1.Controls.Add(this.btnSahib);
            this.groupBox1.Controls.Add(this.btnAngrej);
            this.groupBox1.Controls.Add(this.btnGurPartap);
            this.groupBox1.Controls.Add(this.MaximumBet);
            this.groupBox1.Location = new System.Drawing.Point(37, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 190);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "$";
            // 
            // SahibBet
            // 
            this.SahibBet.BackColor = System.Drawing.SystemColors.Info;
            this.SahibBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SahibBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SahibBet.Location = new System.Drawing.Point(487, 129);
            this.SahibBet.Name = "SahibBet";
            this.SahibBet.Size = new System.Drawing.Size(317, 35);
            this.SahibBet.TabIndex = 13;
            this.SahibBet.Text = "Please Place The Bet ";
            this.SahibBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AngrejBet
            // 
            this.AngrejBet.BackColor = System.Drawing.SystemColors.Info;
            this.AngrejBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AngrejBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AngrejBet.Location = new System.Drawing.Point(487, 82);
            this.AngrejBet.Name = "AngrejBet";
            this.AngrejBet.Size = new System.Drawing.Size(317, 33);
            this.AngrejBet.TabIndex = 12;
            this.AngrejBet.Text = "Please Place The Bet ";
            this.AngrejBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GurpartapBet
            // 
            this.GurpartapBet.BackColor = System.Drawing.SystemColors.Info;
            this.GurpartapBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GurpartapBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GurpartapBet.Location = new System.Drawing.Point(487, 38);
            this.GurpartapBet.Name = "GurpartapBet";
            this.GurpartapBet.Size = new System.Drawing.Size(317, 35);
            this.GurpartapBet.TabIndex = 11;
            this.GurpartapBet.Text = "Please Place The Bet ";
            this.GurpartapBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GurpartapBet.Click += new System.EventHandler(this.GurpartapBet_Click);
            // 
            // BetDetails
            // 
            this.BetDetails.AutoSize = true;
            this.BetDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetDetails.Location = new System.Drawing.Point(484, 16);
            this.BetDetails.Name = "BetDetails";
            this.BetDetails.Size = new System.Drawing.Size(40, 17);
            this.BetDetails.TabIndex = 10;
            this.BetDetails.Text = "Bets";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.White;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(251, 148);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(150, 42);
            this.Start.TabIndex = 9;
            this.Start.Text = "START";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // TigerNumber
            // 
            this.TigerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TigerNumber.Location = new System.Drawing.Point(355, 110);
            this.TigerNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.TigerNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TigerNumber.Name = "TigerNumber";
            this.TigerNumber.Size = new System.Drawing.Size(64, 22);
            this.TigerNumber.TabIndex = 8;
            this.TigerNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Tigerno
            // 
            this.Tigerno.AutoSize = true;
            this.Tigerno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tigerno.Location = new System.Drawing.Point(239, 116);
            this.Tigerno.Name = "Tigerno";
            this.Tigerno.Size = new System.Drawing.Size(100, 16);
            this.Tigerno.TabIndex = 7;
            this.Tigerno.Text = "Tiger number";
            // 
            // BettingAmount
            // 
            this.BettingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BettingAmount.Location = new System.Drawing.Point(355, 53);
            this.BettingAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.BettingAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BettingAmount.Name = "BettingAmount";
            this.BettingAmount.Size = new System.Drawing.Size(63, 22);
            this.BettingAmount.TabIndex = 6;
            this.BettingAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PlaceBet
            // 
            this.PlaceBet.BackColor = System.Drawing.Color.White;
            this.PlaceBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceBet.Location = new System.Drawing.Point(197, 53);
            this.PlaceBet.Name = "PlaceBet";
            this.PlaceBet.Size = new System.Drawing.Size(84, 36);
            this.PlaceBet.TabIndex = 5;
            this.PlaceBet.Text = "Place Bet";
            this.PlaceBet.UseVisualStyleBackColor = false;
            this.PlaceBet.Click += new System.EventHandler(this.PlaceBet_Click);
            // 
            // btnSahib
            // 
            this.btnSahib.AutoSize = true;
            this.btnSahib.Checked = true;
            this.btnSahib.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSahib.Location = new System.Drawing.Point(19, 142);
            this.btnSahib.Name = "btnSahib";
            this.btnSahib.Size = new System.Drawing.Size(68, 22);
            this.btnSahib.TabIndex = 3;
            this.btnSahib.TabStop = true;
            this.btnSahib.Text = "Sahib";
            this.btnSahib.UseVisualStyleBackColor = true;
            this.btnSahib.CheckedChanged += new System.EventHandler(this.btnSahib_CheckedChanged);
            // 
            // btnAngrej
            // 
            this.btnAngrej.AutoSize = true;
            this.btnAngrej.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAngrej.Location = new System.Drawing.Point(19, 93);
            this.btnAngrej.Name = "btnAngrej";
            this.btnAngrej.Size = new System.Drawing.Size(73, 22);
            this.btnAngrej.TabIndex = 2;
            this.btnAngrej.Text = "Angrej";
            this.btnAngrej.UseVisualStyleBackColor = true;
            this.btnAngrej.CheckedChanged += new System.EventHandler(this.btnAngrej_CheckedChanged);
            // 
            // btnGurPartap
            // 
            this.btnGurPartap.AutoSize = true;
            this.btnGurPartap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGurPartap.Location = new System.Drawing.Point(14, 49);
            this.btnGurPartap.Name = "btnGurPartap";
            this.btnGurPartap.Size = new System.Drawing.Size(101, 22);
            this.btnGurPartap.TabIndex = 1;
            this.btnGurPartap.Text = "Gurpartap";
            this.btnGurPartap.UseVisualStyleBackColor = true;
            this.btnGurPartap.CheckedChanged += new System.EventHandler(this.btnGurPartap_CheckedChanged);
            // 
            // MaximumBet
            // 
            this.MaximumBet.AutoSize = true;
            this.MaximumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumBet.Location = new System.Drawing.Point(11, 24);
            this.MaximumBet.Name = "MaximumBet";
            this.MaximumBet.Size = new System.Drawing.Size(101, 17);
            this.MaximumBet.TabIndex = 0;
            this.MaximumBet.Text = "Maximum bet";
            // 
            // Tiger4
            // 
            this.Tiger4.BackColor = System.Drawing.Color.Transparent;
            this.Tiger4.Image = global::TigerRace.Properties.Resources.tiger3;
            this.Tiger4.Location = new System.Drawing.Point(138, 224);
            this.Tiger4.Name = "Tiger4";
            this.Tiger4.Size = new System.Drawing.Size(77, 43);
            this.Tiger4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tiger4.TabIndex = 10;
            this.Tiger4.TabStop = false;
            // 
            // Tiger3
            // 
            this.Tiger3.BackColor = System.Drawing.Color.Transparent;
            this.Tiger3.Image = global::TigerRace.Properties.Resources.tiger2;
            this.Tiger3.Location = new System.Drawing.Point(138, 150);
            this.Tiger3.Name = "Tiger3";
            this.Tiger3.Size = new System.Drawing.Size(77, 44);
            this.Tiger3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tiger3.TabIndex = 9;
            this.Tiger3.TabStop = false;
            // 
            // Tiger2
            // 
            this.Tiger2.BackColor = System.Drawing.Color.Transparent;
            this.Tiger2.Image = global::TigerRace.Properties.Resources.tiger1;
            this.Tiger2.Location = new System.Drawing.Point(138, 85);
            this.Tiger2.Name = "Tiger2";
            this.Tiger2.Size = new System.Drawing.Size(78, 46);
            this.Tiger2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tiger2.TabIndex = 8;
            this.Tiger2.TabStop = false;
            // 
            // Tiger1
            // 
            this.Tiger1.BackColor = System.Drawing.Color.Transparent;
            this.Tiger1.Image = global::TigerRace.Properties.Resources.tiger;
            this.Tiger1.Location = new System.Drawing.Point(134, 14);
            this.Tiger1.Name = "Tiger1";
            this.Tiger1.Size = new System.Drawing.Size(81, 47);
            this.Tiger1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tiger1.TabIndex = 7;
            this.Tiger1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(95, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "3";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(92, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 36);
            this.button2.TabIndex = 16;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(92, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 36);
            this.button3.TabIndex = 17;
            this.button3.Text = "1";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(95, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 36);
            this.button4.TabIndex = 18;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(910, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 266);
            this.button5.TabIndex = 19;
            this.button5.Text = "Finish";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 505);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Tiger4);
            this.Controls.Add(this.Tiger3);
            this.Controls.Add(this.Tiger2);
            this.Controls.Add(this.Tiger1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Track);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Track)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TigerNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tiger4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tiger3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tiger2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tiger1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Track;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SahibBet;
        private System.Windows.Forms.Label AngrejBet;
        private System.Windows.Forms.Label GurpartapBet;
        private System.Windows.Forms.Label BetDetails;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.NumericUpDown TigerNumber;
        private System.Windows.Forms.Label Tigerno;
        private System.Windows.Forms.NumericUpDown BettingAmount;
        private System.Windows.Forms.Button PlaceBet;
        private System.Windows.Forms.RadioButton btnSahib;
        private System.Windows.Forms.RadioButton btnAngrej;
        private System.Windows.Forms.RadioButton btnGurPartap;
        private System.Windows.Forms.Label MaximumBet;
        private System.Windows.Forms.PictureBox Tiger4;
        private System.Windows.Forms.PictureBox Tiger3;
        private System.Windows.Forms.PictureBox Tiger2;
        private System.Windows.Forms.PictureBox Tiger1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

