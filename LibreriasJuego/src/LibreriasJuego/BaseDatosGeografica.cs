using System;
using System.Collections.Generic;
using System.Text;


namespace LibreriasJuego
{
    public class BaseDatosGeografica: IBaseDatosGeografica
    {
        internal BaseDatosGeografica() {
            this.paises = new Dictionary<string, IPais>();
            this.continentes = new Dictionary<string, IContinente>();
            popularBaseDatos();
        }

        private Dictionary<string, IPais> paises;
        private Dictionary<string, IContinente> continentes;

        public IPais getPais(string nombrePais) {
            return this.paises[nombrePais];
        }

        public IContinente getContinente(string nombreContinente) {
            return this.continentes[nombreContinente];
        }

        public IList<IContinente> getContinentes() {
            return new List<IContinente>(this.continentes.Values).AsReadOnly();
        }

        private void popularBaseDatos()
        {
            List<string> nombresContinentes = new List<string>();
            nombresContinentes.Add("Africa");
            nombresContinentes.Add("America");
            nombresContinentes.Add("Asia");
            nombresContinentes.Add("Europa");
            nombresContinentes.Add("Oceania");

            foreach (string nombre in nombresContinentes)
            {
                // Crear Continente
                IContinente c = new Continente(nombre);
                this.continentes.Add(nombre, c);
                // Leer fichero por continente

                // Crear Paises
                // Almacenar
            }
        }
    }

        private IPais procesarLineaPais(string linea, IContinente continente) {
            //Bielorrusia: Minsk - Rublo Bielorruso
            String nombre = null;
            String capital = null;
            IPais p = new Pais(continente, nombre,capital);
            return p;
        }

        
    }
}
