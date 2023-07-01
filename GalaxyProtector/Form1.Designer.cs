
namespace GalaxyProtector
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
            this.ReText = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.df = new Guna.UI2.WinForms.Guna2CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.antidump = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ad = new Guna.UI2.WinForms.Guna2CheckBox();
            this.at = new Guna.UI2.WinForms.Guna2CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pm = new Guna.UI2.WinForms.Guna2CheckBox();
            this.pi = new Guna.UI2.WinForms.Guna2CheckBox();
            this.refp = new Guna.UI2.WinForms.Guna2CheckBox();
            this.call = new Guna.UI2.WinForms.Guna2CheckBox();
            this.LF = new Guna.UI2.WinForms.Guna2CheckBox();
            this.jcontrolflow = new Guna.UI2.WinForms.Guna2CheckBox();
            this.sufcon = new Guna.UI2.WinForms.Guna2CheckBox();
            this.rename2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.se = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cf = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ic = new Guna.UI2.WinForms.Guna2CheckBox();
            this.dn = new Guna.UI2.WinForms.Guna2CheckBox();
            this.de = new Guna.UI2.WinForms.Guna2CheckBox();
            this.dp = new Guna.UI2.WinForms.Guna2CheckBox();
            this.dm = new Guna.UI2.WinForms.Guna2CheckBox();
            this.junk = new Guna.UI2.WinForms.Guna2CheckBox();
            this.hidecode = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Help = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.antispy = new Guna.UI2.WinForms.Guna2CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReText
            // 
            this.ReText.Interval = 500;
            this.ReText.Tick += new System.EventHandler(this.ReText_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(557, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 236);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.Black;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.Color.White;
            this.output.Location = new System.Drawing.Point(14, 43);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(537, 236);
            this.output.TabIndex = 1;
            this.output.Text = "Loaded";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("LEMON MILK Light", 13F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(178)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Protection";
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.BackColor = System.Drawing.Color.Blue;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Items.AddRange(new object[] {
            "None, please select a file"});
            this.listBox1.Location = new System.Drawing.Point(132, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(305, 17);
            this.listBox1.TabIndex = 4;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(443, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(17, 17);
            this.button2.TabIndex = 5;
            this.button2.Text = "*";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // df
            // 
            this.df.Animated = true;
            this.df.AutoSize = true;
            this.df.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.df.CheckedState.BorderRadius = 0;
            this.df.CheckedState.BorderThickness = 0;
            this.df.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.df.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.df.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.df.Location = new System.Drawing.Point(21, 91);
            this.df.Name = "df";
            this.df.Size = new System.Drawing.Size(137, 23);
            this.df.TabIndex = 6;
            this.df.Text = "Disguise Fields";
            this.df.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.SetToolTip(this.df, "Renames the fields.");
            this.df.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.df.UncheckedState.BorderRadius = 0;
            this.df.UncheckedState.BorderThickness = 0;
            this.df.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Location = new System.Drawing.Point(-8, -6);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(863, 416);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.antispy);
            this.tabPage1.Controls.Add(this.antidump);
            this.tabPage1.Controls.Add(this.ad);
            this.tabPage1.Controls.Add(this.at);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.pm);
            this.tabPage1.Controls.Add(this.pi);
            this.tabPage1.Controls.Add(this.refp);
            this.tabPage1.Controls.Add(this.call);
            this.tabPage1.Controls.Add(this.LF);
            this.tabPage1.Controls.Add(this.jcontrolflow);
            this.tabPage1.Controls.Add(this.sufcon);
            this.tabPage1.Controls.Add(this.rename2);
            this.tabPage1.Controls.Add(this.se);
            this.tabPage1.Controls.Add(this.cf);
            this.tabPage1.Controls.Add(this.ic);
            this.tabPage1.Controls.Add(this.dn);
            this.tabPage1.Controls.Add(this.de);
            this.tabPage1.Controls.Add(this.dp);
            this.tabPage1.Controls.Add(this.dm);
            this.tabPage1.Controls.Add(this.junk);
            this.tabPage1.Controls.Add(this.hidecode);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.df);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(836, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "options";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            this.tabPage1.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabPage1_DragDrop);
            this.tabPage1.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabPage1_DragEnter);
            // 
            // antidump
            // 
            this.antidump.Animated = true;
            this.antidump.AutoSize = true;
            this.antidump.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.antidump.CheckedState.BorderRadius = 0;
            this.antidump.CheckedState.BorderThickness = 0;
            this.antidump.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.antidump.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antidump.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.antidump.Location = new System.Drawing.Point(405, 207);
            this.antidump.Name = "antidump";
            this.antidump.Size = new System.Drawing.Size(103, 23);
            this.antidump.TabIndex = 30;
            this.antidump.Text = "Anti Dump";
            this.antidump.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.SetToolTip(this.antidump, "This prevents the file from being debugged & dumped, example fiddler, x64dbg");
            this.antidump.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.antidump.UncheckedState.BorderRadius = 0;
            this.antidump.UncheckedState.BorderThickness = 0;
            this.antidump.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            // 
            // ad
            // 
            this.ad.Animated = true;
            this.ad.AutoSize = true;
            this.ad.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.ad.CheckedState.BorderRadius = 0;
            this.ad.CheckedState.BorderThickness = 0;
            this.ad.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.ad.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ad.Location = new System.Drawing.Point(405, 178);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(110, 23);
            this.ad.TabIndex = 29;
            this.ad.Text = "Anti Debug";
            this.ad.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.SetToolTip(this.ad, "This prevents the file from being debugged & dumped, example fiddler, x64dbg");
            this.ad.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ad.UncheckedState.BorderRadius = 0;
            this.ad.UncheckedState.BorderThickness = 0;
            this.ad.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            // 
            // at
            // 
            this.at.Animated = true;
            this.at.AutoSize = true;
            this.at.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.at.CheckedState.BorderRadius = 0;
            this.at.CheckedState.BorderThickness = 0;
            this.at.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.at.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.at.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.at.Location = new System.Drawing.Point(405, 149);
            this.at.Name = "at";
            this.at.Size = new System.Drawing.Size(117, 23);
            this.at.TabIndex = 28;
            this.at.Text = "Anti Tamper";
            this.at.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.SetToolTip(this.at, "This forces integrity of application.");
            this.at.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.at.UncheckedState.BorderRadius = 0;
            this.at.UncheckedState.BorderThickness = 0;
            this.at.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(598, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 289);
            this.panel1.TabIndex = 27;
            // 
            // pm
            // 
            this.pm.Animated = true;
            this.pm.AutoSize = true;
            this.pm.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.pm.CheckedState.BorderRadius = 0;
            this.pm.CheckedState.BorderThickness = 0;
            this.pm.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.pm.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pm.Location = new System.Drawing.Point(615, 72);
            this.pm.Name = "pm";
            this.pm.Size = new System.Drawing.Size(146, 23);
            this.pm.TabIndex = 26;
            this.pm.Text = "Proxy Methods";
            this.pm.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.SetToolTip(this.pm, "This relocates methods references to type/method/fields.");
            this.pm.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pm.UncheckedState.BorderRadius = 0;
            this.pm.UncheckedState.BorderThickness = 0;
            this.pm.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            // 
            // pi
            // 
            this.pi.Animated = true;
            this.pi.AutoSize = true;
            this.pi.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.pi.CheckedState.BorderRadius = 0;
            this.pi.CheckedState.BorderThickness = 0;
            this.pi.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.pi.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F);
            this.pi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pi.Location = new System.Drawing.Point(615, 14);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(99, 23);
            this.pi.TabIndex = 25;
            this.pi.Text = "Proxy Int";
            this.pi.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.SetToolTip(this.pi, "This relocates int\'s references to type/method/fields.");
            this.pi.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pi.UncheckedState.BorderRadius = 0;
            this.pi.UncheckedState.BorderThickness = 0;
            this.pi.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            // 
            // refp
            // 
            this.refp.Animated = true;
            this.refp.AutoSize = true;
            this.refp.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.refp.CheckedState.BorderRadius = 0;
            this.refp.CheckedState.BorderThickness = 0;
            this.refp.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.refp.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.refp.Location = new System.Drawing.Point(207, 179);
            this.refp.Name = "refp";
            this.refp.Size = new System.Drawing.Size(102, 23);
            this.refp.TabIndex = 24;
            this.refp.Text = "Ref Proxy";
            this.refp.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.SetToolTip(this.refp, "This relocates strings/int\'s references to type/method/fields.");
            this.refp.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.refp.UncheckedState.BorderRadius = 0;
            this.refp.UncheckedState.BorderThickness = 0;
            this.refp.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            // 
            // call
            // 
            this.call.Animated = true;
            this.call.AutoSize = true;
            this.call.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.call.CheckedState.BorderRadius = 0;
            this.call.CheckedState.BorderThickness = 0;
            this.call.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.call.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.call.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.call.Location = new System.Drawing.Point(405, 91);
            this.call.Name = "call";
            this.call.Size = new System.Drawing.Size(163, 23);
            this.call.TabIndex = 23;
            this.call.Text = "Calli convertion";
            this.call.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.SetToolTip(this.call, "This will convert calls to calli.");
            this.call.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.call.UncheckedState.BorderRadius = 0;
            this.call.UncheckedState.BorderThickness = 0;
            this.call.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            // 
            // LF
            // 
            this.LF.Animated = true;
            this.LF.AutoSize = true;
            this.LF.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.LF.CheckedState.BorderRadius = 0;
            this.LF.CheckedState.BorderThickness = 0;
            this.LF.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.LF.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LF.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LF.Location = new System.Drawing.Point(405, 120);
            this.LF.Name = "LF";
            this.LF.Size = new System.Drawing.Size(123, 23);
            this.LF.TabIndex = 22;
            this.LF.Text = "Local Fields";
            this.LF.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.SetToolTip(this.LF, "This converts locals to fields with random names.");
            this.LF.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.LF.UncheckedState.BorderRadius = 0;
            this.LF.UncheckedState.BorderThickness = 0;
            this.LF.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            // 
            // jcontrolflow
            // 
            this.jcontrolflow.Animated = true;
            this.jcontrolflow.AutoSize = true;
            this.jcontrolflow.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.jcontrolflow.CheckedState.BorderRadius = 0;
            this.jcontrolflow.CheckedState.BorderThickness = 0;
            this.jcontrolflow.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.jcontrolflow.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jcontrolflow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.jcontrolflow.Location = new System.Drawing.Point(615, 188);
            this.jcontrolflow.Name = "jcontrolflow";
            this.jcontrolflow.Size = new System.Drawing.Size(180, 23);
            this.jcontrolflow.TabIndex = 21;
            this.jcontrolflow.Text = "jump control flow";
            this.jcontrolflow.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.SetToolTip(this.jcontrolflow, "This adds ILCode.");
            this.jcontrolflow.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.jcontrolflow.UncheckedState.BorderRadius = 0;
            this.jcontrolflow.UncheckedState.BorderThickness = 0;
            this.jcontrolflow.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            // 
            // sufcon
            // 
            this.sufcon.Animated = true;
            this.sufcon.AutoSize = true;
            this.sufcon.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.sufcon.CheckedState.BorderRadius = 0;
            this.sufcon.CheckedState.BorderThickness = 0;
            this.sufcon.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.sufcon.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sufcon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sufcon.Location = new System.Drawing.Point(207, 237);
            this.sufcon.Name = "sufcon";
            this.sufcon.Size = new System.Drawing.Size(139, 23);
            this.sufcon.TabIndex = 20;
            this.sufcon.Text = "SUF Confusion";
            this.sufcon.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.SetToolTip(this.sufcon, "This will confuse them via adding extra code in the methods.");
            this.sufcon.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.sufcon.UncheckedState.BorderRadius = 0;
            this.sufcon.UncheckedState.BorderThickness = 0;
            this.sufcon.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            // 
            // rename2
            // 
            this.rename2.Animated = true;
            this.rename2.AutoSize = true;
            this.rename2.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.rename2.CheckedState.BorderRadius = 0;
            this.rename2.CheckedState.BorderThickness = 0;
            this.rename2.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.rename2.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rename2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rename2.Location = new System.Drawing.Point(615, 159);
            this.rename2.Name = "rename2";
            this.rename2.Size = new System.Drawing.Size(108, 23);
            this.rename2.TabIndex = 19;
            this.rename2.Text = "Rename V2";
            this.rename2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.SetToolTip(this.rename2, "This will rename type/method/fields.");
            this.rename2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.rename2.UncheckedState.BorderRadius = 0;
            this.rename2.UncheckedState.BorderThickness = 0;
            this.rename2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            // 
            // se
            // 
            this.se.Animated = true;
            this.se.AutoSize = true;
            this.se.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.se.CheckedState.BorderRadius = 0;
            this.se.CheckedState.BorderThickness = 0;
            this.se.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.se.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.se.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.se.Location = new System.Drawing.Point(207, 91);
            this.se.Name = "se";
            this.se.Size = new System.Drawing.Size(167, 23);
            this.se.TabIndex = 18;
            this.se.Text = "String encryption";
            this.se.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.SetToolTip(this.se, "This will Encrypt all the strings.");
            this.se.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.se.UncheckedState.BorderRadius = 0;
            this.se.UncheckedState.BorderThickness = 0;
            this.se.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            // 
            // cf
            // 
            this.cf.Animated = true;
            this.cf.AutoSize = true;
            this.cf.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.cf.CheckedState.BorderRadius = 0;
            this.cf.CheckedState.BorderThickness = 0;
            this.cf.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.cf.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cf.Location = new System.Drawing.Point(207, 149);
            this.cf.Name = "cf";
            this.cf.Size = new System.Drawing.Size(138, 23);
            this.cf.TabIndex = 17;
            this.cf.Text = "control flow";
            this.cf.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.SetToolTip(this.cf, "This changes the code so that the decompilers can\'t decompile the method.");
            this.cf.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.cf.UncheckedState.BorderRadius = 0;
            this.cf.UncheckedState.BorderThickness = 0;
            this.cf.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            // 
            // ic
            // 
            this.ic.Animated = true;
            this.ic.AutoSize = true;
            this.ic.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.ic.CheckedState.BorderRadius = 0;
            this.ic.CheckedState.BorderThickness = 0;
            this.ic.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.ic.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ic.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ic.Location = new System.Drawing.Point(207, 120);
            this.ic.Name = "ic";
            this.ic.Size = new System.Drawing.Size(135, 23);
            this.ic.TabIndex = 16;
            this.ic.Text = "int confusion";
            this.ic.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.SetToolTip(this.ic, "This will protect the int\'s via adding calcs.");
            this.ic.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ic.UncheckedState.BorderRadius = 0;
            this.ic.UncheckedState.BorderThickness = 0;
            this.ic.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            // 
            // dn
            // 
            this.dn.Animated = true;
            this.dn.AutoSize = true;
            this.dn.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.dn.CheckedState.BorderRadius = 0;
            this.dn.CheckedState.BorderThickness = 0;
            this.dn.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.dn.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dn.Location = new System.Drawing.Point(21, 208);
            this.dn.Name = "dn";
            this.dn.Size = new System.Drawing.Size(141, 23);
            this.dn.TabIndex = 15;
            this.dn.Text = "Disguise Names";
            this.dn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.SetToolTip(this.dn, "Renames the names.");
            this.dn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dn.UncheckedState.BorderRadius = 0;
            this.dn.UncheckedState.BorderThickness = 0;
            this.dn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            // 
            // de
            // 
            this.de.Animated = true;
            this.de.AutoSize = true;
            this.de.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.de.CheckedState.BorderRadius = 0;
            this.de.CheckedState.BorderThickness = 0;
            this.de.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.de.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.de.Location = new System.Drawing.Point(21, 179);
            this.de.Name = "de";
            this.de.Size = new System.Drawing.Size(145, 23);
            this.de.TabIndex = 14;
            this.de.Text = "Disguise Events";
            this.de.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.SetToolTip(this.de, "Renames the events.");
            this.de.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.de.UncheckedState.BorderRadius = 0;
            this.de.UncheckedState.BorderThickness = 0;
            this.de.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.de.CheckedChanged += new System.EventHandler(this.de_CheckedChanged);
            // 
            // dp
            // 
            this.dp.Animated = true;
            this.dp.AutoSize = true;
            this.dp.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.dp.CheckedState.BorderRadius = 0;
            this.dp.CheckedState.BorderThickness = 0;
            this.dp.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.dp.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dp.Location = new System.Drawing.Point(21, 149);
            this.dp.Name = "dp";
            this.dp.Size = new System.Drawing.Size(174, 23);
            this.dp.TabIndex = 13;
            this.dp.Text = "Disguise Properties";
            this.dp.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.SetToolTip(this.dp, "Renames the properties.");
            this.dp.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dp.UncheckedState.BorderRadius = 0;
            this.dp.UncheckedState.BorderThickness = 0;
            this.dp.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            // 
            // dm
            // 
            this.dm.Animated = true;
            this.dm.AutoSize = true;
            this.dm.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.dm.CheckedState.BorderRadius = 0;
            this.dm.CheckedState.BorderThickness = 0;
            this.dm.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.dm.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dm.Location = new System.Drawing.Point(21, 120);
            this.dm.Name = "dm";
            this.dm.Size = new System.Drawing.Size(161, 23);
            this.dm.TabIndex = 12;
            this.dm.Text = "Disguise Methods";
            this.dm.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.SetToolTip(this.dm, "Renames the methods.");
            this.dm.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.dm.UncheckedState.BorderRadius = 0;
            this.dm.UncheckedState.BorderThickness = 0;
            this.dm.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            // 
            // junk
            // 
            this.junk.Animated = true;
            this.junk.AutoSize = true;
            this.junk.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.junk.CheckedState.BorderRadius = 0;
            this.junk.CheckedState.BorderThickness = 0;
            this.junk.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.junk.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.junk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.junk.Location = new System.Drawing.Point(21, 237);
            this.junk.Name = "junk";
            this.junk.Size = new System.Drawing.Size(98, 23);
            this.junk.TabIndex = 11;
            this.junk.Text = "Add junk";
            this.junk.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.SetToolTip(this.junk, "This will add alot of junk.");
            this.junk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.junk.UncheckedState.BorderRadius = 0;
            this.junk.UncheckedState.BorderThickness = 0;
            this.junk.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            // 
            // hidecode
            // 
            this.hidecode.Animated = true;
            this.hidecode.AutoSize = true;
            this.hidecode.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.hidecode.CheckedState.BorderRadius = 0;
            this.hidecode.CheckedState.BorderThickness = 0;
            this.hidecode.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.hidecode.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidecode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hidecode.Location = new System.Drawing.Point(207, 208);
            this.hidecode.Name = "hidecode";
            this.hidecode.Size = new System.Drawing.Size(155, 23);
            this.hidecode.TabIndex = 10;
            this.hidecode.Text = "Invalid MetaData";
            this.hidecode.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.SetToolTip(this.hidecode, "This protection adds invalid metadata to hide the code.");
            this.hidecode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.hidecode.UncheckedState.BorderRadius = 0;
            this.hidecode.UncheckedState.BorderThickness = 0;
            this.hidecode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("LEMON MILK Light", 13F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(158, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Build";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.output);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(836, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "build";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("LEMON MILK Light", 13F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(178)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(158, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Build";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("LEMON MILK Light", 13F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Protection";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Help
            // 
            this.Help.AllowLinksHandling = true;
            this.Help.AutomaticDelay = 1400;
            this.Help.BackColor = System.Drawing.Color.Black;
            this.Help.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Help.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Help.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Help.MaximumSize = new System.Drawing.Size(0, 0);
            this.Help.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.TitleFont = new System.Drawing.Font("Segoe UI", 1F, System.Drawing.FontStyle.Bold);
            this.Help.TitleForeColor = System.Drawing.Color.Black;
            // 
            // antispy
            // 
            this.antispy.Animated = true;
            this.antispy.AutoSize = true;
            this.antispy.CheckedState.BorderColor = System.Drawing.Color.Blue;
            this.antispy.CheckedState.BorderRadius = 0;
            this.antispy.CheckedState.BorderThickness = 0;
            this.antispy.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.antispy.Font = new System.Drawing.Font("LEMON MILK Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antispy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.antispy.Location = new System.Drawing.Point(405, 237);
            this.antispy.Name = "antispy";
            this.antispy.Size = new System.Drawing.Size(108, 23);
            this.antispy.TabIndex = 31;
            this.antispy.Text = "Anti Dnspy";
            this.antispy.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Help.SetToolTip(this.antispy, "This gives a error to everyone who tried to decompile it via Dnspy");
            this.antispy.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.antispy.UncheckedState.BorderRadius = 0;
            this.antispy.UncheckedState.BorderThickness = 0;
            this.antispy.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(912, 284);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.84D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GalaxyProtector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer ReText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private Guna.UI2.WinForms.Guna2CheckBox df;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CheckBox junk;
        private Guna.UI2.WinForms.Guna2CheckBox hidecode;
        private Guna.UI2.WinForms.Guna2CheckBox de;
        private Guna.UI2.WinForms.Guna2CheckBox dp;
        private Guna.UI2.WinForms.Guna2CheckBox dm;
        private Guna.UI2.WinForms.Guna2CheckBox dn;
        private Guna.UI2.WinForms.Guna2CheckBox ic;
        private Guna.UI2.WinForms.Guna2CheckBox cf;
        private Guna.UI2.WinForms.Guna2CheckBox se;
        private Guna.UI2.WinForms.Guna2CheckBox rename2;
        private Guna.UI2.WinForms.Guna2CheckBox sufcon;
        private Guna.UI2.WinForms.Guna2HtmlToolTip Help;
        private Guna.UI2.WinForms.Guna2CheckBox jcontrolflow;
        private Guna.UI2.WinForms.Guna2CheckBox LF;
        private Guna.UI2.WinForms.Guna2CheckBox call;
        private Guna.UI2.WinForms.Guna2CheckBox refp;
        private Guna.UI2.WinForms.Guna2CheckBox pi;
        private Guna.UI2.WinForms.Guna2CheckBox pm;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CheckBox at;
        private Guna.UI2.WinForms.Guna2CheckBox ad;
        private Guna.UI2.WinForms.Guna2CheckBox antidump;
        private Guna.UI2.WinForms.Guna2CheckBox antispy;
    }
}

