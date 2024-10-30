namespace Tulja_jeweller
{
    partial class bill
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
            naam = new Label();
            label1 = new Label();
            name = new TextBox();
            gaam = new TextBox();
            label2 = new Label();
            viagat = new RichTextBox();
            label3 = new Label();
            date = new DateTimePicker();
            label4 = new Label();
            bhaav = new TextBox();
            majuri = new TextBox();
            label5 = new Label();
            label6 = new Label();
            Mo = new TextBox();
            create = new Button();
            SuspendLayout();
            // 
            // naam
            // 
            naam.AutoSize = true;
            naam.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            naam.Location = new Point(43, 24);
            naam.Name = "naam";
            naam.Size = new Size(73, 28);
            naam.TabIndex = 0;
            naam.Text = "Naam:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 67);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 1;
            label1.Text = "Gaam:";
            // 
            // name
            // 
            name.Location = new Point(122, 28);
            name.Name = "name";
            name.Size = new Size(140, 27);
            name.TabIndex = 2;
            // 
            // gaam
            // 
            gaam.Location = new Point(122, 71);
            gaam.Name = "gaam";
            gaam.Size = new Size(140, 27);
            gaam.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(43, 141);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 4;
            label2.Text = "vigat:";
            // 
            // viagat
            // 
            viagat.Location = new Point(43, 172);
            viagat.Name = "viagat";
            viagat.Size = new Size(281, 172);
            viagat.TabIndex = 5;
            viagat.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(395, 9);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 6;
            label3.Text = "Tarikh:";
            // 
            // date
            // 
            date.Location = new Point(334, 40);
            date.Name = "date";
            date.Size = new Size(250, 27);
            date.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(395, 80);
            label4.Name = "label4";
            label4.Size = new Size(75, 28);
            label4.TabIndex = 8;
            label4.Text = "Bhaav:";
            // 
            // bhaav
            // 
            bhaav.Location = new Point(369, 111);
            bhaav.Name = "bhaav";
            bhaav.Size = new Size(140, 27);
            bhaav.TabIndex = 9;
            // 
            // majuri
            // 
            majuri.Location = new Point(369, 183);
            majuri.Name = "majuri";
            majuri.Size = new Size(140, 27);
            majuri.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(397, 152);
            label5.Name = "label5";
            label5.Size = new Size(73, 28);
            label5.TabIndex = 10;
            label5.Text = "majuri";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(411, 230);
            label6.Name = "label6";
            label6.Size = new Size(48, 28);
            label6.TabIndex = 12;
            label6.Text = "Mo.";
            // 
            // Mo
            // 
            Mo.Location = new Point(369, 261);
            Mo.Name = "Mo";
            Mo.Size = new Size(151, 27);
            Mo.TabIndex = 13;
            // 
            // create
            // 
            create.BackColor = Color.FromArgb(128, 255, 255);
            create.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            create.ForeColor = SystemColors.ButtonFace;
            create.Location = new Point(381, 309);
            create.Name = "create";
            create.Size = new Size(103, 42);
            create.TabIndex = 14;
            create.Text = "Create";
            create.UseVisualStyleBackColor = false;
            create.Click += create_Click;
            // 
            // bill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 363);
            Controls.Add(create);
            Controls.Add(Mo);
            Controls.Add(label6);
            Controls.Add(majuri);
            Controls.Add(label5);
            Controls.Add(bhaav);
            Controls.Add(label4);
            Controls.Add(date);
            Controls.Add(label3);
            Controls.Add(viagat);
            Controls.Add(label2);
            Controls.Add(gaam);
            Controls.Add(name);
            Controls.Add(label1);
            Controls.Add(naam);
            Name = "bill";
            Text = "bill";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label naam;
        private Label label1;
        private TextBox name;
        private TextBox gaam;
        private Label label2;
        private RichTextBox viagat;
        private Label label3;
        private DateTimePicker date;
        private Label label4;
        private TextBox bhaav;
        private TextBox majuri;
        private Label label5;
        private Label label6;
        private TextBox Mo;
        private Button create;
    }
}