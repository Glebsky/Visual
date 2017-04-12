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
            this.PostBox.SelectedIndexChanged += new System.EventHandler(this.PostBox_SelectedIndexChanged);
            // 
            // RemovePostBtn
            // 
            this.RemovePostBtn.Location = new System.Drawing.Point(138, 41);
            this.RemovePostBtn.Name = "RemovePostBtn";
            this.RemovePostBtn.Size = new System.Drawing.Size(23, 23);
            this.RemovePostBtn.TabIndex = 1;
            this.RemovePostBtn.Text = "-";
            this.RemovePostBtn.UseVisualStyleBackColor = true;
            this.RemovePostBtn.Click += new System.EventHandler(this.DeletePost_Click);
            // 
            // AddPostBtn
            // 
            this.AddPostBtn.Location = new System.Drawing.Point(138, 12);
            this.AddPostBtn.Name = "AddPostBtn";
            this.AddPostBtn.Size = new System.Drawing.Size(23, 23);
            this.AddPostBtn.TabIndex = 2;
            this.AddPostBtn.Text = "+";
            this.AddPostBtn.UseVisualStyleBackColor = true;
            this.AddPostBtn.Click += new System.EventHandler(this.AddPost);
            // 
            // AddLinkBtn
            // 
            this.AddLinkBtn.Location = new System.Drawing.Point(307, 13);
            this.AddLinkBtn.Name = "AddLinkBtn";
            this.AddLinkBtn.Size = new System.Drawing.Size(23, 23);
            this.AddLinkBtn.TabIndex = 5;
            this.AddLinkBtn.Text = "+";
            this.AddLinkBtn.UseVisualStyleBackColor = true;
            this.AddLinkBtn.Click += new System.EventHandler(this.AddLink);
            // 
            // RemoveLinkBtn
            // 
            this.RemoveLinkBtn.Location = new System.Drawing.Point(307, 42);
            this.RemoveLinkBtn.Name = "RemoveLinkBtn";
            this.RemoveLinkBtn.Size = new System.Drawing.Size(23, 23);
            this.RemoveLinkBtn.TabIndex = 4;
            this.RemoveLinkBtn.Text = "-";
            this.RemoveLinkBtn.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 222);
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
    }
}

