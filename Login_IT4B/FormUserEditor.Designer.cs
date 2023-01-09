﻿namespace Login_IT4B
{
    partial class FormUserEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsCreateUser = new System.Windows.Forms.ToolStripButton();
            this.tsChangePassword = new System.Windows.Forms.ToolStripButton();
            this.tsDeleteUser = new System.Windows.Forms.ToolStripButton();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCreateUser,
            this.tsChangePassword,
            this.tsDeleteUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsCreateUser
            // 
            this.tsCreateUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCreateUser.Image = ((System.Drawing.Image)(resources.GetObject("tsCreateUser.Image")));
            this.tsCreateUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCreateUser.Name = "tsCreateUser";
            this.tsCreateUser.Size = new System.Drawing.Size(34, 28);
            this.tsCreateUser.Text = "toolStripButton1";
            this.tsCreateUser.ToolTipText = "Přidat uživatele";
            // 
            // tsChangePassword
            // 
            this.tsChangePassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("tsChangePassword.Image")));
            this.tsChangePassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsChangePassword.Name = "tsChangePassword";
            this.tsChangePassword.Size = new System.Drawing.Size(34, 28);
            this.tsChangePassword.Text = "toolStripButton2";
            this.tsChangePassword.ToolTipText = "Změnit heslo";
            // 
            // tsDeleteUser
            // 
            this.tsDeleteUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("tsDeleteUser.Image")));
            this.tsDeleteUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeleteUser.Name = "tsDeleteUser";
            this.tsDeleteUser.Size = new System.Drawing.Size(34, 28);
            this.tsDeleteUser.Text = "toolStripButton3";
            this.tsDeleteUser.ToolTipText = "Smazat uživatele";
            // 
            // lvUsers
            // 
            this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvUsers.FullRowSelect = true;
            this.lvUsers.GridLines = true;
            this.lvUsers.Location = new System.Drawing.Point(0, 33);
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(800, 417);
            this.lvUsers.TabIndex = 1;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Jméno";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Role";
            this.columnHeader2.Width = 250;
            // 
            // FormUserEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvUsers);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormUserEditor";
            this.Text = "Správce uživatelů";
            this.Load += new System.EventHandler(this.FormUserEditor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsCreateUser;
        private ToolStripButton tsChangePassword;
        private ToolStripButton tsDeleteUser;
        private ListView lvUsers;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}