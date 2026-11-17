using System.Xml.Serialization;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao
{
    public class gIBSMonoAdValorem
    {
        [XmlElement(Order = 1)]
        public gIBSMonoAdValoremMonoPadrao gMonoPadrao { get; set; }

        [XmlElement(Order = 2)]
        public gIBSMonoAdValoremMonoReten gMonoReten { get; set; }

        [XmlElement(Order = 3)]
        public gIBSMonoAdValoremMonoRet gMonoRet { get; set; }

        [XmlElement(Order = 4)]
        public gIBSMonoAdValorempBioDiferenca gpBioDiferenca { get; set; }
    }

    public class gIBSMonoAdValoremMonoPadrao
    {
        private decimal _vBCMono;
        private decimal _pAliqMonoUF;
        private decimal _vIBSMonoUF;
        private decimal _pAliqMonoMun;
        private decimal _vIBSMonoMun;
        private decimal _vIBSMono;

        [XmlElement(Order = 1)]
        public decimal vBCMono
        {
            get => _vBCMono.Arredondar(2);
            set => _vBCMono = value.Arredondar(2);
        }

        [XmlElement(Order = 2)]
        public decimal pAliqMonoUF
        {
            get => _pAliqMonoUF.Arredondar(4);
            set => _pAliqMonoUF = value.Arredondar(4);
        }

        [XmlElement(Order = 3)]
        public decimal vIBSMonoUF
        {
            get => _vIBSMonoUF.Arredondar(2);
            set => _vIBSMonoUF = value.Arredondar(2);
        }

        [XmlElement(Order = 4)]
        public decimal pAliqMonoMun
        {
            get => _pAliqMonoMun.Arredondar(4);
            set => _pAliqMonoMun = value.Arredondar(4);
        }

        [XmlElement(Order = 5)]
        public decimal vIBSMonoMun
        {
            get => _vIBSMonoMun.Arredondar(2);
            set => _vIBSMonoMun = value.Arredondar(2);
        }

        [XmlElement(Order = 6)]
        public decimal vIBSMono
        {
            get => _vIBSMono.Arredondar(2);
            set => _vIBSMono = value.Arredondar(2);
        }
    }

    public class gIBSMonoAdValoremMonoReten
    {
        private decimal _vBCMonoReten;
        private decimal _pAliqMonoReten;
        private decimal _vIBSMonoReten;

        [XmlElement(Order = 1)]
        public decimal vBCMonoReten
        {
            get => _vBCMonoReten.Arredondar(2);
            set => _vBCMonoReten = value.Arredondar(2);
        }

        [XmlElement(Order = 2)]
        public decimal pAliqMonoReten
        {
            get => _pAliqMonoReten.Arredondar(4);
            set => _pAliqMonoReten = value.Arredondar(4);
        }

        [XmlElement(Order = 3)]
        public decimal vIBSMonoReten
        {
            get => _vIBSMonoReten.Arredondar(2);
            set => _vIBSMonoReten = value.Arredondar(2);
        }
    }

    public class gIBSMonoAdValoremMonoRet
    {
        private decimal _vIBSMonoRet;

        [XmlElement(Order = 1)]
        public decimal vIBSMonoRet
        {
            get => _vIBSMonoRet.Arredondar(2);
            set => _vIBSMonoRet = value.Arredondar(2);
        }
    }

    public class gIBSMonoAdValorempBioDiferenca
    {
        private decimal _qBCBioComb;
        private decimal _vIBSDiferenca;

        [XmlElement(Order = 1)]
        public decimal qBCBioComb
        {
            get => _qBCBioComb.Arredondar(4);
            set => _qBCBioComb = value.Arredondar(4);
        }

        [XmlElement(Order = 2)]
        public decimal vIBSDiferenca
        {
            get => _vIBSDiferenca.Arredondar(2);
            set => _vIBSDiferenca = value.Arredondar(2);
        }
    }
}
