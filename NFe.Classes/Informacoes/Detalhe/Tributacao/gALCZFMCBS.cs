using System.Xml.Serialization;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao
{
    public class gALCZFMCBS
    {
        private decimal _pAliqEfetRegCbs;
        private decimal _vTribRegCbs;

        [XmlElement(Order = 1)]
        public string tpALCZFMCBS { get; set; }

        [XmlElement(Order = 2)]
        public string nProcSuframa { get; set; }

        [XmlElement(Order = 3)]
        public decimal pAliqEfetRegCBS
        {
            get => _pAliqEfetRegCbs.Arredondar(4);
            set => _pAliqEfetRegCbs = value.Arredondar(4);
        }

        [XmlElement(Order = 4)]
        public decimal vTribRegCBS
        {
            get => _vTribRegCbs.Arredondar(2);
            set => _vTribRegCbs = value.Arredondar(2);
        }
    }
}
