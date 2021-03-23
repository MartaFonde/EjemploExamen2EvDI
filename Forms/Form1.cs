using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        private List<sFriki> frikis = new List<sFriki>();
        string titulo = "FrikiLove Inc.";
        int letra;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        bool borrando = false;
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            borrando = true;
            
            for (int i = listBox1.SelectedItems.Count - 1; i >= 0 ; i--)
            {
                for (int j = frikis.Count - 1; j >= 0; j--)
                {
                    if(frikis[j].Nombre == listBox1.SelectedItems[i].ToString())
                    {
                        frikis.RemoveAt(j);
                    }
                }
                listBox1.Items.Remove(listBox1.SelectedItems[i]);                
            }
            pictureBox1.Image = null;
            borrando = false;
            listBox1.SelectedIndex = -1;
            for (int i = this.panel1.Controls.Count - 1; i >= 0; i--)
            {
                this.panel1.Controls.RemoveAt(i);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if(f2.ShowDialog() == DialogResult.OK)
            {
                eAficion af = eAficion.Fantasía;
                eSexo s = eSexo.Mujer;
                eSexo sOp = eSexo.Hombre;

                if (f2.validateTbNombre.Valido && f2.validateTbEdad.Valido && f2.textBox1.Text.Length > 0
                    && Enum.TryParse(f2.cbAficciones.SelectedItem.ToString(), out af) 
                    && Enum.TryParse(f2.rbSexoH.Checked ? f2.rbSexoH.Text : f2.rbSexoM.Text, out s)
                    && Enum.TryParse(f2.rbSexoOpH.Checked ? f2.rbSexoOpH.Text : f2.rbSexoOpM.Text, out sOp))
                {                    
                    frikis.Add(new sFriki(f2.validateTbNombre.Texto, Int32.Parse(f2.validateTbEdad.Texto),
                        af, s, sOp, f2.textBox1.Text));
                    listBox1.Items.Add(f2.validateTbNombre.Texto);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!borrando)
            {
                int y = 5;
                int x = 5;

                for (int i = this.panel1.Controls.Count - 1; i >= 0; i--)
                {
                    this.panel1.Controls.RemoveAt(i);
                }

                for (int i = 0; i < frikis.Count; i++)
                {
                    if (frikis[i].Nombre == listBox1.SelectedItem.ToString())
                    {
                        pictureBox1.Image = new Bitmap(frikis[i].Foto);
                        toolTip1.SetToolTip(pictureBox1, frikis[i].Nombre + "\n" + frikis[i].Edad + "\n" + frikis[i].Aficion);   
                        for (int j = 0; j < frikis.Count; j++)
                        {
                            if (frikis[j].Sexo == frikis[i].SexoOpuesto && frikis[j].Aficion == frikis[i].Aficion)
                            {
                                Label lbl = new Label();
                                lbl.Text = frikis[j].Nombre;
                                lbl.Location = new Point(x, y);
                                this.panel1.Controls.Add(lbl);
                                y += lbl.Height + 5;
                            }
                        }
                    }
                }
            }           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa para encontrar pareja", "Eiii frikis");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (letra == titulo.Length) letra = 0;           
            this.Text = titulo.Substring(0, letra+1);
            letra++;      
        }
    }
}
