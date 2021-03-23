using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    public enum eAficion
    {
        Manga,
        SciFi,
        RPG,
        Fantasía,
        Terror,
        Tecnología
    }
    public enum eSexo
    {
        Hombre, Mujer
    }
    class sFriki
    {
        internal string Nombre { set; get; }
        internal int Edad { set; get; }
        internal eAficion Aficion { set; get; }
        internal eSexo Sexo { set; get; }
        internal eSexo SexoOpuesto { set; get; }
        internal string Foto { set; get; }

        public sFriki(string nombre, int edad, eAficion aficion, eSexo sexo, eSexo sexoOpuesto, string foto)
        {
            Nombre = nombre;
            Edad = edad;
            Aficion = aficion;
            Sexo = sexo;
            SexoOpuesto = sexoOpuesto;
            Foto = foto;
        }
    }
}
