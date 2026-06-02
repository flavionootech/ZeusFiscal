using System.ComponentModel;
using System.Xml.Serialization;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao
{
    public enum CSTIS
    {
        [Description("Tributada integralmente")]
        [XmlEnum("000")]
        Is000,

        [Description("Alíquota reduzida")]
        [XmlEnum("200")]
        Is200,

        [Description("Isenção")]
        [XmlEnum("400")]
        Is400,

        [Description("Imunidade e não incidência")]
        [XmlEnum("410")]
        Is410,

        [Description("Diferimento")]
        [XmlEnum("510")]
        Is510,

        [Description("Diferimento com redução de alíquota")]
        [XmlEnum("515")]
        Is515,

        [Description("Suspensão")]
        [XmlEnum("550")]
        Is550,

        [Description("Tributação Monofásica")]
        [XmlEnum("620")]
        Is620,

        [Description("Transferência de crédito")]
        [XmlEnum("800")]
        Is800,

        [Description("Ajuste de IBS na ZFM")]
        [XmlEnum("810")]
        Is810,

        [Description("Ajustes")]
        [XmlEnum("811")]
        Is811,

        [Description("Exclusão da Base de Cálculo")]
        [XmlEnum("830")]
        Is830
    }
}