using System.Xml.Serialization;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao
{
    public class gIBSCBSMono
    {
        private decimal _vTotIbsMonoItem;
        private decimal _vTotCbsMonoItem;

        [XmlIgnore]
        public bool PreservarLeiauteAnterior { get; set; }

        // UB84a
        [XmlElement(Order = 1)]
        public gMonoPadrao gMonoPadrao { get; set; }

        // UB90
        [XmlElement(Order = 2)]
        public gMonoReten gMonoReten { get; set; }

        // UB94
        [XmlElement(Order = 3)]
        public gMonoRet gMonoRet { get; set; }

        // UB99
        [XmlElement(Order = 4)]
        public gMonoDif gMonoDif { get; set; }

        [XmlElement(Order = 5)]
        public gIBSMonoAdRem gIBSMonoAdRem { get; set; }

        [XmlElement(Order = 6)]
        public gIBSMonoAdValorem gIBSMonoAdValorem { get; set; }

        [XmlElement(Order = 7)]
        public gCBSMonoAdRem gCBSMonoAdRem { get; set; }

        [XmlElement(Order = 8)]
        public gCBSMonoAdValorem gCBSMonoAdValorem { get; set; }

        // UB104
        [XmlElement(Order = 9)]
        public decimal vTotIBSMonoItem
        {
            get => _vTotIbsMonoItem.Arredondar(2);
            set => _vTotIbsMonoItem = value.Arredondar(2);
        }

        // UB105
        [XmlElement(Order = 10)]
        public decimal vTotCBSMonoItem
        {
            get => _vTotCbsMonoItem.Arredondar(2);
            set => _vTotCbsMonoItem = value.Arredondar(2);
        }

        public bool ShouldSerializegIBSMonoAdRem()
        {
            if (PreservarLeiauteAnterior) return false;

            if (gIBSMonoAdRem == null && gIBSMonoAdValorem == null && gMonoDif == null
                && (gMonoPadrao != null || gMonoReten != null || gMonoRet != null))
            {
                // Compatibilidade com o preenchimento anterior, que reunia IBS e CBS.
                gIBSMonoAdRem = new gIBSMonoAdRem
                {
                    gMonoPadrao = gMonoPadrao == null ? null : new gIBSMonoAdRemMonoPadrao
                    {
                        qBCMono = gMonoPadrao.qBCMono,
                        adRemIBS = gMonoPadrao.adRemIBS,
                        vIBSMono = gMonoPadrao.vIBSMono
                    },
                    gMonoReten = gMonoReten == null ? null : new gIBSMonoAdRemMonoReten
                    {
                        qBCMonoReten = gMonoReten.qBCMonoReten,
                        adRemIBSReten = gMonoReten.adRemIBSReten,
                        vIBSMonoReten = gMonoReten.vIBSMonoReten
                    },
                    gMonoRet = gMonoRet == null ? null : new gIBSMonoAdRemMonoRet
                    {
                        vIBSMonoRet = gMonoRet.vIBSMonoRet
                    }
                };
            }

            return gIBSMonoAdRem != null;
        }

        public bool ShouldSerializegCBSMonoAdRem()
        {
            if (PreservarLeiauteAnterior) return false;

            if (gCBSMonoAdRem == null && gCBSMonoAdValorem == null && gMonoDif == null
                && (gMonoPadrao != null || gMonoReten != null || gMonoRet != null))
            {
                // Compatibilidade com o preenchimento anterior, que reunia IBS e CBS.
                gCBSMonoAdRem = new gCBSMonoAdRem
                {
                    gMonoPadrao = gMonoPadrao == null ? null : new gCBSMonoAdRemMonoPadrao
                    {
                        qBCMono = gMonoPadrao.qBCMono,
                        adRemCBS = gMonoPadrao.adRemCBS,
                        vCBSMono = gMonoPadrao.vCBSMono
                    },
                    gMonoReten = gMonoReten == null ? null : new gCBSMonoAdRemMonoReten
                    {
                        qBCMonoReten = gMonoReten.qBCMonoReten,
                        adRemCBSReten = gMonoReten.adRemCBSReten,
                        vCBSMonoReten = gMonoReten.vCBSMonoReten
                    },
                    gMonoRet = gMonoRet == null ? null : new gCBSMonoAdRemMonoRet
                    {
                        vCBSMonoRet = gMonoRet.vCBSMonoRet
                    }
                };
            }

            return gCBSMonoAdRem != null;
        }

        public bool ShouldSerializegMonoPadrao()
        {
            ShouldSerializegIBSMonoAdRem();
            ShouldSerializegCBSMonoAdRem();
            return gMonoPadrao != null && gIBSMonoAdRem == null && gIBSMonoAdValorem == null
                && gCBSMonoAdRem == null && gCBSMonoAdValorem == null;
        }

        public bool ShouldSerializegMonoReten()
        {
            ShouldSerializegIBSMonoAdRem();
            ShouldSerializegCBSMonoAdRem();
            return gMonoReten != null && gIBSMonoAdRem == null && gIBSMonoAdValorem == null
                && gCBSMonoAdRem == null && gCBSMonoAdValorem == null;
        }

        public bool ShouldSerializegMonoRet()
        {
            ShouldSerializegIBSMonoAdRem();
            ShouldSerializegCBSMonoAdRem();
            return gMonoRet != null && gIBSMonoAdRem == null && gIBSMonoAdValorem == null
                && gCBSMonoAdRem == null && gCBSMonoAdValorem == null;
        }
    }
}
