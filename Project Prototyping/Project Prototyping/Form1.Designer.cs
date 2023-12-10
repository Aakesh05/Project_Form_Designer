namespace Project_Prototyping
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
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.MS_Prototyping = new System.Windows.Forms.MenuStrip();
            this.MS_File_DDown = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_New = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Save_As = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Edit_DDown = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridlinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Prototyping = new System.Windows.Forms.ToolStrip();
            this.TS_Cut = new System.Windows.Forms.ToolStripButton();
            this.TS_Copy = new System.Windows.Forms.ToolStripButton();
            this.TS_Paste = new System.Windows.Forms.ToolStripButton();
            this.TS_Left_Right = new System.Windows.Forms.ToolStripButton();
            this.TS_Left = new System.Windows.Forms.ToolStripButton();
            this.TS_Right = new System.Windows.Forms.ToolStripButton();
            this.TS_Center = new System.Windows.Forms.ToolStripButton();
            this.TS_Font_DDown = new System.Windows.Forms.ToolStripComboBox();
            this.TS_FontStyle_DDown = new System.Windows.Forms.ToolStripComboBox();
            this.TS_FontSize_DDown = new System.Windows.Forms.ToolStripComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MS_Prototyping.SuspendLayout();
            this.TS_Prototyping.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // MS_Prototyping
            // 
            this.MS_Prototyping.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_File_DDown,
            this.MS_Edit_DDown,
            this.viewToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.MS_Prototyping.Location = new System.Drawing.Point(0, 0);
            this.MS_Prototyping.Name = "MS_Prototyping";
            this.MS_Prototyping.Size = new System.Drawing.Size(606, 24);
            this.MS_Prototyping.TabIndex = 0;
            this.MS_Prototyping.Text = "menuStrip1";
            // 
            // MS_File_DDown
            // 
            this.MS_File_DDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_New,
            this.MS_Open,
            this.MS_Save,
            this.MS_Save_As,
            this.MS_Print});
            this.MS_File_DDown.Name = "MS_File_DDown";
            this.MS_File_DDown.Size = new System.Drawing.Size(37, 20);
            this.MS_File_DDown.Text = "File";
            this.MS_File_DDown.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // MS_New
            // 
            this.MS_New.Image = ((System.Drawing.Image)(resources.GetObject("MS_New.Image")));
            this.MS_New.Name = "MS_New";
            this.MS_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MS_New.Size = new System.Drawing.Size(186, 22);
            this.MS_New.Text = "New";
            // 
            // MS_Open
            // 
            this.MS_Open.Image = ((System.Drawing.Image)(resources.GetObject("MS_Open.Image")));
            this.MS_Open.Name = "MS_Open";
            this.MS_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MS_Open.Size = new System.Drawing.Size(186, 22);
            this.MS_Open.Text = "Open";
            this.MS_Open.Click += new System.EventHandler(this.MS_Open_Click);
            // 
            // MS_Save
            // 
            this.MS_Save.Image = ((System.Drawing.Image)(resources.GetObject("MS_Save.Image")));
            this.MS_Save.Name = "MS_Save";
            this.MS_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MS_Save.Size = new System.Drawing.Size(186, 22);
            this.MS_Save.Text = "Save";
            this.MS_Save.Click += new System.EventHandler(this.MS_Save_Click);
            // 
            // MS_Save_As
            // 
            this.MS_Save_As.Name = "MS_Save_As";
            this.MS_Save_As.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.MS_Save_As.Size = new System.Drawing.Size(186, 22);
            this.MS_Save_As.Text = "Save As";
            // 
            // MS_Print
            // 
            this.MS_Print.Image = ((System.Drawing.Image)(resources.GetObject("MS_Print.Image")));
            this.MS_Print.Name = "MS_Print";
            this.MS_Print.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.MS_Print.Size = new System.Drawing.Size(186, 22);
            this.MS_Print.Text = "Print";
            this.MS_Print.Click += new System.EventHandler(this.MS_Print_Click);
            // 
            // MS_Edit_DDown
            // 
            this.MS_Edit_DDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Cut,
            this.MS_Copy,
            this.MS_Paste,
            this.MS_Undo,
            this.MS_Redo});
            this.MS_Edit_DDown.Name = "MS_Edit_DDown";
            this.MS_Edit_DDown.Size = new System.Drawing.Size(39, 20);
            this.MS_Edit_DDown.Text = "Edit";
            // 
            // MS_Cut
            // 
            this.MS_Cut.Name = "MS_Cut";
            this.MS_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.MS_Cut.Size = new System.Drawing.Size(144, 22);
            this.MS_Cut.Text = "Cut";
            // 
            // MS_Copy
            // 
            this.MS_Copy.Name = "MS_Copy";
            this.MS_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.MS_Copy.Size = new System.Drawing.Size(144, 22);
            this.MS_Copy.Text = "Copy";
            // 
            // MS_Paste
            // 
            this.MS_Paste.Name = "MS_Paste";
            this.MS_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.MS_Paste.Size = new System.Drawing.Size(144, 22);
            this.MS_Paste.Text = "Paste";
            // 
            // MS_Undo
            // 
            this.MS_Undo.Name = "MS_Undo";
            this.MS_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.MS_Undo.Size = new System.Drawing.Size(144, 22);
            this.MS_Undo.Text = "Undo";
            // 
            // MS_Redo
            // 
            this.MS_Redo.Name = "MS_Redo";
            this.MS_Redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.MS_Redo.Size = new System.Drawing.Size(144, 22);
            this.MS_Redo.Text = "Redo";
            this.MS_Redo.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printPreviewToolStripMenuItem,
            this.rulerToolStripMenuItem,
            this.gridlinesToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // rulerToolStripMenuItem
            // 
            this.rulerToolStripMenuItem.Name = "rulerToolStripMenuItem";
            this.rulerToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.rulerToolStripMenuItem.Text = "Ruler";
            // 
            // gridlinesToolStripMenuItem
            // 
            this.gridlinesToolStripMenuItem.Name = "gridlinesToolStripMenuItem";
            this.gridlinesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.gridlinesToolStripMenuItem.Text = "Gridlines";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backColorToolStripMenuItem,
            this.foreColorToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // backColorToolStripMenuItem
            // 
            this.backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            this.backColorToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.backColorToolStripMenuItem.Text = "Back Color";
            this.backColorToolStripMenuItem.Click += new System.EventHandler(this.backColorToolStripMenuItem_Click);
            // 
            // foreColorToolStripMenuItem
            // 
            this.foreColorToolStripMenuItem.Name = "foreColorToolStripMenuItem";
            this.foreColorToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.foreColorToolStripMenuItem.Text = "Fore Color";
            this.foreColorToolStripMenuItem.Click += new System.EventHandler(this.foreColorToolStripMenuItem_Click);
            // 
            // TS_Prototyping
            // 
            this.TS_Prototyping.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Cut,
            this.TS_Copy,
            this.TS_Paste,
            this.TS_Left_Right,
            this.TS_Left,
            this.TS_Center,
            this.TS_Right,
            this.TS_Font_DDown,
            this.TS_FontStyle_DDown,
            this.TS_FontSize_DDown});
            this.TS_Prototyping.Location = new System.Drawing.Point(0, 24);
            this.TS_Prototyping.Name = "TS_Prototyping";
            this.TS_Prototyping.Size = new System.Drawing.Size(606, 25);
            this.TS_Prototyping.TabIndex = 1;
            this.TS_Prototyping.Text = "toolStrip1";
            // 
            // TS_Cut
            // 
            this.TS_Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TS_Cut.Image = ((System.Drawing.Image)(resources.GetObject("TS_Cut.Image")));
            this.TS_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Cut.Name = "TS_Cut";
            this.TS_Cut.Size = new System.Drawing.Size(23, 22);
            this.TS_Cut.Text = "Cut";
            this.TS_Cut.Click += new System.EventHandler(this.TS_Cut_Click);
            // 
            // TS_Copy
            // 
            this.TS_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TS_Copy.Image = ((System.Drawing.Image)(resources.GetObject("TS_Copy.Image")));
            this.TS_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Copy.Name = "TS_Copy";
            this.TS_Copy.Size = new System.Drawing.Size(23, 22);
            this.TS_Copy.Text = "Copy";
            this.TS_Copy.Click += new System.EventHandler(this.TS_Copy_Click);
            // 
            // TS_Paste
            // 
            this.TS_Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TS_Paste.Image = ((System.Drawing.Image)(resources.GetObject("TS_Paste.Image")));
            this.TS_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Paste.Name = "TS_Paste";
            this.TS_Paste.Size = new System.Drawing.Size(23, 22);
            this.TS_Paste.Text = "Paste";
            this.TS_Paste.Click += new System.EventHandler(this.TS_Paste_Click);
            // 
            // TS_Left_Right
            // 
            this.TS_Left_Right.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TS_Left_Right.Image = ((System.Drawing.Image)(resources.GetObject("TS_Left_Right.Image")));
            this.TS_Left_Right.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Left_Right.Name = "TS_Left_Right";
            this.TS_Left_Right.Size = new System.Drawing.Size(23, 22);
            this.TS_Left_Right.Text = "Left Right";
            this.TS_Left_Right.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // TS_Left
            // 
            this.TS_Left.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TS_Left.Image = ((System.Drawing.Image)(resources.GetObject("TS_Left.Image")));
            this.TS_Left.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Left.Name = "TS_Left";
            this.TS_Left.Size = new System.Drawing.Size(23, 22);
            this.TS_Left.Text = "Left Allign";
            this.TS_Left.Click += new System.EventHandler(this.TS_Left_Click);
            // 
            // TS_Right
            // 
            this.TS_Right.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TS_Right.Image = ((System.Drawing.Image)(resources.GetObject("TS_Right.Image")));
            this.TS_Right.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Right.Name = "TS_Right";
            this.TS_Right.Size = new System.Drawing.Size(23, 22);
            this.TS_Right.Text = "Right Allign";
            this.TS_Right.Click += new System.EventHandler(this.TS_Right_Click);
            // 
            // TS_Center
            // 
            this.TS_Center.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TS_Center.Image = ((System.Drawing.Image)(resources.GetObject("TS_Center.Image")));
            this.TS_Center.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Center.Name = "TS_Center";
            this.TS_Center.Size = new System.Drawing.Size(23, 22);
            this.TS_Center.Text = "Center Allign";
            this.TS_Center.Click += new System.EventHandler(this.TS_Center_Click);
            // 
            // TS_Font_DDown
            // 
            this.TS_Font_DDown.Name = "TS_Font_DDown";
            this.TS_Font_DDown.Size = new System.Drawing.Size(121, 25);
            this.TS_Font_DDown.Text = "Font";
            this.TS_Font_DDown.ToolTipText = "\r\n\r\n";
            this.TS_Font_DDown.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // TS_FontStyle_DDown
            // 
            this.TS_FontStyle_DDown.Name = "TS_FontStyle_DDown";
            this.TS_FontStyle_DDown.Size = new System.Drawing.Size(121, 25);
            this.TS_FontStyle_DDown.Text = "Font Style";
            // 
            // TS_FontSize_DDown
            // 
            this.TS_FontSize_DDown.Name = "TS_FontSize_DDown";
            this.TS_FontSize_DDown.Size = new System.Drawing.Size(121, 25);
            this.TS_FontSize_DDown.Text = "Font Size";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(606, 257);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 284);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(606, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(155, 17);
            this.toolStripStatusLabel1.Text = "Document: Pro_Prototyping";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(87, 17);
            this.toolStripStatusLabel2.Text = "Word Count: 0 ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 306);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.TS_Prototyping);
            this.Controls.Add(this.MS_Prototyping);
            this.MainMenuStrip = this.MS_Prototyping;
            this.Name = "Form1";
            this.Text = "Design Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MS_Prototyping.ResumeLayout(false);
            this.MS_Prototyping.PerformLayout();
            this.TS_Prototyping.ResumeLayout(false);
            this.TS_Prototyping.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.MenuStrip MS_Prototyping;
        private System.Windows.Forms.ToolStripMenuItem MS_File_DDown;
        private System.Windows.Forms.ToolStripMenuItem MS_New;
        private System.Windows.Forms.ToolStripMenuItem MS_Open;
        private System.Windows.Forms.ToolStripMenuItem MS_Save;
        private System.Windows.Forms.ToolStripMenuItem MS_Save_As;
        private System.Windows.Forms.ToolStripMenuItem MS_Print;
        private System.Windows.Forms.ToolStripMenuItem MS_Edit_DDown;
        private System.Windows.Forms.ToolStripMenuItem MS_Cut;
        private System.Windows.Forms.ToolStripMenuItem MS_Copy;
        private System.Windows.Forms.ToolStripMenuItem MS_Paste;
        private System.Windows.Forms.ToolStripMenuItem MS_Undo;
        private System.Windows.Forms.ToolStripMenuItem MS_Redo;
        private System.Windows.Forms.ToolStrip TS_Prototyping;
        private System.Windows.Forms.ToolStripButton TS_Cut;
        private System.Windows.Forms.ToolStripButton TS_Copy;
        private System.Windows.Forms.ToolStripButton TS_Paste;
        private System.Windows.Forms.ToolStripButton TS_Left_Right;
        private System.Windows.Forms.ToolStripButton TS_Left;
        private System.Windows.Forms.ToolStripButton TS_Right;
        private System.Windows.Forms.ToolStripButton TS_Center;
        private System.Windows.Forms.ToolStripComboBox TS_Font_DDown;
        private System.Windows.Forms.ToolStripComboBox TS_FontSize_DDown;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridlinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foreColorToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripComboBox TS_FontStyle_DDown;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

