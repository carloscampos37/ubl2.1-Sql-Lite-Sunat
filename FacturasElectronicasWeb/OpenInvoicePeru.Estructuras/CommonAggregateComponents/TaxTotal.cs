using System;
using OpenInvoicePeru.Estructuras.CommonBasicComponents;

namespace OpenInvoicePeru.Estructuras.CommonAggregateComponents
{
    [Serializable]
    public class TaxTotal
    {
        public string Moneda { get; set; }
        
        public PayableAmount TaxableAmount { get; set; }

        public PayableAmount TaxAmount { get; set; }

        public TaxSubtotal TaxSubtotal { get; set; }

        public TaxTotal()
        {
            Moneda = "";
            TaxableAmount = new PayableAmount();
            TaxAmount = new PayableAmount();
            TaxSubtotal = new TaxSubtotal();
        }
    }
}