using System.Xml.Serialization;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao
{
    public class gIBSMonoAdRem
    {
        [XmlElement(Order = 1)]
        public gIBSMonoAdRemMonoPadrao gMonoPadrao { get; set; }

        [XmlElement(Order = 2)]
        public gIBSMonoAdRemMonoReten gMonoReten { get; set; }

        [XmlElement(Order = 3)]
        public gIBSMonoAdRemMonoRet gMonoRet { get; set; }

        [XmlElement(Order = 4)]
        public gIBSMonoAdRempBioDiferenca gpBioDiferenca { get; set; }
    }

    public class gIBSMonoAdRemMonoPadrao
    {
        private decimal _qBCMono;
        private decimal _adRemIBS;
        private decimal _vIBSMono;

        [XmlElement(Order = 1)]
        public decimal qBCMono
        {
            get => _qBCMono.Arredondar(4);
            set => _qBCMono = value.Arredondar(4);
        }

        [XmlElement(Order = 2)]
        public decimal adRemIBS
        {
            get => _adRemIBS.Arredondar(4);
            set => _adRemIBS = value.Arredondar(4);
        }

        [XmlElement(Order = 3)]
        public decimal vIBSMono
        {
            get => _vIBSMono.Arredondar(2);
            set => _vIBSMono = value.Arredondar(2);
        }
    }

    public class gIBSMonoAdRemMonoReten
    {
        private decimal _qBCMonoReten;
        private decimal _adRemIBSReten;
        private decimal _vIBSMonoReten;

        [XmlElement(Order = 1)]
        public decimal qBCMonoReten
        {
            get => _qBCMonoReten.Arredondar(4);
            set => _qBCMonoReten = value.Arredondar(4);
        }

        [XmlElement(Order = 2)]
        public decimal adRemIBSReten
        {
            get => _adRemIBSReten.Arredondar(4);
            set => _adRemIBSReten = value.Arredondar(4);
        }

        [XmlElement(Order = 3)]
        public decimal vIBSMonoReten
        {
            get => _vIBSMonoReten.Arredondar(2);
            set => _vIBSMonoReten = value.Arredondar(2);
        }
    }

    public class gIBSMonoAdRemMonoRet
    {
        private decimal _vIBSMonoRet;

        [XmlElement(Order = 1)]
        public decimal vIBSMonoRet
        {
            get => _vIBSMonoRet.Arredondar(2);
            set => _vIBSMonoRet = value.Arredondar(2);
        }
    }

    public class gIBSMonoAdRempBioDiferenca
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
