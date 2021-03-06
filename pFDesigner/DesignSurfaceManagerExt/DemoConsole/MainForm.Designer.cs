namespace pF.DesignSurfaceManagerExt {
partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose ( bool disposing ) {
        if ( disposing && ( components != null ) ) {
            components.Dispose();
        }
        base.Dispose ( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( MainForm ) );
        this.splitContainer = new System.Windows.Forms.SplitContainer();
        this.tabControl1 = new System.Windows.Forms.TabControl();
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.newFormUseSnapLinesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.newFormUseGridandSnapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.newFormUseGridMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.newFormAlignControlByhandMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.ToolStripMenuItemUnDo = new System.Windows.Forms.ToolStripMenuItem();
        this.ToolStripMenuItemReDo = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
        this.ToolStripMenuItemCut = new System.Windows.Forms.ToolStripMenuItem();
        this.ToolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
        this.ToolStripMenuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
        this.ToolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
        this.toolStripMenuItemTools = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripMenuItemTabOrder = new System.Windows.Forms.ToolStripMenuItem();
        this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
        this.pnl4Toolbox = new System.Windows.Forms.Panel();
        this.listBox1 = new System.Windows.Forms.ListBox();
        this.splitContainer.Panel1.SuspendLayout();
        this.splitContainer.SuspendLayout();
        this.menuStrip1.SuspendLayout();
        this.pnl4Toolbox.SuspendLayout();
        this.SuspendLayout();
        // 
        // splitContainer
        // 
        this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.splitContainer.Location = new System.Drawing.Point( 170, 32 );
        this.splitContainer.Margin = new System.Windows.Forms.Padding( 4 );
        this.splitContainer.Name = "splitContainer";
        // 
        // splitContainer.Panel1
        // 
        this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.Window;
        this.splitContainer.Panel1.Controls.Add( this.tabControl1 );
        this.splitContainer.Size = new System.Drawing.Size( 719, 483 );
        this.splitContainer.SplitterDistance = 498;
        this.splitContainer.SplitterWidth = 5;
        this.splitContainer.TabIndex = 0;
        // 
        // tabControl1
        // 
        this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tabControl1.Location = new System.Drawing.Point( 0, 0 );
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new System.Drawing.Size( 498, 483 );
        this.tabControl1.TabIndex = 0;
        // 
        // menuStrip1
        // 
        this.menuStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripMenuItemTools,
            this.helpToolStripMenuItem} );
        this.menuStrip1.Location = new System.Drawing.Point( 0, 0 );
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Padding = new System.Windows.Forms.Padding( 8, 2, 0, 2 );
        this.menuStrip1.Size = new System.Drawing.Size( 889, 28 );
        this.menuStrip1.TabIndex = 1;
        this.menuStrip1.Text = "menuStrip1";
        // 
        // newToolStripMenuItem
        // 
        this.newToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.newFormUseSnapLinesMenuItem,
            this.newFormUseGridandSnapMenuItem,
            this.newFormUseGridMenuItem,
            this.newFormAlignControlByhandMenuItem} );
        this.newToolStripMenuItem.Name = "newToolStripMenuItem";
        this.newToolStripMenuItem.Size = new System.Drawing.Size( 51, 24 );
        this.newToolStripMenuItem.Text = "&New";
        // 
        // newFormUseSnapLinesMenuItem
        // 
        this.newFormUseSnapLinesMenuItem.Name = "newFormUseSnapLinesMenuItem";
        this.newFormUseSnapLinesMenuItem.Size = new System.Drawing.Size( 318, 24 );
        this.newFormUseSnapLinesMenuItem.Text = "Form (use &SnapLines)";
        this.newFormUseSnapLinesMenuItem.Click += new System.EventHandler( this.newFormUseSnapLinesMenuItem_Click );
        // 
        // newFormUseGridandSnapMenuItem
        // 
        this.newFormUseGridandSnapMenuItem.Name = "newFormUseGridandSnapMenuItem";
        this.newFormUseGridandSnapMenuItem.Size = new System.Drawing.Size( 318, 24 );
        this.newFormUseGridandSnapMenuItem.Text = "Form (use &Grid and snap to the grid)";
        this.newFormUseGridandSnapMenuItem.Click += new System.EventHandler( this.newFormUseGridandSnapMenuItem_Click );
        // 
        // newFormUseGridMenuItem
        // 
        this.newFormUseGridMenuItem.Name = "newFormUseGridMenuItem";
        this.newFormUseGridMenuItem.Size = new System.Drawing.Size( 318, 24 );
        this.newFormUseGridMenuItem.Text = "Form (use Gri&d)";
        this.newFormUseGridMenuItem.Click += new System.EventHandler( this.newFormUseGridMenuItem_Click );
        // 
        // newFormAlignControlByhandMenuItem
        // 
        this.newFormAlignControlByhandMenuItem.Name = "newFormAlignControlByhandMenuItem";
        this.newFormAlignControlByhandMenuItem.Size = new System.Drawing.Size( 318, 24 );
        this.newFormAlignControlByhandMenuItem.Text = "Form (Align control by &hand)";
        this.newFormAlignControlByhandMenuItem.Click += new System.EventHandler( this.newFormAlignControlByhandMenuItem_Click );
        // 
        // editToolStripMenuItem
        // 
        this.editToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemUnDo,
            this.ToolStripMenuItemReDo,
            this.toolStripSeparator3,
            this.ToolStripMenuItemCut,
            this.ToolStripMenuItemCopy,
            this.ToolStripMenuItemPaste,
            this.ToolStripMenuItemDelete,
            this.toolStripSeparator4} );
        this.editToolStripMenuItem.Name = "editToolStripMenuItem";
        this.editToolStripMenuItem.Size = new System.Drawing.Size( 47, 24 );
        this.editToolStripMenuItem.Text = "&Edit";
        // 
        // ToolStripMenuItemUnDo
        // 
        this.ToolStripMenuItemUnDo.Name = "ToolStripMenuItemUnDo";
        this.ToolStripMenuItemUnDo.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
        this.ToolStripMenuItemUnDo.Size = new System.Drawing.Size( 165, 24 );
        this.ToolStripMenuItemUnDo.Text = "Undo";
        this.ToolStripMenuItemUnDo.Click += new System.EventHandler( this.undoToolStripMenuItem_Click );
        // 
        // ToolStripMenuItemReDo
        // 
        this.ToolStripMenuItemReDo.Name = "ToolStripMenuItemReDo";
        this.ToolStripMenuItemReDo.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
        this.ToolStripMenuItemReDo.Size = new System.Drawing.Size( 165, 24 );
        this.ToolStripMenuItemReDo.Text = "Redo";
        this.ToolStripMenuItemReDo.Click += new System.EventHandler( this.redoToolStripMenuItem_Click );
        // 
        // toolStripSeparator3
        // 
        this.toolStripSeparator3.Name = "toolStripSeparator3";
        this.toolStripSeparator3.Size = new System.Drawing.Size( 162, 6 );
        // 
        // ToolStripMenuItemCut
        // 
        this.ToolStripMenuItemCut.Image = ((System.Drawing.Image) (resources.GetObject( "ToolStripMenuItemCut.Image" )));
        this.ToolStripMenuItemCut.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.ToolStripMenuItemCut.Name = "ToolStripMenuItemCut";
        this.ToolStripMenuItemCut.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
        this.ToolStripMenuItemCut.Size = new System.Drawing.Size( 165, 24 );
        this.ToolStripMenuItemCut.Text = "Cut";
        this.ToolStripMenuItemCut.Click += new System.EventHandler( this.OnMenuClick );
        // 
        // ToolStripMenuItemCopy
        // 
        this.ToolStripMenuItemCopy.Image = ((System.Drawing.Image) (resources.GetObject( "ToolStripMenuItemCopy.Image" )));
        this.ToolStripMenuItemCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.ToolStripMenuItemCopy.Name = "ToolStripMenuItemCopy";
        this.ToolStripMenuItemCopy.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
        this.ToolStripMenuItemCopy.Size = new System.Drawing.Size( 165, 24 );
        this.ToolStripMenuItemCopy.Text = "Copy";
        this.ToolStripMenuItemCopy.Click += new System.EventHandler( this.OnMenuClick );
        // 
        // ToolStripMenuItemPaste
        // 
        this.ToolStripMenuItemPaste.Image = ((System.Drawing.Image) (resources.GetObject( "ToolStripMenuItemPaste.Image" )));
        this.ToolStripMenuItemPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.ToolStripMenuItemPaste.Name = "ToolStripMenuItemPaste";
        this.ToolStripMenuItemPaste.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
        this.ToolStripMenuItemPaste.Size = new System.Drawing.Size( 165, 24 );
        this.ToolStripMenuItemPaste.Text = "Paste";
        this.ToolStripMenuItemPaste.Click += new System.EventHandler( this.OnMenuClick );
        // 
        // ToolStripMenuItemDelete
        // 
        this.ToolStripMenuItemDelete.Name = "ToolStripMenuItemDelete";
        this.ToolStripMenuItemDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
        this.ToolStripMenuItemDelete.Size = new System.Drawing.Size( 165, 24 );
        this.ToolStripMenuItemDelete.Text = "Delete";
        this.ToolStripMenuItemDelete.Click += new System.EventHandler( this.OnMenuClick );
        // 
        // toolStripSeparator4
        // 
        this.toolStripSeparator4.Name = "toolStripSeparator4";
        this.toolStripSeparator4.Size = new System.Drawing.Size( 162, 6 );
        // 
        // toolStripMenuItemTools
        // 
        this.toolStripMenuItemTools.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTabOrder} );
        this.toolStripMenuItemTools.Name = "toolStripMenuItemTools";
        this.toolStripMenuItemTools.Size = new System.Drawing.Size( 57, 24 );
        this.toolStripMenuItemTools.Text = "&Tools";
        // 
        // toolStripMenuItemTabOrder
        // 
        this.toolStripMenuItemTabOrder.Name = "toolStripMenuItemTabOrder";
        this.toolStripMenuItemTabOrder.Size = new System.Drawing.Size( 145, 24 );
        this.toolStripMenuItemTabOrder.Text = "Tab Order";
        this.toolStripMenuItemTabOrder.Click += new System.EventHandler( this.toolStripMenuItemTabOrder_Click );
        // 
        // helpToolStripMenuItem
        // 
        this.helpToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAbout} );
        this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        this.helpToolStripMenuItem.Size = new System.Drawing.Size( 53, 24 );
        this.helpToolStripMenuItem.Text = "&Help";
        // 
        // ToolStripMenuItemAbout
        // 
        this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
        this.ToolStripMenuItemAbout.Size = new System.Drawing.Size( 128, 24 );
        this.ToolStripMenuItemAbout.Text = "About...";
        this.ToolStripMenuItemAbout.Click += new System.EventHandler( this.OnAbout );
        // 
        // pnl4Toolbox
        // 
        this.pnl4Toolbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.pnl4Toolbox.Controls.Add( this.listBox1 );
        this.pnl4Toolbox.Dock = System.Windows.Forms.DockStyle.Left;
        this.pnl4Toolbox.Location = new System.Drawing.Point( 0, 28 );
        this.pnl4Toolbox.Name = "pnl4Toolbox";
        this.pnl4Toolbox.Size = new System.Drawing.Size( 163, 487 );
        this.pnl4Toolbox.TabIndex = 2;
        // 
        // listBox1
        // 
        this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.listBox1.FormattingEnabled = true;
        this.listBox1.ItemHeight = 16;
        this.listBox1.Location = new System.Drawing.Point( 0, 0 );
        this.listBox1.Name = "listBox1";
        this.listBox1.Size = new System.Drawing.Size( 159, 468 );
        this.listBox1.TabIndex = 0;
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF( 8F, 16F );
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size( 889, 515 );
        this.Controls.Add( this.pnl4Toolbox );
        this.Controls.Add( this.splitContainer );
        this.Controls.Add( this.menuStrip1 );
        this.Icon = ((System.Drawing.Icon) (resources.GetObject( "$this.Icon" )));
        this.MainMenuStrip = this.menuStrip1;
        this.Margin = new System.Windows.Forms.Padding( 4 );
        this.Name = "MainForm";
        this.Text = "Tiny Form ⁯IDE";
        this.Load += new System.EventHandler( this.MainForm_Load );
        this.splitContainer.Panel1.ResumeLayout( false );
        this.splitContainer.ResumeLayout( false );
        this.menuStrip1.ResumeLayout( false );
        this.menuStrip1.PerformLayout();
        this.pnl4Toolbox.ResumeLayout( false );
        this.ResumeLayout( false );
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUnDo;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemReDo;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCut;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCopy;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPaste;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDelete;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTools;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTabOrder;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.Panel pnl4Toolbox;
    private System.Windows.Forms.ListBox listBox1;
    public System.Windows.Forms.ToolStripMenuItem newFormUseGridandSnapMenuItem;
    public System.Windows.Forms.ToolStripMenuItem newFormUseSnapLinesMenuItem;
    public System.Windows.Forms.ToolStripMenuItem newFormUseGridMenuItem;
    public System.Windows.Forms.ToolStripMenuItem newFormAlignControlByhandMenuItem;

}
}

