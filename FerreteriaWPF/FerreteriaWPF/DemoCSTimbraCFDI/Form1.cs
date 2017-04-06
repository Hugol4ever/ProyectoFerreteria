using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Profact.TimbraCFDI;
using System.Xml;
using System.Xml.Serialization;

namespace DemoCSTimbraCFDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistraEmisorWebService_Click(object sender, EventArgs e)
        {
            //Este ejemplo utilizaremos los archivos que se encuentran en la carpeta ArchivosPrueba
            //En el ambiente productivo deberemos utilizar los archivos y contraseña originales de nuestro Emisor

            //Inicializamos el conector el parámetro indica el ambiente en el que se utilizará 
            //Fasle = Ambiente de pruebas
            //True = Ambiente de producción
            try
            {
                Conector conector = new Conector(false);

                //Establecemos las credenciales para el permiso de conexión
                //Ambiente de pruebas = mvpNUXmQfK8=
                //Ambiente de producción = Esta será asignado por el proveedor al salir a productivo
                conector.EstableceCredenciales("mvpNUXmQfK8=");

                //Rfc Emisor
                string rfcEmisor = "AAA010101AAA";

                //Ruta del archivo .cer
                string rutaCer = Application.StartupPath + "\\ArchivosPrueba\\aaa010101aaa__csd_01.cer";

                //Ruta del archivo .key
                string rutaKey = Application.StartupPath + "\\ArchivosPrueba\\aaa010101aaa__csd_01.key";

                //Contraseña de la llave privada
                string contrasena = "12345678a";

                //Registramos al Emisor por medio del conector y guardamos resultado
                ResultadoRegistro resultadoRegistro;
                resultadoRegistro = conector.RegistraEmisor(rfcEmisor, rutaCer, rutaKey, contrasena);

                //Verificamos el resultado
                if (resultadoRegistro.Exitoso)
                {
                    //El Emisor fue registrado/actualizado correctamente
                    MessageBox.Show("El Emisor fue registrado/actualizado correctamente");
                }
                else
                {
                    //Ocurrió un error al registrar al Emisor
                    MessageBox.Show(resultadoRegistro.Descripcion);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("error -> " + ex);
            }
        }

        private void btnTimbraCfdiEntidad_Click(object sender, EventArgs e)
        {
            //Este ejemplo está dirigido a aquellos integradores que aún no generan el xml (CFDI)

            //Inicializamos el conector el parámetro indica el ambiente en el que se utilizará 
            //Fasle = Ambiente de pruebas
            //True = Ambiente de producción
            Conector conector = new Conector(false);

            //Establecemos las credenciales para el permiso de conexión
            //Ambiente de pruebas = mvpNUXmQfK8=
            //Ambiente de producción = Esta será asignado por el proveedor al salir a productivo
            conector.EstableceCredenciales("mvpNUXmQfK8=");

            //Creamos un comprobante por medio de la entidad Comprobante
            Comprobante comprobante = new Comprobante();

            //Llenamos datos del comprobante
            comprobante.serie = "F";
            comprobante.folio = "1";
            comprobante.fecha = DateTime.Now;
            comprobante.formaDePago = "Pago en una sola exhibición";
            comprobante.metodoDePago = "Transferencia bancaria";
            comprobante.subTotal = 100;
            comprobante.total = 116;
            //TIPO DE COMPROBANTE 
            //Ingreso: Factura 1, Rec honorarios 4, rec de arrendamiento 5, Rec donativos 7, Nota de cargo 3
            //Egreso: Nota de credito 2
            //Traslado: Carta porte  6
            comprobante.tipoDeComprobante = ComprobanteTipoDeComprobante.ingreso;
            comprobante.LugarExpedicion = "Mexico, Distrito Federal";

            //Llenamos datos del emisor
            comprobante.Emisor = new ComprobanteEmisor();
            comprobante.Emisor.rfc = "AAA010101AAA";
            comprobante.Emisor.nombre = "Empresa de pruebas S.A. de C.V.";

            //Llenamos domicilio fiscal del emisor
            comprobante.Emisor.DomicilioFiscal = new t_UbicacionFiscal();
            comprobante.Emisor.DomicilioFiscal.calle = "Calle pruebas";
            comprobante.Emisor.DomicilioFiscal.noExterior = "1";
            comprobante.Emisor.DomicilioFiscal.noInterior = "A";
            comprobante.Emisor.DomicilioFiscal.colonia = "Colonia pruebas";
            comprobante.Emisor.DomicilioFiscal.municipio = "Municipio pruebas";
            comprobante.Emisor.DomicilioFiscal.estado = "Estado pruebas";
            comprobante.Emisor.DomicilioFiscal.pais = "Mexico";
            comprobante.Emisor.DomicilioFiscal.codigoPostal = "53125";

            //Llenamos regimen fiscal del emisor
            comprobante.Emisor.RegimenFiscal = new ComprobanteEmisorRegimenFiscal[1];
            comprobante.Emisor.RegimenFiscal[0] = new ComprobanteEmisorRegimenFiscal();
            comprobante.Emisor.RegimenFiscal[0].Regimen = "Regimen general de ley personas morales";

            //Llena datos de expedido en (Solo en caso de que el comprobante haya sido expedido en una sucursal y no en la matriz
            comprobante.Emisor.ExpedidoEn = new t_Ubicacion();
            comprobante.Emisor.ExpedidoEn.calle = "Calle expedido en";
            comprobante.Emisor.ExpedidoEn.noExterior = "2";
            comprobante.Emisor.ExpedidoEn.noInterior = "B";
            comprobante.Emisor.ExpedidoEn.colonia = "Colonia expedido en";
            comprobante.Emisor.ExpedidoEn.municipio = "Municipio expedido en";
            comprobante.Emisor.ExpedidoEn.estado = "Estado expedido en";
            comprobante.Emisor.ExpedidoEn.pais = "Mexico";
            comprobante.Emisor.ExpedidoEn.codigoPostal = "53120";

            //Llena datos del receptor
            comprobante.Receptor = new ComprobanteReceptor();
            comprobante.Receptor.rfc = "BBB010101BBB";
            comprobante.Receptor.nombre = "Cliente de prueba S.A. de C.V.";

            //Llena domicilio del receptor
            comprobante.Receptor.Domicilio = new t_Ubicacion();
            comprobante.Receptor.Domicilio.calle = "Calle cliente";
            comprobante.Receptor.Domicilio.noExterior = "3";
            comprobante.Receptor.Domicilio.noInterior = "C";
            comprobante.Receptor.Domicilio.colonia = "Colonia cliente";
            comprobante.Receptor.Domicilio.municipio = "Municipio cliente";
            comprobante.Receptor.Domicilio.estado = "Estado cliente";
            comprobante.Receptor.Domicilio.pais = "México";
            comprobante.Receptor.Domicilio.codigoPostal = "5";

            //Llenamos los conceptos
            comprobante.Conceptos = new ComprobanteConcepto[2];

            //Concepto 1
            comprobante.Conceptos[0] = new ComprobanteConcepto();
            comprobante.Conceptos[0].cantidad = 1;
            comprobante.Conceptos[0].unidad = "PZA";
            comprobante.Conceptos[0].noIdentificacion = "1";
            comprobante.Conceptos[0].descripcion = "Prueba concepto 1";
            comprobante.Conceptos[0].valorUnitario = 50;
            comprobante.Conceptos[0].importe = 50;

            //Concepto 2
            comprobante.Conceptos[1] = new ComprobanteConcepto();
            comprobante.Conceptos[1].cantidad = 1;
            comprobante.Conceptos[1].unidad = "PZA";
            comprobante.Conceptos[1].noIdentificacion = "1";
            comprobante.Conceptos[1].descripcion = "Prueba concepto 2";
            comprobante.Conceptos[1].valorUnitario = 50;
            comprobante.Conceptos[1].importe = 50;

            //Llenamos impuestos
            comprobante.Impuestos = new ComprobanteImpuestos();
            comprobante.Impuestos.Traslados = new ComprobanteImpuestosTraslado[1];
            comprobante.Impuestos.Traslados[0] = new ComprobanteImpuestosTraslado();
            comprobante.Impuestos.Traslados[0].importe = 16;
            comprobante.Impuestos.Traslados[0].impuesto = ComprobanteImpuestosTrasladoImpuesto.IVA;
            comprobante.Impuestos.Traslados[0].tasa = 16;

            List<XmlElement> LXmlComplementos = new List<XmlElement>();

            ImpuestosLocales impLocales = new ImpuestosLocales();
            List<ImpuestosLocalesTrasladosLocales> traslados = new List<ImpuestosLocalesTrasladosLocales>();

            //Agregamos una retención local
            ImpuestosLocalesTrasladosLocales traslado = new ImpuestosLocalesTrasladosLocales();
            traslado.Importe = 12;
            traslado.ImpLocTrasladado = "Impuesto sobre hospedaje";
            traslado.TasadeTraslado = 2;

            traslados.Add(traslado);

            impLocales.TrasladosLocales = traslados.ToArray<ImpuestosLocalesTrasladosLocales>();
            impLocales.version = "1.0";

            //Totales
            impLocales.TotaldeRetenciones = 0;
            impLocales.TotaldeTraslados = 20;

            XmlSerializerNamespaces nsImpLocales = new XmlSerializerNamespaces();
            nsImpLocales.Add("implocal", "http://www.sat.gob.mx/implocal");
            string xmlImpLocales = XMLUtilerias.SerializaObjeto(impLocales, typeof(ImpuestosLocales), nsImpLocales);

            XmlDocument docImpuestosLocales = new XmlDocument();
            docImpuestosLocales.LoadXml(xmlImpLocales);
            comprobante.ImpLocalSpecified = true;
            LXmlComplementos.Add(docImpuestosLocales.DocumentElement);

            comprobante.Complemento = new ComprobanteComplemento();
            comprobante.Complemento.Any = LXmlComplementos.ToArray<XmlElement>();



            ////INICIA EJEMPLO PARA COMPLEMENTO NÓMINA
            ////Descomentar esta sección para utilizar el complemento nómina

            ////Declaramos arreglo de complementos
            //List<XmlElement> LXmlComplementos = new List<XmlElement>();

            ////Lenamos clase Nomina con datos
            //Nomina nomina = new Nomina();
            //nomina.RegistroPatronal = "1234567890";
            //nomina.NumEmpleado = "1";
            //nomina.CURP = "AAAA800101HDFTRN04";
            //nomina.TipoRegimen = 1;
            //nomina.NumSeguridadSocial = "1234567890";
            //nomina.FechaPago = DateTime.Now;
            //nomina.FechaInicialPago = DateTime.Now;
            //nomina.FechaFinalPago = DateTime.Now;
            //nomina.NumDiasPagados = 15;
            //nomina.Departamento = "DESARROLLO";
            //nomina.CLABE = "123456789012345678";
            //nomina.Banco = "001";
            //if (nomina.Banco != null)
            //    nomina.BancoSpecified = true;
            //else
            //    nomina.BancoSpecified = false;
            //nomina.FechaInicioRelLaboral = DateTime.Now;
            //if (nomina.FechaInicioRelLaboral != null)
            //    nomina.FechaInicioRelLaboralSpecified = true;
            //else
            //    nomina.FechaInicioRelLaboralSpecified = false;
            //nomina.Antiguedad = 45;
            //if (nomina.Antiguedad != 0)
            //    nomina.AntiguedadSpecified = true;
            //else
            //    nomina.AntiguedadSpecified = false;
            //nomina.Puesto = "PROGRAMADOR";
            //nomina.TipoContrato = "BASE";
            //nomina.TipoJornada = "DIURNA";
            //nomina.PeriodicidadPago = "QUINCENAL";
            //nomina.SalarioBaseCotApor = 1000;
            //if (nomina.SalarioBaseCotApor != 0)
            //    nomina.SalarioBaseCotAporSpecified = true;
            //else
            //    nomina.SalarioBaseCotAporSpecified = false;
            //nomina.RiesgoPuesto = 1;
            //if (nomina.RiesgoPuesto != 0)
            //    nomina.RiesgoPuestoSpecified = true;
            //else
            //    nomina.RiesgoPuestoSpecified = false;
            //nomina.SalarioDiarioIntegrado = 150;
            //if (nomina.SalarioDiarioIntegrado != 0)
            //    nomina.SalarioDiarioIntegradoSpecified = true;
            //else
            //    nomina.SalarioDiarioIntegradoSpecified = false;

            //nomina.Percepciones = new NominaPercepciones();
            //nomina.Percepciones.Percepcion = new NominaPercepcionesPercepcion[1];
            //nomina.Percepciones.TotalExento = 100;
            //nomina.Percepciones.TotalGravado = 200;

            //nomina.Percepciones.Percepcion[0] = new NominaPercepcionesPercepcion();
            //nomina.Percepciones.Percepcion[0].TipoPercepcion = "001";
            //nomina.Percepciones.Percepcion[0].Clave = "1";
            //nomina.Percepciones.Percepcion[0].Concepto = "SALARIO";
            //nomina.Percepciones.Percepcion[0].ImporteGravado = 1000;
            //nomina.Percepciones.Percepcion[0].ImporteExento = 500;

            //System.Xml.Serialization.XmlSerializerNamespaces nsNominas = new System.Xml.Serialization.XmlSerializerNamespaces();
            //nsNominas.Add("nomina", "http://www.sat.gob.mx/nomina");
            //string xmlNomina = XMLUtilerias.SerializaObjeto(nomina, typeof(Nomina), nsNominas);
            //XmlDocument docNominas = new XmlDocument();
            //docNominas.LoadXml(xmlNomina);
            //comprobante.NominasSpecified = true;
            //LXmlComplementos.Add(docNominas.DocumentElement);
            ////FIN EJEMPLO PARA COMPLEMENTO NÓMINA





            ////INICIA EJEMPLO PARA COMPLEMENTO IMPUESTOS LOCALES
            ////Descomentar esta sección para utilizar el complemento impuestos locales

            ////Declaramos arreglo de complementos
            //List<XmlElement> LXmlComplementos = new List<XmlElement>();

            //ImpuestosLocales impLocales = new ImpuestosLocales();
            //List<ImpuestosLocalesTrasladosLocales> traslado = new List<ImpuestosLocalesTrasladosLocales>();

            //ImpuestosLocalesTrasladosLocales tras = new ImpuestosLocalesTrasladosLocales();
            //tras.Importe = 13;
            //tras.ImpLocTrasladado = "Traslado local ejemplo";
            //tras.TasadeTraslado = 13;

            //traslado.Add(tras);

            //impLocales.TrasladosLocales = traslado.ToArray<ImpuestosLocalesTrasladosLocales>();
            //impLocales.version = "1.0";

            ////Totales
            //impLocales.TotaldeTraslados = 13;
            //impLocales.TotaldeRetenciones = 0;

            //XmlSerializerNamespaces nsImpLocales = new XmlSerializerNamespaces();
            //nsImpLocales.Add("implocal", "http://www.sat.gob.mx/implocal");
            //string xmlImpLocales = XMLUtilerias.SerializaObjeto(impLocales, typeof(ImpuestosLocales), nsImpLocales);

            //XmlDocument docImpuestosLocales = new XmlDocument();
            //docImpuestosLocales.LoadXml(xmlImpLocales);
            //comprobante.ImpLocalSpecified = true;
            //LXmlComplementos.Add(docImpuestosLocales.DocumentElement);
            ////FIN EJEMPLO PARA COMPLEMENTO IMPUESTOS LOCALES





            ////COMPLEMENTOS UTILIZADOS?
            ////Descomentar esta sección si utilizaste algún complemento como nóminas, impuestos locales, donativos, estados de cuenta etc..
            //comprobante.Complemento = new ComprobanteComplemento();
            //comprobante.Complemento.Any = LXmlComplementos.ToArray<XmlElement>();




            ////INICIA EJEMPLO PARA ADDENDAS
            ////Descomentar esta sección para agregar una addenda al comprobante

            ////Creamos nuestra addenda
            //string miAddendaEjemplo = "<Documento><Cabezero dato=\"valor\" dato2=\"valor2\"><Cuerpo datoCuerpo=\"valorCuerpo\" datoCuerpo2=\"valorCuerpo2\"/></Cabezero></Documento>";

            ////Transformamos a XmlElement
            //System.Xml.XmlDocument docAddenda = new System.Xml.XmlDocument();
            //docAddenda.LoadXml(miAddendaEjemplo);
            //XmlElement xmlAdenda = docAddenda.DocumentElement;

            ////Agregamos addenda
            //comprobante.Addenda = new ComprobanteAddenda();
            //comprobante.Addenda.Any = new XmlElement[1];
            //comprobante.Addenda.Any[0] = xmlAdenda;




            //Timbramos el CFDI por medio del conector y guardamos resultado
            ResultadoTimbre resultadoTimbre;
            resultadoTimbre = conector.TimbraCFDI(comprobante);

            //Verificamos el resultado
            if(resultadoTimbre.Exitoso)
            {
                //El comprobante fue timbrado exitosamente

                //Guardamos xml cfdi
                if(resultadoTimbre.GuardaXml("C:\\", "timbrado"))
                {
                    MessageBox.Show("El xml fue guardado correctamente");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al guardar el comprobante");
                }

                //Los siguientes datos deberán ir en la respresentación impresa ó PDF

                //1.- Código bidimensional
                if(resultadoTimbre.GuardaCodigoBidimensional("C:\\", "codigo"))
                {
                    MessageBox.Show("El código bidimensional fue guardado correctamente");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al guardar el código bidimensional");
                }

                //2.- Folio fiscal
                string folioFiscal = resultadoTimbre.FolioUUID;

                //3.- No. Certificado del Emisor
                string noCertificado = resultadoTimbre.No_Certificado;

                //4.- No. Certificado del SAT
                string noCertificadoSAT = resultadoTimbre.No_Certificado_SAT;

                //5.- Fecha y Hora de certificación
                string fechaCert = resultadoTimbre.FechaCertificacion;

                //6.- Sello del cfdi
                string selloCFDI = resultadoTimbre.SelloCFDI;

                //7.- Sello del SAT
                string selloSAT = resultadoTimbre.SelloSAT;

                //8.- Cadena original de complemento de certificación
                string cadena = resultadoTimbre.CadenaTimbre;

                MessageBox.Show("Timbrado Exitoso");
            }
            else
            {
                //No se pudo timbrar, mostramos respuesta
                MessageBox.Show(resultadoTimbre.Descripcion);
            }
        }

        private void btnTimbraCfdiArchivo_Click(object sender, EventArgs e)
        {
            ofdComprobante.ShowDialog();
        }

        private void ofdComprobante_FileOk(object sender, CancelEventArgs e)
        {
            //Este ejemplo está dirigido a aquellos integradores que ya generan el xml (CFDI) y solo desean timbrarlo

            //Inicializamos el conector el parámetro indica el ambiente en el que se utilizará 
            //Fasle = Ambiente de pruebas
            //True = Ambiente de producción
            Conector conector = new Conector(false);

            //Establecemos las credenciales para el permiso de conexión
            //Ambiente de pruebas = mvpNUXmQfK8=
            //Ambiente de producción = Esta será asignado por el proveedor al salir a productivo
            conector.EstableceCredenciales("mvpNUXmQfK8=");

            //Ruta del archivo a timbrar
            string rutaArchivo = ofdComprobante.FileName;

            //Timbramos el CFDI por medio del conector y guardamos resultado
            ResultadoTimbre resultadoTimbre;
            resultadoTimbre = conector.TimbraCFDI(rutaArchivo);

            //Verificamos el resultado
            if(resultadoTimbre.Exitoso)
            {
                //El comprobante fue timbrado exitosamente

                //Guardamos xml cfdi
                if(resultadoTimbre.GuardaXml("C:\\", "timbrado"))
                {
                    MessageBox.Show("El xml fue guardado correctamente");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al guardar el comprobante");
                }

                //Los siguientes datos deberán ir en la respresentación impresa ó PDF

                //1.- Código bidimensional
                if (resultadoTimbre.GuardaCodigoBidimensional("C:\\", "codigo"))
                {
                    MessageBox.Show("El código bidimensional fue guardado correctamente");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al guardar el código bidimensional");
                }

                //2.- Folio fiscal
                string folioFiscal = resultadoTimbre.FolioUUID;

                //3.- No. Certificado del Emisor
                string noCertificado = resultadoTimbre.No_Certificado;

                //4.- No. Certificado del SAT
                string noCertificadoSAT = resultadoTimbre.No_Certificado_SAT;

                //5.- Fecha y Hora de certificación
                string fechaCert = resultadoTimbre.FechaCertificacion;

                //6.- Sello del cfdi
                string selloCFDI = resultadoTimbre.SelloCFDI;

                //7.- Sello del SAT
                string selloSAT = resultadoTimbre.SelloSAT;

                //8.- Cadena original de complemento de certificación
                string cadena = resultadoTimbre.CadenaTimbre;

                MessageBox.Show("Timbrado Exitoso");
            }
            else
            {
                //No se pudo timbrar, mostramos respuesta
                MessageBox.Show(resultadoTimbre.Descripcion);
            }
        }

        private void btnObtieneCFDI_Click(object sender, EventArgs e)
        {
            //En este ejemplo se muestra como recuperar un comprobante xml, previamente timbrado

            //Inicializamos el conector el parámetro indica el ambiente en el que se utilizará 
            //Fasle = Ambiente de pruebas
            //True = Ambiente de producción
            Conector conector = new Conector(false);

            //Establecemos las credenciales para el permiso de conexión
            //Ambiente de pruebas = mvpNUXmQfK8=
            //Ambiente de producción = Esta será asignado por el proveedor al salir a productivo
            conector.EstableceCredenciales("mvpNUXmQfK8=");

            //Rfc Emisor
            string rfcEmisor = txtRfcEmisorConsulta.Text.Trim();

            //Folio Fiscal - UUID
            string folioFiscal = txtFolioFiscalConsulta.Text.Trim();

            //Obtenemos el xml por medio del conector y guardamos resultado
            ResultadoConsulta resultadoConsulta;

            resultadoConsulta = conector.ObtieneCFDI(rfcEmisor, folioFiscal);

            //Verificamos el resultado
            if (resultadoConsulta.Exitoso)
            {
                //El comprobante fue timbrado exitosamente

                //Guardamos xml cfdi
                if (resultadoConsulta.GuardaXml("C:\\", "consultado"))
                {
                    MessageBox.Show("El xml fue guardado correctamente");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al guardar el comprobante");
                }

                //Los siguientes datos deberán ir en la respresentación impresa ó PDF

                //1.- Código bidimensional
                if (resultadoConsulta.GuardaCodigoBidimensional("C:\\", "codigo_consultado"))
                {
                    MessageBox.Show("El código bidimensional fue guardado correctamente");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al guardar el código bidimensional");
                }

                //2.- Folio fiscal
                string FolioFiscal = resultadoConsulta.FolioUUID;

                //3.- No. Certificado del Emisor
                string noCertificado = resultadoConsulta.No_Certificado;

                //4.- No. Certificado del SAT
                string noCertificadoSAT = resultadoConsulta.No_Certificado_SAT;

                //5.- Fecha y Hora de certificación
                string fechaCert = resultadoConsulta.FechaCertificacion;

                //6.- Sello del cfdi
                string selloCFDI = resultadoConsulta.SelloCFDI;

                //7.- Sello del SAT
                string selloSAT = resultadoConsulta.SelloSAT;

                //8.- Cadena original de complemento de certificación
                string cadena = resultadoConsulta.CadenaTimbre;

                MessageBox.Show("Consulta Exitosa");
            }
            else
            {
                //No se pudo timbrar, mostramos respuesta
                MessageBox.Show(resultadoConsulta.Descripcion);
            }
        }

        private void btnCancelaCFDI_Click(object sender, EventArgs e)
        {
            //En este ejemplo se muestra como cancelar un comprobante xml, previamente timbrado

            //Inicializamos el conector el parámetro indica el ambiente en el que se utilizará 
            //Fasle = Ambiente de pruebas
            //True = Ambiente de producción
            Conector conector = new Conector(false);

            //Establecemos las credenciales para el permiso de conexión
            //Ambiente de pruebas = mvpNUXmQfK8=
            //Ambiente de producción = Esta será asignado por el proveedor al salir a productivo
            conector.EstableceCredenciales("mvpNUXmQfK8=");

            //Rfc Emisor
            string rfcEmisor = txtRfcEmisorCancelacion.Text.Trim();

            //Folio Fiscal - UUID
            string folioFiscal = txtFolioFiscalCancelacion.Text.Trim();

            //Obtenemos el xml por medio del conector y guardamos resultado
            ResultadoCancelacion resultadoCancelacion;

            resultadoCancelacion = conector.CancelaCFDI(rfcEmisor, folioFiscal);

            //Verificamos el resultado
            if(resultadoCancelacion.Exitoso)
            {
                //El comprobante fue cancelado exitosamente
                MessageBox.Show("Cancelación exitosa " + resultadoCancelacion.Descripcion);
            }
            else
            {
                //No se pudo cancelar, mostramos respuesta
                MessageBox.Show(resultadoCancelacion.Descripcion);
            }
        }
    }
}
