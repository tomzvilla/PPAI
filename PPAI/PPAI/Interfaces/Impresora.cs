using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PPAI.Entidades;

namespace PPAI.Interfaces
{
    public class Impresora
    {
        public void PDFimprimirEntradas(Entradas entrada, bool esGuiada)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            // Crear documento

            PdfDocument e= new PdfDocument();

            // Crear fuente a utilizar

            XFont fuente = new XFont("Arial", 14);

            // Nueva pagina

            PdfPage pagina = e.AddPage();

            // Esta clase me provee de metodso relacionados al dibujado para una clase especifica
             
            XGraphics gfx = XGraphics.FromPdfPage(pagina);


            gfx.DrawRectangle(XPens.Black, 175,230,270,370);

            // Dibujar titulo

            gfx.DrawString("Museo Pictorico - Entrada", new XFont("Arial", 16, XFontStyle.Bold), XBrushes.Black, new XPoint(210,250));

            // Dibujar sede

            gfx.DrawString("Sede: ", fuente, XBrushes.Black, new XPoint(190, 290));
            gfx.DrawString($"{entrada.sede.mostrarNombre()}", fuente, XBrushes.Black, new XPoint(320, 290));


            // Dibujar fecha y hora


            gfx.DrawString("Fecha y Hora: ", fuente, XBrushes.Black, new XPoint(190, 330));
            gfx.DrawString($"{entrada.FechaVenta}", fuente, XBrushes.Black, new XPoint(320, 330));

            // Dibujar Nro Entrada


            gfx.DrawString("Nro Entrada: ", fuente, XBrushes.Black, new XPoint(190, 370));
            gfx.DrawString($"{entrada.Numero}", fuente, XBrushes.Black, new XPoint(320, 370));

            // Dibujar guia

            var montoUnitario = entrada.tarifa.Monto;

            gfx.DrawString("¿Es guiada?: ", fuente, XBrushes.Black, new XPoint(190, 530));
            if (esGuiada)
            {
                gfx.DrawString("SI", fuente, XBrushes.Black, new XPoint(320, 530));
                montoUnitario += entrada.tarifa.MontoAdicionalGuia;
            }

            else
                gfx.DrawString("NO", fuente, XBrushes.Black, new XPoint(320, 530));

            // Díbujar Precio

            gfx.DrawString("Precio: ", fuente, XBrushes.Black, new XPoint(190, 410));
            gfx.DrawString($"{montoUnitario}", fuente, XBrushes.Black, new XPoint(320, 410));

            // Dibujar Tipo Entrada

            gfx.DrawString("Tipo de Entrada: ", fuente, XBrushes.Black, new XPoint(190, 450));
            gfx.DrawString($"{entrada.tarifa.tipoEntrada.mostrarNombre()}", fuente, XBrushes.Black, new XPoint(320, 450));

            // Dibujar tipo visita

            gfx.DrawString("Tipo de Visita: ", fuente, XBrushes.Black, new XPoint(190, 490));
            gfx.DrawString($"{entrada.tarifa.tipoVisita.mostrarNombre()}", fuente, XBrushes.Black, new XPoint(320, 490));





            e.Save($@"C:\\Users\villa\Desktop\DSI\PPAI\Entradas\{entrada.Numero}.pdf");
        }
    }
}
