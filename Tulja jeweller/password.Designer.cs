﻿namespace Tulja_jeweller
{
    partial class password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(password));
            pass = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // pass
            // 
            pass.Location = new Point(303, 168);
            pass.Name = "pass";
            pass.Size = new Size(178, 27);
            pass.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Location = new Point(343, 201);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "ENTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pass);
            MaximizeBox = false;
            Name = "password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pass;
        private Button button1;
    }
}