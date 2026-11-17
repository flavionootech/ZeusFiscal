using System.Xml.Serialization;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao
{
    public class gCBSMonoAdValorem
    {
        [XmlElement(Order = 1)]
        public gCBSMonoAdValoremMonoPadrao gMonoPadrao { get; set; }

        [XmlElement(Order = 2)]
        public gCBSMonoAdValoremMonoReten gMonoReten { get; set; }

        [XmlElement(Order = 3)]
        public gCBSMonoAdValoremMonoRet gMonoRet { get; set; }

        [XmlElement(Order = 4)]
        public gCBSMonoAdValorempBioDiferenca gpBioDiferenca { get; set; }
    }

    public class gCBSMonoAdValoremMonoPadrao
    {
        private decimal _vBCMono;
        private decimal _pAliqMonoCBS;
        private decimal _vCBSMono;

        [XmlElement(Order = 1)]
        public decimal vBCMono
        {
            get => _vBCMono.Arredondar(2);
            set => _vBCMono = value.Arredondar(2);
        }

        [XmlElement(Order = 2)]
        public decimal pAliqMonoCBS
        {
            get => _pAliqMonoCBS.Arredondar(4);
            set => _pAliqMonoCBS = value.Arredondar(4);
        }

        [XmlElement(Order = 3)]
        public decimal vCBSMono
        {
            get => _vCBSMono.Arredondar(2);
            set => _vCBSMono = value.Arredondar(2);
        }
    }

    public class gCBSMonoAdValoremMonoReten
    {
        private decimal _vBCMonoReten;
        private decimal _pAliqMonoReten;
        private decimal _vCBSMonoReten;

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
        public decimal vCBSMonoReten
        {
            get => _vCBSMonoReten.Arredondar(2);
            set => _vCBSMonoReten = value.Arredondar(2);
        }
    }

    public class gCBSMonoAdValoremMonoRet
    {
        private decimal _vCBSMonoRet;

        [XmlElement(Order = 1)]
        public decimal vCBSMonoRet
        {
            get => _vCBSMonoRet.Arredondar(2);
            set => _vCBSMonoRet = value.Arredondar(2);
        }
    }

    public class gCBSMonoAdValorempBioDiferenca
    {
        private decimal _qBCBioComb;
        private decimal _vCBSDiferenca;

        [XmlElement(Order = 1)]
        public decimal qBCBioComb
        {
            get => _qBCBioComb.Arredondar(4);
            set => _qBCBioComb = value.Arredondar(4);
        }

        [XmlElement(Order = 2)]
        public decimal vCBSDiferenca
        {
            get => _vCBSDiferenca.Arredondar(2);
            set => _vCBSDiferenca = value.Arredondar(2);
        }
    }
}
