using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class Mision
    {
        #region Fields (Private Backing Fields)
        private int _id;
        private string _titulo;
        private string _descripcion;
        private int _creditos;
        #endregion

        #region Properties
        public int Id
        {
            get { return _id; }
        }

        public string Titulo
        {
            get { return _titulo; }
        }
        #endregion

        #region Constructors
        public Mision() { }

        public Mision(int id, string nombre)
        {
            _id = id;
            _nombre = nombre;
        }
        #endregion
    }
}
}
