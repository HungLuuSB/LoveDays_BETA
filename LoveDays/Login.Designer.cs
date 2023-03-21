namespace LoveDays
{
    partial class Form_Login
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
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.BackColor = System.Drawing.Color.Transparent;
            this.lb_username.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_username.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic);
            this.lb_username.Location = new System.Drawing.Point(12, 285);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(117, 33);
            this.lb_username.TabIndex = 1;
            this.lb_username.Text = "Username:";
            this.lb_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.BackColor = System.Drawing.Color.Transparent;
            this.lb_password.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_password.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic);
            this.lb_password.Location = new System.Drawing.Point(12, 335);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(115, 33);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "Password:";
            this.lb_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.SystemColors.Control;
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tb_username.Location = new System.Drawing.Point(135, 288);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(253, 30);
            this.tb_username.TabIndex = 3;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.SystemColors.Control;
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tb_password.Location = new System.Drawing.Point(135, 337);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(253, 30);
            this.tb_password.TabIndex = 4;
            // 
            // bt_login
            // 
            this.bt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_login.Location = new System.Drawing.Point(164, 374);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(75, 38);
            this.bt_login.TabIndex = 5;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.Transparent;
            this.bt_exit.FlatAppearance.BorderSize = 0;
            this.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_exit.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.bt_exit.Location = new System.Drawing.Point(373, 0);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(27, 29);
            this.bt_exit.TabIndex = 6;
            this.bt_exit.Text = "X";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoveDays.Properties.Resources.login_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Button bt_exit;
    }
}

