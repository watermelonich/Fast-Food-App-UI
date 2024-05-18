namespace Fast_Food_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.paneltop = new System.Windows.Forms.Panel();
            this.panelcenter = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.food = new System.Windows.Forms.Button();
            this.drinks = new System.Windows.Forms.Button();
            this.chat = new System.Windows.Forms.Button();
            this.delivery = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.panelslide = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.paneltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(32)))), ((int)(((byte)(20)))));
            this.panelLeft.Controls.Add(this.panelslide);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.about);
            this.panelLeft.Controls.Add(this.delivery);
            this.panelLeft.Controls.Add(this.chat);
            this.panelLeft.Controls.Add(this.drinks);
            this.panelLeft.Controls.Add(this.food);
            this.panelLeft.Controls.Add(this.home);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(202, 656);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.paneltop.Controls.Add(this.label5);
            this.paneltop.Controls.Add(this.label4);
            this.paneltop.Controls.Add(this.label3);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(202, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(980, 47);
            this.paneltop.TabIndex = 1;
            // 
            // panelcenter
            // 
            this.panelcenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcenter.Location = new System.Drawing.Point(202, 47);
            this.panelcenter.Name = "panelcenter";
            this.panelcenter.Size = new System.Drawing.Size(980, 609);
            this.panelcenter.TabIndex = 2;
            // 
            // home
            // 
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.Location = new System.Drawing.Point(8, 89);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(194, 63);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Food";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "App";
            // 
            // food
            // 
            this.food.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.food.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food.Image = ((System.Drawing.Image)(resources.GetObject("food.Image")));
            this.food.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.food.Location = new System.Drawing.Point(8, 158);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(194, 63);
            this.food.TabIndex = 0;
            this.food.Text = "Food";
            this.food.UseVisualStyleBackColor = true;
            this.food.Click += new System.EventHandler(this.food_Click);
            // 
            // drinks
            // 
            this.drinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drinks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinks.Image = ((System.Drawing.Image)(resources.GetObject("drinks.Image")));
            this.drinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.drinks.Location = new System.Drawing.Point(8, 227);
            this.drinks.Name = "drinks";
            this.drinks.Size = new System.Drawing.Size(194, 63);
            this.drinks.TabIndex = 0;
            this.drinks.Text = "Drinks";
            this.drinks.UseVisualStyleBackColor = true;
            this.drinks.Click += new System.EventHandler(this.drinks_Click);
            // 
            // chat
            // 
            this.chat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chat.Image = ((System.Drawing.Image)(resources.GetObject("chat.Image")));
            this.chat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chat.Location = new System.Drawing.Point(8, 296);
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(194, 63);
            this.chat.TabIndex = 0;
            this.chat.Text = "My Chat";
            this.chat.UseVisualStyleBackColor = true;
            this.chat.Click += new System.EventHandler(this.chat_Click);
            // 
            // delivery
            // 
            this.delivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delivery.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivery.Image = ((System.Drawing.Image)(resources.GetObject("delivery.Image")));
            this.delivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delivery.Location = new System.Drawing.Point(8, 365);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(194, 63);
            this.delivery.TabIndex = 0;
            this.delivery.Text = "Delivery";
            this.delivery.UseVisualStyleBackColor = true;
            this.delivery.Click += new System.EventHandler(this.delivery_Click);
            // 
            // about
            // 
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.Image = ((System.Drawing.Image)(resources.GetObject("about.Image")));
            this.about.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.about.Location = new System.Drawing.Point(8, 434);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(194, 63);
            this.about.TabIndex = 0;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // panelslide
            // 
            this.panelslide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.panelslide.Location = new System.Drawing.Point(0, 89);
            this.panelslide.Name = "panelslide";
            this.panelslide.Size = new System.Drawing.Size(7, 63);
            this.panelslide.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fast Food";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(498, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "App";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(944, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 656);
            this.Controls.Add(this.panelcenter);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Panel panelcenter;
        private System.Windows.Forms.Panel panelslide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button delivery;
        private System.Windows.Forms.Button chat;
        private System.Windows.Forms.Button drinks;
        private System.Windows.Forms.Button food;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

