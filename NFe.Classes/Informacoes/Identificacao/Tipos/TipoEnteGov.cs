using System.ComponentModel;
using System.Xml.Serialization;

namespace NFe.Classes.Informacoes.Identificacao.Tipos
{
    public enum TipoEnteGov
    {
        [Description("União")]
        [XmlEnum("1")]
        Uniao = 1,

        [Description("Estados")]
        [XmlEnum("2")]
        Estados = 2,

        [Description("Distrito Federal")]
        [XmlEnum("3")]
        DistritoFederal = 3,

        [Description("Municípios")]
        [XmlEnum("4")]
        Municipios = 4,
    }
}
