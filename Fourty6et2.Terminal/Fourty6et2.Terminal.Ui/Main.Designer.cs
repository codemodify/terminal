namespace Fourty6et2.Terminal.Ui
{
    partial class Main
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
            this.TheCustomTabControl = new Fourty6et2.ThirdParty.CustomTabControl.CustomTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TheCustomTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // TheCustomTabControl
            // 
            this.TheCustomTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.TheCustomTabControl.Controls.Add(this.tabPage1);
            this.TheCustomTabControl.Controls.Add(this.tabPage2);
            this.TheCustomTabControl.Controls.Add(this.tabPage3);
            this.TheCustomTabControl.DisplayStyle = Fourty6et2.ThirdParty.CustomTabControl.TabStyle.VisualStudio;
            // 
            // 
            // 
            this.TheCustomTabControl.DisplayStyleProvider.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.TheCustomTabControl.DisplayStyleProvider.BorderColorHot = System.Drawing.SystemColors.ControlDark;
            this.TheCustomTabControl.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.TheCustomTabControl.DisplayStyleProvider.CloserColor = System.Drawing.Color.DarkGray;
            this.TheCustomTabControl.DisplayStyleProvider.FocusTrack = false;
            this.TheCustomTabControl.DisplayStyleProvider.HotTrack = true;
            this.TheCustomTabControl.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.TheCustomTabControl.DisplayStyleProvider.Opacity = 1F;
            this.TheCustomTabControl.DisplayStyleProvider.Overlap = 7;
            this.TheCustomTabControl.DisplayStyleProvider.Padding = new System.Drawing.Point(14, 1);
            this.TheCustomTabControl.DisplayStyleProvider.ShowTabCloser = true;
            this.TheCustomTabControl.DisplayStyleProvider.TextColor = System.Drawing.SystemColors.ControlText;
            this.TheCustomTabControl.DisplayStyleProvider.TextColorDisabled = System.Drawing.SystemColors.ControlDark;
            this.TheCustomTabControl.DisplayStyleProvider.TextColorSelected = System.Drawing.Color.RoyalBlue;
            this.TheCustomTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TheCustomTabControl.HotTrack = true;
            this.TheCustomTabControl.Location = new System.Drawing.Point(0, 0);
            this.TheCustomTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.TheCustomTabControl.Name = "TheCustomTabControl";
            this.TheCustomTabControl.SelectedIndex = 0;
            this.TheCustomTabControl.Size = new System.Drawing.Size(830, 451);
            this.TheCustomTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(822, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(822, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(822, 420);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(830, 451);
            this.ControlBox = false;
            this.Controls.Add(this.TheCustomTabControl);
            this.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Opacity = 0.8D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Terminal";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.TheCustomTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ThirdParty.CustomTabControl.CustomTabControl TheCustomTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;


    }
}

