namespace pF.pDesigner {

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
using System.Windows.Markup;




public partial class pDesignerMainForm : Form {

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


    public pDesigner pDesignerCore = new pDesigner();
    private IpDesigner IpDesignerCore = null;

    #region Init

    //- ctor
    public pDesignerMainForm() {
        InitializeComponent();

        //- the control: (pDesigner)pDesignerCore 
        IpDesignerCore = this.pDesignerCore as IpDesigner;
        pDesignerCore.Parent = this.pnl4pDesigner;


        //- Add the toolboxItems to the future toolbox 
        //- the pointer
        ToolboxItem toolPointer = new System.Drawing.Design.ToolboxItem();
        toolPointer.DisplayName = "<Pointer>";
        toolPointer.Bitmap = new System.Drawing.Bitmap( 16, 16 );
        listBox1.Items.Add( toolPointer );
        //- the controls
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
        
        
        //- init the (pDesigner)pDesignerCore 
        IpDesignerCore.Toolbox = listBox1;
    }

    private void pDesignerMainForm_Load( object sender, EventArgs e ) {

    }

    #endregion




    #region Menu commands

    private void deleteFormToolStripMenuItem_Click( object sender, EventArgs e ) {
        IpDesignerCore.RemoveDesignSurface( IpDesignerCore.ActiveDesignSurface );
    }

    private void undoToolStripMenuItem_Click ( object sender, EventArgs e ) {
        IpDesignerCore.UndoOnDesignSurface();
    }

    private void redoToolStripMenuItem_Click ( object sender, EventArgs e ) {
        IpDesignerCore.RedoOnDesignSurface();
    }

    private void OnMenuClick( object sender, EventArgs e ) {
        string cmd = (sender as ToolStripMenuItem).Text;
        if( cmd == "Cut" )
            IpDesignerCore.CutOnDesignSurface();
        else if( cmd == "Copy" )
            IpDesignerCore.CopyOnDesignSurface();
        else if( cmd == "Paste" )
            IpDesignerCore.PasteOnDesignSurface();
        else if( cmd == "Delete" )
            IpDesignerCore.DeleteOnDesignSurface();
    }

    private void toolStripMenuItemTabOrder_Click( object sender, EventArgs e ) {
        IpDesignerCore.SwitchTabOrder();
    }

    private void OnAbout( object sender, EventArgs e ) {
        MessageBox.Show( "picoFormDesigner coded by Paolo Foti \r\nVersion is: " + Version, "pFDesigner - p(ico)F(orm)Designer", MessageBoxButtons.OK, MessageBoxIcon.Question );
    }
    #endregion

    private void toolStripMenuItem1_Click( object sender, EventArgs e ) {
        IpDesignerCore.AddDesignSurface<Form>( 640, 480, AlignmentModeEnum.SnapLines, new Size( 1, 1 ) );
 
    }

    private void useGridToolStripMenuItem_Click( object sender, EventArgs e ) {
        IpDesignerCore.AddDesignSurface<Form>( 640, 480, AlignmentModeEnum.Grid, new Size( 16, 16 ) );
 
    }

    private void useGridWithoutSnappingToolStripMenuItem_Click( object sender, EventArgs e ) {
        IpDesignerCore.AddDesignSurface<Form>( 640, 480, AlignmentModeEnum.GridWithoutSnapping, new Size( 16, 16 ) );
 
    }

    private void useNoGuidesToolStripMenuItem_Click( object sender, EventArgs e ) {
        IpDesignerCore.AddDesignSurface<Form>( 640, 480, AlignmentModeEnum.NoGuides, new Size( 1, 1 ) );
 
    }


}//end_class
}//end_namespace