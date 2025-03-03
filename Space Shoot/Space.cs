using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Space_Shoot
{
    public partial class Space : Form

    {
        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shootgMedia;
        WindowsMediaPlayer explosion;

        PictureBox[] enemiesmunition;
        int enemiesmunitionSpeed;

        PictureBox[] enemies;
        int enemieSpeed;

        PictureBox[] stars;
        int backgroundspeed;
        int playerspeed;
        PictureBox[] munitions;
        int munitionspeed;

        int score;
        int level;
        int deficulty;
        bool pause;
        bool gameisover;

        Random rnd;
        public Space()
        {
            InitializeComponent();
        }

        private void Space_Load(object sender, EventArgs e)
        {
            pause = false;
            gameisover = false;
            score = 0;
            level = 1;
            deficulty = 9;

            backgroundspeed = 4;
            playerspeed = 4;
            enemieSpeed = 4;
            enemiesmunitionSpeed = 4;
            munitionspeed = 20;
            munitions = new PictureBox[3];
            stars = new PictureBox[15];
            rnd = new Random();

            string assetsPath = Path.Combine(Application.StartupPath, "assets");

            Image munition = Image.FromFile(Path.Combine(assetsPath, "munition.png"));
            Image enemi1 = Image.FromFile(Path.Combine(assetsPath, "E1.png"));
            Image enemi2 = Image.FromFile(Path.Combine(assetsPath, "E2.png"));
            Image enemi3 = Image.FromFile(Path.Combine(assetsPath, "E3.png"));
            Image boss1 = Image.FromFile(Path.Combine(assetsPath, "Boss1.png"));
            Image boss2 = Image.FromFile(Path.Combine(assetsPath, "Boss2.png"));

            enemies = new PictureBox[10];

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(40, 40);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BorderStyle = BorderStyle.None;
                enemies[i].Visible = true;
                this.Controls.Add(enemies[i]);
                enemies[i].Location = new Point((i + 1) * 50, -50);
            }

            enemies[0].Image = boss1;
            enemies[1].Image = enemi2;
            enemies[2].Image = enemi3;
            enemies[3].Image = enemi3;
            enemies[4].Image = enemi1;
            enemies[5].Image = enemi3;
            enemies[6].Image = enemi2;
            enemies[7].Image = enemi3;
            enemies[8].Image = enemi2;
            enemies[9].Image = boss2;

            for (int i = 0; i < munitions.Length; i++)
            {
                munitions[i] = new PictureBox();
                munitions[i].Size = new Size(8, 8);
                munitions[i].Image = munition;
                munitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                munitions[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(munitions[i]);
            }

            gameMedia = new WindowsMediaPlayer();
            shootgMedia = new WindowsMediaPlayer();
            explosion = new WindowsMediaPlayer();


            string songPath = Path.Combine(Application.StartupPath, "song");

            gameMedia.URL = Path.Combine(songPath, "GameSong.mp3");
            shootgMedia.URL = Path.Combine(songPath, "shoot.mp3");
            explosion.URL = Path.Combine(songPath, "boom.mp3");

            gameMedia.settings.setMode("loop", true);
            gameMedia.settings.volume = 5;
            gameMedia.settings.volume = 1;
            shootgMedia.settings.volume = 1;
            explosion.settings.volume = 6;

            enemiesmunition = new PictureBox[10];

            for (int i = 0; i < enemiesmunition.Length; i++)
            {
                enemiesmunition[i] = new PictureBox();
                enemiesmunition[i].Size = new Size(2, 25);
                enemiesmunition[i].Visible = false;
                enemiesmunition[i].BackColor = Color.Yellow;
                int x = rnd.Next(0, 10);
                enemiesmunition[i].Location = new Point(enemies[x].Location.X, enemies[x].Location.Y - 20);
                this.Controls.Add(enemiesmunition[i]);
            }
            gameMedia.controls.play();



            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rnd.Next(20, 500), rnd.Next(-10, 400));
                if (i % 2 == 1)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.Wheat;
                }
                else
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(stars[i]);


            }

            gameMedia.controls.play();

        }

        private void MoveBgroundTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length / 2; i++)
            {
                stars[i].Top += backgroundspeed;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
            for (int i = stars.Length / 2; i < stars.Length; i++)
            {
                stars[i].Top += backgroundspeed - 2;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
        }

        private void Rightmovetime_Tick(object sender, EventArgs e)
        {
            if (Player.Right < 580)
            {
                Player.Left += playerspeed;
            }
        }

        private void Downmovetimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top < 400)
            {
                Player.Top += playerspeed;
            }
        }

        private void Leftmovetimer_Tick(object sender, EventArgs e)
        {
            if (Player.Left > 10)
            {
                Player.Left -= playerspeed;

            }
        }

        private void Upmovetimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top > 10)
            {
                Player.Top -= playerspeed;
            }
        }

        private void Space_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pause)
            {


                if (e.KeyCode == Keys.Right)
                {
                    Rightmovetime.Start();
                }
                if (e.KeyCode == Keys.Left)
                {
                    Leftmovetimer.Start();
                }
                if (e.KeyCode == Keys.Down)
                {
                    Downmovetimer.Start();
                }
                if (e.KeyCode == Keys.Up)
                {
                    Upmovetimer.Start();
                }
            }
        }

        private void Space_KeyUp(object sender, KeyEventArgs e)
        {
            Rightmovetime.Stop();
            Leftmovetimer.Stop();
            Downmovetimer.Stop();
            Upmovetimer.Stop();

            if (e.KeyCode == Keys.Space)
            {
                if (!gameisover)
                {
                    if (pause)
                    {
                        StartTimers();
                        label1.Visible = false;
                        gameMedia.controls.play();
                        pause = false;
                    }
                    else
                    {
                        label1.Location = new Point(this.Width / 2 - 120, 150);
                        label1.Text = "PAUSED";
                        label1.Visible = true;
                        gameMedia.controls.pause();
                        StopTimers();
                        pause = true;
                    }
                }
            }
        }

        private void Movemunitiontimer_Tick(object sender, EventArgs e)
        {
            shootgMedia.controls.play();
            for (int i = 0; i < munitions.Length; i++)
            {
                if (munitions[i].Top > 0)
                {
                    munitions[i].Visible = true;
                    munitions[i].Top -= munitionspeed;

                    Collition();
                }
                else
                {
                    munitions[i].Visible = false;
                    munitions[i].Location = new Point(Player.Location.X + 20, Player.Location.Y - i * 30);
                }
            }
        }

        private void Movenemiestimer_Tick(object sender, EventArgs e)
        {
            MoveEnemies(enemies, enemieSpeed);
        }

        private void MoveEnemies(PictureBox[] array, int speed)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                if (array[i].Top > this.Height)
                {
                    array[i].Location = new Point((i + 1) * 50, -200);
                }
            }

        }

        private void Collition()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (munitions[0].Bounds.IntersectsWith(enemies[i].Bounds)
                || munitions[1].Bounds.IntersectsWith(enemies[i].Bounds) || munitions[2].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.controls.play();

                    score += 1;
                    scorelbl.Text = (level < 10) ? "0" + score.ToString() : score.ToString();

                    if(score % 30 == 0)
                    {
                        level += 1;
                        levellbl.Text = (level < 10) ? level.ToString() : level.ToString();

                        if(enemieSpeed <= 10 && enemiesmunitionSpeed <= 10 && deficulty >= 0)
                        {
                            deficulty--;
                            enemieSpeed++;
                            enemiesmunitionSpeed++;

                        }
                        if(level == 10)
                        {
                            GameOver("NICE DONE");
                        }
                    }
                    enemies[i].Location = new Point((i + 1) * 50, -100);
                }
                if (Player.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.settings.volume = 30;
                    explosion.controls.play();
                    Player.Visible = false;
                    GameOver("Game Over");
                }
            }
        }
        private void GameOver(string str)
        {
            label1.Text = str;
            label1.Location = new Point(120, 120);
            label1.Visible = true;
            Replaybtn.Visible = true;
            Exitbtn.Visible = true;

            gameMedia.controls.stop();
            StopTimers();
        }
        private void StopTimers()
        {
            MoveBgroundTimer.Stop();
            Movemunitiontimer.Stop();
            Movenemiestimer.Stop();
            Enemiesmunitiontimer.Stop();
        }
        private void StartTimers()
        {
            MoveBgroundTimer.Start();
            Movenemiestimer.Start();
            Movemunitiontimer.Start();
            Enemiesmunitiontimer.Start();
        }

        private void Enemiesmunitiontimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemiesmunition.Length; i++)
            {
                if (enemiesmunition[i].Top < this.Height)
                {
                    enemiesmunition[i].Visible = true;
                    enemiesmunition[i].Top += enemiesmunitionSpeed;

                    CollitionWithEnemiesMunition();
                }
                else
                {
                    enemiesmunition[i].Visible = false;
                    int x = rnd.Next(0, 10);
                    enemiesmunition[i].Location = new Point(enemies[x].Location.X + 20, enemies[x].Location.Y + 30);
                }
            }
        }

        private void CollitionWithEnemiesMunition()
        {
            for (int i = 0; i < enemiesmunition.Length; i++)
            {
                if (enemiesmunition[i].Bounds.IntersectsWith(Player.Bounds))
                {
                    enemiesmunition[i].Visible = false;
                    explosion.settings.volume = 30;
                    explosion.controls.play();
                    Player.Visible = false;
                    GameOver("Game Over");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Replaybtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Space_Load(e, e);
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void scorelbl_Click(object sender, EventArgs e)
        {

        }
    }
}


