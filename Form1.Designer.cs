namespace LibertyX
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectApi = new System.Windows.Forms.Button();
            this.script_P = new System.Windows.Forms.Panel();
            this.b12 = new System.Windows.Forms.Button();
            this.b11 = new System.Windows.Forms.Button();
            this.b10 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b13 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.script_P.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(691, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(651, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "--";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(141, 18);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.fastColoredTextBox1.CharHeight = 18;
            this.fastColoredTextBox1.CharWidth = 10;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(7, 45);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(547, 296);
            this.fastColoredTextBox1.TabIndex = 2;
            this.fastColoredTextBox1.Text = "Hello World";
            this.fastColoredTextBox1.Zoom = 100;
            this.fastColoredTextBox1.Load += new System.EventHandler(this.fastColoredTextBox_Load);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(7, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Execute";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(104, 347);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(196, 347);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 34);
            this.button5.TabIndex = 5;
            this.button5.Text = "Open File";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(288, 347);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 34);
            this.button6.TabIndex = 6;
            this.button6.Text = "Save File";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(634, 347);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 34);
            this.button7.TabIndex = 7;
            this.button7.Text = "Inject";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(-7, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 45);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMoveable_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "LibertyX";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SelectApi
            // 
            this.SelectApi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SelectApi.FlatAppearance.BorderSize = 0;
            this.SelectApi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectApi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectApi.Location = new System.Drawing.Point(537, 347);
            this.SelectApi.Name = "SelectApi";
            this.SelectApi.Size = new System.Drawing.Size(91, 34);
            this.SelectApi.TabIndex = 10;
            this.SelectApi.Text = "Scripts";
            this.SelectApi.UseVisualStyleBackColor = false;
            this.SelectApi.Click += new System.EventHandler(this.SelectApi_Click);
            // 
            // script_P
            // 
            this.script_P.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.script_P.Controls.Add(this.b12);
            this.script_P.Controls.Add(this.b11);
            this.script_P.Controls.Add(this.b10);
            this.script_P.Controls.Add(this.b9);
            this.script_P.Controls.Add(this.b8);
            this.script_P.Controls.Add(this.b7);
            this.script_P.Controls.Add(this.b6);
            this.script_P.Controls.Add(this.b5);
            this.script_P.Controls.Add(this.b4);
            this.script_P.Controls.Add(this.b3);
            this.script_P.Controls.Add(this.b2);
            this.script_P.Controls.Add(this.b13);
            this.script_P.Location = new System.Drawing.Point(560, 45);
            this.script_P.Name = "script_P";
            this.script_P.Size = new System.Drawing.Size(156, 296);
            this.script_P.TabIndex = 11;
            // 
            // b12
            // 
            this.b12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.b12.Dock = System.Windows.Forms.DockStyle.Top;
            this.b12.FlatAppearance.BorderSize = 0;
            this.b12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b12.Location = new System.Drawing.Point(0, 253);
            this.b12.Name = "b12";
            this.b12.Size = new System.Drawing.Size(156, 23);
            this.b12.TabIndex = 12;
            this.b12.Text = "Lumber Tycoon";
            this.b12.UseVisualStyleBackColor = false;
            this.b12.Click += new System.EventHandler(this.b12_Click);
            // 
            // b11
            // 
            this.b11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.b11.Dock = System.Windows.Forms.DockStyle.Top;
            this.b11.FlatAppearance.BorderSize = 0;
            this.b11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b11.Location = new System.Drawing.Point(0, 230);
            this.b11.Name = "b11";
            this.b11.Size = new System.Drawing.Size(156, 23);
            this.b11.TabIndex = 11;
            this.b11.Text = "Muder Mystery";
            this.b11.UseVisualStyleBackColor = false;
            this.b11.Click += new System.EventHandler(this.b11_Click);
            // 
            // b10
            // 
            this.b10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.b10.Dock = System.Windows.Forms.DockStyle.Top;
            this.b10.FlatAppearance.BorderSize = 0;
            this.b10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b10.Location = new System.Drawing.Point(0, 207);
            this.b10.Name = "b10";
            this.b10.Size = new System.Drawing.Size(156, 23);
            this.b10.TabIndex = 10;
            this.b10.Text = "Wild West";
            this.b10.UseVisualStyleBackColor = false;
            this.b10.Click += new System.EventHandler(this.b10_Click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.b9.Dock = System.Windows.Forms.DockStyle.Top;
            this.b9.FlatAppearance.BorderSize = 0;
            this.b9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b9.Location = new System.Drawing.Point(0, 184);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(156, 23);
            this.b9.TabIndex = 9;
            this.b9.Text = "Tower Of Hell";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.b8.Dock = System.Windows.Forms.DockStyle.Top;
            this.b8.FlatAppearance.BorderSize = 0;
            this.b8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b8.Location = new System.Drawing.Point(0, 161);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(156, 23);
            this.b8.TabIndex = 8;
            this.b8.Text = "Bloxburg (FARM)";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.b7.Dock = System.Windows.Forms.DockStyle.Top;
            this.b7.FlatAppearance.BorderSize = 0;
            this.b7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b7.Location = new System.Drawing.Point(0, 138);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(156, 23);
            this.b7.TabIndex = 7;
            this.b7.Text = "Royle High (FARM)";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.b6.Dock = System.Windows.Forms.DockStyle.Top;
            this.b6.FlatAppearance.BorderSize = 0;
            this.b6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b6.Location = new System.Drawing.Point(0, 115);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(156, 23);
            this.b6.TabIndex = 6;
            this.b6.Text = "Infinate Yeild";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.b5.Dock = System.Windows.Forms.DockStyle.Top;
            this.b5.FlatAppearance.BorderSize = 0;
            this.b5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b5.Location = new System.Drawing.Point(0, 92);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(156, 23);
            this.b5.TabIndex = 5;
            this.b5.Text = "Islands";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.b4.Dock = System.Windows.Forms.DockStyle.Top;
            this.b4.FlatAppearance.BorderSize = 0;
            this.b4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b4.Location = new System.Drawing.Point(0, 69);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(156, 23);
            this.b4.TabIndex = 4;
            this.b4.Text = "Adopt me";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.b3.Dock = System.Windows.Forms.DockStyle.Top;
            this.b3.FlatAppearance.BorderSize = 0;
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b3.Location = new System.Drawing.Point(0, 46);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(156, 23);
            this.b3.TabIndex = 3;
            this.b3.Text = "Jailbreak (FARM)";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.b2.Dock = System.Windows.Forms.DockStyle.Top;
            this.b2.FlatAppearance.BorderSize = 0;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b2.Location = new System.Drawing.Point(0, 23);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(156, 23);
            this.b2.TabIndex = 2;
            this.b2.Text = "Jailbreak ";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b13
            // 
            this.b13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.b13.Dock = System.Windows.Forms.DockStyle.Top;
            this.b13.FlatAppearance.BorderSize = 0;
            this.b13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b13.Location = new System.Drawing.Point(0, 0);
            this.b13.Name = "b13";
            this.b13.Size = new System.Drawing.Size(156, 23);
            this.b13.TabIndex = 1;
            this.b13.Text = "Aimbot";
            this.b13.UseVisualStyleBackColor = false;
            this.b13.Click += new System.EventHandler(this.b13_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel.Controls.Add(this.button17);
            this.panel.Controls.Add(this.button16);
            this.panel.Controls.Add(this.button15);
            this.panel.Controls.Add(this.button14);
            this.panel.Controls.Add(this.button13);
            this.panel.Controls.Add(this.button12);
            this.panel.Controls.Add(this.button11);
            this.panel.Controls.Add(this.button10);
            this.panel.Controls.Add(this.button9);
            this.panel.Controls.Add(this.b);
            this.panel.Location = new System.Drawing.Point(560, 45);
            this.panel.MaximumSize = new System.Drawing.Size(156, 296);
            this.panel.MinimumSize = new System.Drawing.Size(10, 296);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(156, 296);
            this.panel.TabIndex = 12;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button17.Dock = System.Windows.Forms.DockStyle.Top;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button17.Location = new System.Drawing.Point(0, 207);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(156, 23);
            this.button17.TabIndex = 11;
            this.button17.Text = "coming soon...";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button16.Dock = System.Windows.Forms.DockStyle.Top;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button16.Location = new System.Drawing.Point(0, 184);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(156, 23);
            this.button16.TabIndex = 10;
            this.button16.Text = "coming soon...";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button15.Dock = System.Windows.Forms.DockStyle.Top;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button15.Location = new System.Drawing.Point(0, 161);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(156, 23);
            this.button15.TabIndex = 9;
            this.button15.Text = "coming soon...";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button14.Dock = System.Windows.Forms.DockStyle.Top;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button14.Location = new System.Drawing.Point(0, 138);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(156, 23);
            this.button14.TabIndex = 8;
            this.button14.Text = "coming soon...";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button13.Dock = System.Windows.Forms.DockStyle.Top;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button13.Location = new System.Drawing.Point(0, 115);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(156, 23);
            this.button13.TabIndex = 7;
            this.button13.Text = "coming soon...";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button12.Location = new System.Drawing.Point(0, 92);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(156, 23);
            this.button12.TabIndex = 6;
            this.button12.Text = "Krnl (NOT SETUP)";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button11.Location = new System.Drawing.Point(0, 69);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(156, 23);
            this.button11.TabIndex = 5;
            this.button11.Text = "Nihon";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button10.Location = new System.Drawing.Point(0, 46);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(156, 23);
            this.button10.TabIndex = 4;
            this.button10.Text = "Viper";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Location = new System.Drawing.Point(0, 23);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(156, 23);
            this.button9.TabIndex = 3;
            this.button9.Text = "EasyExploits";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // b
            // 
            this.b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.b.Dock = System.Windows.Forms.DockStyle.Top;
            this.b.FlatAppearance.BorderSize = 0;
            this.b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b.Location = new System.Drawing.Point(0, 0);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(156, 23);
            this.b.TabIndex = 2;
            this.b.Text = "Fluxus";
            this.b.UseVisualStyleBackColor = false;
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(728, 384);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.script_P);
            this.Controls.Add(this.SelectApi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.fastColoredTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.script_P.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SelectApi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel script_P;
        private System.Windows.Forms.Button b13;
        private System.Windows.Forms.Button b11;
        private System.Windows.Forms.Button b10;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b12;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button b;
    }
}

