
namespace Halal_ECodes_Checker
{
    partial class halal_ecode_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(halal_ecode_form));
            this.ecode_inp_txt = new System.Windows.Forms.TextBox();
            this.check_ecode_btn = new System.Windows.Forms.Button();
            this.ecode_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.desc_lbl = new System.Windows.Forms.Label();
            this.clarification_lbl = new System.Windows.Forms.Label();
            this.title_lbl = new System.Windows.Forms.Label();
            this.halal_btn = new System.Windows.Forms.Button();
            this.haram_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.help_btn = new System.Windows.Forms.Button();
            this.status_lbl = new System.Windows.Forms.Label();
            this.musbooh_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ecode_inp_txt
            // 
            this.ecode_inp_txt.Location = new System.Drawing.Point(112, 73);
            this.ecode_inp_txt.Name = "ecode_inp_txt";
            this.ecode_inp_txt.Size = new System.Drawing.Size(508, 27);
            this.ecode_inp_txt.TabIndex = 1;
            // 
            // check_ecode_btn
            // 
            this.check_ecode_btn.AutoSize = true;
            this.check_ecode_btn.BackColor = System.Drawing.Color.Transparent;
            this.check_ecode_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.check_ecode_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.check_ecode_btn.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.check_ecode_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.check_ecode_btn.Location = new System.Drawing.Point(0, 489);
            this.check_ecode_btn.Name = "check_ecode_btn";
            this.check_ecode_btn.Size = new System.Drawing.Size(650, 42);
            this.check_ecode_btn.TabIndex = 2;
            this.check_ecode_btn.Text = "Check E-Code";
            this.check_ecode_btn.UseVisualStyleBackColor = false;
            this.check_ecode_btn.Click += new System.EventHandler(this.check_ecode_btn_Click);
            // 
            // ecode_lbl
            // 
            this.ecode_lbl.AutoSize = true;
            this.ecode_lbl.BackColor = System.Drawing.Color.Transparent;
            this.ecode_lbl.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ecode_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ecode_lbl.Location = new System.Drawing.Point(12, 73);
            this.ecode_lbl.Name = "ecode_lbl";
            this.ecode_lbl.Size = new System.Drawing.Size(74, 21);
            this.ecode_lbl.TabIndex = 0;
            this.ecode_lbl.Text = "E-Code";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.BackColor = System.Drawing.Color.Transparent;
            this.name_lbl.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.name_lbl.Location = new System.Drawing.Point(12, 146);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(73, 21);
            this.name_lbl.TabIndex = 3;
            this.name_lbl.Text = "Name: ";
            // 
            // desc_lbl
            // 
            this.desc_lbl.AutoSize = true;
            this.desc_lbl.BackColor = System.Drawing.Color.Transparent;
            this.desc_lbl.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.desc_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.desc_lbl.Location = new System.Drawing.Point(12, 200);
            this.desc_lbl.Name = "desc_lbl";
            this.desc_lbl.Size = new System.Drawing.Size(125, 21);
            this.desc_lbl.TabIndex = 4;
            this.desc_lbl.Text = "Description: ";
            // 
            // clarification_lbl
            // 
            this.clarification_lbl.BackColor = System.Drawing.Color.Transparent;
            this.clarification_lbl.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clarification_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.clarification_lbl.Location = new System.Drawing.Point(12, 299);
            this.clarification_lbl.Name = "clarification_lbl";
            this.clarification_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clarification_lbl.Size = new System.Drawing.Size(626, 93);
            this.clarification_lbl.TabIndex = 5;
            this.clarification_lbl.Text = "Clarification: ";
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.BackColor = System.Drawing.Color.Transparent;
            this.title_lbl.Font = new System.Drawing.Font("OCR A Extended", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.title_lbl.Location = new System.Drawing.Point(112, 9);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(398, 45);
            this.title_lbl.TabIndex = 6;
            this.title_lbl.Text = "E-Code Checker";
            // 
            // halal_btn
            // 
            this.halal_btn.AutoSize = true;
            this.halal_btn.BackColor = System.Drawing.Color.Transparent;
            this.halal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.halal_btn.Font = new System.Drawing.Font("Castellar", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.halal_btn.ForeColor = System.Drawing.Color.Lime;
            this.halal_btn.Location = new System.Drawing.Point(0, 441);
            this.halal_btn.Name = "halal_btn";
            this.halal_btn.Size = new System.Drawing.Size(226, 40);
            this.halal_btn.TabIndex = 7;
            this.halal_btn.Text = "Halal Codes";
            this.halal_btn.UseVisualStyleBackColor = false;
            this.halal_btn.Click += new System.EventHandler(this.halal_btn_Click);
            // 
            // haram_btn
            // 
            this.haram_btn.AutoSize = true;
            this.haram_btn.BackColor = System.Drawing.Color.Transparent;
            this.haram_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.haram_btn.Font = new System.Drawing.Font("Castellar", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.haram_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.haram_btn.Location = new System.Drawing.Point(223, 441);
            this.haram_btn.Name = "haram_btn";
            this.haram_btn.Size = new System.Drawing.Size(226, 40);
            this.haram_btn.TabIndex = 8;
            this.haram_btn.Text = "Haram Codes";
            this.haram_btn.UseVisualStyleBackColor = false;
            this.haram_btn.Click += new System.EventHandler(this.haram_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.AutoSize = true;
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close_btn.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.close_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.close_btn.Location = new System.Drawing.Point(583, 9);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(57, 42);
            this.close_btn.TabIndex = 9;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // help_btn
            // 
            this.help_btn.AutoSize = true;
            this.help_btn.BackColor = System.Drawing.Color.Transparent;
            this.help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.help_btn.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.help_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.help_btn.Location = new System.Drawing.Point(516, 9);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(57, 42);
            this.help_btn.TabIndex = 10;
            this.help_btn.Text = "?";
            this.help_btn.UseVisualStyleBackColor = false;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.BackColor = System.Drawing.Color.Transparent;
            this.status_lbl.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.status_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.status_lbl.Location = new System.Drawing.Point(12, 247);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(80, 21);
            this.status_lbl.TabIndex = 11;
            this.status_lbl.Text = "Status: ";
            // 
            // musbooh_btn
            // 
            this.musbooh_btn.AutoSize = true;
            this.musbooh_btn.BackColor = System.Drawing.Color.Transparent;
            this.musbooh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.musbooh_btn.Font = new System.Drawing.Font("Castellar", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.musbooh_btn.ForeColor = System.Drawing.Color.Yellow;
            this.musbooh_btn.Location = new System.Drawing.Point(445, 441);
            this.musbooh_btn.Name = "musbooh_btn";
            this.musbooh_btn.Size = new System.Drawing.Size(208, 40);
            this.musbooh_btn.TabIndex = 12;
            this.musbooh_btn.Text = "Musbooh Codes";
            this.musbooh_btn.UseVisualStyleBackColor = false;
            this.musbooh_btn.Click += new System.EventHandler(this.musbooh_btn_Click);
            // 
            // halal_ecode_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 531);
            this.Controls.Add(this.musbooh_btn);
            this.Controls.Add(this.status_lbl);
            this.Controls.Add(this.help_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.haram_btn);
            this.Controls.Add(this.halal_btn);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.clarification_lbl);
            this.Controls.Add(this.desc_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.check_ecode_btn);
            this.Controls.Add(this.ecode_inp_txt);
            this.Controls.Add(this.ecode_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "halal_ecode_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Halal ECode Checker - v 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ecode_inp_txt;
        private System.Windows.Forms.Button check_ecode_btn;
        private System.Windows.Forms.Label ecode_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label desc_lbl;
        private System.Windows.Forms.Label clarification_lbl;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Button halal_btn;
        private System.Windows.Forms.Button haram_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button help_btn;
        private System.Windows.Forms.Label status_lbl;
        private System.Windows.Forms.Button musbooh_btn;
    }
}

