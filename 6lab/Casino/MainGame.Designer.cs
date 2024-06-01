namespace Casino
{
    partial class MainGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.button1 = new System.Windows.Forms.Button();
            this.Crown = new System.Windows.Forms.Button();
            this.Anchor = new System.Windows.Forms.Button();
            this.Heart = new System.Windows.Forms.Button();
            this.Spade = new System.Windows.Forms.Button();
            this.Club = new System.Windows.Forms.Button();
            this.Diamond = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.die1 = new System.Windows.Forms.Label();
            this.die2 = new System.Windows.Forms.Label();
            this.die3 = new System.Windows.Forms.Label();
            this.payBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(3, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Crown
            // 
            this.Crown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Crown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Crown.Location = new System.Drawing.Point(3, 3);
            this.Crown.Name = "Crown";
            this.Crown.Size = new System.Drawing.Size(75, 56);
            this.Crown.TabIndex = 1;
            this.Crown.Text = "👑";
            this.Crown.UseVisualStyleBackColor = true;
            this.Crown.Click += new System.EventHandler(this.Crown_Click);
            // 
            // Anchor
            // 
            this.Anchor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Anchor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Anchor.Location = new System.Drawing.Point(84, 3);
            this.Anchor.Name = "Anchor";
            this.Anchor.Size = new System.Drawing.Size(75, 56);
            this.Anchor.TabIndex = 2;
            this.Anchor.Text = "⚓";
            this.Anchor.UseVisualStyleBackColor = true;
            this.Anchor.Click += new System.EventHandler(this.Anchor_Click);
            // 
            // Heart
            // 
            this.Heart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Heart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Heart.Location = new System.Drawing.Point(3, 65);
            this.Heart.Name = "Heart";
            this.Heart.Size = new System.Drawing.Size(75, 56);
            this.Heart.TabIndex = 3;
            this.Heart.Text = "♥️";
            this.Heart.UseVisualStyleBackColor = true;
            this.Heart.Click += new System.EventHandler(this.Heart_Click);
            // 
            // Spade
            // 
            this.Spade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Spade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Spade.Location = new System.Drawing.Point(84, 65);
            this.Spade.Name = "Spade";
            this.Spade.Size = new System.Drawing.Size(75, 56);
            this.Spade.TabIndex = 4;
            this.Spade.Text = "♠️";
            this.Spade.UseVisualStyleBackColor = true;
            this.Spade.Click += new System.EventHandler(this.Spade_Click);
            // 
            // Club
            // 
            this.Club.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Club.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Club.Location = new System.Drawing.Point(3, 127);
            this.Club.Name = "Club";
            this.Club.Size = new System.Drawing.Size(75, 56);
            this.Club.TabIndex = 5;
            this.Club.Text = "♣️";
            this.Club.UseVisualStyleBackColor = true;
            this.Club.Click += new System.EventHandler(this.Club_Click);
            // 
            // Diamond
            // 
            this.Diamond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Diamond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Diamond.Location = new System.Drawing.Point(84, 127);
            this.Diamond.Name = "Diamond";
            this.Diamond.Size = new System.Drawing.Size(75, 56);
            this.Diamond.TabIndex = 6;
            this.Diamond.Text = "♦️";
            this.Diamond.UseVisualStyleBackColor = true;
            this.Diamond.Click += new System.EventHandler(this.Diamond_Click);
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.balance.Location = new System.Drawing.Point(565, 37);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(31, 13);
            this.balance.TabIndex = 7;
            this.balance.Text = "------";
            this.balance.Click += new System.EventHandler(this.balance_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(514, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Баланс";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // die1
            // 
            this.die1.AutoSize = true;
            this.die1.BackColor = System.Drawing.Color.Transparent;
            this.die1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.die1.Location = new System.Drawing.Point(10, 24);
            this.die1.Name = "die1";
            this.die1.Size = new System.Drawing.Size(59, 31);
            this.die1.TabIndex = 9;
            this.die1.Text = "-----";
            this.die1.Click += new System.EventHandler(this.die1_Click);
            // 
            // die2
            // 
            this.die2.AutoSize = true;
            this.die2.BackColor = System.Drawing.Color.Transparent;
            this.die2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.die2.Location = new System.Drawing.Point(90, 24);
            this.die2.Name = "die2";
            this.die2.Size = new System.Drawing.Size(59, 31);
            this.die2.TabIndex = 10;
            this.die2.Text = "-----";
            // 
            // die3
            // 
            this.die3.AutoSize = true;
            this.die3.BackColor = System.Drawing.Color.Transparent;
            this.die3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.die3.Location = new System.Drawing.Point(170, 24);
            this.die3.Name = "die3";
            this.die3.Size = new System.Drawing.Size(59, 31);
            this.die3.TabIndex = 11;
            this.die3.Text = "-----";
            // 
            // payBox
            // 
            this.payBox.Location = new System.Drawing.Point(51, 189);
            this.payBox.Name = "payBox";
            this.payBox.Size = new System.Drawing.Size(108, 20);
            this.payBox.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.No;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(3, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Сброс ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ставка:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.Crown);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.payBox);
            this.panel1.Controls.Add(this.Anchor);
            this.panel1.Controls.Add(this.Heart);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Spade);
            this.panel1.Controls.Add(this.Club);
            this.panel1.Controls.Add(this.Diamond);
            this.panel1.Location = new System.Drawing.Point(-1, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 279);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.die2);
            this.panel2.Controls.Add(this.die3);
            this.panel2.Controls.Add(this.die1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel2.Location = new System.Drawing.Point(263, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 85);
            this.panel2.TabIndex = 17;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(623, 342);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.balance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainGame";
            this.Text = "Делайте ваши ставки!";
            this.Load += new System.EventHandler(this.MainGame_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Crown;
        private System.Windows.Forms.Button Anchor;
        private System.Windows.Forms.Button Heart;
        private System.Windows.Forms.Button Spade;
        private System.Windows.Forms.Button Club;
        private System.Windows.Forms.Button Diamond;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label die1;
        private System.Windows.Forms.Label die2;
        private System.Windows.Forms.Label die3;
        private System.Windows.Forms.TextBox payBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}