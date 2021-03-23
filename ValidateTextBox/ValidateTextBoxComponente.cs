using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidateTextBox
{
    public enum eTipo
    {
        Numérico,
        Textual
    }

    [DefaultProperty("Texto")]
    [DefaultEvent("CambiaTexto")]
    public partial class ValidateTextBoxComponente : UserControl
    {        
        private bool valido = false;
        public bool Valido
        {
            get
            {
                return valido;
            }
        }

        [Category("Examen")]
        [Description("Texto del textbox")]
        public string Texto
        {
            set
            {
                textBox1.Text = value;
                comprobar();
            }
            get
            {
                return textBox1.Text;
            }
        }

        [Category("Examen")]
        [Description("Multilinea del textbox")]
        public bool Multilinea
        {
            set
            {
                textBox1.Multiline = value;
            }
            get
            {
                return textBox1.Multiline;
            }
        }

        [Category("Examen")]
        [Description("Tipo de char del textbox")]
        private eTipo tipo = eTipo.Numérico;
        public eTipo Tipo
        {
            set
            {
                if(Enum.IsDefined(typeof(eTipo), value))
                {
                    tipo = value;
                    comprobar();
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return tipo;
            }
        }

        [Category("Examen")]
        [Description("Cambia texto de textbox")]
        public event System.EventHandler CambiaTexto;

        public ValidateTextBoxComponente()
        {
            InitializeComponent();
            valido = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            textBox1.Location = new Point(10, 10);
            //this.Size = new Size(textBox1.Width + 20, textBox1.Height + 20);
            this.Height = textBox1.Height + 20;
            textBox1.Width = this.Width - 20;

            e.Graphics.DrawRectangle(new Pen(valido ? Color.Green : Color.Red), new Rectangle(5, 5, this.Width - 10, this.Height - 10));
        }    
        
        private void comprobar()
        {
            string text = textBox1.Text.Trim();            

            if (Tipo == eTipo.Numérico)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (!Char.IsDigit(text[i]))
                    {
                        valido = false;
                    }
                }
            }
            else if(Tipo == eTipo.Textual)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (!Char.IsLetter(text[i]) && text[i] != ' ')
                    {
                        valido = false;
                    }
                }
            }
            Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CambiaTexto?.Invoke(this, EventArgs.Empty);
            valido = true;
            comprobar();
        }
    }
}
