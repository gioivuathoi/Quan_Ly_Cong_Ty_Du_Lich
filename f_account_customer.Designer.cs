namespace Quản_lý_công_ty_du_lịch
{
    partial class f_account_customer
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
            this.button_search_tour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.looking_for_tour = new System.Windows.Forms.Label();
            this.TB_search_tour = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hồSơCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinVéĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.véToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hủyVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khiếuNạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cẩmNangDuLịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_get_phone_num_infor = new System.Windows.Forms.Button();
            this.button_get_mess_infor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_search_tour);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.looking_for_tour);
            this.panel1.Controls.Add(this.TB_search_tour);
            this.panel1.Location = new System.Drawing.Point(19, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 283);
            this.panel1.TabIndex = 0;
            // 
            // button_search_tour
            // 
            this.button_search_tour.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search_tour.Location = new System.Drawing.Point(109, 176);
            this.button_search_tour.Name = "button_search_tour";
            this.button_search_tour.Size = new System.Drawing.Size(256, 61);
            this.button_search_tour.TabIndex = 9;
            this.button_search_tour.Text = "Tìm Kiếm";
            this.button_search_tour.UseVisualStyleBackColor = true;
            this.button_search_tour.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bạn muốn đi đâu:";
            // 
            // looking_for_tour
            // 
            this.looking_for_tour.AutoSize = true;
            this.looking_for_tour.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.looking_for_tour.Location = new System.Drawing.Point(63, 9);
            this.looking_for_tour.Name = "looking_for_tour";
            this.looking_for_tour.Size = new System.Drawing.Size(400, 44);
            this.looking_for_tour.TabIndex = 1;
            this.looking_for_tour.Text = "Tìm kiếm Tour du lịch";
            this.looking_for_tour.Click += new System.EventHandler(this.label1_Click);
            // 
            // TB_search_tour
            // 
            this.TB_search_tour.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_search_tour.Location = new System.Drawing.Point(20, 112);
            this.TB_search_tour.Name = "TB_search_tour";
            this.TB_search_tour.Size = new System.Drawing.Size(469, 39);
            this.TB_search_tour.TabIndex = 0;
            this.TB_search_tour.UseWaitCursor = true;
            this.TB_search_tour.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHàngToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.véToolStripMenuItem,
            this.cẩmNangDuLịchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(893, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hồSơCáNhânToolStripMenuItem,
            this.thôngTinVéĐặtToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // hồSơCáNhânToolStripMenuItem
            // 
            this.hồSơCáNhânToolStripMenuItem.Name = "hồSơCáNhânToolStripMenuItem";
            this.hồSơCáNhânToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.hồSơCáNhânToolStripMenuItem.Text = "Hồ sơ cá nhân";
            this.hồSơCáNhânToolStripMenuItem.Click += new System.EventHandler(this.hồSơCáNhânToolStripMenuItem_Click);
            // 
            // thôngTinVéĐặtToolStripMenuItem
            // 
            this.thôngTinVéĐặtToolStripMenuItem.Name = "thôngTinVéĐặtToolStripMenuItem";
            this.thôngTinVéĐặtToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.thôngTinVéĐặtToolStripMenuItem.Text = "Thông tin vé đặt";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // véToolStripMenuItem
            // 
            this.véToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đặtVéToolStripMenuItem,
            this.hủyVéToolStripMenuItem,
            this.khiếuNạiToolStripMenuItem});
            this.véToolStripMenuItem.Name = "véToolStripMenuItem";
            this.véToolStripMenuItem.Size = new System.Drawing.Size(39, 24);
            this.véToolStripMenuItem.Text = "Vé";
            // 
            // đặtVéToolStripMenuItem
            // 
            this.đặtVéToolStripMenuItem.Name = "đặtVéToolStripMenuItem";
            this.đặtVéToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.đặtVéToolStripMenuItem.Text = "Đặt vé";
            this.đặtVéToolStripMenuItem.Click += new System.EventHandler(this.đặtVéToolStripMenuItem_Click);
            // 
            // hủyVéToolStripMenuItem
            // 
            this.hủyVéToolStripMenuItem.Name = "hủyVéToolStripMenuItem";
            this.hủyVéToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.hủyVéToolStripMenuItem.Text = "Hủy vé";
            // 
            // khiếuNạiToolStripMenuItem
            // 
            this.khiếuNạiToolStripMenuItem.Name = "khiếuNạiToolStripMenuItem";
            this.khiếuNạiToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.khiếuNạiToolStripMenuItem.Text = "Khiếu nại";
            // 
            // cẩmNangDuLịchToolStripMenuItem
            // 
            this.cẩmNangDuLịchToolStripMenuItem.Name = "cẩmNangDuLịchToolStripMenuItem";
            this.cẩmNangDuLịchToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.cẩmNangDuLịchToolStripMenuItem.Text = "Cẩm nang du lịch";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(19, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 337);
            this.panel2.TabIndex = 2;
            // 
            // button_get_phone_num_infor
            // 
            this.button_get_phone_num_infor.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_get_phone_num_infor.Location = new System.Drawing.Point(62, 158);
            this.button_get_phone_num_infor.Name = "button_get_phone_num_infor";
            this.button_get_phone_num_infor.Size = new System.Drawing.Size(188, 45);
            this.button_get_phone_num_infor.TabIndex = 2;
            this.button_get_phone_num_infor.Text = "Gọi điện";
            this.button_get_phone_num_infor.UseVisualStyleBackColor = true;
            this.button_get_phone_num_infor.Click += new System.EventHandler(this.button_get_phone_num_infor_Click);
            // 
            // button_get_mess_infor
            // 
            this.button_get_mess_infor.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_get_mess_infor.Location = new System.Drawing.Point(62, 80);
            this.button_get_mess_infor.Name = "button_get_mess_infor";
            this.button_get_mess_infor.Size = new System.Drawing.Size(188, 42);
            this.button_get_mess_infor.TabIndex = 1;
            this.button_get_mess_infor.Text = "Nhắn tin";
            this.button_get_mess_infor.UseVisualStyleBackColor = true;
            this.button_get_mess_infor.Click += new System.EventHandler(this.button_get_mess_infor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Liên hệ với chúng tôi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_get_phone_num_infor);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.button_get_mess_infor);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(547, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 636);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(306, 341);
            this.dataGridView1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Các tour thịnh hành:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(20, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(484, 311);
            this.dataGridView2.TabIndex = 0;
            // 
            // f_account_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 725);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "f_account_customer";
            this.Text = "Trang cá nhân";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hồSơCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinVéĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem véToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đặtVéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hủyVéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khiếuNạiToolStripMenuItem;
        private System.Windows.Forms.TextBox TB_search_tour;
        private System.Windows.Forms.Label looking_for_tour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_search_tour;
        private System.Windows.Forms.ToolStripMenuItem cẩmNangDuLịchToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_get_phone_num_infor;
        private System.Windows.Forms.Button button_get_mess_infor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}