using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms.Design;
using System.Diagnostics;



namespace pF.DesignSurfaceExt {

class Program {
    const string _Name_ = "DemoConsole";

    //- NOTE: the code needs to run under a thread with an STA ApartmentState
    [STAThread]
    static void Main ( string[] args ) {
        try {
            Console.WriteLine( "Begin the demo of DesignSurfaceExt..." );


            //Form frm = new Form();
            //IDesignSurfaceExt surface = new DesignSurfaceExt.DesignSurfaceExt();
            //surface.CreateRootComponent( typeof( Form ), new Size( 400, 400 ) );
            //surface.CreateControl( typeof( Button ), new Size( 100, 40 ), new Point( 10, 10 ) );
            //TextBox t1 = (TextBox) surface.CreateControl( typeof( TextBox ), new Size( 300, 20 ), new Point( 10, 80 ) );
            //t1.Text = "Hello World by DesignSurfaceExt";
            //surface.GetView().Parent = frm;
            //frm.ShowDialog();
            
            
            MainForm f = new MainForm();
            f.ShowDialog();

            Console.WriteLine ( "Bye!" );
        }//end_try
        catch ( Exception ex ) {
            Console.WriteLine ( "Exception (strike a key to quit!): " + ex.Message );
            Console.ReadLine();
        }//end_catch

    }//end_main
}//end_class
}//end_namespace
