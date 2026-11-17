using System.Xml.Serialization;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao
{
    public class gCBSMonoAdRem
    {
        [XmlElement(Order = 1)]
        public gCBSMonoAdRemMonoPadrao gMonoPadrao { get; set; }

        [XmlElement(Order = 2)]
        public gCBSMonoAdRemMonoReten gMonoReten { get; set; }

        [XmlElement(Order = 3)]
        public gCBSMonoAdRemMonoRet gMonoRet { get; set; }

        [XmlElement(Order = 4)]
        public gCBSMonoAdRempBioDiferenca gpBioDiferenca { get; set; }
    }

    public class gCBSMonoAdRemMonoPadrao
    {
        private decimal _qBCMono;
        private decimal _adRemCBS;
        private decimal _vCBSMono;

        [XmlElement(Order = 1)]
        public decimal qBCMono
        {
            get => _qBCMono.Arredondar(4);
            set => _qBCMono = value.Arredondar(4);
        }

        [XmlElement(Order = 2)]
        public decimal adRemCBS
        {
            get => _adRemCBS.Arredondar(4);
            set => _adRemCBS = value.Arredondar(4);
        }

        [XmlElement(Order = 3)]
        public decimal vCBSMono
        {
            get => _vCBSMono.Arredondar(2);
            set => _vCBSMono = value.Arredondar(2);
        }
    }

    public class gCBSMonoAdRemMonoReten
    {
        private decimal _qBCMonoReten;
        private decimal _adRemCBSReten;
        private decimal _vCBSMonoReten;

        [XmlElement(Order = 1)]
        public decimal qBCMonoReten
        {
            get => _qBCMonoReten.Arredondar(4);
            set => _qBCMonoReten = value.Arredondar(4);
        }

        [XmlElement(Order = 2)]
        public decimal adRemCBSReten
        {
            get => _adRemCBSReten.Arredondar(4);
            set => _adRemCBSReten = value.Arredondar(4);
        }

        [XmlElement(Order = 3)]
        public decimal vCBSMonoReten
        {
            get => _vCBSMonoReten.Arredondar(2);
            set => _vCBSMonoReten = value.Arredondar(2);
        }
    }

    public class gCBSMonoAdRemMonoRet
    {
        private decimal _vCBSMonoRet;

        [XmlElement(Order = 1)]
        public decimal vCBSMonoRet
        {
            get => _vCBSMonoRet.Arredondar(2);
            set => _vCBSMonoRet = value.Arredondar(2);
        }
    }

    public class gCBSMonoAdRempBioDiferenca
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
