﻿namespace Overlay
{
    partial class Form1
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
            this.WB = new System.Windows.Forms.WebBrowser();
            this.submit_web_search = new System.Windows.Forms.Button();
            this.web_search = new System.Windows.Forms.TextBox();
            this.web_panel = new System.Windows.Forms.Panel();
            this.web_address_background = new System.Windows.Forms.Panel();
            this.drag_panel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contract = new System.Windows.Forms.Button();
            this.expand = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.webpage_back = new System.Windows.Forms.Button();
            this.exit_program = new System.Windows.Forms.Button();
            this.settings_panel = new System.Windows.Forms.Panel();
            this.web_panel.SuspendLayout();
            this.drag_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WB
            // 
            this.WB.Location = new System.Drawing.Point(0, 30);
            this.WB.Name = "WB";
            this.WB.ScrollBarsEnabled = false;
            this.WB.Size = new System.Drawing.Size(720, 405);
            this.WB.TabIndex = 0;
            this.WB.TabStop = false;
            this.WB.Url = new System.Uri("http://z", System.UriKind.Absolute);
            // 
            // submit_web_search
            // 
            this.submit_web_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            this.submit_web_search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            this.submit_web_search.FlatAppearance.BorderSize = 0;
            this.submit_web_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_web_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_web_search.ForeColor = System.Drawing.Color.White;
            this.submit_web_search.Location = new System.Drawing.Point(633, 42);
            this.submit_web_search.Name = "submit_web_search";
            this.submit_web_search.Size = new System.Drawing.Size(75, 23);
            this.submit_web_search.TabIndex = 1;
            this.submit_web_search.Text = "Search";
            this.submit_web_search.UseVisualStyleBackColor = false;
            this.submit_web_search.Click += new System.EventHandler(this.submit_web_search_Click);
            // 
            // web_search
            // 
            this.web_search.AcceptsReturn = true;
            this.web_search.BackColor = System.Drawing.Color.White;
            this.web_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.web_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.web_search.ForeColor = System.Drawing.Color.Black;
            this.web_search.Location = new System.Drawing.Point(17, 45);
            this.web_search.Multiline = true;
            this.web_search.Name = "web_search";
            this.web_search.Size = new System.Drawing.Size(605, 16);
            this.web_search.TabIndex = 2;
            this.web_search.TabStop = false;
            this.web_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.web_search_KeyDown);
            // 
            // web_panel
            // 
            this.web_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.web_panel.Controls.Add(this.web_address_background);
            this.web_panel.Location = new System.Drawing.Point(0, 30);
            this.web_panel.Name = "web_panel";
            this.web_panel.Size = new System.Drawing.Size(720, 46);
            this.web_panel.TabIndex = 3;
            // 
            // web_address_background
            // 
            this.web_address_background.BackColor = System.Drawing.Color.White;
            this.web_address_background.Location = new System.Drawing.Point(12, 12);
            this.web_address_background.Name = "web_address_background";
            this.web_address_background.Size = new System.Drawing.Size(615, 23);
            this.web_address_background.TabIndex = 0;
            // 
            // drag_panel
            // 
            this.drag_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            this.drag_panel.Controls.Add(this.textBox2);
            this.drag_panel.Controls.Add(this.label2);
            this.drag_panel.Controls.Add(this.textBox1);
            this.drag_panel.Controls.Add(this.label1);
            this.drag_panel.Controls.Add(this.contract);
            this.drag_panel.Controls.Add(this.expand);
            this.drag_panel.Controls.Add(this.settings_button);
            this.drag_panel.Controls.Add(this.webpage_back);
            this.drag_panel.Controls.Add(this.exit_program);
            this.drag_panel.Location = new System.Drawing.Point(0, 0);
            this.drag_panel.Name = "drag_panel";
            this.drag_panel.Size = new System.Drawing.Size(720, 30);
            this.drag_panel.TabIndex = 4;
            this.drag_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drag_panel_MouseDown);
            this.drag_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drag_panel_MouseMove);
            this.drag_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drag_panel_MouseUp);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(379, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(254, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resize";
            // 
            // contract
            // 
            this.contract.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            this.contract.FlatAppearance.BorderSize = 0;
            this.contract.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.contract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(209)))));
            this.contract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contract.ForeColor = System.Drawing.Color.White;
            this.contract.Location = new System.Drawing.Point(347, 0);
            this.contract.Name = "contract";
            this.contract.Size = new System.Drawing.Size(26, 30);
            this.contract.TabIndex = 5;
            this.contract.Text = "-";
            this.contract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contract.UseVisualStyleBackColor = true;
            this.contract.MouseDown += new System.Windows.Forms.MouseEventHandler(this.contract_MouseDown);
            this.contract.MouseUp += new System.Windows.Forms.MouseEventHandler(this.contract_MouseUp);
            // 
            // expand
            // 
            this.expand.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            this.expand.FlatAppearance.BorderSize = 0;
            this.expand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.expand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(209)))));
            this.expand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expand.ForeColor = System.Drawing.Color.White;
            this.expand.Location = new System.Drawing.Point(318, 0);
            this.expand.Name = "expand";
            this.expand.Size = new System.Drawing.Size(26, 30);
            this.expand.TabIndex = 4;
            this.expand.Text = "+";
            this.expand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expand.UseVisualStyleBackColor = true;
            this.expand.MouseDown += new System.Windows.Forms.MouseEventHandler(this.expand_MouseDown);
            this.expand.MouseUp += new System.Windows.Forms.MouseEventHandler(this.expand_MouseUp);
            // 
            // settings_button
            // 
            this.settings_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            this.settings_button.FlatAppearance.BorderSize = 0;
            this.settings_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.settings_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(209)))));
            this.settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_button.ForeColor = System.Drawing.Color.White;
            this.settings_button.Location = new System.Drawing.Point(86, 0);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(84, 30);
            this.settings_button.TabIndex = 3;
            this.settings_button.Text = "Settings";
            this.settings_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // webpage_back
            // 
            this.webpage_back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            this.webpage_back.FlatAppearance.BorderSize = 0;
            this.webpage_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.webpage_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(209)))));
            this.webpage_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.webpage_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webpage_back.ForeColor = System.Drawing.Color.White;
            this.webpage_back.Location = new System.Drawing.Point(0, 0);
            this.webpage_back.Name = "webpage_back";
            this.webpage_back.Size = new System.Drawing.Size(86, 30);
            this.webpage_back.TabIndex = 2;
            this.webpage_back.Text = "Go Back";
            this.webpage_back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.webpage_back.UseVisualStyleBackColor = true;
            this.webpage_back.Click += new System.EventHandler(this.webpage_back_Click);
            // 
            // exit_program
            // 
            this.exit_program.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            this.exit_program.FlatAppearance.BorderSize = 0;
            this.exit_program.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.exit_program.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(107)))), ((int)(((byte)(209)))));
            this.exit_program.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_program.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_program.ForeColor = System.Drawing.Color.White;
            this.exit_program.Location = new System.Drawing.Point(690, 0);
            this.exit_program.Name = "exit_program";
            this.exit_program.Size = new System.Drawing.Size(30, 30);
            this.exit_program.TabIndex = 1;
            this.exit_program.Text = "X";
            this.exit_program.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit_program.UseVisualStyleBackColor = true;
            this.exit_program.Click += new System.EventHandler(this.exit_program_Click);
            // 
            // settings_panel
            // 
            this.settings_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.settings_panel.Location = new System.Drawing.Point(0, 30);
            this.settings_panel.Name = "settings_panel";
            this.settings_panel.Size = new System.Drawing.Size(720, 0);
            this.settings_panel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(720, 76);
            this.Controls.Add(this.settings_panel);
            this.Controls.Add(this.drag_panel);
            this.Controls.Add(this.web_search);
            this.Controls.Add(this.submit_web_search);
            this.Controls.Add(this.web_panel);
            this.Controls.Add(this.WB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.web_panel.ResumeLayout(false);
            this.drag_panel.ResumeLayout(false);
            this.drag_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser WB;
        private System.Windows.Forms.Button submit_web_search;
        private System.Windows.Forms.TextBox web_search;
        private System.Windows.Forms.Panel web_panel;
        private System.Windows.Forms.Panel drag_panel;
        private System.Windows.Forms.Panel web_address_background;
        private System.Windows.Forms.Button exit_program;
        private System.Windows.Forms.Button webpage_back;
        private System.Windows.Forms.Panel settings_panel;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button expand;
        private System.Windows.Forms.Button contract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;

    }
}

