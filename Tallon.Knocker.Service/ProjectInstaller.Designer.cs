﻿namespace Tallon.Knocker.Service
{
    partial class ProjectInstaller
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.knockServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.knockServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // knockServiceProcessInstaller
            // 
            this.knockServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.knockServiceProcessInstaller.Password = null;
            this.knockServiceProcessInstaller.Username = null;
            // 
            // knockServiceInstaller
            // 
            this.knockServiceInstaller.ServiceName = "Knock Service";
            this.knockServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.knockServiceProcessInstaller,
            this.knockServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller knockServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller knockServiceInstaller;
    }
}