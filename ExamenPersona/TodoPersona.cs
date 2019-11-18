using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPersona
{
    class TodoPersona
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string FechaNacimiento { get; set; }
        public string Dni { get; set; }
        public bool Done { get; set; }
    }

}

