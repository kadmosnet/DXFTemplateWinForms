namespace DXFTemplateWinForms
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
            DXFReaderNET.DxfDocument dxfDocument1 = new DXFReaderNET.DxfDocument();
            DXFReaderNET.AciColor aciColor1 = new DXFReaderNET.AciColor();
            DXFReaderNET.Objects.RasterVariables rasterVariables1 = new DXFReaderNET.Objects.RasterVariables();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newDrawingToolStripMenuItem = new ToolStripMenuItem();
            loadDXFFileToolStripMenuItem = new ToolStripMenuItem();
            saveDFXFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            zoomExtentsToolStripMenuItem = new ToolStripMenuItem();
            zoomWindowToolStripMenuItem = new ToolStripMenuItem();
            dxfReaderNETControl1 = new DXFReaderNET.DXFReaderNETControl();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripMenuItem1 = new ToolStripMenuItem();
            aboutDXFReaderNETWinFormsComponentToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newDrawingToolStripMenuItem, loadDXFFileToolStripMenuItem, saveDFXFileToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newDrawingToolStripMenuItem
            // 
            newDrawingToolStripMenuItem.Name = "newDrawingToolStripMenuItem";
            newDrawingToolStripMenuItem.Size = new Size(152, 22);
            newDrawingToolStripMenuItem.Text = "New drawing";
            newDrawingToolStripMenuItem.Click += newDrawingToolStripMenuItem_Click;
            // 
            // loadDXFFileToolStripMenuItem
            // 
            loadDXFFileToolStripMenuItem.Name = "loadDXFFileToolStripMenuItem";
            loadDXFFileToolStripMenuItem.Size = new Size(152, 22);
            loadDXFFileToolStripMenuItem.Text = "Load DXF file...";
            loadDXFFileToolStripMenuItem.Click += loadDXFFileToolStripMenuItem_Click;
            // 
            // saveDFXFileToolStripMenuItem
            // 
            saveDFXFileToolStripMenuItem.Name = "saveDFXFileToolStripMenuItem";
            saveDFXFileToolStripMenuItem.Size = new Size(152, 22);
            saveDFXFileToolStripMenuItem.Text = "Save DFX file...";
            saveDFXFileToolStripMenuItem.Click += saveDFXFileToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(152, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomExtentsToolStripMenuItem, zoomWindowToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // zoomExtentsToolStripMenuItem
            // 
            zoomExtentsToolStripMenuItem.Name = "zoomExtentsToolStripMenuItem";
            zoomExtentsToolStripMenuItem.Size = new Size(151, 22);
            zoomExtentsToolStripMenuItem.Text = "Zoom extents";
            zoomExtentsToolStripMenuItem.Click += zoomExtentsToolStripMenuItem_Click;
            // 
            // zoomWindowToolStripMenuItem
            // 
            zoomWindowToolStripMenuItem.Name = "zoomWindowToolStripMenuItem";
            zoomWindowToolStripMenuItem.Size = new Size(151, 22);
            zoomWindowToolStripMenuItem.Text = "Zoom window";
            zoomWindowToolStripMenuItem.Click += zoomWindowToolStripMenuItem_Click;
            // 
            // dxfReaderNETControl1
            // 
            dxfReaderNETControl1.ContinuousHighlight = false;
            dxfReaderNETControl1.CustomCursor = DXFReaderNET.CustomCursorType.None;
            dxfReaderNETControl1.CustomCursorColor = Color.White;
            dxfReaderNETControl1.DistributionCode = "";
            dxfDocument1.ActiveLayout = "Model";
            dxfDocument1.Comments = null;
            aciColor1.Index = 256;
            aciColor1.IsByBlock = false;
            aciColor1.IsByLayer = true;
            aciColor1.UseTrueColor = false;
            dxfDocument1.CurrentColor = aciColor1;
            dxfDocument1.CurrentElevation = 0D;
            dxfDocument1.CurrentLayer = "0";
            dxfDocument1.CurrentLineTypeName = "ByLayer";
            dxfDocument1.CurrentLineTypeScale = 1D;
            dxfDocument1.CurrentTextSize = 2.5D;
            dxfDocument1.CurrentTextStyle = "STANDARD";
            dxfDocument1.CurrentThickness = 0D;
            dxfDocument1.DateCreated = new DateTime(2025, 4, 12, 17, 38, 44, 640);
            dxfDocument1.DateLastEdited = new DateTime(2025, 4, 12, 17, 38, 44, 640);
            dxfDocument1.Handle = "90526";
            dxfDocument1.IsBinary = false;
            dxfDocument1.Modified = false;
            dxfDocument1.Name = null;
            dxfDocument1.Owner = null;
            rasterVariables1.DisplayFrame = true;
            rasterVariables1.DisplayQuality = DXFReaderNET.Objects.ImageDisplayQuality.High;
            rasterVariables1.Handle = "90568";
            rasterVariables1.Owner = null;
            rasterVariables1.Units = DXFReaderNET.ImageUnits.Unitless;
            dxfDocument1.RasterVariables = rasterVariables1;
            dxfDocument1.SortentsTables = null;
            dxfDocument1.ThumbnailImage = null;
            dxfDocument1.TotalEditTime = new DateTime(2025, 4, 12, 0, 0, 0, 0);
            dxfDocument1.TotalEditTimeDays = 0;
            dxfDocument1.UserTimer = new DateTime(2025, 4, 12, 0, 0, 0, 0);
            dxfDocument1.UserTimerDays = 0;
            dxfReaderNETControl1.DXF = dxfDocument1;
            dxfReaderNETControl1.FileName = null;
            dxfReaderNETControl1.GrabPointsSize = 8;
            dxfReaderNETControl1.HighlightGrabPointsOnHover = false;
            dxfReaderNETControl1.HighlightGrabPointsOnHoverColor = Color.FromArgb(0, 163, 0);
            dxfReaderNETControl1.HighlightMarkerColor2 = Color.Magenta;
            dxfReaderNETControl1.HighlightNotContinuous = false;
            dxfReaderNETControl1.Location = new Point(0, 0);
            dxfReaderNETControl1.Name = "dxfReaderNETControl1";
            dxfReaderNETControl1.ShowGridRuler = false;
            dxfReaderNETControl1.Size = new Size(652, 348);
            dxfReaderNETControl1.TabIndex = 1;
            dxfReaderNETControl1.MouseDown += dxfReaderNETControl1_MouseDown;
            dxfReaderNETControl1.MouseMove += dxfReaderNETControl1_MouseMove;
            dxfReaderNETControl1.MouseUp += dxfReaderNETControl1_MouseUp;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new Point(0, 425);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(86, 22);
            toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { aboutDXFReaderNETWinFormsComponentToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(24, 20);
            toolStripMenuItem1.Text = "?";
            // 
            // aboutDXFReaderNETWinFormsComponentToolStripMenuItem
            // 
            aboutDXFReaderNETWinFormsComponentToolStripMenuItem.Name = "aboutDXFReaderNETWinFormsComponentToolStripMenuItem";
            aboutDXFReaderNETWinFormsComponentToolStripMenuItem.Size = new Size(325, 22);
            aboutDXFReaderNETWinFormsComponentToolStripMenuItem.Text = "About DXFReader.NET WinForms Component...";
            aboutDXFReaderNETWinFormsComponentToolStripMenuItem.Click += aboutDXFReaderNETWinFormsComponentToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(dxfReaderNETControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "DXFReader.NET WinForms - Template";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private DXFReaderNET.DXFReaderNETControl dxfReaderNETControl1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newDrawingToolStripMenuItem;
        private ToolStripMenuItem loadDXFFileToolStripMenuItem;
        private ToolStripMenuItem saveDFXFileToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem zoomExtentsToolStripMenuItem;
        private ToolStripMenuItem zoomWindowToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem aboutDXFReaderNETWinFormsComponentToolStripMenuItem;
    }
}
