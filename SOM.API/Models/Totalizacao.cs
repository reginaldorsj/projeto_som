using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOM.API.Models
{
    [Serializable]
    public class Totalizacao
    {
        private long _id;
        private string _detalhe;
        private string _cor;
        private DateTime _data;
        private int _quantidade;

        public long Id { get => _id; set => _id = value; }
        public string Detalhe { get => _detalhe; set => _detalhe = value; }
        public string Cor { get => _cor; set => _cor = value; }
        public DateTime Data { get => _data; set => _data = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
    }
}