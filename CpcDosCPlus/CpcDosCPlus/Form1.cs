using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpcDosCPlus
{
    public partial class Form1 : Form
    {
        private readonly CpcDosCPlusListeObjets objets;

        public Form1()
        {
            InitializeComponent();
            objets = new CpcDosCPlusListeObjets("fichier1.txt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (CpcDosCPlusObjet objet in objets)
            {
                listBox1.Items.Add(objet);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            ListBox list = sender as ListBox;

            if (list != null)
            {
                CpcDosCPlusObjet obj = list.SelectedItem as CpcDosCPlusObjet;

                if (list != null)
                {
                    panel1.Controls.Add(obj.CreateUC());
                }
            }
        }
    }
}
