namespace Rapture.Therapy.Integration
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPageAuthentication = new System.Windows.Forms.TabPage();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonDevelopment = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabPageAuthentication.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.TabPageAuthentication);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(910, 432);
            this.tabControl1.TabIndex = 0;
            // 
            // TabPageAuthentication
            // 
            this.TabPageAuthentication.Controls.Add(this.ButtonDevelopment);
            this.TabPageAuthentication.Location = new System.Drawing.Point(4, 24);
            this.TabPageAuthentication.Name = "TabPageAuthentication";
            this.TabPageAuthentication.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageAuthentication.Size = new System.Drawing.Size(902, 404);
            this.TabPageAuthentication.TabIndex = 0;
            this.TabPageAuthentication.Text = "Authentication";
            this.TabPageAuthentication.UseVisualStyleBackColor = true;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExit.Location = new System.Drawing.Point(847, 462);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 1;
            this.ButtonExit.Text = "E&xit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonDevelopment
            // 
            this.ButtonDevelopment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDevelopment.Location = new System.Drawing.Point(772, 375);
            this.ButtonDevelopment.Name = "ButtonDevelopment";
            this.ButtonDevelopment.Size = new System.Drawing.Size(124, 23);
            this.ButtonDevelopment.TabIndex = 2;
            this.ButtonDevelopment.Text = "&Development";
            this.ButtonDevelopment.UseVisualStyleBackColor = true;
            this.ButtonDevelopment.Click += new System.EventHandler(this.ButtonDevelopment_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 497);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Rapture Therapy Integration Application";
            this.tabControl1.ResumeLayout(false);
            this.TabPageAuthentication.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage TabPageAuthentication;
        private Button ButtonExit;
        private Button ButtonDevelopment;
    }
}