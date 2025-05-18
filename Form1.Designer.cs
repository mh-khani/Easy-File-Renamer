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
            AutoIncrement = new RadioButton();
            AutoA_Z = new RadioButton();
            none = new RadioButton();
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
            Filenames.Enabled = false;
            Filenames.FormattingEnabled = true;
            Filenames.Location = new Point(324, 32);
            Filenames.Name = "Filenames";
            Filenames.Size = new Size(344, 375);
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
            OpenFilesBt.Size = new Size(150, 49);
            OpenFilesBt.TabIndex = 1;
            OpenFilesBt.Text = "Open Files";
            OpenFilesBt.UseVisualStyleBackColor = false;
            OpenFilesBt.Click += OpenFilesBt_Click;
            // 
            // InputNames
            // 
            InputNames.BackColor = Color.WhiteSmoke;
            InputNames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            InputNames.Enabled = false;
            InputNames.Location = new Point(11, 134);
            InputNames.Multiline = true;
            InputNames.Name = "InputNames";
            InputNames.Size = new Size(307, 290);
            InputNames.TabIndex = 2;
            InputNames.TextChanged += InputNames_TextChanged;
            // 
            // PrefixTxt
            // 
            PrefixTxt.BackColor = Color.FromArgb(240, 247, 237);
            PrefixTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PrefixTxt.Enabled = false;
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
            Suffixtxt.Enabled = false;
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
            ChagefileNames.Enabled = false;
            ChagefileNames.FlatAppearance.BorderColor = Color.White;
            ChagefileNames.FlatAppearance.BorderSize = 0;
            ChagefileNames.FlatAppearance.MouseDownBackColor = Color.PaleGoldenrod;
            ChagefileNames.FlatAppearance.MouseOverBackColor = Color.LightGoldenrodYellow;
            ChagefileNames.FlatStyle = FlatStyle.Flat;
            ChagefileNames.Font = new Font("abeatbyKai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChagefileNames.ForeColor = Color.DimGray;
            ChagefileNames.Location = new Point(168, 17);
            ChagefileNames.Name = "ChagefileNames";
            ChagefileNames.Size = new Size(145, 49);
            ChagefileNames.TabIndex = 6;
            ChagefileNames.Text = "Rename Files";
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
            label1.Size = new Size(71, 16);
            label1.TabIndex = 7;
            label1.Text = "Preview";
            // 
            // AutoIncrement
            // 
            AutoIncrement.AutoSize = true;
            AutoIncrement.Enabled = false;
            AutoIncrement.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 128);
            AutoIncrement.Font = new Font("Abscissa", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AutoIncrement.Location = new Point(13, 110);
            AutoIncrement.Name = "AutoIncrement";
            AutoIncrement.Size = new Size(124, 25);
            AutoIncrement.TabIndex = 8;
            AutoIncrement.Text = "Auto Increment\t";
            AutoIncrement.UseVisualStyleBackColor = true;
            AutoIncrement.CheckedChanged += AutoIncrement_CheckedChanged;
            // 
            // AutoA_Z
            // 
            AutoA_Z.AutoSize = true;
            AutoA_Z.Enabled = false;
            AutoA_Z.Font = new Font("Abscissa", 11.2499981F);
            AutoA_Z.Location = new Point(143, 110);
            AutoA_Z.Name = "AutoA_Z";
            AutoA_Z.Size = new Size(80, 25);
            AutoA_Z.TabIndex = 9;
            AutoA_Z.Text = "Auto A-Z";
            AutoA_Z.UseVisualStyleBackColor = true;
            AutoA_Z.CheckedChanged += AutoA_Z_CheckedChanged;
            // 
            // none
            // 
            none.AutoSize = true;
            none.Enabled = false;
            none.Font = new Font("Abscissa", 11.2499981F);
            none.Location = new Point(229, 110);
            none.Name = "none";
            none.Size = new Size(58, 25);
            none.TabIndex = 10;
            none.Text = "None";
            none.UseVisualStyleBackColor = true;
            none.CheckedChanged += none_CheckedChanged;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 434);
            Controls.Add(none);
            Controls.Add(AutoA_Z);
            Controls.Add(AutoIncrement);
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
        private RadioButton AutoIncrement;
        private RadioButton AutoA_Z;
        private RadioButton none;
    }
}
