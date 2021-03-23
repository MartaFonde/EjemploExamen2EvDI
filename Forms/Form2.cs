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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            cbAficciones.Items.Add(eAficion.Manga);
            cbAficciones.Items.Add(eAficion.SciFi);
            cbAficciones.Items.Add(eAficion.RPG);
            cbAficciones.Items.Add(eAficion.Tecnología);
            cbAficciones.Items.Add(eAficion.Terror);
            cbAficciones.Items.Add(eAficion.Fantasía);
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "jpg|*.jpg|Todos los archivos|*.*";
            if(op.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = op.FileName;
            }
        }
    }
}
