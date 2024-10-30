namespace Tulja_jeweller
{
    partial class showbills
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            majuri = new TextBox();
            bhaav = new TextBox();
            vigat = new RichTextBox();
            search = new TextBox();
            searchbtn = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            naam = new TextBox();
            label9 = new Label();
            tarikh = new TextBox();
            label10 = new Label();
            gaam = new TextBox();
            label11 = new Label();
            mo = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label12 = new Label();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AccessibleRole = AccessibleRole.TitleBar;
            tableLayoutPanel1.AllowDrop = true;
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Center;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.8738174F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.12618F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 74F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.Controls.Add(label4, 3, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(majuri, 2, 1);
            tableLayoutPanel1.Controls.Add(bhaav, 3, 1);
            tableLayoutPanel1.Controls.Add(vigat, 1, 1);
            tableLayoutPanel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(25, 247);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.0684929F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 84.9315F));
            tableLayoutPanel1.Size = new Size(803, 219);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(741, 9);
            label4.Name = "label4";
            label4.Size = new Size(48, 25);
            label4.TabIndex = 2;
            label4.Text = "ભાવ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(362, 9);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 1;
            label2.Text = "વિગત";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(661, 9);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 2;
            label3.Text = "મજુરી";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(37, 25);
            label1.TabIndex = 0;
            label1.Text = "ક્રમ";
            // 
            // majuri
            // 
            majuri.Location = new Point(656, 40);
            majuri.Name = "majuri";
            majuri.Size = new Size(68, 27);
            majuri.TabIndex = 4;
            // 
            // bhaav
            // 
            bhaav.Location = new Point(733, 40);
            bhaav.Name = "bhaav";
            bhaav.Size = new Size(64, 27);
            bhaav.TabIndex = 5;
            // 
            // vigat
            // 
            vigat.Location = new Point(137, 40);
            vigat.Name = "vigat";
            vigat.Size = new Size(510, 173);
            vigat.TabIndex = 3;
            vigat.Text = "";
            // 
            // search
            // 
            search.Location = new Point(233, 472);
            search.Name = "search";
            search.PlaceholderText = "Search Name";
            search.Size = new Size(248, 27);
            search.TabIndex = 1;
            // 
            // searchbtn
            // 
            searchbtn.BackColor = Color.Lime;
            searchbtn.ForeColor = Color.White;
            searchbtn.Location = new Point(487, 472);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(94, 29);
            searchbtn.TabIndex = 2;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = false;
            searchbtn.Click += searchbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(12, 21);
            label5.Name = "label5";
            label5.Size = new Size(183, 28);
            label5.TabIndex = 3;
            label5.Text = "શ્રી તુલજા ભવાની મા";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(374, 9);
            label6.Name = "label6";
            label6.Size = new Size(92, 28);
            label6.TabIndex = 4;
            label6.Text = "|| શ્રી 1 ||";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(711, 21);
            label7.Name = "label7";
            label7.Size = new Size(117, 28);
            label7.TabIndex = 5;
            label7.Text = "શ્રી મેલડી મા";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(12, 94);
            label8.Name = "label8";
            label8.Size = new Size(49, 28);
            label8.TabIndex = 6;
            label8.Text = "નામ";
            // 
            // naam
            // 
            naam.Location = new Point(67, 98);
            naam.Name = "naam";
            naam.Size = new Size(156, 27);
            naam.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(612, 94);
            label9.Name = "label9";
            label9.Size = new Size(70, 28);
            label9.TabIndex = 8;
            label9.Text = "તારીખ";
            // 
            // tarikh
            // 
            tarikh.Location = new Point(688, 98);
            tarikh.Name = "tarikh";
            tarikh.ReadOnly = true;
            tarikh.Size = new Size(156, 27);
            tarikh.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(612, 151);
            label10.Name = "label10";
            label10.Size = new Size(50, 28);
            label10.TabIndex = 10;
            label10.Text = "ગામ";
            // 
            // gaam
            // 
            gaam.Location = new Point(688, 155);
            gaam.Name = "gaam";
            gaam.Size = new Size(156, 27);
            gaam.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(12, 151);
            label11.Name = "label11";
            label11.Size = new Size(48, 28);
            label11.TabIndex = 12;
            label11.Text = "Mo.";
            // 
            // mo
            // 
            mo.Location = new Point(67, 155);
            mo.Name = "mo";
            mo.Size = new Size(156, 27);
            mo.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(336, 56);
            label12.Name = "label12";
            label12.Size = new Size(158, 28);
            label12.TabIndex = 14;
            label12.Text = "શ્રી તુલજા જવેલર્સ";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 128);
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(734, 472);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 15;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // showbills
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 523);
            Controls.Add(button1);
            Controls.Add(label12);
            Controls.Add(mo);
            Controls.Add(label11);
            Controls.Add(gaam);
            Controls.Add(label10);
            Controls.Add(tarikh);
            Controls.Add(label9);
            Controls.Add(naam);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(searchbtn);
            Controls.Add(search);
            Controls.Add(tableLayoutPanel1);
            Name = "showbills";
            Text = "showbills";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox search;
        private Button searchbtn;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox naam;
        private Label label9;
        private TextBox tarikh;
        private Label label10;
        private TextBox gaam;
        private Label label11;
        private TextBox mo;
        private RichTextBox vigat;
        private TextBox majuri;
        private TextBox bhaav;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label12;
        private Button button1;
    }
}