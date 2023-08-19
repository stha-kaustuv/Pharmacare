
namespace Pharmacare
{
    partial class Adminstrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminstrator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.btnLogOut = new Guna.UI.WinForms.GunaButton();
            this.btnProfile = new Guna.UI.WinForms.GunaButton();
            this.btnViewUser = new Guna.UI.WinForms.GunaButton();
            this.btnAddUser = new Guna.UI.WinForms.GunaButton();
            this.btnDashboard = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.uC_ViewUser1 = new Pharmacare.AdminstratorUC.UC_ViewUser();
            this.uC_AddUser1 = new Pharmacare.AdminstratorUC.UC_AddUser();
            this.userControl_Dashboard1 = new Pharmacare.AdminstratorUC.UserControl_Dashboard();
            this.uC_Profile1 = new Pharmacare.AdminstratorUC.UC_Profile();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.userNameLabel);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnViewUser);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 769);
            this.panel1.TabIndex = 0;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.userNameLabel.Location = new System.Drawing.Point(0, 694);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(275, 29);
            this.userNameLabel.TabIndex = 14;
            this.userNameLabel.Text = "Pharmacare";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AnimationHoverSpeed = 0.07F;
            this.btnLogOut.AnimationSpeed = 0.03F;
            this.btnLogOut.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogOut.BorderColor = System.Drawing.Color.Black;
            this.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogOut.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogOut.ImageSize = new System.Drawing.Size(35, 35);
            this.btnLogOut.Location = new System.Drawing.Point(7, 590);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnLogOut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogOut.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnLogOut.OnHoverImage = null;
            this.btnLogOut.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogOut.Size = new System.Drawing.Size(260, 42);
            this.btnLogOut.TabIndex = 13;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.AnimationHoverSpeed = 0.07F;
            this.btnProfile.AnimationSpeed = 0.03F;
            this.btnProfile.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProfile.BorderColor = System.Drawing.Color.Black;
            this.btnProfile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProfile.FocusedColor = System.Drawing.Color.Empty;
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProfile.ImageSize = new System.Drawing.Size(35, 35);
            this.btnProfile.Location = new System.Drawing.Point(7, 507);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnProfile.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnProfile.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnProfile.OnHoverImage = null;
            this.btnProfile.OnPressedColor = System.Drawing.Color.Black;
            this.btnProfile.Size = new System.Drawing.Size(260, 42);
            this.btnProfile.TabIndex = 12;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnViewUser
            // 
            this.btnViewUser.AnimationHoverSpeed = 0.07F;
            this.btnViewUser.AnimationSpeed = 0.03F;
            this.btnViewUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewUser.BorderColor = System.Drawing.Color.Black;
            this.btnViewUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnViewUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUser.ForeColor = System.Drawing.Color.White;
            this.btnViewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnViewUser.Image")));
            this.btnViewUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewUser.ImageSize = new System.Drawing.Size(35, 35);
            this.btnViewUser.Location = new System.Drawing.Point(7, 425);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnViewUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnViewUser.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnViewUser.OnHoverImage = null;
            this.btnViewUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnViewUser.Size = new System.Drawing.Size(260, 42);
            this.btnViewUser.TabIndex = 11;
            this.btnViewUser.Text = "View User";
            this.btnViewUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.AnimationHoverSpeed = 0.07F;
            this.btnAddUser.AnimationSpeed = 0.03F;
            this.btnAddUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddUser.BorderColor = System.Drawing.Color.Black;
            this.btnAddUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddUser.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddUser.Location = new System.Drawing.Point(7, 345);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnAddUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddUser.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAddUser.OnHoverImage = null;
            this.btnAddUser.OnPressedColor = System.Drawing.Color.White;
            this.btnAddUser.Size = new System.Drawing.Size(260, 42);
            this.btnAddUser.TabIndex = 10;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AnimationHoverSpeed = 0.07F;
            this.btnDashboard.AnimationSpeed = 0.03F;
            this.btnDashboard.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.BorderColor = System.Drawing.Color.Black;
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.FocusedColor = System.Drawing.Color.Empty;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDashboard.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDashboard.Location = new System.Drawing.Point(7, 264);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnDashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDashboard.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnDashboard.OnHoverImage = null;
            this.btnDashboard.OnPressedColor = System.Drawing.Color.White;
            this.btnDashboard.Size = new System.Drawing.Size(260, 42);
            this.btnDashboard.TabIndex = 9;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDashboard.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adminstrator";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.uC_Profile1);
            this.panel2.Controls.Add(this.uC_ViewUser1);
            this.panel2.Controls.Add(this.uC_AddUser1);
            this.panel2.Controls.Add(this.userControl_Dashboard1);
            this.panel2.Location = new System.Drawing.Point(276, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1104, 770);
            this.panel2.TabIndex = 1;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this.panel2;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this.panel2;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.TargetControl = this.panel2;
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.TargetControl = this.panel2;
            // 
            // uC_ViewUser1
            // 
            this.uC_ViewUser1.BackColor = System.Drawing.Color.White;
            this.uC_ViewUser1.Location = new System.Drawing.Point(-3, -4);
            this.uC_ViewUser1.Name = "uC_ViewUser1";
            this.uC_ViewUser1.Size = new System.Drawing.Size(1104, 770);
            this.uC_ViewUser1.TabIndex = 2;
            // 
            // uC_AddUser1
            // 
            this.uC_AddUser1.BackColor = System.Drawing.Color.White;
            this.uC_AddUser1.Location = new System.Drawing.Point(-3, -1);
            this.uC_AddUser1.Name = "uC_AddUser1";
            this.uC_AddUser1.Size = new System.Drawing.Size(1104, 770);
            this.uC_AddUser1.TabIndex = 1;
            this.uC_AddUser1.Load += new System.EventHandler(this.uC_AddUser1_Load);
            // 
            // userControl_Dashboard1
            // 
            this.userControl_Dashboard1.BackColor = System.Drawing.Color.White;
            this.userControl_Dashboard1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Dashboard1.Name = "userControl_Dashboard1";
            this.userControl_Dashboard1.Size = new System.Drawing.Size(1088, 672);
            this.userControl_Dashboard1.TabIndex = 0;
            // 
            // uC_Profile1
            // 
            this.uC_Profile1.BackColor = System.Drawing.Color.White;
            this.uC_Profile1.Location = new System.Drawing.Point(-3, 0);
            this.uC_Profile1.Name = "uC_Profile1";
            this.uC_Profile1.Size = new System.Drawing.Size(1104, 770);
            this.uC_Profile1.TabIndex = 3;
            // 
            // Adminstrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1367, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adminstrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adminstrator";
            this.Load += new System.EventHandler(this.Adminstrator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton btnLogOut;
        private Guna.UI.WinForms.GunaButton btnProfile;
        private Guna.UI.WinForms.GunaButton btnViewUser;
        private Guna.UI.WinForms.GunaButton btnAddUser;
        private System.Windows.Forms.Label userNameLabel;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private AdminstratorUC.UserControl_Dashboard userControl_Dashboard1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private AdminstratorUC.UC_AddUser uC_AddUser1;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private AdminstratorUC.UC_ViewUser uC_ViewUser1;
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
        private AdminstratorUC.UC_Profile uC_Profile1;
    }
}