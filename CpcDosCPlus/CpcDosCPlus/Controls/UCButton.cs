using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpcDosCPlus.Controls
{
    public partial class UCButton : UserControl
    {
        public UCButton(CpcDosCPlusBouton button)
        {
            InitializeComponent();
            //TODO: Gérer proprement le binding bi-directionnel
            textBox1.Text = button.Texte; 
            button1.Text = button.Texte;
        }
    }
}
