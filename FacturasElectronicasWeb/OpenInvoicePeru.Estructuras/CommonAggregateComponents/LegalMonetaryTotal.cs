using System;
using OpenInvoicePeru.Estructuras.CommonBasicComponents;

namespace OpenInvoicePeru.Estructuras.CommonAggregateComponents
{
    [Serializable]
    public class LegalMonetaryTotal
    {
        public PayableAmount LineExtensionAmount { get; set; }

        public PayableAmount TaxInclusiveAmount { get; set; }

        public PayableAmount PayableAmount { get; set; }

        public PayableAmount AllowanceTotalAmount { get; set; }

        public PayableAmount ChargeTotalAmount { get; set; }

        public PayableAmount PrepaidAmount { get; set; }

        public string Moneda { get; set; }

        public LegalMonetaryTotal()
        {
            Moneda = "PEN";
            // GRAVADA
            LineExtensionAmount = new PayableAmount();
    
            // venta total
            TaxInclusiveAmount = new PayableAmount();
     
  
            // descuentos
            AllowanceTotalAmount = new PayableAmount();

            // cargos
            ChargeTotalAmount = new PayableAmount();

            // venta - descuento + cargos
            PayableAmount = new PayableAmount();

            PrepaidAmount = new PayableAmount();
        }
    }
}