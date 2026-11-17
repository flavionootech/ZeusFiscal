using System;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;
using NFe.Classes.Informacoes.Pagamento;
using Xunit;

namespace NFe.Utils.Testes
{
    public class FormaPagamentoTestes
    {
        [Theory]
        [InlineData("01", FormaPagamento.fpDinheiro)]
        [InlineData("17", FormaPagamento.fpPagamentoInstantaneoPIXDinamico)]
        [InlineData("20", FormaPagamento.fpPagamentoInstantaneoPIXEstatico)]
        [InlineData("23", FormaPagamento.fpPagamentoInstantaneoPIXAutomatico)]
        [InlineData("24", FormaPagamento.fpPagamentoBookTransfer)]
        [InlineData("90", FormaPagamento.fpSemPagamento)]
        [InlineData("99", FormaPagamento.fpOutro)]
        public void DeveLerMeioPagamentoDoXml(string codigo, FormaPagamento formaPagamento)
        {
            var serializer = new XmlSerializer(typeof(detPag));
            using var leitor = new StringReader($"<detPag><tPag>{codigo}</tPag><vPag>10.00</vPag></detPag>");
            var pagamento = (detPag)serializer.Deserialize(leitor);

            Assert.Equal(formaPagamento, pagamento.tPag);
            Assert.Equal(10m, pagamento.vPag);
        }

        [Theory]
        [InlineData("01", FormaPagamento.fpDinheiro)]
        [InlineData("17", FormaPagamento.fpPagamentoInstantaneoPIXDinamico)]
        [InlineData("20", FormaPagamento.fpPagamentoInstantaneoPIXEstatico)]
        [InlineData("23", FormaPagamento.fpPagamentoInstantaneoPIXAutomatico)]
        [InlineData("24", FormaPagamento.fpPagamentoBookTransfer)]
        [InlineData("90", FormaPagamento.fpSemPagamento)]
        [InlineData("99", FormaPagamento.fpOutro)]
        public void DeveGravarMeioPagamentoNoXml(string codigo, FormaPagamento formaPagamento)
        {
            var pagamento = new detPag
            {
                tPag = formaPagamento,
                vPag = 10m
            };

            var serializer = new XmlSerializer(typeof(detPag));
            using var escritor = new StringWriter();
            serializer.Serialize(escritor, pagamento);
            var xml = XDocument.Parse(escritor.ToString());

            Assert.Equal(codigo, xml.Root.Element("tPag").Value);
            Assert.Equal(10m, (decimal)xml.Root.Element("vPag"));
        }

        [Fact]
        public void DeveRejeitarMeioPagamentoDesconhecido()
        {
            var serializer = new XmlSerializer(typeof(detPag));
            using var leitor = new StringReader("<detPag><tPag>25</tPag><vPag>10.00</vPag></detPag>");

            Assert.Throws<InvalidOperationException>(() => serializer.Deserialize(leitor));
        }
    }
}
