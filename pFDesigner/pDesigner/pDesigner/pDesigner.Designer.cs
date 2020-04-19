namespace pF.pDesigner {
    partial class pDesigner {
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

#region Component Designer generated code

/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent() {
    this.splitterpDesigner = new System.Windows.Forms.SplitContainer();
    this.tbCtrlpDesigner = new System.Windows.Forms.TabControl();
    this.splitterpDesigner.Panel1.SuspendLayout();
    this.splitterpDesigner.SuspendLayout();
    this.SuspendLayout();
    //
    // splitterpDesigner
    //
    this.splitterpDesigner.Dock = System.Windows.Forms.DockStyle.Fill;
    this.splitterpDesigner.Location = new System.Drawing.Point ( 0, 0 );
    this.splitterpDesigner.Name = "splitterpDesigner";
    //
    // splitterpDesigner.Panel1
    //
    this.splitterpDesigner.Panel1.Controls.Add ( this.tbCtrlpDesigner );
    this.splitterpDesigner.Size = new System.Drawing.Size ( 635, 305 );
    this.splitterpDesigner.SplitterDistance = 439;
    this.splitterpDesigner.TabIndex = 0;
    //
    // tbCtrlpDesigner
    //
    this.tbCtrlpDesigner.Dock = System.Windows.Forms.DockStyle.Fill;
    this.tbCtrlpDesigner.Location = new System.Drawing.Point ( 0, 0 );
    this.tbCtrlpDesigner.Name = "tbCtrlpDesigner";
    this.tbCtrlpDesigner.SelectedIndex = 0;
    this.tbCtrlpDesigner.Size = new System.Drawing.Size ( 439, 305 );
    this.tbCtrlpDesigner.TabIndex = 0;
    this.tbCtrlpDesigner.SelectedIndexChanged += new System.EventHandler ( this.tbCtrlpDesigner_SelectedIndexChanged );
    //
    // pDesigner
    //
    this.AutoScaleDimensions = new System.Drawing.SizeF ( 8F, 16F );
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    this.Controls.Add ( this.splitterpDesigner );
    this.Name = "pDesigner";
    this.Size = new System.Drawing.Size ( 635, 305 );
    this.splitterpDesigner.Panel1.ResumeLayout ( false );
    this.splitterpDesigner.ResumeLayout ( false );
    this.ResumeLayout ( false );

}

#endregion

private System.Windows.Forms.SplitContainer splitterpDesigner;
private System.Windows.Forms.TabControl tbCtrlpDesigner;
    }
}
