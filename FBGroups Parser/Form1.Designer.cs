namespace FBGroups_Parser
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
            this.WB = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WB
            // 
            this.WB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WB.Location = new System.Drawing.Point(0, 0);
            this.WB.MinimumSize = new System.Drawing.Size(20, 20);
            this.WB.Name = "WB";
            this.WB.Size = new System.Drawing.Size(722, 278);
            this.WB.TabIndex = 0;
            this.WB.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WB_DocumentCompleted);
            this.WB.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.WB_Navigated);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 278);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WB;
        private System.Windows.Forms.Button button1;
    }
}

