using System.Windows.Forms;
namespace FileNameChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            openFileDialog1 = new OpenFileDialog();
            Filenames = new ListBox();
            OpenFilesBt = new Button();
            InputNames = new TextBox();
            PrefixTxt = new TextBox();
            Suffixtxt = new TextBox();
            ChagefileNames = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Filenames
            // 
            Filenames.BackColor = Color.WhiteSmoke;
            Filenames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Filenames.FormattingEnabled = true;
            Filenames.Location = new Point(324, 32);
            Filenames.Name = "Filenames";
            Filenames.Size = new Size(344, 360);
            Filenames.TabIndex = 0;
            // 
            // OpenFilesBt
            // 
            OpenFilesBt.BackColor = Color.GreenYellow;
            OpenFilesBt.Cursor = Cursors.Hand;
            OpenFilesBt.FlatAppearance.BorderColor = Color.White;
            OpenFilesBt.FlatAppearance.BorderSize = 0;
            OpenFilesBt.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            OpenFilesBt.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
            OpenFilesBt.FlatStyle = FlatStyle.Flat;
            OpenFilesBt.Font = new Font("abeatbyKai", 12F);
            OpenFilesBt.Location = new Point(11, 17);
            OpenFilesBt.Name = "OpenFilesBt";
            OpenFilesBt.Size = new Size(122, 49);
            OpenFilesBt.TabIndex = 1;
            OpenFilesBt.Text = "Open Files";
            OpenFilesBt.UseVisualStyleBackColor = false;
            OpenFilesBt.Click += OpenFilesBt_Click;
            // 
            // InputNames
            // 
            InputNames.BackColor = Color.WhiteSmoke;
            InputNames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            InputNames.Location = new Point(11, 118);
            InputNames.Multiline = true;
            InputNames.Name = "InputNames";
            InputNames.Size = new Size(307, 274);
            InputNames.TabIndex = 2;
            InputNames.TextChanged += InputNames_TextChanged;
            // 
            // PrefixTxt
            // 
            PrefixTxt.BackColor = Color.FromArgb(240, 247, 237);
            PrefixTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PrefixTxt.ForeColor = SystemColors.WindowFrame;
            PrefixTxt.Location = new Point(11, 80);
            PrefixTxt.Multiline = true;
            PrefixTxt.Name = "PrefixTxt";
            PrefixTxt.Size = new Size(150, 25);
            PrefixTxt.TabIndex = 4;
            PrefixTxt.Text = "Prefix...";
            PrefixTxt.TextChanged += PrefixTxt_TextChanged;
            PrefixTxt.MouseDown += PrefixTxt_MouseDown;
            // 
            // Suffixtxt
            // 
            Suffixtxt.BackColor = Color.FromArgb(240, 247, 237);
            Suffixtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Suffixtxt.ForeColor = SystemColors.WindowFrame;
            Suffixtxt.Location = new Point(168, 80);
            Suffixtxt.Multiline = true;
            Suffixtxt.Name = "Suffixtxt";
            Suffixtxt.Size = new Size(150, 25);
            Suffixtxt.TabIndex = 5;
            Suffixtxt.Text = "Suffix...";
            Suffixtxt.TextChanged += Suffixtxt_TextChanged;
            Suffixtxt.MouseDown += Suffixtxt_MouseDown;
            // 
            // ChagefileNames
            // 
            ChagefileNames.BackColor = Color.FromArgb(221, 247, 208);
            ChagefileNames.Cursor = Cursors.Hand;
            ChagefileNames.FlatAppearance.BorderColor = Color.White;
            ChagefileNames.FlatAppearance.BorderSize = 0;
            ChagefileNames.FlatAppearance.MouseDownBackColor = Color.PaleGoldenrod;
            ChagefileNames.FlatAppearance.MouseOverBackColor = Color.LightGoldenrodYellow;
            ChagefileNames.FlatStyle = FlatStyle.Flat;
            ChagefileNames.Font = new Font("abeatbyKai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChagefileNames.ForeColor = Color.DimGray;
            ChagefileNames.Location = new Point(145, 17);
            ChagefileNames.Name = "ChagefileNames";
            ChagefileNames.Size = new Size(168, 49);
            ChagefileNames.TabIndex = 6;
            ChagefileNames.Text = "Chage File Names";
            ChagefileNames.UseVisualStyleBackColor = false;
            ChagefileNames.Click += ChagefileNames_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("abeatbyKai", 12F);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(324, 13);
            label1.Name = "label1";
            label1.Size = new Size(58, 16);
            label1.TabIndex = 7;
            label1.Text = "Output";
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 402);
            Controls.Add(label1);
            Controls.Add(ChagefileNames);
            Controls.Add(Suffixtxt);
            Controls.Add(PrefixTxt);
            Controls.Add(InputNames);
            Controls.Add(OpenFilesBt);
            Controls.Add(Filenames);
            DisplayHeader = false;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Padding = new Padding(20, 30, 20, 20);
            Resizable = false;
            ShadowType = MetroFormShadowType.DropShadow;
            Style = MetroFramework.MetroColorStyle.Lime;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private ListBox Filenames;
        private Button OpenFilesBt;
        private TextBox InputNames;
        private TextBox PrefixTxt;
        private TextBox Suffixtxt;
        private Button ChagefileNames;
        private Label label1;
    }
}
