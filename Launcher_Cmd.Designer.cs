namespace Cmmdx_Launcher
{
    partial class Launcher_Cmd
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
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewG1", System.Windows.Forms.HorizontalAlignment.Left);
            this.startbutton = new Guna.UI2.WinForms.Guna2Button();
            this.TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Stopbutton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Refresh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.startbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.startbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.startbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.startbutton.FillColor = System.Drawing.Color.Lime;
            this.startbutton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startbutton.ForeColor = System.Drawing.Color.Black;
            this.startbutton.Location = new System.Drawing.Point(45, 326);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(158, 39);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "Start";
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // TextBox
            // 
            this.TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox.DefaultText = "";
            this.TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox.Location = new System.Drawing.Point(263, 326);
            this.TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox.Name = "TextBox";
            this.TextBox.PasswordChar = '\0';
            this.TextBox.PlaceholderText = "";
            this.TextBox.SelectedText = "";
            this.TextBox.Size = new System.Drawing.Size(217, 39);
            this.TextBox.TabIndex = 1;
            // 
            // Stopbutton
            // 
            this.Stopbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Stopbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Stopbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Stopbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Stopbutton.FillColor = System.Drawing.Color.Red;
            this.Stopbutton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Stopbutton.ForeColor = System.Drawing.Color.Black;
            this.Stopbutton.Location = new System.Drawing.Point(539, 326);
            this.Stopbutton.Name = "Stopbutton";
            this.Stopbutton.Size = new System.Drawing.Size(158, 39);
            this.Stopbutton.TabIndex = 3;
            this.Stopbutton.Text = "Stop";
            this.Stopbutton.Click += new System.EventHandler(this.Stopbutton_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(688, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(38, 30);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "X";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.startbutton;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.Stopbutton;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 10;
            this.guna2Elipse3.TargetControl = this.TextBox;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 10;
            this.guna2Elipse4.TargetControl = this.listView1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            listViewGroup2.Header = "ListViewG1";
            listViewGroup2.Name = "ListByCmmdx";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(45, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(652, 257);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 10;
            this.guna2Elipse5.TargetControl = this.guna2Button1;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 12;
            this.guna2Elipse6.TargetControl = this;
            // 
            // column
            // 
            this.column.Text = "Name";
            this.column.Width = 627;
            // 
            // Refresh
            // 
            this.Refresh.BorderColor = System.Drawing.Color.Transparent;
            this.Refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Refresh.FillColor = System.Drawing.Color.Yellow;
            this.Refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Refresh.ForeColor = System.Drawing.Color.Black;
            this.Refresh.Location = new System.Drawing.Point(280, 384);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(180, 42);
            this.Refresh.TabIndex = 6;
            this.Refresh.Text = "Refresh";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.BorderRadius = 11;
            this.guna2Elipse7.TargetControl = this.Refresh;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Launcher Cmd";
            // 
            // Launcher_Cmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(738, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.Stopbutton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.startbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Launcher_Cmd";
            this.Text = "Launcher_Cmd";
            this.Load += new System.EventHandler(this.Launcher_Cmd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button startbutton;
        private Guna.UI2.WinForms.Guna2TextBox TextBox;
        private Guna.UI2.WinForms.Guna2Button Stopbutton;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader column;
        private Guna.UI2.WinForms.Guna2Button Refresh;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private System.Windows.Forms.Label label1;
    }
}