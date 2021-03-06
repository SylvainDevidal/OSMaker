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

namespace pF.DesignSurfaceExt {

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

    private List<IDesignSurfaceExt2> _listOfDesignSurface = new List<IDesignSurfaceExt2>();

    private IDesignSurfaceExt2 GetCurrentIDesignSurface() {
        if( null  == this._listOfDesignSurface ) return null;
        if( 0 == this._listOfDesignSurface.Count ) return null;

        return _listOfDesignSurface[this.tabControl1.SelectedIndex];
    }


    #region Init

    //- ctor
    public MainForm() {
        InitializeComponent();

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
        this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler( this.OnTabPageSelected );
    }

    private void OnTabPageSelected( object sender, TabControlEventArgs e ) {
        //- select into the propertygrid the current Form 
        SelectRootComponent();
    } 

    #endregion



    //- When the selection changes this sets the PropertyGrid's selected component
    private void OnSelectionChanged ( object sender, System.EventArgs e ) {
        IDesignSurfaceExt isurf = GetCurrentIDesignSurface();
        if ( null != isurf ) {
            ISelectionService selectionService = null;
            selectionService = isurf.GetIDesignerHost().GetService ( typeof ( ISelectionService ) ) as ISelectionService;
            this.propertyGrid.SelectedObject = selectionService.PrimarySelection;
        }
    }
    
    private void SelectRootComponent() {
        //- find out the DesignSurfaceExt control hosted by the TabPage
        IDesignSurfaceExt isurf = GetCurrentIDesignSurface();
        if( null != isurf )
            this.propertyGrid.SelectedObject = isurf.GetIDesignerHost().RootComponent;
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
        TabPage tp =new TabPage("Use SnapLines");
        this.tabControl1.TabPages.Add(tp);
        int iTabPageSelectedIndex = this.tabControl1.SelectedIndex;
        //- steps.1.2.3
        DesignSurfaceExt2 surface = CreateDesignSurface();
        //- step.4
        //- choose an alignment mode...
        ((DesignSurfaceExt2)surface).UseSnapLines();
        //- step.5
        //- create the Root compoment, in these cases a Form
        try {
            Form rootComponent = null;
            rootComponent = (Form) surface.CreateRootComponent( typeof( Form ), new Size( 400, 400 ) );
            rootComponent.Text = "Root Component hosted by the DesignSurface N." + iTabPageSelectedIndex;
            rootComponent.BackColor = Color.Yellow;
            //-
            //-
            //- step.4
            //- display the DesignSurface
            Control view = surface.GetView();
            if( null == view ) 
                return ;
            //- change some properties
            view.Text = "Test Form N. " + iTabPageSelectedIndex;
            view.Dock = DockStyle.Fill;
            //- Note these assignments
            view.Parent = tp;
            //- finally enable the Drag&Drop on RootComponent
            ((DesignSurfaceExt2) surface).EnableDragandDrop();
        }//end_try
        catch( Exception ex) {
            Console.WriteLine( Name + " the DesignSurface N. " + iTabPageSelectedIndex + " has generated errors during loading!Exception: " + ex.Message );
            return ;
        }//end_catch
    }

    private void newFormUseGridandSnapMenuItem_Click( object sender, EventArgs e ) {
        TabPage tp = new TabPage( "Use Grid (Snap to the grid)" );
        this.tabControl1.TabPages.Add( tp );
        int iTabPageSelectedIndex = this.tabControl1.SelectedIndex;
        //- steps.1.2.3
        DesignSurfaceExt2 surface = CreateDesignSurface();
        //- step.4
        //- choose an alignment mode...
        ((DesignSurfaceExt2) surface).UseGrid( new System.Drawing.Size( 32, 32 ) );
        //- step.5
        //- create the Root compoment, in these cases a Form
        try {
            Form rootComponent = null;
            rootComponent = (Form) surface.CreateRootComponent( typeof( Form ), new Size( 400, 400 ) );
            rootComponent.Text = "Root Component hosted by the DesignSurface N." + iTabPageSelectedIndex;
            rootComponent.BackColor = Color.YellowGreen;
            //-
            //-
            //- step.4
            //- display the DesignSurface
            Control view = surface.GetView();
            if( null == view ) 
                return;
            //- change some properties
            view.Text = "Test Form N. " + iTabPageSelectedIndex;
            view.Dock = DockStyle.Fill;
            //- Note these assignments
            view.Parent = tp;
        }//end_try
        catch( Exception ex ) {
            Console.WriteLine( Name + " the DesignSurface N. " + iTabPageSelectedIndex + " has generated errors during loading!Exception: " + ex.Message );
            return;
        }//end_catch
    }

    private void newFormUseGridMenuItem_Click( object sender, EventArgs e ) {
        TabPage tp = new TabPage( "Use Grid" );
        this.tabControl1.TabPages.Add( tp );
        int iTabPageSelectedIndex = this.tabControl1.SelectedIndex;
        //- steps.1.2.3
        DesignSurfaceExt2 surface = CreateDesignSurface();
        //- step.4
        //- choose an alignment mode...
        ((DesignSurfaceExt2) surface).UseGridWithoutSnapping( new System.Drawing.Size( 16, 16 ) );
        //- step.5
        //- create the Root compoment, in these cases a Form
        try {
            Form rootComponent = null;
            rootComponent = (Form) surface.CreateRootComponent( typeof( Form ), new Size( 600, 400 ) );
            rootComponent.Text = "Root Component hosted by the DesignSurface N." + iTabPageSelectedIndex;
            rootComponent.BackColor = Color.LightGreen;
            //-
            //-
            //- step.4
            //- display the DesignSurface
            Control view = surface.GetView();
            if( null == view ) 
                return;
            //- change some properties
            view.Text = "Test Form N. " + iTabPageSelectedIndex;
            view.Dock = DockStyle.Fill;
            //- Note these assignments
            view.Parent = tp;
        }//end_try
        catch( Exception ex ) {
            Console.WriteLine( Name + " the DesignSurface N. " + iTabPageSelectedIndex + " has generated errors during loading!Exception: " + ex.Message );
            return;
        }//end_catch
    }

    private void newFormAlignControlByhandMenuItem_Click( object sender, EventArgs e ) {
        TabPage tp = new TabPage( "Align control by hand" );
        this.tabControl1.TabPages.Add( tp );
        int iTabPageSelectedIndex = this.tabControl1.SelectedIndex;
        //- steps.1.2.3
        DesignSurfaceExt2 surface = CreateDesignSurface();
        //- step.4
        //- choose an alignment mode...
        ((DesignSurfaceExt2) surface).UseNoGuides();
        //- step.5
        //- create the Root compoment, in these cases a Form
        try {
            Form rootComponent = null;
            rootComponent = (Form) surface.CreateRootComponent( typeof( Form ), new Size( 400, 400 ) );
            rootComponent.Text = "Root Component hosted by the DesignSurface N." + iTabPageSelectedIndex;
            rootComponent.BackColor = Color.LightGray;
            //-
            //-
            //- step.4
            //- display the DesignSurface
            Control view = surface.GetView();
            if( null == view ) 
                return;
            //- change some properties
            view.Text = "Test Form N. " + iTabPageSelectedIndex;
            view.Dock = DockStyle.Fill;
            //- Note these assignments
            view.Parent = tp;
        }//end_try
        catch( Exception ex ) {
            Console.WriteLine( Name + " the DesignSurface N. " + iTabPageSelectedIndex + " has generated errors during loading!Exception: " + ex.Message );
            return;
        }//end_catch
    }
    
    private DesignSurfaceExt2 CreateDesignSurface() {
        //- step.0
        //- create a DesignSurface and put it inside a Form in DesignTime
        DesignSurfaceExt2 surface = new DesignSurfaceExt2();
        //-
        //-
        IDesignSurfaceExt2 isurf = (IDesignSurfaceExt2) surface;
        this._listOfDesignSurface.Add( isurf );
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

}


}