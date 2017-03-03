namespace _3DdiceRoller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thereIsNoHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rollButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.d20Label = new System.Windows.Forms.Label();
            this.d20num = new System.Windows.Forms.NumericUpDown();
            this.d12Label = new System.Windows.Forms.Label();
            this.d12num = new System.Windows.Forms.NumericUpDown();
            this.d10Label = new System.Windows.Forms.Label();
            this.d10num = new System.Windows.Forms.NumericUpDown();
            this.d00Label = new System.Windows.Forms.Label();
            this.d00num = new System.Windows.Forms.NumericUpDown();
            this.d8Label = new System.Windows.Forms.Label();
            this.d8num = new System.Windows.Forms.NumericUpDown();
            this.d6Label = new System.Windows.Forms.Label();
            this.d6num = new System.Windows.Forms.NumericUpDown();
            this.d4Label = new System.Windows.Forms.Label();
            this.d4num = new System.Windows.Forms.NumericUpDown();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorSelect = new System.Windows.Forms.ComboBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d20num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d12num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d10num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d00num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d8num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d6num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d4num)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1045, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thereIsNoHelpToolStripMenuItem,
            this.versionInformationToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // thereIsNoHelpToolStripMenuItem
            // 
            this.thereIsNoHelpToolStripMenuItem.Name = "thereIsNoHelpToolStripMenuItem";
            this.thereIsNoHelpToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.thereIsNoHelpToolStripMenuItem.Text = "There is no help";
            this.thereIsNoHelpToolStripMenuItem.Click += new System.EventHandler(this.thereIsNoHelpToolStripMenuItem_Click);
            // 
            // versionInformationToolStripMenuItem
            // 
            this.versionInformationToolStripMenuItem.Name = "versionInformationToolStripMenuItem";
            this.versionInformationToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.versionInformationToolStripMenuItem.Text = "Version Information";
            this.versionInformationToolStripMenuItem.Click += new System.EventHandler(this.versionInformationToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(214, 26);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 933F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.rollButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.747127F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.25288F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1045, 724);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // rollButton
            // 
            this.rollButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rollButton.Location = new System.Drawing.Point(60, 633);
            this.rollButton.Margin = new System.Windows.Forms.Padding(4);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(925, 61);
            this.rollButton.TabIndex = 0;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.225154F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.77693F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.223658F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.77582F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.223658F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.77582F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.223658F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.77582F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.161383F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.45245F));
            this.tableLayoutPanel2.Controls.Add(this.d20Label, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.d20num, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.d12Label, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.d12num, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.d10Label, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.d10num, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.d00Label, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.d00num, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.d8Label, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.d8num, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.d6Label, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.d6num, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.d4Label, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.d4num, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.colorLabel, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.colorSelect, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.textLabel, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.totalBox, 9, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(60, 489);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(925, 136);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // d20Label
            // 
            this.d20Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.d20Label.AutoSize = true;
            this.d20Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d20Label.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.d20Label.Location = new System.Drawing.Point(377, 87);
            this.d20Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.d20Label.Name = "d20Label";
            this.d20Label.Size = new System.Drawing.Size(55, 29);
            this.d20Label.TabIndex = 14;
            this.d20Label.Text = "d20";
            // 
            // d20num
            // 
            this.d20num.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.d20num.Location = new System.Drawing.Point(440, 91);
            this.d20num.Margin = new System.Windows.Forms.Padding(4);
            this.d20num.Name = "d20num";
            this.d20num.Size = new System.Drawing.Size(99, 22);
            this.d20num.TabIndex = 15;
            this.d20num.ValueChanged += new System.EventHandler(this.d20num_ValueChanged);
            // 
            // d12Label
            // 
            this.d12Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.d12Label.AutoSize = true;
            this.d12Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d12Label.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.d12Label.Location = new System.Drawing.Point(196, 87);
            this.d12Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.d12Label.Name = "d12Label";
            this.d12Label.Size = new System.Drawing.Size(55, 29);
            this.d12Label.TabIndex = 12;
            this.d12Label.Text = "d12";
            // 
            // d12num
            // 
            this.d12num.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.d12num.Location = new System.Drawing.Point(259, 91);
            this.d12num.Margin = new System.Windows.Forms.Padding(4);
            this.d12num.Name = "d12num";
            this.d12num.Size = new System.Drawing.Size(99, 22);
            this.d12num.TabIndex = 13;
            this.d12num.ValueChanged += new System.EventHandler(this.d12num_ValueChanged);
            // 
            // d10Label
            // 
            this.d10Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.d10Label.AutoSize = true;
            this.d10Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d10Label.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.d10Label.Location = new System.Drawing.Point(15, 87);
            this.d10Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.d10Label.Name = "d10Label";
            this.d10Label.Size = new System.Drawing.Size(55, 29);
            this.d10Label.TabIndex = 10;
            this.d10Label.Text = "d10";
            // 
            // d10num
            // 
            this.d10num.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.d10num.Location = new System.Drawing.Point(78, 91);
            this.d10num.Margin = new System.Windows.Forms.Padding(4);
            this.d10num.Name = "d10num";
            this.d10num.Size = new System.Drawing.Size(99, 22);
            this.d10num.TabIndex = 11;
            this.d10num.ValueChanged += new System.EventHandler(this.d10num_ValueChanged);
            // 
            // d00Label
            // 
            this.d00Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.d00Label.AutoSize = true;
            this.d00Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d00Label.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.d00Label.Location = new System.Drawing.Point(558, 19);
            this.d00Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.d00Label.Name = "d00Label";
            this.d00Label.Size = new System.Drawing.Size(55, 29);
            this.d00Label.TabIndex = 6;
            this.d00Label.Text = "d00";
            // 
            // d00num
            // 
            this.d00num.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.d00num.Location = new System.Drawing.Point(621, 23);
            this.d00num.Margin = new System.Windows.Forms.Padding(4);
            this.d00num.Name = "d00num";
            this.d00num.Size = new System.Drawing.Size(99, 22);
            this.d00num.TabIndex = 7;
            this.d00num.ValueChanged += new System.EventHandler(this.d00num_ValueChanged);
            // 
            // d8Label
            // 
            this.d8Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.d8Label.AutoSize = true;
            this.d8Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d8Label.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.d8Label.Location = new System.Drawing.Point(391, 19);
            this.d8Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.d8Label.Name = "d8Label";
            this.d8Label.Size = new System.Drawing.Size(41, 29);
            this.d8Label.TabIndex = 4;
            this.d8Label.Text = "d8";
            // 
            // d8num
            // 
            this.d8num.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.d8num.Location = new System.Drawing.Point(440, 23);
            this.d8num.Margin = new System.Windows.Forms.Padding(4);
            this.d8num.Name = "d8num";
            this.d8num.Size = new System.Drawing.Size(99, 22);
            this.d8num.TabIndex = 5;
            this.d8num.ValueChanged += new System.EventHandler(this.d8num_ValueChanged);
            // 
            // d6Label
            // 
            this.d6Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.d6Label.AutoSize = true;
            this.d6Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d6Label.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.d6Label.Location = new System.Drawing.Point(210, 19);
            this.d6Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.d6Label.Name = "d6Label";
            this.d6Label.Size = new System.Drawing.Size(41, 29);
            this.d6Label.TabIndex = 2;
            this.d6Label.Text = "d6";
            // 
            // d6num
            // 
            this.d6num.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.d6num.Location = new System.Drawing.Point(259, 23);
            this.d6num.Margin = new System.Windows.Forms.Padding(4);
            this.d6num.Name = "d6num";
            this.d6num.Size = new System.Drawing.Size(99, 22);
            this.d6num.TabIndex = 3;
            this.d6num.ValueChanged += new System.EventHandler(this.d6num_ValueChanged);
            // 
            // d4Label
            // 
            this.d4Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.d4Label.AutoSize = true;
            this.d4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d4Label.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.d4Label.Location = new System.Drawing.Point(29, 19);
            this.d4Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.d4Label.Name = "d4Label";
            this.d4Label.Size = new System.Drawing.Size(41, 29);
            this.d4Label.TabIndex = 0;
            this.d4Label.Text = "d4";
            // 
            // d4num
            // 
            this.d4num.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.d4num.Location = new System.Drawing.Point(78, 23);
            this.d4num.Margin = new System.Windows.Forms.Padding(4);
            this.d4num.Name = "d4num";
            this.d4num.Size = new System.Drawing.Size(99, 22);
            this.d4num.TabIndex = 1;
            this.d4num.ValueChanged += new System.EventHandler(this.d4num_ValueChanged);
            // 
            // colorLabel
            // 
            this.colorLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.colorLabel.Location = new System.Drawing.Point(549, 89);
            this.colorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(64, 26);
            this.colorLabel.TabIndex = 16;
            this.colorLabel.Text = "Color";
            // 
            // colorSelect
            // 
            this.colorSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colorSelect.FormattingEnabled = true;
            this.colorSelect.Items.AddRange(new object[] {
            "Red",
            "Yellow",
            "Blue",
            "Green",
            "Orange",
            "Purple",
            "White",
            "Black"});
            this.colorSelect.Location = new System.Drawing.Point(622, 90);
            this.colorSelect.Margin = new System.Windows.Forms.Padding(4);
            this.colorSelect.Name = "colorSelect";
            this.colorSelect.Size = new System.Drawing.Size(97, 24);
            this.colorSelect.TabIndex = 17;
            this.colorSelect.Text = "Select color";
            this.colorSelect.SelectedIndexChanged += new System.EventHandler(this.colorSelect_SelectedIndexChanged);
            // 
            // textLabel
            // 
            this.textLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(787, 29);
            this.textLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(93, 39);
            this.textLabel.TabIndex = 18;
            this.textLabel.Text = "Total";
            // 
            // totalBox
            // 
            this.totalBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalBox.Location = new System.Drawing.Point(747, 72);
            this.totalBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(174, 22);
            this.totalBox.TabIndex = 19;
            this.totalBox.TextChanged += new System.EventHandler(this.totalBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 752);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "3D Dice Roller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d20num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d12num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d10num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d00num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d8num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d6num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d4num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thereIsNoHelpToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label d20Label;
        private System.Windows.Forms.NumericUpDown d20num;
        private System.Windows.Forms.Label d12Label;
        private System.Windows.Forms.NumericUpDown d12num;
        private System.Windows.Forms.Label d10Label;
        private System.Windows.Forms.NumericUpDown d10num;
        private System.Windows.Forms.Label d00Label;
        private System.Windows.Forms.NumericUpDown d00num;
        private System.Windows.Forms.Label d8Label;
        private System.Windows.Forms.NumericUpDown d8num;
        private System.Windows.Forms.Label d6Label;
        private System.Windows.Forms.NumericUpDown d6num;
        private System.Windows.Forms.Label d4Label;
        private System.Windows.Forms.NumericUpDown d4num;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.ComboBox colorSelect;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.ToolStripMenuItem versionInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
    }
}

