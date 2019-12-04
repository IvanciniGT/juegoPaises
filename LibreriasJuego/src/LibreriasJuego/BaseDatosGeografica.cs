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
        
    }
}
