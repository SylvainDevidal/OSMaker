using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Drawing.Design;
using pF.DesignSurfaceExt;

namespace pF.DesignSurfaceManagerExt {

public partial class MainForm : Form {


    private string _version = string.Empty;
    public string Version {
        get {
            if( string.IsNullOrEmpty( _version ) ) {
                //- Get the actual version of the file hosted in running assembly
                System.Diagnostics.FileVersionInfo FVI = System.Diagnostics.FileVersionInfo.GetVersionInfo( System.Reflection.Assembly.GetExecutingAssembly().Location );
                _version = FVI.ProductVersion;
            }
            return _version;
        }
    }


    //- STEP.A
    private DesignSurfaceManagerExt _mgr = new DesignSurfaceManagerExt();
   

    private IDesignSurfaceExt2 GetCurrentIDesignSurface() {
        int index = this.tabControl1.SelectedIndex;
        if(index >= _mgr.DesignSurfaces.Count ) 
            return null;
        DesignSurface surface = _mgr.DesignSurfaces[index];
        return surface as IDesignSurfaceExt2;
    }


    #region Init

    //- ctor
    public MainForm() {
        InitializeComponent();


        //- STEP.B
        _mgr.PropertyGridHost.Parent = this.splitContainer.Panel2;
        //- STEP.C
        //- SelectedIndexChanged event fires when the TabControls SelectedIndex or SelectedTab value changes. 
        //- give the focus to the DesigneSurface accordingly to te selected TabPage and sync the propertyGrid
        this.tabControl1.SelectedIndexChanged += ( object sender, EventArgs e ) =>
        {
            TabControl tabCtrl = sender as TabControl;
            _mgr.ActiveDesignSurface = (DesignSurfaceExt2) _mgr.DesignSurfaces[tabCtrl.SelectedIndex];
        };


        //- Add the toolboxItems to the future toolbox 
        //- the pointer
        ToolboxItem toolPointer = new System.Drawing.Design.ToolboxItem();
        toolPointer.DisplayName = "<Pointer>";
        toolPointer.Bitmap = new System.Drawing.Bitmap( 16, 16 );
        listBox1.Items.Add( toolPointer );
        //- the control
        listBox1.Items.Add( new ToolboxItem( typeof( Button ) ) );
        listBox1.Items.Add( new ToolboxItem( typeof( ListView ) ) );
        listBox1.Items.Add( new ToolboxItem( typeof( TreeView ) ) );
        listBox1.Items.Add( new ToolboxItem( typeof( TextBox ) ) );
        listBox1.Items.Add( new ToolboxItem( typeof( Label ) ) );
        listBox1.Items.Add( new ToolboxItem( typeof( TabControl ) ) );
        listBox1.Items.Add( new ToolboxItem( typeof( OpenFileDialog ) ) );
        listBox1.Items.Add( new ToolboxItem( typeof( CheckBox ) ) );
        listBox1.Items.Add( new ToolboxItem( typeof( ComboBox ) ) );
        listBox1.Items.Add( new ToolboxItem( typeof( GroupBox ) ) );
        listBox1.Items.Add( new ToolboxItem( typeof( ImageList ) ) );
        listBox1.Items.Add( new ToolboxItem( typeof( Panel ) ) );
        listBox1.Items.Add( new ToolboxItem( typeof( ProgressBar ) ) );
        listBox1.Items.Add( new ToolboxItem( typeof( ToolBar ) ) );
        listBox1.Items.Add( new ToolboxItem( typeof( ToolTip ) ) );
        listBox1.Items.Add( new ToolboxItem( typeof( StatusBar ) ) );
    }

    private void MainForm_Load( object sender, EventArgs e ) {
        this.tabControl1.Selected += ( object snd, TabControlEventArgs ea ) =>
        {
            //- select into the propertygrid the current Form 
            SelectRootComponent();
        };
    }



    #endregion



    //- When the selection changes this sets the PropertyGrid's selected component
    private void OnSelectionChanged ( object sender, System.EventArgs e ) {
        IDesignSurfaceExt isurf = GetCurrentIDesignSurface();
        if ( null != isurf ) {
            ISelectionService selectionService = null;
            selectionService = isurf.GetIDesignerHost().GetService ( typeof ( ISelectionService ) ) as ISelectionService;
            this._mgr.PropertyGridHost.SelectedObject = selectionService.PrimarySelection;
        }
    }
    
    private void SelectRootComponent() {
        //- find out the DesignSurfaceExt control hosted by the TabPage
        IDesignSurfaceExt isurf = GetCurrentIDesignSurface();
        if( null != isurf )
            this._mgr.PropertyGridHost.SelectedObject = isurf.GetIDesignerHost().RootComponent;
    }

    private void undoToolStripMenuItem_Click ( object sender, EventArgs e ) {
        IDesignSurfaceExt isurf = GetCurrentIDesignSurface(); 
        if( null != isurf )
            isurf.GetUndoEngineExt().Undo();
    }

    private void redoToolStripMenuItem_Click ( object sender, EventArgs e ) {
        IDesignSurfaceExt isurf = GetCurrentIDesignSurface();
        if( null != isurf )
            isurf.GetUndoEngineExt().Redo();
    }

    private void OnAbout ( object sender, EventArgs e ) {
        MessageBox.Show( "Tiny Form IDE coded by Paolo Foti \r\nVersion is: " + Version, "Tiny Form IDE", MessageBoxButtons.OK, MessageBoxIcon.Question );
    }
    
    private void toolStripMenuItemTabOrder_Click ( object sender, EventArgs e ) {
        IDesignSurfaceExt isurf = GetCurrentIDesignSurface();
        if( null != isurf )
            isurf.SwitchTabOrder();
    }

    private void OnMenuClick( object sender, EventArgs e ) {
        IDesignSurfaceExt isurf = GetCurrentIDesignSurface();
        if( null != isurf )
            isurf.DoAction( (sender as ToolStripMenuItem).Text );
    }

    private void newFormUseSnapLinesMenuItem_Click( object sender, EventArgs e ) {
        //- step.0
        TabPage tp = CreateNewTabPage( "Use SnapLines" );
        //- step.1
        DesignSurfaceExt2 surface = CreateDesignSurface();
        //- step.2
        //- choose an alignment mode...
        ((DesignSurfaceExt2)surface).UseSnapLines();
        //- step.3
        //- create the Root compoment, in these case a Form
        Control rootComponent = (Control) CreateRootComponent( tp, surface, typeof( Form ), new Size( 400, 400 ) );
        int iTabPageSelectedIndex = this.tabControl1.SelectedIndex;
        rootComponent.Text = "Root Component hosted by the DesignSurface N." + iTabPageSelectedIndex;
        rootComponent.BackColor = Color.Yellow;
    }

    private void newFormUseGridandSnapMenuItem_Click( object sender, EventArgs e ) {
        //- step.0
        TabPage tp = CreateNewTabPage( "Use Grid (Snap to the grid)" );
        //- step.1
        DesignSurfaceExt2 surface = CreateDesignSurface();
        //- step.2
        //- choose an alignment mode...
        ((DesignSurfaceExt2) surface).UseGrid( new System.Drawing.Size( 32, 32 ) );
        //- step.3
        //- create the Root compoment, in these case a Form
        Control rootComponent = (Control) CreateRootComponent( tp, surface, typeof( Form ), new Size( 400, 400 ) );
        int iTabPageSelectedIndex = this.tabControl1.SelectedIndex;
        rootComponent.Text = "Root Component hosted by the DesignSurface N." + iTabPageSelectedIndex;
        rootComponent.BackColor = Color.YellowGreen;
    }
      
    private void newFormUseGridMenuItem_Click( object sender, EventArgs e ) {
        //- step.0
        TabPage tp = CreateNewTabPage( "Use Grid" );
        //- step.1
        DesignSurfaceExt2 surface = CreateDesignSurface();
        //- step.2
        //- choose an alignment mode...
        ((DesignSurfaceExt2) surface).UseGridWithoutSnapping( new System.Drawing.Size( 16, 16 ) );
        //- step.3
        //- create the Root compoment, in these case a Form
        Control rootComponent = (Control) CreateRootComponent( tp, surface, typeof( Form ), new Size( 600, 400 ) );
        int iTabPageSelectedIndex = this.tabControl1.SelectedIndex;
        rootComponent.Text = "Root Component hosted by the DesignSurface N." + iTabPageSelectedIndex;
        rootComponent.BackColor = Color.LightGreen;
    }

    private void newFormAlignControlByhandMenuItem_Click( object sender, EventArgs e ) {
        //- step.0
        TabPage tp = CreateNewTabPage( "Align control by hand" );
        //- step.1
        DesignSurfaceExt2 surface = CreateDesignSurface();
        //- step.2
        //- choose an alignment mode...
        ((DesignSurfaceExt2) surface).UseNoGuides();
        //- step.3
        //- create the Root compoment, in these case a Form
        Control rootComponent = (Control) CreateRootComponent( tp, surface, typeof( Form ), new Size( 640, 480 ) );
        int iTabPageSelectedIndex = this.tabControl1.SelectedIndex;
        rootComponent.Text = "Root Component hosted by the DesignSurface N." + iTabPageSelectedIndex;
        rootComponent.BackColor = Color.LightGray;
    }

    private TabPage CreateNewTabPage(string text) {
        TabPage tp = new TabPage( text );
        this.tabControl1.TabPages.Add( tp );
        return tp;
    }

    private DesignSurfaceExt2 CreateDesignSurface() {
        //- step.0
        //- create a DesignSurface and put it inside a Form in DesignTime
        DesignSurfaceExt2 surface = this._mgr.CreateDesignSurfaceExt2();
        IDesignSurfaceExt2 isurf = (IDesignSurfaceExt2) surface;
        //- step.1
        //- enable the UndoEngines
        isurf.GetUndoEngineExt().Enabled = true;
        //- step.2
        //- try to get a ptr to ISelectionService interface
        //- if we obtain it then hook the SelectionChanged event
        ISelectionService selectionService = (ISelectionService) (isurf.GetIDesignerHost().GetService( typeof( ISelectionService ) ));
        if( null != selectionService )
            selectionService.SelectionChanged += new System.EventHandler( OnSelectionChanged );
        //- step.3
        //- Select the service IToolboxService
        //- and hook it to our ListBox
        ToolboxServiceImp tbox = isurf.GetIToolboxService() as ToolboxServiceImp;
        if( null != tbox )
            tbox.Toolbox = listBox1;
        //-
        //- finally return the Designsurface
        return surface;
    }

    private IComponent CreateRootComponent( TabPage tpage, DesignSurfaceExt2 surface, Type controlType, Size controlSize ) {
        try {
            IComponent rootComponent = surface.CreateRootComponent( controlType, controlSize );
            this.tabControl1.SelectedIndex = this.tabControl1.TabPages.Count - 1;
            rootComponent.Site.Name = this._mgr.GetValidFormName();
            //- display the DesignSurface
            Control view = surface.GetView();
            if( null == view )
                return null;
            //- change some properties
            view.Text = rootComponent.Site.Name;
            view.Dock = DockStyle.Fill;
            //- Note these assignments
            view.Parent = tpage;
            //- finally enable the Drag&Drop on RootComponent
            ((DesignSurfaceExt2) surface).EnableDragandDrop();
            return rootComponent;
        }//end_try
        catch( Exception ex ) {
            Console.WriteLine( Name + "CreateRootComponent() has generated errors during loading!Exception: " + ex.Message );
            throw;
        }//end_catch
    
    }

}


}