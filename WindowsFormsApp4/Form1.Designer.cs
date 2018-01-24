namespace WindowsFormsApp4
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
            this.reactionButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Label();
            this.ready1 = new System.Windows.Forms.Label();
            this.ready2 = new System.Windows.Forms.Label();
            this.ready3 = new System.Windows.Forms.Label();
            this.ready4 = new System.Windows.Forms.Label();
            this.go = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.PB = new System.Windows.Forms.Label();
            this.personalBest = new System.Windows.Forms.Label();
            this.avgNumber = new System.Windows.Forms.Label();
            this.avg = new System.Windows.Forms.Label();
            this.avgCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reactionButton
            // 
            this.reactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactionButton.Location = new System.Drawing.Point(12, 120);
            this.reactionButton.Name = "reactionButton";
            this.reactionButton.Size = new System.Drawing.Size(331, 185);
            this.reactionButton.TabIndex = 0;
            this.reactionButton.Text = "READY";
            this.reactionButton.UseVisualStyleBackColor = true;
            this.reactionButton.Click += new System.EventHandler(this.reactionButton_Click);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.Location = new System.Drawing.Point(12, 9);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(284, 108);
            this.timer.TabIndex = 1;
            this.timer.Text = "0.000";
            this.timer.Click += new System.EventHandler(this.timer_Click);
            // 
            // ready1
            // 
            this.ready1.AutoSize = true;
            this.ready1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ready1.Location = new System.Drawing.Point(349, 81);
            this.ready1.Name = "ready1";
            this.ready1.Size = new System.Drawing.Size(25, 24);
            this.ready1.TabIndex = 2;
            this.ready1.Text = "X";
            this.ready1.Click += new System.EventHandler(this.ready1_Click);
            // 
            // ready2
            // 
            this.ready2.AutoSize = true;
            this.ready2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.ready2.Location = new System.Drawing.Point(349, 131);
            this.ready2.Name = "ready2";
            this.ready2.Size = new System.Drawing.Size(25, 24);
            this.ready2.TabIndex = 3;
            this.ready2.Text = "X";
            this.ready2.Click += new System.EventHandler(this.ready2_Click);
            // 
            // ready3
            // 
            this.ready3.AutoSize = true;
            this.ready3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.ready3.Location = new System.Drawing.Point(349, 181);
            this.ready3.Name = "ready3";
            this.ready3.Size = new System.Drawing.Size(25, 24);
            this.ready3.TabIndex = 4;
            this.ready3.Text = "X";
            this.ready3.Click += new System.EventHandler(this.ready3_Click);
            // 
            // ready4
            // 
            this.ready4.AutoSize = true;
            this.ready4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ready4.Location = new System.Drawing.Point(349, 231);
            this.ready4.Name = "ready4";
            this.ready4.Size = new System.Drawing.Size(25, 24);
            this.ready4.TabIndex = 5;
            this.ready4.Text = "X";
            this.ready4.Click += new System.EventHandler(this.ready4_Click);
            // 
            // go
            // 
            this.go.AutoSize = true;
            this.go.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.go.Location = new System.Drawing.Point(349, 281);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(25, 24);
            this.go.TabIndex = 6;
            this.go.Text = "X";
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(380, 27);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(95, 48);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(279, 27);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(95, 48);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // PB
            // 
            this.PB.AutoSize = true;
            this.PB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PB.Location = new System.Drawing.Point(407, 157);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(42, 24);
            this.PB.TabIndex = 10;
            this.PB.Text = "PB:";
            // 
            // personalBest
            // 
            this.personalBest.AutoSize = true;
            this.personalBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalBest.Location = new System.Drawing.Point(407, 181);
            this.personalBest.Name = "personalBest";
            this.personalBest.Size = new System.Drawing.Size(17, 24);
            this.personalBest.TabIndex = 11;
            this.personalBest.Text = "-";
            this.personalBest.Click += new System.EventHandler(this.personalBest_Click);
            // 
            // avgNumber
            // 
            this.avgNumber.AutoSize = true;
            this.avgNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgNumber.Location = new System.Drawing.Point(407, 243);
            this.avgNumber.Name = "avgNumber";
            this.avgNumber.Size = new System.Drawing.Size(17, 24);
            this.avgNumber.TabIndex = 12;
            this.avgNumber.Text = "-";
            this.avgNumber.Click += new System.EventHandler(this.avgNumber_Click);
            // 
            // avg
            // 
            this.avg.AutoSize = true;
            this.avg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avg.Location = new System.Drawing.Point(385, 219);
            this.avg.Name = "avg";
            this.avg.Size = new System.Drawing.Size(53, 24);
            this.avg.TabIndex = 13;
            this.avg.Text = "AVG";
            // 
            // avgCount
            // 
            this.avgCount.AutoSize = true;
            this.avgCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgCount.Location = new System.Drawing.Point(434, 219);
            this.avgCount.Name = "avgCount";
            this.avgCount.Size = new System.Drawing.Size(21, 24);
            this.avgCount.TabIndex = 14;
            this.avgCount.Text = "0";
            this.avgCount.Click += new System.EventHandler(this.avgCount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 316);
            this.Controls.Add(this.avgCount);
            this.Controls.Add(this.avg);
            this.Controls.Add(this.avgNumber);
            this.Controls.Add(this.personalBest);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.go);
            this.Controls.Add(this.ready4);
            this.Controls.Add(this.ready3);
            this.Controls.Add(this.ready2);
            this.Controls.Add(this.ready1);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.reactionButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reactionButton;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label ready1;
        private System.Windows.Forms.Label ready2;
        private System.Windows.Forms.Label ready3;
        private System.Windows.Forms.Label ready4;
        private System.Windows.Forms.Label go;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label PB;
        private System.Windows.Forms.Label personalBest;
        private System.Windows.Forms.Label avgNumber;
        private System.Windows.Forms.Label avg;
        private System.Windows.Forms.Label avgCount;
    }
}

