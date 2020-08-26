using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using OpenInvoicePeru.Comun;
using OpenInvoicePeru.Comun.Constantes;
using OpenInvoicePeru.Estructuras.CommonAggregateComponents;
using OpenInvoicePeru.Estructuras.CommonExtensionComponents;
using OpenInvoicePeru.Estructuras.SunatAggregateComponents;

namespace OpenInvoicePeru.Estructuras.EstandarUbl
{
    [Serializable]
    public class CreditNote : IXmlSerializable, IEstructuraXml
    {


        public DateTime IssueDate { get; set; }

        public string MontoEnLetras { get; set; }

        public decimal DescuentoGlobal { get; set; }

        public SignatureCac Signature { get; set; }

        public AccountingSupplierParty AccountingSupplierParty { get; set; }

        public string UblVersionId { get; set; }

        public UblExtensions UblExtensions { get; set; }

        public BillingPayment PrepaidPayment { get; set; }


        public string InvoiceTypeCode { get; set; }

        public string CustomizationId { get; set; }

        public string Id { get; set; }

         public AccountingSupplierParty AccountingCustomerParty { get; set; }

        public List<InvoiceLine> InvoiceLines { get; set; }

        public List<InvoiceDocumentReference> DespatchDocumentReferences { get; set; }

        public List<InvoiceDocumentReference> AdditionalDocumentReferences { get; set; }

        public string DocumentCurrencyCode { get; set; }

        public List<TaxTotal> TaxTotals { get; set; }

        public LegalMonetaryTotal LegalMonetaryTotal { get; set; }

        public string OrderReference { get; set; }

        public IFormatProvider Formato { get; set; }

        public string NroPedido { get; set; }

        public int TotItem { get; set; }

        // nuevo 

        public string AnexoSunat { get; set; }

        public DateTime IssueHora { get; set; }


        public List<DiscrepancyResponse> DiscrepancyResponses { get; set; }

        public List<BillingReference> BillingReferences { get; set; }

       public List<InvoiceLine> CreditNoteLines { get; set; }

 
        public CreditNote()
        {
            AccountingSupplierParty = new AccountingSupplierParty();
            AccountingCustomerParty = new AccountingSupplierParty();
            DespatchDocumentReferences = new List<InvoiceDocumentReference>();
            AdditionalDocumentReferences = new List<InvoiceDocumentReference>();
            UblExtensions = new UblExtensions();
            Signature = new SignatureCac();
            InvoiceLines = new List<InvoiceLine>();
            TaxTotals = new List<TaxTotal>();
            LegalMonetaryTotal = new LegalMonetaryTotal();
            UblVersionId = "2.1";
            CustomizationId = "2.0";
            Formato = new System.Globalization.CultureInfo(Formatos.Cultura);
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        public void WriteXml(XmlWriter writer)
        {
            // pagina 1

            #region pagina1

            #region Cabecera

            writer.WriteAttributeString("xmlns", EspacioNombres.xmlnsInvoice);
            writer.WriteAttributeString("xmlns:cac", EspacioNombres.cac);
            writer.WriteAttributeString("xmlns:cbc", EspacioNombres.cbc);
            writer.WriteAttributeString("xmlns:ccts", EspacioNombres.ccts);
            writer.WriteAttributeString("xmlns:ds", Http.ds);
            writer.WriteAttributeString("xmlns:ext", EspacioNombres.ext);
            writer.WriteAttributeString("xmlns:qdt", EspacioNombres.qdt);
            writer.WriteAttributeString("xmlns:sac", EspacioNombres.sac);
            writer.WriteAttributeString("xmlns:udt", EspacioNombres.udt);
            writer.WriteAttributeString("xmlns:xsi", Http.xsi);

            #endregion Cabecera

            var ext2 = UblExtensions.Extension2.ExtensionContent.AdditionalInformation;
            {

                #region UBLExtension

                writer.WriteStartElement("ext:UBLExtensions");
                {
                    writer.WriteStartElement("ext:UBLExtension");
                    {
                        writer.WriteStartElement("ext:ExtensionContent");
                        {
                            writer.WriteString("aa");
                        }
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                #endregion UBLExtension

                #endregion pagina1

                // pagina 2

                #region pagina2

                #region UBLVersion

                writer.WriteElementString("cbc:UBLVersionID", UblVersionId);
                writer.WriteElementString("cbc:CustomizationID", CustomizationId);

                #region ProfileID
                writer.WriteStartElement("cbc:ProfileID");
                {
                    writer.WriteAttributeString("schemeName", Sunat.schemeName);
                    writer.WriteAttributeString("schemeAgencyName", Sunat.peSunat);
                    writer.WriteAttributeString("schemeURI", Sunat.catalogos + "17");
                    writer.WriteString("0101");
                }
                writer.WriteEndElement();
                #endregion ProfileID

                writer.WriteElementString("cbc:ID", Id);
                writer.WriteElementString("cbc:IssueDate", IssueDate.ToString(Formatos.FormatoFecha));
                writer.WriteElementString("cbc:IssueTime", IssueHora.ToString(Formatos.FormatoHora));

                #region InvoiceTypeCode

                writer.WriteStartElement("cbc:InvoiceTypeCode");
                {
                    writer.WriteAttributeString("listAgencyName", Sunat.peSunat);
                    writer.WriteAttributeString("listName", Sunat.TipoDocumento);
                    writer.WriteAttributeString("listURI", Sunat.catalogos + "01");
                    writer.WriteAttributeString("listID", "0101");
                    writer.WriteString("01");
                }
                writer.WriteEndElement();
                #endregion InvoiceTypeCode

                #region Note

                writer.WriteStartElement("cbc:Note");
                {
                    writer.WriteAttributeString("languageLocaleID", "1000");
                    writer.WriteString(MontoEnLetras);
                }
                writer.WriteEndElement();
                #endregion Note

                #region Note2
                //      writer.WriteStartElement("cbc:Note");
                //      {
                //         writer.WriteAttributeString("languageLocaleID", "1000");
                //        writer.WriteString(NroPedido);
                //    }
                //     writer.WriteEndElement();
                #endregion Note2

                #region DocumentCurrencyCode

                writer.WriteStartElement("cbc:DocumentCurrencyCode");
                {
                    writer.WriteAttributeString("listID", Sunat.iso4217);
                    writer.WriteAttributeString("listName", Sunat.currenty);
                    writer.WriteAttributeString("listAgencyName", Sunat.unece);
                    writer.WriteString("PEN");
                }
                writer.WriteEndElement();
                #endregion DocumentCurrencyCode

                writer.WriteElementString("cbc:LineCountNumeric", Convert.ToString(TotItem));

                #endregion UBLVersion

                #region OrderReference

                if (!string.IsNullOrEmpty(OrderReference))
                {
                    writer.WriteStartElement("cac:OrderReference");
                    {
                        writer.WriteElementString("cbc:ID", OrderReference);
                    }
                    writer.WriteEndElement();
                }
                #endregion OrderReference

                #region Signature

                writer.WriteStartElement("cac:Signature");
                {
                    writer.WriteElementString("cbc:ID", "IDSignSP");

                    #region SignatoryParty

                    writer.WriteStartElement("cac:SignatoryParty"); ;
                    {
                        writer.WriteStartElement("cac:PartyIdentification");
                        {
                            writer.WriteElementString("cbc:ID", Signature.SignatoryParty.PartyIdentification.Id.Value);
                        }
                        writer.WriteEndElement();

                        writer.WriteStartElement("cac:PartyName");
                        {
                            writer.WriteElementString("cbc:Name", Signature.SignatoryParty.PartyName.Name);
                        }
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                    #endregion SignatoryParty

                    #region DigitalSignatureAttachment
                    writer.WriteStartElement("cac:DigitalSignatureAttachment");
                    {
                        writer.WriteStartElement("cac:ExternalReference");
                        {
                            writer.WriteElementString("cbc:URI", "#SignatureSP");
                        }
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                    #endregion DigitalSignatureAttachment

                }
                writer.WriteEndElement();
                #endregion Signature

                #region AccountingSupplierParty

                writer.WriteStartElement("cac:AccountingSupplierParty");
                {
                    #region Party

                    writer.WriteStartElement("cac:Party");
                    {
                        #region PartyIdentification

                        writer.WriteStartElement("cac:PartyIdentification");
                        {
                            #region ID

                            writer.WriteStartElement("cbc:ID");
                            {
                                writer.WriteAttributeString("schemeID", "6");
                                writer.WriteAttributeString("schemeName", Sunat.documentoIdentidad);
                                writer.WriteAttributeString("schemeAgencyName", Sunat.peSunat);
                                writer.WriteAttributeString("schemeURI", Sunat.catalogos + "06");
                                writer.WriteString(Signature.SignatoryParty.PartyIdentification.Id.Value);
                            }
                            writer.WriteEndElement();
                            #endregion ID
                        }
                        writer.WriteEndElement();
                        #endregion PartyIdentification

                        #region PartyLegalEntity

                        writer.WriteStartElement("cac:PartyLegalEntity");
                        {
                            writer.WriteElementString("cbc:RegistrationName", Signature.SignatoryParty.PartyName.Name);
                            writer.WriteStartElement("cac:RegistrationAddress");
                            {
                                writer.WriteElementString("cbc:AddressTypeCode", AnexoSunat);
                                //    {
                                //        writer.WriteAttributeString ("schemeAgencyName", Sunat.peSunat);
                                //        writer.WriteAttributeString("schemeName", "Establecimientos anexos");
                                //        writer.WriteString(AnexoSunat);
                                //    }
                                //    writer.WriteEndElement();
                            }
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();


                        #endregion PartyLegalEntity

                    }
                    writer.WriteEndElement();
                    #endregion Party

                }
                writer.WriteEndElement();
                #endregion AccountingSupplierParty

                #endregion pagina2

                // pagina 3

                #region pagina3

                #region AccountingCustomerParty

                writer.WriteStartElement("cac:AccountingCustomerParty");
                {
                    #region Party

                    writer.WriteStartElement("cac:Party");
                    {
                        #region PartyIdentification

                        writer.WriteStartElement("cac:PartyIdentification");
                        {
                            #region ID
                            writer.WriteStartElement("cbc:ID");
                            {
                                writer.WriteAttributeString("schemeID", "6");
                                writer.WriteAttributeString("schemeName", Sunat.documentoIdentidad);
                                writer.WriteAttributeString("schemeAgencyName", Sunat.peSunat);
                                writer.WriteAttributeString("schemeURI", Sunat.catalogos + "06");
                                writer.WriteString(AccountingCustomerParty.CustomerAssignedAccountId);
                            }
                            writer.WriteEndElement();
                            #endregion ID
                        }
                        writer.WriteEndElement();
                        #endregion PartyIdentification

                        #region PartyLegalEntity

                        writer.WriteStartElement("cac:PartyLegalEntity");
                        {
                            writer.WriteElementString("cbc:RegistrationName", AccountingCustomerParty.Party.PartyLegalEntity.RegistrationName);
                        }
                        writer.WriteEndElement();

                        #endregion PartyLegalEntity

                    }
                    writer.WriteEndElement();
                    #endregion Party

                }
                writer.WriteEndElement();
                #endregion AccountingCustomerParty

                if (DescuentoGlobal > 0)
                {
                    writer.WriteStartElement("cac:AllowanceCharge");
                    {
                        writer.WriteElementString("cbc:ChargeIndicator", "False");
                        writer.WriteElementString("cbc:AllowanceChargeReasonCode", "00");
                        writer.WriteElementString("cbc:MultiplierFactorNumeric", "0");
                        writer.WriteStartElement("cbc:Amount");
                        writer.WriteAttributeString("currencyID", "PEN");
                        writer.WriteString(Convert.ToString(DescuentoGlobal));
                    }
                    writer.WriteEndElement();
                }

                #region TaxTotal

                int vprimeravez = 0;
                writer.WriteStartElement("cac:TaxTotal");
                {
                    foreach (var taxTotal in TaxTotals)
                    {
                        #region TaxAmount

                        if (vprimeravez == 0)
                        {
                            writer.WriteStartElement("cbc:TaxAmount");
                            {
                                writer.WriteAttributeString("currencyID", taxTotal.Moneda);
                                writer.WriteString(taxTotal.TaxAmount.Value.ToString(Formatos.FormatoNumerico, Formato));
                            }
                            writer.WriteEndElement();
                            vprimeravez = 1;
                        }

                        #endregion TaxAmount

                        #region TaxSubtotal

                        if (taxTotal.TaxableAmount.Value > 0)
                        {
                            writer.WriteStartElement("cac:TaxSubtotal");
                            {
                                #region TaxableAmount

                                writer.WriteStartElement("cbc:TaxableAmount");
                                {
                                    writer.WriteAttributeString("currencyID", taxTotal.Moneda);
                                    writer.WriteString(taxTotal.TaxableAmount.Value.ToString(Formatos.FormatoNumerico, Formato));
                                }
                                writer.WriteEndElement();
                                #endregion TaxableAmount

                                #region TaxAmount

                                writer.WriteStartElement("cbc:TaxAmount");
                                {
                                    writer.WriteAttributeString("currencyID", taxTotal.Moneda);
                                    writer.WriteString(taxTotal.TaxAmount.Value.ToString(Formatos.FormatoNumerico, Formato));

                                }
                                writer.WriteEndElement();
                                #endregion TaxAmount

                                #region TaxCategory

                                writer.WriteStartElement("cac:TaxCategory");
                                {

                                    #region ID

                                    writer.WriteStartElement("cbc:ID");
                                    {
                                        writer.WriteAttributeString("schemeID", Sunat.iso5305);
                                        writer.WriteAttributeString("schemeName", Sunat.taxCategory);
                                        writer.WriteAttributeString("schemeAgencyName", Sunat.unece);
                                        writer.WriteString(taxTotal.TaxableAmount.CurrencyId);

                                    }
                                    writer.WriteEndElement();
                                    #endregion ID

                                    #region TaxScheme

                                    writer.WriteStartElement("cac:TaxScheme");
                                    {
                                        writer.WriteStartElement("cbc:ID");
                                        {
                                            writer.WriteAttributeString("schemeID", Sunat.iso5153);
                                            writer.WriteAttributeString("schemeAgencyID", "6");
                                            writer.WriteString(taxTotal.TaxSubtotal.TaxCategory.TaxScheme.Id);
                                        }
                                        writer.WriteEndElement();

                                        writer.WriteElementString("cbc:Name", taxTotal.TaxSubtotal.TaxCategory.TaxScheme.Name);
                                        writer.WriteElementString("cbc:TaxTypeCode", taxTotal.TaxSubtotal.TaxCategory.TaxScheme.TaxTypeCode);
                                    }
                                    writer.WriteEndElement();
                                    #endregion TaxScheme
                                }
                                writer.WriteEndElement();
                                #endregion TaxCategory
                            }
                            writer.WriteEndElement();

                        }

                        #endregion TaxSubtotal

                    }
                }
                writer.WriteEndElement();
                #endregion TaxTotal


                #endregion pagina3

                // pagina 4

                #region pagina4

                #region LegalMonetaryTotal

                writer.WriteStartElement("cac:LegalMonetaryTotal");
                {

                    //   if (LegalMonetaryTotal.LineExtensionAmount.Value > 0)
                    //     {
                    //   writer.WriteStartElement("cbc:LineExtensionAmount");
                    //   {
                    //       writer.WriteAttributeString("currencyID", LegalMonetaryTotal.Moneda );
                    //        writer.WriteValue(LegalMonetaryTotal.LineExtensionAmount.Value.ToString(Formatos.FormatoNumerico, Formato));
                    //     }
                    //       writer.WriteEndElement();
                    //  }
                    if (LegalMonetaryTotal.TaxInclusiveAmount.Value > 0)
                    {
                        writer.WriteStartElement("cbc:TaxInclusiveAmount");
                        {
                            writer.WriteAttributeString("currencyID", LegalMonetaryTotal.Moneda);
                            writer.WriteValue(LegalMonetaryTotal.TaxInclusiveAmount.Value.ToString(Formatos.FormatoNumerico, Formato));
                        }
                        writer.WriteEndElement();
                    }
                    if (LegalMonetaryTotal.AllowanceTotalAmount.Value > 0)
                    {
                        writer.WriteStartElement("cbc:AllowanceTotalAmount");
                        {
                            writer.WriteAttributeString("currencyID", LegalMonetaryTotal.Moneda);
                            writer.WriteValue(LegalMonetaryTotal.AllowanceTotalAmount.Value.ToString(Formatos.FormatoNumerico, Formato));
                        }
                        writer.WriteEndElement();
                    }
                    if (LegalMonetaryTotal.ChargeTotalAmount.Value > 0)
                    {
                        writer.WriteStartElement("cbc:ChargeTotalAmount");
                        {
                            writer.WriteAttributeString("currencyID", LegalMonetaryTotal.Moneda);
                            writer.WriteValue(LegalMonetaryTotal.ChargeTotalAmount.Value.ToString(Formatos.FormatoNumerico, Formato));
                        }
                        writer.WriteEndElement();
                    }
                    if (LegalMonetaryTotal.PayableAmount.Value > 0)
                    {
                        writer.WriteStartElement("cbc:PayableAmount");
                        {
                            writer.WriteAttributeString("currencyID", LegalMonetaryTotal.Moneda);
                            writer.WriteValue(LegalMonetaryTotal.PayableAmount.Value.ToString(Formatos.FormatoNumerico, Formato));
                        }
                        writer.WriteEndElement();
                    }

                }
                writer.WriteEndElement();
                #endregion LegalMonetaryTotal

                foreach (var invoiceLine in InvoiceLines)
                {
                    #region InvoiceLines

                    writer.WriteStartElement("cac:InvoiceLine");
                    {
                        writer.WriteElementString("cbc:ID", invoiceLine.Id.ToString());

                        #region InvoicedQuantity

                        writer.WriteStartElement("cbc:InvoicedQuantity");
                        {
                            writer.WriteAttributeString("unitCode", invoiceLine.InvoicedQuantity.UnitCode);
                            writer.WriteAttributeString("unitCodeListID", Sunat.iso20);
                            writer.WriteAttributeString("unitCodeListAgencyName", Sunat.unece);
                            writer.WriteString(invoiceLine.InvoicedQuantity.Value.ToString(Formatos.FormatoNumerico, Formato));
                        }
                        writer.WriteEndElement();
                        #endregion InvoicedQuantity

                        #region LineExtensionAmount

                        writer.WriteStartElement("cbc:LineExtensionAmount");
                        {
                            writer.WriteAttributeString("currencyID", invoiceLine.LineExtensionAmount.CurrencyId);
                            writer.WriteString(invoiceLine.LineExtensionAmount.Value.ToString(Formatos.FormatoNumerico, Formato));
                        }
                        writer.WriteEndElement();

                        #endregion LineExtensionAmount

                        #region PricingReference

                        writer.WriteStartElement("cac:PricingReference");
                        {
                            #region AlternativeConditionPrice

                            foreach (var item in invoiceLine.PricingReference.AlternativeConditionPrices)
                            {
                                writer.WriteStartElement("cac:AlternativeConditionPrice");
                                {
                                    #region PriceAmount

                                    writer.WriteStartElement("cbc:PriceAmount");
                                    {
                                        writer.WriteAttributeString("currencyID", item.PriceAmount.CurrencyId);
                                        writer.WriteString(item.PriceAmount.Value.ToString(Formatos.FormatoNumerico, Formato));
                                    }
                                    writer.WriteEndElement();
                                    #endregion PriceAmount

                                    #region PriceTypeCode

                                    writer.WriteStartElement("cbc:PriceTypeCode");
                                    {
                                        writer.WriteAttributeString("listName", Sunat.tipoPrecio);
                                        writer.WriteAttributeString("listAgencyName", Sunat.peSunat);
                                        writer.WriteAttributeString("listURI", Sunat.catalogos + "16");
                                        writer.WriteString(item.PriceTypeCode);
                                    }
                                    writer.WriteEndElement();
                                    #endregion PriceTypeCode
                                }
                                writer.WriteEndElement();
                            }
                            #endregion AlternativeConditionPrice

                        }
                        writer.WriteEndElement();
                        #endregion PricingReference

                        #region AllowanceCharge

                        if (invoiceLine.AllowanceCharge.Amount.Value > 0)
                        {
                            writer.WriteStartElement("cac:AllowanceCharge");
                            {
                                writer.WriteElementString("cbc:ChargeIndicator", invoiceLine.AllowanceCharge.ChargeIndicator.ToString().ToLower());
                                {
                                    #region Amount

                                    writer.WriteStartElement("cbc:Amount");
                                    {
                                        writer.WriteAttributeString("currencyID", invoiceLine.AllowanceCharge.Amount.CurrencyId);
                                        writer.WriteValue(invoiceLine.AllowanceCharge.Amount.Value.ToString(Formatos.FormatoNumerico, Formato));
                                    }
                                    writer.WriteEndElement();
                                    #endregion Amount
                                }
                                writer.WriteEndElement();
                            }
                            writer.WriteEndElement();
                        }
                        #endregion AllowanceCharge

                        // hasta aqui Ok 

                        #region TaxTotal

                        foreach (var taxTotal in invoiceLine.TaxTotals)
                        {
                            writer.WriteStartElement("cac:TaxTotal");
                            {
                                #region TaxAmount 

                                writer.WriteStartElement("cbc:TaxAmount");
                                {
                                    writer.WriteAttributeString("currencyID", taxTotal.TaxAmount.CurrencyId);
                                    writer.WriteString(taxTotal.TaxAmount.Value.ToString(Formatos.FormatoNumerico, Formato));
                                }
                                writer.WriteEndElement();
                                #endregion TaxAmount

                                #region TaxSubtotal

                                writer.WriteStartElement("cac:TaxSubtotal");
                                {
                                    #region TaxableAmount

                                    if (!string.IsNullOrEmpty(taxTotal.TaxableAmount.CurrencyId))
                                    {
                                        writer.WriteStartElement("cbc:TaxableAmount");
                                        {
                                            writer.WriteAttributeString("currencyID", taxTotal.TaxableAmount.CurrencyId);
                                            writer.WriteString(taxTotal.TaxableAmount.Value.ToString(Formatos.FormatoNumerico, Formato));
                                        }
                                        writer.WriteEndElement();
                                    }

                                    #endregion TaxableAmount

                                    #region TaxAmount

                                    writer.WriteStartElement("cbc:TaxAmount");
                                    {
                                        writer.WriteAttributeString("currencyID", taxTotal.TaxSubtotal.TaxAmount.CurrencyId);
                                        writer.WriteString(taxTotal.TaxAmount.Value.ToString(Formatos.FormatoNumerico, Formato));
                                    }
                                    writer.WriteEndElement();
                                    #endregion TaxAmount 

                                    #region TaxCategory

                                    writer.WriteStartElement("cac:TaxCategory");
                                    {

                                        #region ID

                                        writer.WriteStartElement("cbc:ID");
                                        {
                                            writer.WriteAttributeString("schemeID", Sunat.iso5305);
                                            writer.WriteAttributeString("schemeName", Sunat.taxCategory);
                                            writer.WriteAttributeString("schemeAgencyName", Sunat.unece);
                                            writer.WriteString("S");
                                        }
                                        writer.WriteEndElement();
                                        #endregion ID

                                        writer.WriteElementString("cbc:Percent", (taxTotal.TaxSubtotal.Percent.ToString(Formatos.FormatoNumerico, Formato)));

                                        #region TaxExemptionReasonCode

                                        writer.WriteStartElement("cbc:TaxExemptionReasonCode");
                                        {
                                            writer.WriteAttributeString("listAgencyName", Sunat.peSunat);
                                            writer.WriteAttributeString("listName", Sunat.AfectacionIgv);
                                            writer.WriteAttributeString("listURI", Sunat.catalogos + "07");
                                            writer.WriteString(taxTotal.TaxSubtotal.TaxCategory.TaxExemptionReasonCode);
                                        }
                                        writer.WriteEndElement();
                                        #endregion TaxExemptionReasonCode

                                        #region TaxScheme

                                        writer.WriteStartElement("cac:TaxScheme");
                                        {
                                            #region ID

                                            writer.WriteStartElement("cbc:ID");
                                            {
                                                writer.WriteAttributeString("schemeID", Sunat.iso5153);
                                                writer.WriteAttributeString("schemeName", Sunat.TaxIdentifier);
                                                writer.WriteAttributeString("schemeAgencyName", Sunat.unece);
                                                writer.WriteString(taxTotal.TaxSubtotal.TaxCategory.TaxScheme.Id);

                                            }
                                            writer.WriteEndElement();
                                            #endregion ID

                                            writer.WriteElementString("cbc:Name", taxTotal.TaxSubtotal.TaxCategory.TaxScheme.Name);
                                            writer.WriteElementString("cbc:TaxTypeCode", taxTotal.TaxSubtotal.TaxCategory.TaxScheme.TaxTypeCode);

                                        }
                                        writer.WriteEndElement();
                                        #endregion TaxScheme

                                    }
                                    writer.WriteEndElement();
                                    #endregion TaxCategory

                                }
                                writer.WriteEndElement();
                                #endregion TaxSubtotal

                            }
                            writer.WriteEndElement();
                        }
                        #endregion TaxTotal

                        #region Item

                        writer.WriteStartElement("cac:Item");

                        #region Description

                        writer.WriteElementString("cbc:Description", invoiceLine.Item.Description);
                        //writer.WriteStartElement("cbc:Description");
                        //writer.WriteCData(invoiceLine.Item.Description);
                        //writer.WriteEndElement();

                        #endregion Description

                        #region SellersItemIdentification


                        writer.WriteStartElement("cac:SellersItemIdentification");
                        writer.WriteElementString("cbc:ID", invoiceLine.Item.SellersItemIdentification.Id);
                        writer.WriteEndElement();

                        #endregion SellersItemIdentification

                        #region AdditionalInformation
                        if (!string.IsNullOrEmpty(invoiceLine.Item.AdditionalItemIdentification.Id))
                        {
                            writer.WriteStartElement("cac:AdditionalItemIdentification");
                            writer.WriteElementString("cbc:ID", invoiceLine.Item.AdditionalItemIdentification.Id);
                            writer.WriteEndElement();
                        }

                        #endregion AdditionalInformation

                        writer.WriteEndElement();

                        #endregion Item

                        #region Price

                        writer.WriteStartElement("cac:Price");
                        {
                            writer.WriteStartElement("cbc:PriceAmount");
                            {
                                writer.WriteAttributeString("currencyID", invoiceLine.Price.PriceAmount.CurrencyId);
                                writer.WriteString(invoiceLine.Price.PriceAmount.Value.ToString(Formatos.FormatoNumerico, Formato));
                            }
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();
                        #endregion Price

                    }
                    writer.WriteEndElement();
                    #endregion InvoiceLines
                }
                #endregion pagina4

            }
        }

        
    }
}