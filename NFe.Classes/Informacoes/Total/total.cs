namespace NFe.Classes.Informacoes.Total
{
    public class total
    {
        private decimal? _vNFTot;

        /// <summary>
        ///     W02 - Grupo Totais referentes ao ICMS
        /// </summary>
        public ICMSTot ICMSTot { get; set; }

        /// <summary>
        ///     W17 - Grupo Totais referentes ao ISSQN
        /// </summary>
        public ISSQNtot ISSQNtot { get; set; }

        /// <summary>
        ///     W23 - Grupo Retenções de Tributos
        /// </summary>
        public retTrib retTrib { get; set; }

        public IBSCBSTot IBSCBSTot { get; set; }

        public decimal? vNFTot
        {
            get { return _vNFTot.Arredondar(2); }
            set { _vNFTot = value.Arredondar(2); }
        }

        public bool ShouldSerializevNFTot()
        {
            return vNFTot.HasValue;
        }
    }
}