using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuavanzado.Registros.RegistroDVDs
{

    internal class ColeccionDVD
    {
        public List<DVD> DVDsRegistrados = new List<DVD>();


        public void agregar(DVD index)
        {


            DVDsRegistrados.Add(index);


        }

    }
}
