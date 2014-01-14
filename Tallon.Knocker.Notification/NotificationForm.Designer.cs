namespace Tallon.Knocker.Notification
{
    partial class NotificationForm
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
            this.cmdDismiss = new System.Windows.Forms.Button();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdDismiss
            // 
            this.cmdDismiss.AutoSize = true;
            this.cmdDismiss.BackColor = System.Drawing.Color.Chartreuse;
            this.cmdDismiss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDismiss.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdDismiss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDismiss.Font = new System.Drawing.Font("BankGothic Md BT", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDismiss.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmdDismiss.Location = new System.Drawing.Point(0, 505);
            this.cmdDismiss.Name = "cmdDismiss";
            this.cmdDismiss.Size = new System.Drawing.Size(838, 199);
            this.cmdDismiss.TabIndex = 0;
            this.cmdDismiss.Text = "Dismiss";
            this.cmdDismiss.UseVisualStyleBackColor = false;
            this.cmdDismiss.Click += new System.EventHandler(this.cmdDismiss_Click);
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 5000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeader.Font = new System.Drawing.Font("BankGothic Md BT", 60F);
            this.lblHeader.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(30, 100, 0, 0);
            this.lblHeader.Size = new System.Drawing.Size(969, 184);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "You have a visitor...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(838, 704);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.cmdDismiss);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdDismiss;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Label lblHeader;
    }
}

