using System;using System.Text;using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Drawing;

using pF.DesignSurfaceManagerExt;


namespace pF.DesignSurfaceManagerExt {
class Program {
    const string _Name_ = "DemoConsole";

    [STAThread]
    static void Main ( string[] args ) {
        try {
            Console.WriteLine( "Begin the demo of DesignSurfaceManagerExt..." );
                        
            MainForm f = new MainForm();
            f.Size = new Size(1200, 800);
            f.Show();
            f.newFormUseSnapLinesMenuItem.PerformClick();
            f.newFormUseGridandSnapMenuItem.PerformClick();
            f.newFormUseGridMenuItem.PerformClick();
            f.newFormAlignControlByhandMenuItem.PerformClick();
            Application.Run();

            Console.WriteLine ( "Bye!" );
        }//end_try
        catch ( Exception ex ) {
            Console.WriteLine ( "Exception (strike a key to quit!): " + ex.Message );
            Console.ReadLine();
        }//end_catch
    }//end_main


  
    
}//end_class
}//end_namespace

