using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOM.API.Models
{
    [Serializable]
    public class Plantao
    {
        private string _especialidade;
        private string _medico;
        private string _cremeb;
        private string _uf;
        private DateTime _dataHoraInicio;
        private DateTime _dataHoraFim;
        public string Especialidade { get => _especialidade; set => _especialidade = value; }
        public string Profissional { get => _medico; set => _medico = value; }
        public string Cremeb { get => _cremeb; set => _cremeb = value; }
        public string Uf { get => _uf; set => _uf = value; }
        public DateTime DataHoraInicio { get => _dataHoraInicio; set => _dataHoraInicio = value; }
        public DateTime DataHoraFim { get => _dataHoraFim; set => _dataHoraFim = value; }


    }
}