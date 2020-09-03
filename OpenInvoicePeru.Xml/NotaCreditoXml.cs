using System;
using System.Collections.Generic;
using OpenInvoicePeru.Comun;
using OpenInvoicePeru.Comun.Dto.Contratos;
using OpenInvoicePeru.Comun.Dto.Modelos;
using OpenInvoicePeru.Estructuras.CommonAggregateComponents;
using OpenInvoicePeru.Estructuras.CommonBasicComponents;
using OpenInvoicePeru.Estructuras.CommonExtensionComponents;
using OpenInvoicePeru.Estructuras.EstandarUbl;
using OpenInvoicePeru.Estructuras.SunatAggregateComponents;
using System.Linq;
using System.Windows.Forms;

namespace OpenInvoicePeru.Xml
{
    public class NotaCreditoXml : IDocumentoXml
    {
        IEstructuraXml IDocumentoXml.Generar(IDocumentoElectronico request)
        {
            try
            {
                var documento = (DocumentoElectronico)request;
                documento.MontoEnLetras = documento.MontoEnLetras;
                var creditNote = new CreditNote
                {

                    Id = documento.IdDocumento,
                    IssueDate = DateTime.Parse(documento.FechaEmision),
                    IssueHora = DateTime.Parse(documento.FechaRegistro),
                    MontoEnLetras = documento.MontoEnLetras,
                    NroPedido = documento.NroPedido,
                    InvoiceTypeCode = documento.TipoDocumento,
                    DocumentCurrencyCode = documento.Moneda,
                    DescuentoGlobal = documento.DescuentoGlobal,
                    AnexoSunat = documento.AnexoSunat,
                    TotItem = documento.TotItem,
                    Signature = new SignatureCac
                    {
                        Id = documento.IdDocumento,
                        SignatoryParty = new SignatoryParty
                        {
                            PartyIdentification = new PartyIdentification
                            {
                                Id = new PartyIdentificationId
                                {
                                    Value = documento.Emisor.NroDocumento
                                }
                            },
                            PartyName = new PartyName
                            {
                                Name = documento.Emisor.NombreLegal
                            }
                        },
                        DigitalSignatureAttachment = new DigitalSignatureAttachment
                        {
                            ExternalReference = new ExternalReference
                            {
                                Uri = $"{documento.Emisor.NroDocumento}-{documento.IdDocumento}"
                            }
                        }
                    },
                    AccountingSupplierParty = new AccountingSupplierParty
                    {
                        CustomerAssignedAccountId = documento.Emisor.NroDocumento,
                        AdditionalAccountId = documento.Emisor.TipoDocumento,
                        Party = new Party
                        {
                            PartyName = new PartyName
                            {
                                Name = documento.Emisor.NombreComercial
                            },
                            PostalAddress = new PostalAddress
                            {
                                Id = documento.Emisor.Ubigeo,
                                StreetName = documento.Emisor.Direccion,
                                CitySubdivisionName = documento.Emisor.Urbanizacion,
                                CountrySubentity = documento.Emisor.Departamento,
                                CityName = documento.Emisor.Provincia,
                                District = documento.Emisor.Distrito,
                                Country = new Country { IdentificationCode = "PE" }
                            },
                            PartyLegalEntity = new PartyLegalEntity
                            {
                                RegistrationName = documento.Emisor.NombreLegal
                            }
                        }
                    },
                    AccountingCustomerParty = new AccountingSupplierParty
                    {
                        CustomerAssignedAccountId = documento.Receptor.NroDocumento,
                        AdditionalAccountId = documento.Receptor.TipoDocumento,
                        Party = new Party
                        {
                            PartyName = new PartyName
                            {
                                Name = documento.Receptor.NombreComercial ?? string.Empty
                            },
                            PartyLegalEntity = new PartyLegalEntity
                            {
                                RegistrationName = documento.Receptor.NombreLegal
                            }
                        }
                    },
                    UblVersionId = "2.1",
                    CustomizationId = "2.0",
                    LegalMonetaryTotal = new LegalMonetaryTotal
                    {
                        Moneda = documento.Moneda,
                        LineExtensionAmount = new PayableAmount
                        {
                            CurrencyId = documento.Moneda,
                            Value = documento.TotalGravadas + documento.TotalExoneradas + documento.TotalInafectas + documento.TotalGratuitas
                        },
                        TaxInclusiveAmount = new PayableAmount
                        {
                            CurrencyId = documento.Moneda,
                            Value = documento.TotalVenta
                        },
                        AllowanceTotalAmount = new PayableAmount
                        {
                            CurrencyId = documento.Moneda,
                            Value = documento.DescuentoGlobal
                        },
                        ChargeTotalAmount = new PayableAmount
                        {
                            CurrencyId = documento.Moneda,
                            Value = documento.TotalOtrosTributos
                        },
                        PayableAmount = new PayableAmount
                        {
                            CurrencyId = documento.Moneda,
                            Value = documento.TotalVenta - documento.DescuentoGlobal + documento.TotalOtrosTributos
                        },
                    },


                    // datos de cabecera documento 

                    TaxTotals = new List<TaxTotal>
                    {
                        #region TotalGravadas

                        new TaxTotal
                        {
                            Moneda = documento.Moneda,
                            TaxableAmount = new PayableAmount
                            {
                                CurrencyId = "S",
                                Value = documento.TotalGravadas
                            },
                            TaxAmount = new PayableAmount
                            {
                                CurrencyId = "IGV",
                                Value = documento.TotalIgv
                            },
                            TaxSubtotal = new TaxSubtotal
                            {
                                Percent = documento.PorcentajeIgv,
                                TaxAmount = new PayableAmount
                                {
                                    CurrencyId = "IGV",
                                    Value = documento.TotalIgv,
                                },
                                TaxCategory = new TaxCategory
                                {
                                    TaxExemptionReasonCode = "10",
                                    TaxScheme = new TaxScheme
                                    {
                                        Id = "1000",
                                        Name = "IGV",
                                        TaxTypeCode = "VAT"
                                    }
                                }
                            }
                        }
                        #endregion TotalGravadas

                    }
            };
            if (!string.IsNullOrEmpty(documento.NroOrdenCompra))
                {
                    creditNote.OrderReference = documento.NroOrdenCompra;
                }

                if (documento.TotalIsc > 0)
                {
                    creditNote.TaxTotals.Add(new TaxTotal
                    {
                        Moneda = documento.Moneda,
                        TaxAmount = new PayableAmount
                        {
                            CurrencyId = documento.Moneda,
                            Value = documento.TotalIsc,
                        },
                        TaxSubtotal = new TaxSubtotal
                        {
                            TaxAmount = new PayableAmount
                            {
                                CurrencyId = documento.Moneda,
                                Value = documento.TotalIsc
                            },
                            TaxCategory = new TaxCategory
                            {
                                TaxScheme = new TaxScheme
                                {
                                    Id = "2000",
                                    Name = "ISC",
                                    TaxTypeCode = "EXC"
                                }
                            }
                        }
                    });
                }
                if (documento.TotalInafectas > 0)
                {

                    creditNote.TaxTotals.Add(new TaxTotal
                    {
                        Moneda = documento.Moneda,
                        TaxableAmount = new PayableAmount
                        {
                            CurrencyId = "O",
                            Value = documento.TotalInafectas
                        },
                        TaxAmount = new PayableAmount
                        {
                            CurrencyId = documento.Moneda,
                            Value = 0,
                        },
                        TaxSubtotal = new TaxSubtotal
                        {
                            TaxAmount = new PayableAmount
                            {
                                CurrencyId = documento.Moneda,
                                Value = documento.TotalInafectas
                            },
                            TaxCategory = new TaxCategory
                            {
                                TaxScheme = new TaxScheme
                                {
                                    Id = "9998",
                                    Name = "INA",
                                    TaxTypeCode = "FRE"
                                }
                            }
                        }
                    });
                }
                if (documento.TotalExoneradas > 0)
                {
                    creditNote.TaxTotals.Add(new TaxTotal
                    {
                        Moneda = documento.Moneda,
                        TaxableAmount = new PayableAmount
                        {
                            CurrencyId = "E",
                            Value = documento.TotalExoneradas
                        },
                        TaxAmount = new PayableAmount
                        {
                            CurrencyId = documento.Moneda,
                            Value = 0,
                        },
                        TaxSubtotal = new TaxSubtotal
                        {
                            TaxAmount = new PayableAmount
                            {
                                CurrencyId = documento.Moneda,
                                Value = documento.TotalExoneradas
                            },
                            TaxCategory = new TaxCategory
                            {
                                TaxScheme = new TaxScheme
                                {
                                    Id = "9997",
                                    Name = "EXO",
                                    TaxTypeCode = "VAT"
                                }
                            }
                        }
                    });
                }
                if (documento.TotalGratuitas > 0)
                {
                    creditNote.TaxTotals.Add(new TaxTotal
                    {
                        Moneda = documento.Moneda,
                        TaxableAmount = new PayableAmount
                        {

                            CurrencyId = "I",
                            Value = documento.TotalGratuitas
                        },
                        TaxAmount = new PayableAmount
                        {
                            CurrencyId = documento.Moneda,
                            Value = 0,
                        },
                        TaxSubtotal = new TaxSubtotal
                        {
                            TaxAmount = new PayableAmount
                            {
                                CurrencyId = documento.Moneda,
                                Value = documento.TotalExoneradas
                            },
                            TaxCategory = new TaxCategory
                            {
                                TaxScheme = new TaxScheme
                                {
                                    Id = "9999",
                                    Name = "GRATUITO",
                                    TaxTypeCode = "OTH"
                                }
                            }
                        }
                    });
                }
                if (documento.TotalOtrosTributos > 0)
                {
                    creditNote.TaxTotals.Add(new TaxTotal
                    {
                        Moneda = documento.Moneda,
                        TaxableAmount = new PayableAmount
                        {
                            CurrencyId = "O",
                            Value = documento.TotalOtrosTributos
                        },
                        TaxAmount = new PayableAmount
                        {
                            CurrencyId = documento.Moneda,
                            Value = documento.TotalOtrosTributos,
                        },
                        TaxSubtotal = new TaxSubtotal
                        {
                            TaxAmount = new PayableAmount
                            {
                                CurrencyId = documento.Moneda,
                                Value = documento.TotalOtrosTributos
                            },
                            TaxCategory = new TaxCategory
                            {
                                TaxScheme = new TaxScheme
                                {
                                    Id = "9999",
                                    Name = "OTROS",
                                    TaxTypeCode = "OTH"
                                }
                            }
                        }
                    });
                }

                {
                    creditNote.UblExtensions.Extension2.ExtensionContent
                            .AdditionalInformation.AdditionalProperties.Add(new AdditionalProperty
                            {
                                Id = "1002",
                                Value = "Articulos gratuitos"
                            });
                }

                /* Numero de Placa del Vehiculo - Gastos art.37� Renta */
                if (!string.IsNullOrEmpty(documento.PlacaVehiculo))
                {
                    creditNote.UblExtensions.Extension2.ExtensionContent
                        .AdditionalInformation.SunatCosts.RoadTransport
                        .LicensePlateId = documento.PlacaVehiculo;
                }

                /* Tipo de Operaci�n - Catalogo N� 17 */
                if (!string.IsNullOrEmpty(documento.TipoOperacion)
                    && documento.DatosGuiaTransportista == null)
                {
                    creditNote.UblExtensions.Extension2.ExtensionContent
                        .AdditionalInformation.SunatTransaction.Id = documento.TipoOperacion;
                    // Si es Emisor Itinerante.
                    if (documento.TipoOperacion == "05")
                    {
                        creditNote.UblExtensions.Extension2.ExtensionContent
                            .AdditionalInformation.AdditionalProperties.Add(new AdditionalProperty
                            {
                                Id = "3000", // En el catalogo aparece como 2005 pero es 3000
                                Value = "Venta realizada por emisor itinerante"
                            });
                    }
                }

                foreach (var relacionado in documento.Relacionados)
                {
                    creditNote.DespatchDocumentReferences.Add(new InvoiceDocumentReference
                    {
                        DocumentTypeCode = relacionado.TipoDocumento,
                        Id = relacionado.NroDocumento
                    });
                }

                foreach (var relacionado in documento.OtrosDocumentosRelacionados)
                {
                    creditNote.AdditionalDocumentReferences.Add(new InvoiceDocumentReference
                    {
                        DocumentTypeCode = relacionado.TipoDocumento,
                        Id = relacionado.NroDocumento
                    });
                }

                var dctosPorItem = documento.Items.Sum(d => d.Descuento);
                if (documento.DescuentoGlobal > 0 || dctosPorItem > 0)
                {
                    creditNote.UblExtensions.Extension2.ExtensionContent
                        .AdditionalInformation.AdditionalMonetaryTotals.Add(new AdditionalMonetaryTotal
                        {
                            Id = "2005",
                            PayableAmount = new PayableAmount
                            {
                                CurrencyId = documento.Moneda,
                                Value = documento.DescuentoGlobal + dctosPorItem
                            }
                        });
                }
                if (documento.MontoPercepcion > 0)
                {
                    creditNote.UblExtensions.Extension2.ExtensionContent
                        .AdditionalInformation.AdditionalMonetaryTotals.Add(new AdditionalMonetaryTotal
                        {
                            Id = "2001",
                            ReferenceAmount = new PayableAmount
                            {
                                CurrencyId = documento.Moneda,
                                Value = documento.TotalVenta
                            },
                            PayableAmount = new PayableAmount
                            {
                                CurrencyId = documento.Moneda,
                                Value = documento.MontoPercepcion
                            },
                            TotalAmount = new PayableAmount
                            {
                                CurrencyId = documento.Moneda,
                                Value = documento.TotalVenta + documento.MontoPercepcion
                            }
                        });
                }
                if (documento.MontoAnticipo > 0)
                {
                    creditNote.PrepaidPayment = new BillingPayment
                    {
                        Id = new PartyIdentificationId
                        {
                            SchemeId = documento.TipoDocAnticipo,
                            Value = documento.DocAnticipo
                        },
                        PaidAmount = new PayableAmount
                        {
                            CurrencyId = documento.MonedaAnticipo,
                            Value = documento.MontoAnticipo
                        },
                        InstructionId = documento.Emisor.NroDocumento
                    };
                    creditNote.LegalMonetaryTotal.PrepaidAmount = new PayableAmount
                    {
                        CurrencyId = documento.MonedaAnticipo,
                        Value = documento.MontoAnticipo
                    };
                }

                // Datos Adicionales a la Factura.
                foreach (var adicional in documento.DatoAdicionales)
                {
                    creditNote.UblExtensions.Extension2.ExtensionContent
                        .AdditionalInformation.AdditionalProperties.Add(new AdditionalProperty
                        {
                            Id = adicional.Codigo,
                            Value = adicional.Contenido
                        });
                }

                if (documento.MontoDetraccion > 0)
                {
                    creditNote.UblExtensions.Extension2.ExtensionContent
                        .AdditionalInformation.AdditionalMonetaryTotals.Add(new AdditionalMonetaryTotal
                        {
                            Id = "2003",
                            PayableAmount = new PayableAmount
                            {
                                CurrencyId = documento.Moneda,
                                Value = documento.MontoDetraccion
                            },
                            Percent = documento.CalculoDetraccion * 100
                        });
                }

                // Para datos de Guia de Remision Transportista.
                if (!string.IsNullOrEmpty(documento.DatosGuiaTransportista?.RucTransportista))
                {
                    creditNote.UblExtensions.Extension2.ExtensionContent
                        .AdditionalInformation.SunatEmbededDespatchAdvice = new SunatEmbededDespatchAdvice
                        {
                            DeliveryAddress = new PostalAddress
                            {
                                Id = documento.DatosGuiaTransportista.DireccionDestino.Ubigeo,
                                StreetName = documento.DatosGuiaTransportista.DireccionDestino.Direccion,
                                CitySubdivisionName = documento.DatosGuiaTransportista.DireccionDestino.Urbanizacion,
                                CityName = documento.DatosGuiaTransportista.DireccionDestino.Departamento,
                                CountrySubentity = documento.DatosGuiaTransportista.DireccionDestino.Provincia,
                                District = documento.DatosGuiaTransportista.DireccionDestino.Distrito,
                                Country = new Country
                                {
                                    IdentificationCode = "PE"
                                }
                            },
                            OriginAddress = new PostalAddress
                            {
                                Id = documento.DatosGuiaTransportista.DireccionOrigen.Ubigeo,
                                StreetName = documento.DatosGuiaTransportista.DireccionOrigen.Direccion,
                                CitySubdivisionName = documento.DatosGuiaTransportista.DireccionOrigen.Urbanizacion,
                                CityName = documento.DatosGuiaTransportista.DireccionOrigen.Departamento,
                                CountrySubentity = documento.DatosGuiaTransportista.DireccionOrigen.Provincia,
                                District = documento.DatosGuiaTransportista.DireccionOrigen.Distrito,
                                Country = new Country
                                {
                                    IdentificationCode = "PE"
                                }
                            },
                            SunatCarrierParty = new AccountingSupplierParty
                            {
                                CustomerAssignedAccountId = documento.DatosGuiaTransportista.RucTransportista,
                                AdditionalAccountId = "06",
                                Party = new Party
                                {
                                    PartyLegalEntity = new PartyLegalEntity
                                    {
                                        RegistrationName = documento.DatosGuiaTransportista.NombreTransportista
                                    }
                                }
                            },
                            DriverParty = new AgentParty
                            {
                                PartyIdentification = new PartyIdentification
                                {
                                    Id = new PartyIdentificationId
                                    {
                                        Value = documento.DatosGuiaTransportista.NroLicenciaConducir
                                    }
                                }
                            },
                            SunatRoadTransport = new SunatRoadTransport
                            {
                                LicensePlateId = documento.DatosGuiaTransportista.PlacaVehiculo,
                                TransportAuthorizationCode = documento.DatosGuiaTransportista.CodigoAutorizacion,
                                BrandName = documento.DatosGuiaTransportista.MarcaVehiculo
                            },
                            TransportModeCode = documento.DatosGuiaTransportista.ModoTransporte,
                            GrossWeightMeasure = new InvoicedQuantity
                            {
                                UnitCode = documento.DatosGuiaTransportista.UnidadMedida,
                                Value = documento.DatosGuiaTransportista.PesoBruto
                            }
                        };
                }

                foreach (var detalleDocumento in documento.Items)
                {
                    var linea = new InvoiceLine
                    {
                        Id = detalleDocumento.Id,
                        InvoicedQuantity = new InvoicedQuantity
                        {
                            UnitCode = detalleDocumento.UnidadMedida,
                            Value = detalleDocumento.Cantidad
                        },
                        LineExtensionAmount = new PayableAmount
                        {
                            CurrencyId = documento.Moneda,
                            Value = detalleDocumento.ItemVenta
                        },
                        PricingReference = new PricingReference
                        {
                            AlternativeConditionPrices = new List<AlternativeConditionPrice>()
                        },
                        Item = new Item
                        {
                            Description = detalleDocumento.Descripcion,
                            SellersItemIdentification = new SellersItemIdentification
                            {
                                Id = detalleDocumento.CodigoItem
                            },
                            AdditionalItemIdentification = new AdditionalItemIdentification
                            {
                                Id = detalleDocumento.PlacaVehiculo
                            }
                        },
                        Price = new Price
                        {
                            PriceAmount = new PayableAmount
                            {
                                CurrencyId = documento.Moneda,
                                Value = detalleDocumento.PrecioUnitario
                            }
                        },
                    };

                    /* 16 - Afectaci�n al IGV por �tem */
                    linea.TaxTotals.Add(new TaxTotal
                    {
                        TaxableAmount = new PayableAmount
                        {
                            CurrencyId = documento.Moneda,
                            Value = detalleDocumento.ItemGravado,
                        },
                        TaxAmount = new PayableAmount
                        {
                            CurrencyId = documento.Moneda,
                            Value = detalleDocumento.Impuesto
                        },
                        TaxSubtotal = new TaxSubtotal
                        {

                            TaxAmount = new PayableAmount
                            {
                                CurrencyId = documento.Moneda,
                                Value = detalleDocumento.Impuesto
                            },
                            TaxCategory = new TaxCategory
                            {
                                TaxExemptionReasonCode = detalleDocumento.TipoImpuesto,
                                TaxScheme = new TaxScheme()
                                {
                                    Id= detalleDocumento.AfectacionIgv.Id,
                                    Codigo = detalleDocumento.AfectacionIgv.Codigo,
                                    Name = detalleDocumento.AfectacionIgv.Nombre,
                                    TaxTypeCode = detalleDocumento.AfectacionIgv.Nemotecnico
                                }
                            }
                        }
                    });

                    /* 17 - Sistema de ISC por �tem */
                    if (detalleDocumento.ImpuestoSelectivo > 0)
                        linea.TaxTotals.Add(new TaxTotal
                        {
                            TaxAmount = new PayableAmount
                            {
                                CurrencyId = documento.Moneda,
                                Value = detalleDocumento.ImpuestoSelectivo
                            },
                            TaxSubtotal = new TaxSubtotal
                            {
                                TaxAmount = new PayableAmount
                                {
                                    CurrencyId = documento.Moneda,
                                    Value = detalleDocumento.ImpuestoSelectivo
                                },
                                TaxCategory = new TaxCategory
                                {
                                    TaxExemptionReasonCode = detalleDocumento.TipoImpuesto,
                                    TierRange = "01",
                                    TaxScheme = new TaxScheme()
                                    {
                                        Id = "2000",
                                        Name = "ISC",
                                        TaxTypeCode = "EXC"
                                    }
                                }
                            }
                        });

                    linea.PricingReference.AlternativeConditionPrices.Add(new AlternativeConditionPrice
                    {
                        PriceAmount = new PayableAmount
                        {
                            CurrencyId = documento.Moneda,
                            // Comprobamos que sea una operacion gratuita.
                            Value = documento.TotalGratuitas > 0 ? 0 : detalleDocumento.PrecioReferencial
                        },
                        PriceTypeCode = detalleDocumento.TipoPrecio
                    });
                    // Para operaciones no onerosas (gratuitas)
                    if (documento.TotalGratuitas > 0)
                        linea.PricingReference.AlternativeConditionPrices.Add(new AlternativeConditionPrice
                        {
                            PriceAmount = new PayableAmount
                            {
                                CurrencyId = documento.Moneda,
                                Value = detalleDocumento.PrecioReferencial
                            },
                            PriceTypeCode = "02"
                        });

                    /* 51 - Descuentos por �tem */
                    if (detalleDocumento.Descuento > 0)
                    {
                        linea.AllowanceCharge.ChargeIndicator = false;
                        linea.AllowanceCharge.Amount = new PayableAmount
                        {
                            CurrencyId = documento.Moneda,
                            Value = detalleDocumento.Descuento
                        };
                    }

                    creditNote.InvoiceLines.Add(linea);
                }
                return creditNote;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
        }
    }
}