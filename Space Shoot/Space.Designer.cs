namespace Space_Shoot
{
    partial class Space
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Space));
            this.MoveBgroundTimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.Leftmovetimer = new System.Windows.Forms.Timer(this.components);
            this.Rightmovetime = new System.Windows.Forms.Timer(this.components);
            this.Upmovetimer = new System.Windows.Forms.Timer(this.components);
            this.Downmovetimer = new System.Windows.Forms.Timer(this.components);
            this.Movemunitiontimer = new System.Windows.Forms.Timer(this.components);
            this.Movenemiestimer = new System.Windows.Forms.Timer(this.components);
            this.Enemiesmunitiontimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Replaybtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.scorelbl = new System.Windows.Forms.Label();
            this.levellbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBgroundTimer
            // 
            this.MoveBgroundTimer.Enabled = true;
            this.MoveBgroundTimer.Interval = 10;
            this.MoveBgroundTimer.Tick += new System.EventHandler(this.MoveBgroundTimer_Tick);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(260, 400);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 50);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // Leftmovetimer
            // 
            this.Leftmovetimer.Interval = 5;
            this.Leftmovetimer.Tick += new System.EventHandler(this.Leftmovetimer_Tick);
            // 
            // Rightmovetime
            // 
            this.Rightmovetime.Interval = 5;
            this.Rightmovetime.Tick += new System.EventHandler(this.Rightmovetime_Tick);
            // 
            // Upmovetimer
            // 
            this.Upmovetimer.Interval = 5;
            this.Upmovetimer.Tick += new System.EventHandler(this.Upmovetimer_Tick);
            // 
            // Downmovetimer
            // 
            this.Downmovetimer.Interval = 5;
            this.Downmovetimer.Tick += new System.EventHandler(this.Downmovetimer_Tick);
            // 
            // Movemunitiontimer
            // 
            this.Movemunitiontimer.Enabled = true;
            this.Movemunitiontimer.Interval = 20;
            this.Movemunitiontimer.Tick += new System.EventHandler(this.Movemunitiontimer_Tick);
            // 
            // Movenemiestimer
            // 
            this.Movenemiestimer.Enabled = true;
            this.Movenemiestimer.Tick += new System.EventHandler(this.Movenemiestimer_Tick);
            // 
            // Enemiesmunitiontimer
            // 
            this.Enemiesmunitiontimer.Enabled = true;
            this.Enemiesmunitiontimer.Interval = 20;
            this.Enemiesmunitiontimer.Tick += new System.EventHandler(this.Enemiesmunitiontimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 57.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(160, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 93);
            this.label1.TabIndex = 1;
            this.label1.Text = "label 1";
            this.label1.Visible = false;
            // 
            // Replaybtn
            // 
            this.Replaybtn.Location = new System.Drawing.Point(192, 244);
            this.Replaybtn.Name = "Replaybtn";
            this.Replaybtn.Size = new System.Drawing.Size(193, 48);
            this.Replaybtn.TabIndex = 2;
            this.Replaybtn.Text = "REPLAY";
            this.Replaybtn.UseVisualStyleBackColor = true;
            this.Replaybtn.Visible = false;
            this.Replaybtn.Click += new System.EventHandler(this.Replaybtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(192, 330);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(193, 47);
            this.Exitbtn.TabIndex = 3;
            this.Exitbtn.Text = "EXIT";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Visible = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.BackColor = System.Drawing.Color.Transparent;
            this.scorelbl.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelbl.ForeColor = System.Drawing.Color.Yellow;
            this.scorelbl.Location = new System.Drawing.Point(92, 9);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(0, 26);
            this.scorelbl.TabIndex = 4;
            this.scorelbl.Click += new System.EventHandler(this.scorelbl_Click);
            // 
            // levellbl
            // 
            this.levellbl.AutoSize = true;
            this.levellbl.BackColor = System.Drawing.Color.Transparent;
            this.levellbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.levellbl.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levellbl.ForeColor = System.Drawing.Color.Yellow;
            this.levellbl.Location = new System.Drawing.Point(533, 9);
            this.levellbl.Name = "levellbl";
            this.levellbl.Size = new System.Drawing.Size(23, 26);
            this.levellbl.TabIndex = 5;
            this.levellbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "SCORE :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(463, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "LEVEL :";
            // 
            // Space
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.levellbl);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Replaybtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.Name = "Space";
            this.Text = "Space Shoot";
            this.Load += new System.EventHandler(this.Space_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Space_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Space_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MoveBgroundTimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer Leftmovetimer;
        private System.Windows.Forms.Timer Rightmovetime;
        private System.Windows.Forms.Timer Upmovetimer;
        private System.Windows.Forms.Timer Downmovetimer;
        private System.Windows.Forms.Timer Movemunitiontimer;
        private System.Windows.Forms.Timer Movenemiestimer;
        private System.Windows.Forms.Timer Enemiesmunitiontimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Replaybtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Label levellbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

