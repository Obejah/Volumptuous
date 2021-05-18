
namespace Volumptuous
{
    partial class FlappyBird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBird));
            this.Player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.PipeTop1 = new System.Windows.Forms.PictureBox();
            this.idle = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.Leaderboards = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.PipeBottom1 = new System.Windows.Forms.PictureBox();
            this.PipeBottom2 = new System.Windows.Forms.PictureBox();
            this.PipeTop2 = new System.Windows.Forms.PictureBox();
            this.Scores = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(75, 389);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(91, 64);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.Player_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lives: 3";
            // 
            // PipeTop1
            // 
            this.PipeTop1.BackColor = System.Drawing.Color.ForestGreen;
            this.PipeTop1.Image = ((System.Drawing.Image)(resources.GetObject("PipeTop1.Image")));
            this.PipeTop1.Location = new System.Drawing.Point(625, 1);
            this.PipeTop1.Name = "PipeTop1";
            this.PipeTop1.Size = new System.Drawing.Size(135, 500);
            this.PipeTop1.TabIndex = 2;
            this.PipeTop1.TabStop = false;
            this.PipeTop1.Tag = "Pipe";
            this.PipeTop1.Visible = false;
            // 
            // idle
            // 
            this.idle.Enabled = true;
            this.idle.Interval = 50;
            this.idle.Tick += new System.EventHandler(this.idle_Tick);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(192, 206);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(121, 51);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Leaderboards
            // 
            this.Leaderboards.Location = new System.Drawing.Point(446, 206);
            this.Leaderboards.Name = "Leaderboards";
            this.Leaderboards.Size = new System.Drawing.Size(121, 51);
            this.Leaderboards.TabIndex = 4;
            this.Leaderboards.Text = "Leaderboards";
            this.Leaderboards.UseVisualStyleBackColor = true;
            this.Leaderboards.Click += new System.EventHandler(this.Leaderboards_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(319, 249);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(121, 51);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Ground
            // 
            this.Ground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ground.BackgroundImage")));
            this.Ground.Location = new System.Drawing.Point(-1, 895);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1189, 108);
            this.Ground.TabIndex = 6;
            this.Ground.TabStop = false;
            this.Ground.Tag = "Pipe";
            // 
            // PipeBottom1
            // 
            this.PipeBottom1.BackColor = System.Drawing.Color.ForestGreen;
            this.PipeBottom1.Image = ((System.Drawing.Image)(resources.GetObject("PipeBottom1.Image")));
            this.PipeBottom1.Location = new System.Drawing.Point(625, 599);
            this.PipeBottom1.Name = "PipeBottom1";
            this.PipeBottom1.Size = new System.Drawing.Size(135, 897);
            this.PipeBottom1.TabIndex = 7;
            this.PipeBottom1.TabStop = false;
            this.PipeBottom1.Tag = "Pipe";
            this.PipeBottom1.Visible = false;
            // 
            // PipeBottom2
            // 
            this.PipeBottom2.BackColor = System.Drawing.Color.ForestGreen;
            this.PipeBottom2.Image = ((System.Drawing.Image)(resources.GetObject("PipeBottom2.Image")));
            this.PipeBottom2.Location = new System.Drawing.Point(1040, 464);
            this.PipeBottom2.Name = "PipeBottom2";
            this.PipeBottom2.Size = new System.Drawing.Size(138, 772);
            this.PipeBottom2.TabIndex = 7;
            this.PipeBottom2.TabStop = false;
            this.PipeBottom2.Tag = "Pipe";
            this.PipeBottom2.Click += new System.EventHandler(this.PipeBottom2_Click);
            // 
            // PipeTop2
            // 
            this.PipeTop2.BackColor = System.Drawing.Color.ForestGreen;
            this.PipeTop2.Image = ((System.Drawing.Image)(resources.GetObject("PipeTop2.Image")));
            this.PipeTop2.Location = new System.Drawing.Point(1040, -41);
            this.PipeTop2.Name = "PipeTop2";
            this.PipeTop2.Size = new System.Drawing.Size(138, 478);
            this.PipeTop2.TabIndex = 2;
            this.PipeTop2.TabStop = false;
            this.PipeTop2.Tag = "Pipe";
            // 
            // Scores
            // 
            this.Scores.AutoSize = true;
            this.Scores.BackColor = System.Drawing.Color.Transparent;
            this.Scores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Scores.Location = new System.Drawing.Point(337, 24);
            this.Scores.Name = "Scores";
            this.Scores.Size = new System.Drawing.Size(20, 24);
            this.Scores.TabIndex = 8;
            this.Scores.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(467, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(329, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(752, 1001);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Scores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Leaderboards);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.PipeTop2);
            this.Controls.Add(this.PipeTop1);
            this.Controls.Add(this.PipeBottom2);
            this.Controls.Add(this.PipeBottom1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FlappyBird";
            this.Text = "FlappyBird";
            this.Load += new System.EventHandler(this.FlappyBird_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PipeTop1;
        private System.Windows.Forms.Timer idle;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Leaderboards;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox PipeBottom1;
        private System.Windows.Forms.PictureBox PipeBottom2;
        private System.Windows.Forms.PictureBox PipeTop2;
        private System.Windows.Forms.Label Scores;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

