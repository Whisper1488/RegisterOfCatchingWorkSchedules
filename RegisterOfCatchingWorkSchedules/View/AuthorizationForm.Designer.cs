﻿namespace RegisterOfCatchingWorkSchedules.View
{
    partial class AuthorizationForm
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
			this.btn_login = new System.Windows.Forms.Button();
			this.textBox_login = new System.Windows.Forms.TextBox();
			this.textBox_password = new System.Windows.Forms.TextBox();
			this.label_login = new System.Windows.Forms.Label();
			this.label_password = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_login
			// 
			this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_login.Location = new System.Drawing.Point(88, 254);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(150, 50);
			this.btn_login.TabIndex = 0;
			this.btn_login.Text = "Войти";
			this.btn_login.UseVisualStyleBackColor = true;
			this.btn_login.Click += new System.EventHandler(this.OnLogin);
			// 
			// textBox_login
			// 
			this.textBox_login.Location = new System.Drawing.Point(88, 127);
			this.textBox_login.Name = "textBox_login";
			this.textBox_login.Size = new System.Drawing.Size(150, 20);
			this.textBox_login.TabIndex = 1;
			// 
			// textBox_password
			// 
			this.textBox_password.Location = new System.Drawing.Point(88, 181);
			this.textBox_password.Name = "textBox_password";
			this.textBox_password.Size = new System.Drawing.Size(150, 20);
			this.textBox_password.TabIndex = 2;
			// 
			// label_login
			// 
			this.label_login.AutoSize = true;
			this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_login.Location = new System.Drawing.Point(85, 108);
			this.label_login.Name = "label_login";
			this.label_login.Size = new System.Drawing.Size(46, 16);
			this.label_login.TabIndex = 3;
			this.label_login.Text = "Логин";
			// 
			// label_password
			// 
			this.label_password.AutoSize = true;
			this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_password.Location = new System.Drawing.Point(85, 162);
			this.label_password.Name = "label_password";
			this.label_password.Size = new System.Drawing.Size(56, 16);
			this.label_password.TabIndex = 4;
			this.label_password.Text = "Пароль";
			// 
			// AuthorizationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 399);
			this.Controls.Add(this.label_password);
			this.Controls.Add(this.label_login);
			this.Controls.Add(this.textBox_password);
			this.Controls.Add(this.textBox_login);
			this.Controls.Add(this.btn_login);
			this.Name = "AuthorizationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авторизация";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
    }
}