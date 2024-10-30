namespace Tulja_jeweller
{
    partial class Form1
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
            billcreate = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // billcreate
            // 
            billcreate.BackColor = Color.FromArgb(0, 192, 192);
            billcreate.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            billcreate.ForeColor = Color.White;
            billcreate.Location = new Point(237, 157);
            billcreate.Name = "billcreate";
            billcreate.Size = new Size(157, 43);
            billcreate.TabIndex = 0;
            billcreate.Text = "Create Bill";
            billcreate.UseVisualStyleBackColor = false;
            billcreate.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 192);
            button2.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(409, 157);
            button2.Name = "button2";
            button2.Size = new Size(157, 43);
            button2.TabIndex = 1;
            button2.Text = "Show Bils";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(billcreate);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button billcreate;
        private Button button2;
    }
}