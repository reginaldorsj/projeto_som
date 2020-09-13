using SOM.OR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOM.API.Models
{
    [Serializable]
    public class Ocorrencia
    {
        private Atendimento _atendimento;
        private IList<Doenca> _doencas;

        public virtual Atendimento Atendimento
        {
            get { return _atendimento; }
            set { _atendimento = value; }
        }
        public virtual IList<Doenca> Doencas
        {
            get { return _doencas; }
            set { _doencas = value; }
        }
    }
}