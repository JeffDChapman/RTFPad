namespace RTFPad
{
    partial class rtfPadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rtfPadForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNewTab = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileCloseCurrentTab = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFilePrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFilePageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditClear = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditFind = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatFont = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatColor = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutRTFPadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripPrintPreview = new System.Windows.Forms.ToolStripButton();
            this.toolStripUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripCBoxFont = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripCBoxFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripStrikethrough = new System.Windows.Forms.ToolStripButton();
            this.toolStripFontColor = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripAlignLeft = new System.Windows.Forms.ToolStripButton();
            this.toolStripAlignCenter = new System.Windows.Forms.ToolStripButton();
            this.toolStripAlignRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripBullet = new System.Windows.Forms.ToolStripButton();
            this.dialogOpen = new System.Windows.Forms.OpenFileDialog();
            this.dialogSave = new System.Windows.Forms.SaveFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripInfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.dialogPrintPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.dialogPrint = new System.Windows.Forms.PrintDialog();
            this.dialogPageSetup = new System.Windows.Forms.PageSetupDialog();
            this.dialogFont = new System.Windows.Forms.FontDialog();
            this.dialogColor = new System.Windows.Forms.ColorDialog();
            this.btnToBottom = new System.Windows.Forms.Button();
            this.btnEditDocument = new System.Windows.Forms.Button();
            this.timerAutoloadFile = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuView,
            this.menuFormat,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNewTab,
            this.menuFileCloseCurrentTab,
            this.menuFileOpen,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.toolStripSeparator1,
            this.menuFilePrint,
            this.menuFilePrintPreview,
            this.menuFilePageSetup,
            this.toolStripSeparator2,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(54, 29);
            this.menuFile.Text = "&File";
            this.menuFile.Click += new System.EventHandler(this.menuFile_Click);
            // 
            // menuFileNewTab
            // 
            this.menuFileNewTab.Name = "menuFileNewTab";
            this.menuFileNewTab.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNewTab.Size = new System.Drawing.Size(320, 34);
            this.menuFileNewTab.Text = "&New Tab...";
            this.menuFileNewTab.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // menuFileCloseCurrentTab
            // 
            this.menuFileCloseCurrentTab.Enabled = false;
            this.menuFileCloseCurrentTab.Name = "menuFileCloseCurrentTab";
            this.menuFileCloseCurrentTab.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.menuFileCloseCurrentTab.Size = new System.Drawing.Size(320, 34);
            this.menuFileCloseCurrentTab.Text = "&Close Current Tab";
            this.menuFileCloseCurrentTab.Click += new System.EventHandler(this.menuFileCloseCurrentTab_Click);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(320, 34);
            this.menuFileOpen.Text = "&Open...";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(320, 34);
            this.menuFileSave.Text = "&Save";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.Size = new System.Drawing.Size(320, 34);
            this.menuFileSaveAs.Text = "Save &As...";
            this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(317, 6);
            // 
            // menuFilePrint
            // 
            this.menuFilePrint.Name = "menuFilePrint";
            this.menuFilePrint.Size = new System.Drawing.Size(320, 34);
            this.menuFilePrint.Text = "&Print...";
            this.menuFilePrint.Click += new System.EventHandler(this.menuFilePrint_Click);
            // 
            // menuFilePrintPreview
            // 
            this.menuFilePrintPreview.Name = "menuFilePrintPreview";
            this.menuFilePrintPreview.Size = new System.Drawing.Size(320, 34);
            this.menuFilePrintPreview.Text = "Print Pre&view...";
            this.menuFilePrintPreview.Click += new System.EventHandler(this.menuFilePrintPreview_Click);
            // 
            // menuFilePageSetup
            // 
            this.menuFilePageSetup.Name = "menuFilePageSetup";
            this.menuFilePageSetup.Size = new System.Drawing.Size(320, 34);
            this.menuFilePageSetup.Text = "Page Set&up...";
            this.menuFilePageSetup.Click += new System.EventHandler(this.menuFilePageSetup_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(317, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(320, 34);
            this.menuFileExit.Text = "E&xit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditUndo,
            this.menuEditRedo,
            this.toolStripSeparator6,
            this.menuEditCut,
            this.menuEditCopy,
            this.menuEditPaste,
            this.menuEditClear,
            this.menuEditSelectAll,
            this.toolStripSeparator7,
            this.menuEditFind,
            this.menuEditFindNext,
            this.menuEditReplace});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(58, 29);
            this.menuEdit.Text = "&Edit";
            // 
            // menuEditUndo
            // 
            this.menuEditUndo.Name = "menuEditUndo";
            this.menuEditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuEditUndo.Size = new System.Drawing.Size(248, 34);
            this.menuEditUndo.Text = "&Undo";
            this.menuEditUndo.Click += new System.EventHandler(this.menuEditUndo_Click);
            // 
            // menuEditRedo
            // 
            this.menuEditRedo.Name = "menuEditRedo";
            this.menuEditRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.menuEditRedo.Size = new System.Drawing.Size(248, 34);
            this.menuEditRedo.Text = "&Redo";
            this.menuEditRedo.Click += new System.EventHandler(this.menuEditRedo_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(245, 6);
            // 
            // menuEditCut
            // 
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuEditCut.Size = new System.Drawing.Size(248, 34);
            this.menuEditCut.Text = "Cu&t";
            this.menuEditCut.Click += new System.EventHandler(this.menuEditCut_Click);
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuEditCopy.Size = new System.Drawing.Size(248, 34);
            this.menuEditCopy.Text = "&Copy";
            this.menuEditCopy.Click += new System.EventHandler(this.menuEditCopy_Click);
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuEditPaste.Size = new System.Drawing.Size(248, 34);
            this.menuEditPaste.Text = "&Paste";
            this.menuEditPaste.Click += new System.EventHandler(this.menuEditPaste_Click);
            // 
            // menuEditClear
            // 
            this.menuEditClear.Name = "menuEditClear";
            this.menuEditClear.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuEditClear.Size = new System.Drawing.Size(248, 34);
            this.menuEditClear.Text = "Cle&ar";
            this.menuEditClear.Click += new System.EventHandler(this.menuEditClear_Click);
            // 
            // menuEditSelectAll
            // 
            this.menuEditSelectAll.Name = "menuEditSelectAll";
            this.menuEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuEditSelectAll.Size = new System.Drawing.Size(248, 34);
            this.menuEditSelectAll.Text = "Select A&ll";
            this.menuEditSelectAll.Click += new System.EventHandler(this.menuEditSelectAll_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(245, 6);
            // 
            // menuEditFind
            // 
            this.menuEditFind.Name = "menuEditFind";
            this.menuEditFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menuEditFind.Size = new System.Drawing.Size(248, 34);
            this.menuEditFind.Text = "&Find";
            this.menuEditFind.Click += new System.EventHandler(this.menuEditFind_Click);
            // 
            // menuEditFindNext
            // 
            this.menuEditFindNext.Name = "menuEditFindNext";
            this.menuEditFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuEditFindNext.Size = new System.Drawing.Size(248, 34);
            this.menuEditFindNext.Text = "Find &Next";
            this.menuEditFindNext.Click += new System.EventHandler(this.menuEditFindNext_Click);
            // 
            // menuEditReplace
            // 
            this.menuEditReplace.Name = "menuEditReplace";
            this.menuEditReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.menuEditReplace.Size = new System.Drawing.Size(248, 34);
            this.menuEditReplace.Text = "&Replace";
            this.menuEditReplace.Click += new System.EventHandler(this.menuEditReplace_Click);
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewWordWrap});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(65, 29);
            this.menuView.Text = "&View";
            // 
            // menuViewWordWrap
            // 
            this.menuViewWordWrap.Name = "menuViewWordWrap";
            this.menuViewWordWrap.Size = new System.Drawing.Size(206, 34);
            this.menuViewWordWrap.Text = "&Word Wrap";
            this.menuViewWordWrap.Click += new System.EventHandler(this.menuViewWordWrap_Click);
            // 
            // menuFormat
            // 
            this.menuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormatFont,
            this.menuFormatColor});
            this.menuFormat.Name = "menuFormat";
            this.menuFormat.Size = new System.Drawing.Size(85, 29);
            this.menuFormat.Text = "F&ormat";
            // 
            // menuFormatFont
            // 
            this.menuFormatFont.Name = "menuFormatFont";
            this.menuFormatFont.Size = new System.Drawing.Size(157, 34);
            this.menuFormatFont.Text = "&Font";
            this.menuFormatFont.Click += new System.EventHandler(this.menuFormatFont_Click);
            // 
            // menuFormatColor
            // 
            this.menuFormatColor.Name = "menuFormatColor";
            this.menuFormatColor.Size = new System.Drawing.Size(157, 34);
            this.menuFormatColor.Text = "&Color";
            this.menuFormatColor.Click += new System.EventHandler(this.menuFormatColor_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutRTFPadToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutRTFPadToolStripMenuItem
            // 
            this.aboutRTFPadToolStripMenuItem.Name = "aboutRTFPadToolStripMenuItem";
            this.aboutRTFPadToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
            this.aboutRTFPadToolStripMenuItem.Text = "&About RTFPad";
            this.aboutRTFPadToolStripMenuItem.Click += new System.EventHandler(this.aboutRTFPadToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNew,
            this.toolStripOpen,
            this.toolStripSave,
            this.toolStripPrint,
            this.toolStripPrintPreview,
            this.toolStripUndo,
            this.toolStripRedo,
            this.toolStripCBoxFont,
            this.toolStripCBoxFontSize,
            this.toolStripBold,
            this.toolStripItalic,
            this.toolStripUnderline,
            this.toolStripStrikethrough,
            this.toolStripFontColor,
            this.toolStripAlignLeft,
            this.toolStripAlignCenter,
            this.toolStripAlignRight,
            this.toolStripBullet});
            this.toolStrip.Location = new System.Drawing.Point(0, 33);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip.Size = new System.Drawing.Size(978, 33);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripNew
            // 
            this.toolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNew.Image = global::RTFPad.icons.NewDocument;
            this.toolStripNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNew.Name = "toolStripNew";
            this.toolStripNew.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripNew.Size = new System.Drawing.Size(34, 28);
            this.toolStripNew.Text = "New Tab";
            this.toolStripNew.Click += new System.EventHandler(this.toolStripNew_Click);
            this.toolStripNew.MouseEnter += new System.EventHandler(this.toolStripNew_MouseEnter);
            this.toolStripNew.MouseLeave += new System.EventHandler(this.toolStripNew_MouseLeave);
            // 
            // toolStripOpen
            // 
            this.toolStripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpen.Image = global::RTFPad.icons.OpenFolder;
            this.toolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpen.Name = "toolStripOpen";
            this.toolStripOpen.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripOpen.Size = new System.Drawing.Size(34, 28);
            this.toolStripOpen.Text = "Open File";
            this.toolStripOpen.Click += new System.EventHandler(this.toolStripOpen_Click);
            this.toolStripOpen.MouseEnter += new System.EventHandler(this.toolStripOpen_MouseEnter);
            this.toolStripOpen.MouseLeave += new System.EventHandler(this.toolStripOpen_MouseLeave);
            // 
            // toolStripSave
            // 
            this.toolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSave.Image = global::RTFPad.icons.Save;
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripSave.Size = new System.Drawing.Size(34, 28);
            this.toolStripSave.Text = "Save Current Tab";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            this.toolStripSave.MouseEnter += new System.EventHandler(this.toolStripSave_MouseEnter);
            this.toolStripSave.MouseLeave += new System.EventHandler(this.toolStripSave_MouseLeave);
            // 
            // toolStripPrint
            // 
            this.toolStripPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPrint.Image = global::RTFPad.icons.Print;
            this.toolStripPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPrint.Name = "toolStripPrint";
            this.toolStripPrint.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripPrint.Size = new System.Drawing.Size(34, 28);
            this.toolStripPrint.Text = "Print Current Tab";
            this.toolStripPrint.Click += new System.EventHandler(this.toolStripPrint_Click);
            this.toolStripPrint.MouseEnter += new System.EventHandler(this.toolStripPrint_MouseEnter);
            this.toolStripPrint.MouseLeave += new System.EventHandler(this.toolStripPrint_MouseLeave);
            // 
            // toolStripPrintPreview
            // 
            this.toolStripPrintPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPrintPreview.Image = global::RTFPad.icons.PrintPreview;
            this.toolStripPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPrintPreview.Name = "toolStripPrintPreview";
            this.toolStripPrintPreview.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripPrintPreview.Size = new System.Drawing.Size(34, 28);
            this.toolStripPrintPreview.Text = "Print Preview";
            this.toolStripPrintPreview.Click += new System.EventHandler(this.toolStripPrintPreview_Click);
            this.toolStripPrintPreview.MouseEnter += new System.EventHandler(this.toolStripPrintPreview_MouseEnter);
            this.toolStripPrintPreview.MouseLeave += new System.EventHandler(this.toolStripPrintPreview_MouseLeave);
            // 
            // toolStripUndo
            // 
            this.toolStripUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripUndo.Image = global::RTFPad.icons.Edit_Undo;
            this.toolStripUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUndo.Name = "toolStripUndo";
            this.toolStripUndo.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripUndo.Size = new System.Drawing.Size(34, 28);
            this.toolStripUndo.Text = "Undo";
            this.toolStripUndo.Click += new System.EventHandler(this.toolStripUndo_Click);
            this.toolStripUndo.MouseEnter += new System.EventHandler(this.toolStripUndo_MouseEnter);
            this.toolStripUndo.MouseLeave += new System.EventHandler(this.toolStripUndo_MouseLeave);
            // 
            // toolStripRedo
            // 
            this.toolStripRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRedo.Image = global::RTFPad.icons.Edit_Redo;
            this.toolStripRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRedo.Name = "toolStripRedo";
            this.toolStripRedo.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripRedo.Size = new System.Drawing.Size(34, 28);
            this.toolStripRedo.Text = "Redo";
            this.toolStripRedo.Click += new System.EventHandler(this.toolStripRedo_Click);
            this.toolStripRedo.MouseEnter += new System.EventHandler(this.toolStripRedo_MouseEnter);
            this.toolStripRedo.MouseLeave += new System.EventHandler(this.toolStripRedo_MouseLeave);
            // 
            // toolStripCBoxFont
            // 
            this.toolStripCBoxFont.AutoSize = false;
            this.toolStripCBoxFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripCBoxFont.DropDownWidth = 200;
            this.toolStripCBoxFont.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripCBoxFont.MaxDropDownItems = 30;
            this.toolStripCBoxFont.Name = "toolStripCBoxFont";
            this.toolStripCBoxFont.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripCBoxFont.Size = new System.Drawing.Size(200, 33);
            this.toolStripCBoxFont.SelectedIndexChanged += new System.EventHandler(this.toolStripCBoxFont_SelectedIndexChanged);
            // 
            // toolStripCBoxFontSize
            // 
            this.toolStripCBoxFontSize.AutoSize = false;
            this.toolStripCBoxFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripCBoxFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.toolStripCBoxFontSize.MaxDropDownItems = 16;
            this.toolStripCBoxFontSize.Name = "toolStripCBoxFontSize";
            this.toolStripCBoxFontSize.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripCBoxFontSize.Size = new System.Drawing.Size(73, 33);
            this.toolStripCBoxFontSize.SelectedIndexChanged += new System.EventHandler(this.toolStripCBoxFontSize_SelectedIndexChanged);
            // 
            // toolStripBold
            // 
            this.toolStripBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBold.Image = global::RTFPad.icons.Bold;
            this.toolStripBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBold.Name = "toolStripBold";
            this.toolStripBold.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripBold.Size = new System.Drawing.Size(34, 28);
            this.toolStripBold.Text = "Bold";
            this.toolStripBold.Click += new System.EventHandler(this.toolStripBold_Click);
            this.toolStripBold.MouseEnter += new System.EventHandler(this.toolStripBold_MouseEnter);
            this.toolStripBold.MouseLeave += new System.EventHandler(this.toolStripBold_MouseLeave);
            // 
            // toolStripItalic
            // 
            this.toolStripItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItalic.Image = global::RTFPad.icons.Italic;
            this.toolStripItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItalic.Name = "toolStripItalic";
            this.toolStripItalic.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripItalic.Size = new System.Drawing.Size(34, 28);
            this.toolStripItalic.Text = "Italic";
            this.toolStripItalic.Click += new System.EventHandler(this.toolStripItalic_Click);
            this.toolStripItalic.MouseEnter += new System.EventHandler(this.toolStripItalic_MouseEnter);
            this.toolStripItalic.MouseLeave += new System.EventHandler(this.toolStripItalic_MouseLeave);
            // 
            // toolStripUnderline
            // 
            this.toolStripUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripUnderline.Image = global::RTFPad.icons.Underline;
            this.toolStripUnderline.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripUnderline.Name = "toolStripUnderline";
            this.toolStripUnderline.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripUnderline.Size = new System.Drawing.Size(34, 28);
            this.toolStripUnderline.Text = "Underline";
            this.toolStripUnderline.Click += new System.EventHandler(this.toolStripUnderline_Click);
            this.toolStripUnderline.MouseEnter += new System.EventHandler(this.toolStripUnderline_MouseEnter);
            this.toolStripUnderline.MouseLeave += new System.EventHandler(this.toolStripUnderline_MouseLeave);
            // 
            // toolStripStrikethrough
            // 
            this.toolStripStrikethrough.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStrikethrough.Image = global::RTFPad.icons.Strikeout;
            this.toolStripStrikethrough.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripStrikethrough.Name = "toolStripStrikethrough";
            this.toolStripStrikethrough.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripStrikethrough.Size = new System.Drawing.Size(34, 28);
            this.toolStripStrikethrough.Text = "Strikethrough";
            this.toolStripStrikethrough.Click += new System.EventHandler(this.toolStripStrikethrough_Click);
            this.toolStripStrikethrough.MouseEnter += new System.EventHandler(this.toolStripStrikethrough_MouseEnter);
            this.toolStripStrikethrough.MouseLeave += new System.EventHandler(this.toolStripStrikethrough_MouseLeave);
            // 
            // toolStripFontColor
            // 
            this.toolStripFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripFontColor.Image = global::RTFPad.icons.Color;
            this.toolStripFontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFontColor.Name = "toolStripFontColor";
            this.toolStripFontColor.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripFontColor.Size = new System.Drawing.Size(42, 28);
            this.toolStripFontColor.Text = "Color Picker";
            this.toolStripFontColor.Click += new System.EventHandler(this.toolStripFontColor_Click);
            this.toolStripFontColor.MouseEnter += new System.EventHandler(this.toolStripFontColor_MouseEnter);
            this.toolStripFontColor.MouseLeave += new System.EventHandler(this.toolStripFontColor_MouseLeave);
            // 
            // toolStripAlignLeft
            // 
            this.toolStripAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAlignLeft.Image = global::RTFPad.icons.Left;
            this.toolStripAlignLeft.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripAlignLeft.Name = "toolStripAlignLeft";
            this.toolStripAlignLeft.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripAlignLeft.Size = new System.Drawing.Size(34, 28);
            this.toolStripAlignLeft.Text = "Left Align";
            this.toolStripAlignLeft.Click += new System.EventHandler(this.toolStripAlignLeft_Click);
            this.toolStripAlignLeft.MouseEnter += new System.EventHandler(this.toolStripAlignLeft_MouseEnter);
            this.toolStripAlignLeft.MouseLeave += new System.EventHandler(this.toolStripAlignLeft_MouseLeave);
            // 
            // toolStripAlignCenter
            // 
            this.toolStripAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAlignCenter.Image = global::RTFPad.icons.Center;
            this.toolStripAlignCenter.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripAlignCenter.Name = "toolStripAlignCenter";
            this.toolStripAlignCenter.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripAlignCenter.Size = new System.Drawing.Size(34, 28);
            this.toolStripAlignCenter.Text = "Center";
            this.toolStripAlignCenter.Click += new System.EventHandler(this.toolStripAlignCenter_Click);
            this.toolStripAlignCenter.MouseEnter += new System.EventHandler(this.toolStripAlignCenter_MouseEnter);
            this.toolStripAlignCenter.MouseLeave += new System.EventHandler(this.toolStripAlignCenter_MouseLeave);
            // 
            // toolStripAlignRight
            // 
            this.toolStripAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAlignRight.Image = global::RTFPad.icons.Right;
            this.toolStripAlignRight.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripAlignRight.Name = "toolStripAlignRight";
            this.toolStripAlignRight.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripAlignRight.Size = new System.Drawing.Size(34, 28);
            this.toolStripAlignRight.Text = "Right Align";
            this.toolStripAlignRight.Click += new System.EventHandler(this.toolStripAlignRight_Click);
            this.toolStripAlignRight.MouseEnter += new System.EventHandler(this.toolStripAlignRight_MouseEnter);
            this.toolStripAlignRight.MouseLeave += new System.EventHandler(this.toolStripAlignRight_MouseLeave);
            // 
            // toolStripBullet
            // 
            this.toolStripBullet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBullet.Image = global::RTFPad.icons.List_Bullets;
            this.toolStripBullet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBullet.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripBullet.Name = "toolStripBullet";
            this.toolStripBullet.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripBullet.Size = new System.Drawing.Size(34, 33);
            this.toolStripBullet.Text = "Bullets";
            this.toolStripBullet.Click += new System.EventHandler(this.toolStripBullet_Click);
            this.toolStripBullet.MouseEnter += new System.EventHandler(this.toolStripBullet_MouseEnter);
            this.toolStripBullet.MouseLeave += new System.EventHandler(this.toolStripBullet_MouseLeave);
            // 
            // dialogOpen
            // 
            this.dialogOpen.DefaultExt = "rtf";
            this.dialogOpen.Filter = "Rich Text Format (*.rtf)|*.rtf|Plain text File (*.txt)|*.txt|All Files|";
            // 
            // dialogSave
            // 
            this.dialogSave.DefaultExt = "rtf";
            this.dialogSave.Filter = "Rich Text Format (*.rtf)|*.rtf|Plain text File (*.txt)|*.txt|All Files|";
            // 
            // tabControl
            // 
            this.tabControl.AllowDrop = true;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(0, 18);
            this.tabControl.Location = new System.Drawing.Point(0, 66);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(978, 962);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            this.tabControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseUp);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripInfoLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 1028);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(978, 22);
            this.statusStrip.TabIndex = 3;
            // 
            // statusStripInfoLabel
            // 
            this.statusStripInfoLabel.Name = "statusStripInfoLabel";
            this.statusStripInfoLabel.Size = new System.Drawing.Size(0, 15);
            // 
            // tabMenu
            // 
            this.tabMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tabMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuNew,
            this.contextMenuClose});
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Size = new System.Drawing.Size(160, 68);
            // 
            // contextMenuNew
            // 
            this.contextMenuNew.Name = "contextMenuNew";
            this.contextMenuNew.Size = new System.Drawing.Size(159, 32);
            this.contextMenuNew.Text = "&New Tab";
            this.contextMenuNew.Click += new System.EventHandler(this.contextMenuNew_Click);
            // 
            // contextMenuClose
            // 
            this.contextMenuClose.Name = "contextMenuClose";
            this.contextMenuClose.Size = new System.Drawing.Size(159, 32);
            this.contextMenuClose.Text = "&Close Tab";
            this.contextMenuClose.Click += new System.EventHandler(this.contextMenuClose_Click);
            // 
            // dialogPrintPreview
            // 
            this.dialogPrintPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.dialogPrintPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.dialogPrintPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.dialogPrintPreview.Enabled = true;
            this.dialogPrintPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("dialogPrintPreview.Icon")));
            this.dialogPrintPreview.Name = "dialogPrintPreview";
            this.dialogPrintPreview.ShowIcon = false;
            this.dialogPrintPreview.Visible = false;
            // 
            // dialogPrint
            // 
            this.dialogPrint.UseEXDialog = true;
            // 
            // dialogPageSetup
            // 
            this.dialogPageSetup.EnableMetric = true;
            this.dialogPageSetup.MinMargins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            // 
            // dialogFont
            // 
            this.dialogFont.Color = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.dialogFont.FontMustExist = true;
            this.dialogFont.ShowColor = true;
            // 
            // dialogColor
            // 
            this.dialogColor.AnyColor = true;
            this.dialogColor.FullOpen = true;
            // 
            // btnToBottom
            // 
            this.btnToBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnToBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToBottom.Image = ((System.Drawing.Image)(resources.GetObject("btnToBottom.Image")));
            this.btnToBottom.Location = new System.Drawing.Point(905, 124);
            this.btnToBottom.Margin = new System.Windows.Forms.Padding(0);
            this.btnToBottom.Name = "btnToBottom";
            this.btnToBottom.Size = new System.Drawing.Size(26, 24);
            this.btnToBottom.TabIndex = 4;
            this.btnToBottom.UseVisualStyleBackColor = true;
            this.btnToBottom.Visible = false;
            this.btnToBottom.Click += new System.EventHandler(this.btnToBottom_Click);
            // 
            // btnEditDocument
            // 
            this.btnEditDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditDocument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDocument.Image = ((System.Drawing.Image)(resources.GetObject("btnEditDocument.Image")));
            this.btnEditDocument.Location = new System.Drawing.Point(896, 124);
            this.btnEditDocument.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditDocument.Name = "btnEditDocument";
            this.btnEditDocument.Size = new System.Drawing.Size(36, 36);
            this.btnEditDocument.TabIndex = 5;
            this.btnEditDocument.UseVisualStyleBackColor = true;
            this.btnEditDocument.Visible = false;
            this.btnEditDocument.Click += new System.EventHandler(this.btnEditDocument_Click);
            // 
            // timerAutoloadFile
            // 
            this.timerAutoloadFile.Enabled = true;
            this.timerAutoloadFile.Interval = 1000;
            this.timerAutoloadFile.Tick += new System.EventHandler(this.timerAutoloadFile_Tick);
            // 
            // rtfPadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 1050);
            this.Controls.Add(this.btnEditDocument);
            this.Controls.Add(this.btnToBottom);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 10);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(300, 100);
            this.Name = "rtfPadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RTFPad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.rtfPadForm_FormClosing);
            this.Resize += new System.EventHandler(this.rtfPadForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuFormat;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFileNewTab;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuFilePrint;
        private System.Windows.Forms.ToolStripMenuItem menuFilePrintPreview;
        private System.Windows.Forms.ToolStripMenuItem menuFilePageSetup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripButton toolStripNew;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.OpenFileDialog dialogOpen;
        private System.Windows.Forms.SaveFileDialog dialogSave;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ContextMenuStrip tabMenu;
        private System.Windows.Forms.ToolStripMenuItem contextMenuNew;
        private System.Windows.Forms.ToolStripMenuItem contextMenuClose;
        private System.Windows.Forms.ToolStripMenuItem menuFileCloseCurrentTab;
        private System.Windows.Forms.ToolStripButton toolStripOpen;
        private System.Windows.Forms.ToolStripButton toolStripPrint;
        private System.Windows.Forms.ToolStripButton toolStripPrintPreview;
        private System.Windows.Forms.ToolStripButton toolStripUndo;
        private System.Windows.Forms.ToolStripComboBox toolStripCBoxFont;
        private System.Windows.Forms.ToolStripComboBox toolStripCBoxFontSize;
        private System.Windows.Forms.ToolStripDropDownButton toolStripFontColor;
        private System.Windows.Forms.ToolStripMenuItem menuEditUndo;
        private System.Windows.Forms.ToolStripMenuItem menuEditRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem menuEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem menuEditClear;
        private System.Windows.Forms.ToolStripMenuItem menuEditSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem menuEditFind;
        private System.Windows.Forms.ToolStripMenuItem menuEditFindNext;
        private System.Windows.Forms.ToolStripMenuItem menuEditReplace;
        private System.Windows.Forms.ToolStripButton toolStripRedo;
        private System.Windows.Forms.PrintPreviewDialog dialogPrintPreview;
        private System.Windows.Forms.PrintDialog dialogPrint;
        private System.Windows.Forms.PageSetupDialog dialogPageSetup;
        private System.Windows.Forms.ToolStripMenuItem menuFormatFont;
        private System.Windows.Forms.FontDialog dialogFont;
        private System.Windows.Forms.ToolStripButton toolStripBold;
        private System.Windows.Forms.ToolStripButton toolStripItalic;
        private System.Windows.Forms.ToolStripButton toolStripUnderline;
        private System.Windows.Forms.ToolStripButton toolStripStrikethrough;
        private System.Windows.Forms.ToolStripStatusLabel statusStripInfoLabel;
        private System.Windows.Forms.ToolStripMenuItem menuViewWordWrap;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutRTFPadToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripAlignLeft;
        private System.Windows.Forms.ToolStripButton toolStripAlignCenter;
        private System.Windows.Forms.ToolStripButton toolStripAlignRight;
        private System.Windows.Forms.ToolStripMenuItem menuFormatColor;
        private System.Windows.Forms.ColorDialog dialogColor;
        private System.Windows.Forms.ToolStripButton toolStripBullet;
        private System.Windows.Forms.Button btnToBottom;
        private System.Windows.Forms.Button btnEditDocument;
        private System.Windows.Forms.Timer timerAutoloadFile;
    }
}

