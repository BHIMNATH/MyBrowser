namespace Brow
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
            this.ty = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.web = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.front = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ty
            // 
            this.ty.AutoCompleteCustomSource.AddRange(new string[] {
            "http://",
            "http://google.com",
            ".in",
            ".com",
            "http://facebook.com",
            "http://amazon.com",
            "http://.tk.",
            "http://twitter.com",
            ".co.in"});
            this.ty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ty.BackColor = System.Drawing.SystemColors.InfoText;
            this.ty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ty.ForeColor = System.Drawing.Color.White;
            this.ty.Location = new System.Drawing.Point(0, 56);
            this.ty.Name = "ty";
            this.ty.Size = new System.Drawing.Size(781, 29);
            this.ty.TabIndex = 2;
            // 
            // go
            // 
            this.go.BackColor = System.Drawing.Color.Transparent;
            this.go.BackgroundImage = global::Brow.Properties.Resources.search__2_;
            this.go.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.go.Cursor = System.Windows.Forms.Cursors.Hand;
            this.go.Dock = System.Windows.Forms.DockStyle.Right;
            this.go.FlatAppearance.BorderSize = 0;
            this.go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.go.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go.ForeColor = System.Drawing.Color.Transparent;
            this.go.Location = new System.Drawing.Point(781, 0);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(61, 85);
            this.go.TabIndex = 3;
            this.go.UseVisualStyleBackColor = false;
            this.go.Click += new System.EventHandler(this.button1_Click);
            // 
            // web
            // 
            this.web.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web.Location = new System.Drawing.Point(0, 0);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(842, 404);
            this.web.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.front);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.ty);
            this.panel1.Controls.Add(this.go);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 85);
            this.panel1.TabIndex = 15;
            // 
            // home
            // 
            this.home.AutoSize = true;
            this.home.BackColor = System.Drawing.Color.Transparent;
            this.home.BackgroundImage = global::Brow.Properties.Resources.home;
            this.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.home.Dock = System.Windows.Forms.DockStyle.Left;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Location = new System.Drawing.Point(0, 0);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(74, 56);
            this.home.TabIndex = 4;
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImage = global::Brow.Properties.Resources.arrow_left__2_;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back.Dock = System.Windows.Forms.DockStyle.Left;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Location = new System.Drawing.Point(74, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(68, 56);
            this.back.TabIndex = 4;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // front
            // 
            this.front.BackColor = System.Drawing.Color.Transparent;
            this.front.BackgroundImage = global::Brow.Properties.Resources.arrow_right__2_;
            this.front.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.front.Dock = System.Windows.Forms.DockStyle.Left;
            this.front.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.front.Location = new System.Drawing.Point(142, 0);
            this.front.Name = "front";
            this.front.Size = new System.Drawing.Size(67, 56);
            this.front.TabIndex = 4;
            this.front.UseVisualStyleBackColor = false;
            this.front.Click += new System.EventHandler(this.front_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.BackgroundImage = global::Brow.Properties.Resources.refresh;
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Location = new System.Drawing.Point(209, 0);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(73, 56);
            this.refresh.TabIndex = 4;
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(842, 404);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.web);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ty;
        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button front;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button go;
    }
}

