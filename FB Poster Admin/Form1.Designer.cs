namespace FB_Poster_Admin
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
            this.PostBox = new System.Windows.Forms.ListBox();
            this.RemovePostBtn = new System.Windows.Forms.Button();
            this.AddPostBtn = new System.Windows.Forms.Button();
            this.AddLinkBtn = new System.Windows.Forms.Button();
            this.RemoveLinkBtn = new System.Windows.Forms.Button();
            this.LinkBox = new System.Windows.Forms.ListBox();
            this.Apply = new System.Windows.Forms.Button();
            this.PostDownBtn = new System.Windows.Forms.Button();
            this.LinkDownBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PostBox
            // 
            this.PostBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PostBox.FormattingEnabled = true;
            this.PostBox.Location = new System.Drawing.Point(12, 12);
            this.PostBox.Name = "PostBox";
            this.PostBox.Size = new System.Drawing.Size(120, 197);
            this.PostBox.TabIndex = 0;
            this.PostBox.DoubleClick += new System.EventHandler(this.EditPost);
            // 
            // RemovePostBtn
            // 
            this.RemovePostBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.RemovePostBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemovePostBtn.Location = new System.Drawing.Point(138, 41);
            this.RemovePostBtn.Name = "RemovePostBtn";
            this.RemovePostBtn.Size = new System.Drawing.Size(23, 23);
            this.RemovePostBtn.TabIndex = 1;
            this.RemovePostBtn.Text = "-";
            this.RemovePostBtn.UseVisualStyleBackColor = false;
            this.RemovePostBtn.Click += new System.EventHandler(this.DeletePost_Click);
            // 
            // AddPostBtn
            // 
            this.AddPostBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.AddPostBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddPostBtn.Location = new System.Drawing.Point(138, 12);
            this.AddPostBtn.Name = "AddPostBtn";
            this.AddPostBtn.Size = new System.Drawing.Size(23, 23);
            this.AddPostBtn.TabIndex = 2;
            this.AddPostBtn.Text = "+";
            this.AddPostBtn.UseVisualStyleBackColor = false;
            this.AddPostBtn.Click += new System.EventHandler(this.AddPost);
            // 
            // AddLinkBtn
            // 
            this.AddLinkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.AddLinkBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddLinkBtn.Location = new System.Drawing.Point(307, 13);
            this.AddLinkBtn.Name = "AddLinkBtn";
            this.AddLinkBtn.Size = new System.Drawing.Size(23, 23);
            this.AddLinkBtn.TabIndex = 5;
            this.AddLinkBtn.Text = "+";
            this.AddLinkBtn.UseVisualStyleBackColor = false;
            this.AddLinkBtn.Click += new System.EventHandler(this.AddLink);
            // 
            // RemoveLinkBtn
            // 
            this.RemoveLinkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.RemoveLinkBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveLinkBtn.Location = new System.Drawing.Point(307, 42);
            this.RemoveLinkBtn.Name = "RemoveLinkBtn";
            this.RemoveLinkBtn.Size = new System.Drawing.Size(23, 23);
            this.RemoveLinkBtn.TabIndex = 4;
            this.RemoveLinkBtn.Text = "-";
            this.RemoveLinkBtn.UseVisualStyleBackColor = false;
            this.RemoveLinkBtn.Click += new System.EventHandler(this.DeleteLink);
            // 
            // LinkBox
            // 
            this.LinkBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LinkBox.FormattingEnabled = true;
            this.LinkBox.Location = new System.Drawing.Point(167, 13);
            this.LinkBox.Name = "LinkBox";
            this.LinkBox.Size = new System.Drawing.Size(134, 197);
            this.LinkBox.TabIndex = 3;
            this.LinkBox.SelectedIndexChanged += new System.EventHandler(this.LinkBox_SelectedIndexChanged);
            this.LinkBox.DoubleClick += new System.EventHandler(this.EditLink);
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(375, 187);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 6;
            this.Apply.Text = "Применить";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.ApplyChanges);
            // 
            // PostDownBtn
            // 
            this.PostDownBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.PostDownBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PostDownBtn.Location = new System.Drawing.Point(138, 87);
            this.PostDownBtn.Name = "PostDownBtn";
            this.PostDownBtn.Size = new System.Drawing.Size(23, 23);
            this.PostDownBtn.TabIndex = 7;
            this.PostDownBtn.Text = "D";
            this.PostDownBtn.UseVisualStyleBackColor = false;
            this.PostDownBtn.Click += new System.EventHandler(this.DownPost);
            // 
            // LinkDownBtn
            // 
            this.LinkDownBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.LinkDownBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LinkDownBtn.Location = new System.Drawing.Point(307, 112);
            this.LinkDownBtn.Name = "LinkDownBtn";
            this.LinkDownBtn.Size = new System.Drawing.Size(23, 23);
            this.LinkDownBtn.TabIndex = 8;
            this.LinkDownBtn.Text = "D";
            this.LinkDownBtn.UseVisualStyleBackColor = false;
            this.LinkDownBtn.Click += new System.EventHandler(this.DownPost);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(462, 222);
            this.Controls.Add(this.LinkDownBtn);
            this.Controls.Add(this.PostDownBtn);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.AddLinkBtn);
            this.Controls.Add(this.RemoveLinkBtn);
            this.Controls.Add(this.LinkBox);
            this.Controls.Add(this.AddPostBtn);
            this.Controls.Add(this.RemovePostBtn);
            this.Controls.Add(this.PostBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox PostBox;
        private System.Windows.Forms.Button RemovePostBtn;
        private System.Windows.Forms.Button AddPostBtn;
        private System.Windows.Forms.Button AddLinkBtn;
        private System.Windows.Forms.Button RemoveLinkBtn;
        private System.Windows.Forms.ListBox LinkBox;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button PostDownBtn;
        private System.Windows.Forms.Button LinkDownBtn;
    }
}

