namespace Quản_lý_công_ty_du_lịch
{
    partial class f_login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_click = new System.Windows.Forms.Button();
            this.sign_in_click = new System.Windows.Forms.Button();
            this.register_click = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.login_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.login_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exit_click);
            this.panel1.Controls.Add(this.sign_in_click);
            this.panel1.Controls.Add(this.register_click);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 394);
            this.panel1.TabIndex = 0;
            // 
            // exit_click
            // 
            this.exit_click.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_click.Location = new System.Drawing.Point(586, 320);
            this.exit_click.Name = "exit_click";
            this.exit_click.Size = new System.Drawing.Size(145, 58);
            this.exit_click.TabIndex = 5;
            this.exit_click.Text = "Thoát";
            this.exit_click.UseVisualStyleBackColor = true;
            this.exit_click.Click += new System.EventHandler(this.exit_click_Click);
            // 
            // sign_in_click
            // 
            this.sign_in_click.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_in_click.Location = new System.Drawing.Point(47, 320);
            this.sign_in_click.Name = "sign_in_click";
            this.sign_in_click.Size = new System.Drawing.Size(206, 58);
            this.sign_in_click.TabIndex = 3;
            this.sign_in_click.Text = "Đăng nhập";
            this.sign_in_click.UseVisualStyleBackColor = true;
            this.sign_in_click.Click += new System.EventHandler(this.sign_in_click_Click);
            // 
            // register_click
            // 
            this.register_click.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_click.Location = new System.Drawing.Point(302, 320);
            this.register_click.Name = "register_click";
            this.register_click.Size = new System.Drawing.Size(229, 58);
            this.register_click.TabIndex = 4;
            this.register_click.Text = "Đăng ký";
            this.register_click.UseVisualStyleBackColor = true;
            this.register_click.Click += new System.EventHandler(this.register_click_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.login_pass);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(18, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(739, 102);
            this.panel3.TabIndex = 2;
            // 
            // login_pass
            // 
            this.login_pass.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_pass.Location = new System.Drawing.Point(335, 19);
            this.login_pass.Name = "login_pass";
            this.login_pass.Size = new System.Drawing.Size(350, 50);
            this.login_pass.TabIndex = 1;
            this.login_pass.UseSystemPasswordChar = true;
            this.login_pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 52);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.login_name);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(18, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 102);
            this.panel2.TabIndex = 0;
            // 
            // login_name
            // 
            this.login_name.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_name.Location = new System.Drawing.Point(335, 21);
            this.login_name.Name = "login_name";
            this.login_name.Size = new System.Drawing.Size(350, 50);
            this.login_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // f_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "f_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f_login_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button register_click;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox login_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox login_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit_click;
        private System.Windows.Forms.Button sign_in_click;
    }
}

