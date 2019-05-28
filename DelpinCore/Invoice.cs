using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using PdfSharp; //Denne skal bruges
using PdfSharp.Drawing;//Denne skal bruges
using PdfSharp.Pdf;//Denne skal bruges
//using PdfSharp.Pdf.IO;//Denne skal bruges
//using System.IO;//Denne skal bruges
using System.Diagnostics;//Denne skal bruges

namespace DelpinCore
{
    class Invoice
    {
        public void MakePDF(string contactFirstName, string contactLastName, string street,string city,int postalCode, string contactPhone, string debtorID, DateTime startDate, DateTime endDate, string modelName, decimal leasePrice)
        {
            //Her bruges classen pdfDocument.
            PdfDocument document = new PdfDocument();

            //Her laver jeg et pdf dokument og kalder det Created with DPFsharp
            document.Info.Title = "Created with PDFsharp";

            // Her laves en tom side
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font (Dette er skrift størelse og sill)
            XFont companyAndDebtor = new XFont("Calibri", 10, XFontStyle.Regular);
            XFont fakture = new XFont("Calibri", 20, XFontStyle.Bold);
            XFont companyNames = new XFont("Calibri", 13, XFontStyle.Bold);
            XFont smallHeadLine = new XFont("Calibri", 10, XFontStyle.Bold);
            XFont priceFat = new XFont("Calibri", 10, XFontStyle.Bold);

            // Draw the text Dette er hvad der skal være på teksten og hvor det skal være Der kan laves lige så mange som man vil 

            //Kunde Oplysninger------------------------------------------------------------------------------------------------------------------------------
            gfx.DrawString($"{contactFirstName}','{contactLastName}", companyAndDebtor, XBrushes.Black,
                new XRect(80, -320, page.Width, page.Height),
                XStringFormats.CenterLeft);

            gfx.DrawString($"{street}", companyAndDebtor, XBrushes.Black,
                new XRect(80, -310, page.Width, page.Height),
                XStringFormats.CenterLeft);

            gfx.DrawString($"{city},'{postalCode},", companyAndDebtor, XBrushes.Black,
                new XRect(80, -300, page.Width, page.Height),
                XStringFormats.CenterLeft);

            gfx.DrawString($"{contactPhone}", companyAndDebtor, XBrushes.Black,
                new XRect(80, -320, page.Width, page.Height),
                XStringFormats.CenterLeft);


            gfx.DrawString($"{debtorID}", companyAndDebtor, XBrushes.Black,
                new XRect(80, -270, page.Width, page.Height),
                XStringFormats.CenterLeft);

            //FAKTURA---------------------------------------------------------------------------------------------------------------------------------------
            gfx.DrawString("FAKTURA", fakture, XBrushes.Black,
                new XRect(80, -210, page.Width, page.Height),
                XStringFormats.CenterLeft);

            //Firma informationer----------------------------------------------------------------------------------------------------------------------------
            gfx.DrawString("Delpin", companyNames, XBrushes.Black,
                new XRect(-60, -380, page.Width, page.Height),
                XStringFormats.CenterRight);

            gfx.DrawString("Branch Vejnavn og nr ", companyAndDebtor, XBrushes.Black,
                new XRect(-60, -360, page.Width, page.Height),
                XStringFormats.CenterRight);

            gfx.DrawString("Branch by og postNr ", companyAndDebtor, XBrushes.Black,
                new XRect(-60, -350, page.Width, page.Height),
                XStringFormats.CenterRight);

            gfx.DrawString("Tlf ", companyAndDebtor, XBrushes.Black,
                new XRect(-60, -320, page.Width, page.Height),
                XStringFormats.CenterRight);

            //BankOplysninger------------------------------------------------------------------------------------------------------------------------------
            gfx.DrawString("Bank ", companyAndDebtor, XBrushes.Black,
                new XRect(-60, -280, page.Width, page.Height),
                XStringFormats.CenterRight);

            gfx.DrawString("Reg. Nr:0000 ", companyAndDebtor, XBrushes.Black,
                new XRect(-60, -270, page.Width, page.Height),
                XStringFormats.CenterRight);

            gfx.DrawString("Konto Nr:000000000000 ", companyAndDebtor, XBrushes.Black,
                new XRect(-60, -260, page.Width, page.Height),
                XStringFormats.CenterRight);

            //Fakture Nr dato og betalings dato------------------------------------------------------------------------------------------------------------
            gfx.DrawString("Fakture Nr 1 ", companyAndDebtor, XBrushes.Black,
                new XRect(-60, -180, page.Width, page.Height),
                XStringFormats.CenterRight);

            gfx.DrawString($"{startDate} ", companyAndDebtor, XBrushes.Black,
                new XRect(-60, -170, page.Width, page.Height),
                XStringFormats.CenterRight);

            gfx.DrawString($"{endDate} ", companyAndDebtor, XBrushes.Black,
                new XRect(-60, -160, page.Width, page.Height),
                XStringFormats.CenterRight);

            //Headlines Resurce Antal Pris Beløb-----------------------------------------------------------------------------------------------------------
            gfx.DrawString("Resource ", smallHeadLine, XBrushes.Black,
                new XRect(80, -130, page.Width, page.Height),
                XStringFormats.CenterLeft);

            //gfx.DrawString("Antal ", smallHeadLine, XBrushes.Black,
            //    new XRect(350, -130, page.Width, page.Height),
            //    XStringFormats.CenterLeft);

            gfx.DrawString("Pris ", smallHeadLine, XBrushes.Black,
                new XRect(-60, -130, page.Width, page.Height),
                XStringFormats.CenterRight);

            //gfx.DrawString("Beløb ", smallHeadLine, XBrushes.Black,
            //    new XRect(-60, -130, page.Width, page.Height),
            //    XStringFormats.CenterRight);

            //Navn på vare antal pris beløb-------------------------------------------------------------------------------------------------------------
            gfx.DrawString("___________________________________________________________________________________________ ", smallHeadLine, XBrushes.Black,
                new XRect(80, -125, page.Width, page.Height),
                XStringFormats.CenterLeft);

            gfx.DrawString($"{modelName}", companyAndDebtor, XBrushes.Black,
                new XRect(80, -110, page.Width, page.Height),
                XStringFormats.CenterLeft);

            //gfx.DrawString("Navn på Vare", companyAndDebtor, XBrushes.Black,
            //    new XRect(80, -95, page.Width, page.Height),
            //    XStringFormats.CenterLeft);

            //gfx.DrawString("Navn på Vare", companyAndDebtor, XBrushes.Black,
            //    new XRect(80, -80, page.Width, page.Height),
            //    XStringFormats.CenterLeft);

            //gfx.DrawString("5", companyAndDebtor, XBrushes.Black,
            //    new XRect(65, -110, page.Width, page.Height),
            //    XStringFormats.Center);

            //gfx.DrawString("5", companyAndDebtor, XBrushes.Black,
            //    new XRect(65, -95, page.Width, page.Height),
            //    XStringFormats.Center);

            //gfx.DrawString("5", companyAndDebtor, XBrushes.Black,
            //    new XRect(65, -80, page.Width, page.Height),
            //    XStringFormats.Center);

            gfx.DrawString($"{leasePrice}", companyAndDebtor, XBrushes.Black,
                new XRect(-60, -110, page.Width, page.Height),
                XStringFormats.CenterRight);

            //gfx.DrawString("Kr. 500", companyAndDebtor, XBrushes.Black,
            //    new XRect(-150, -95, page.Width, page.Height),
            //    XStringFormats.CenterRight);

            //gfx.DrawString("Kr. 500", companyAndDebtor, XBrushes.Black,
            //    new XRect(-150, -80, page.Width, page.Height),
            //    XStringFormats.CenterRight);

            //gfx.DrawString("antal * pris ", companyAndDebtor, XBrushes.Black,
            //    new XRect(-60, -110, page.Width, page.Height),
            //    XStringFormats.CenterRight);

            //gfx.DrawString("kr.2500 ", companyAndDebtor, XBrushes.Black,
            //    new XRect(-60, -95, page.Width, page.Height),
            //    XStringFormats.CenterRight);

            //gfx.DrawString("kr.2500 ", companyAndDebtor, XBrushes.Black,
            //    new XRect(-60, -80, page.Width, page.Height),
            //    XStringFormats.CenterRight);

            gfx.DrawString("___________________________________________________________________________________________ ", smallHeadLine, XBrushes.Black,
                new XRect(80, -75, page.Width, page.Height),
                XStringFormats.CenterLeft);

            //Ialt før Moms ------------------------------------------------------------------------------------------------------------------------------
            gfx.DrawString($"leasePrice + leasePrice ", priceFat, XBrushes.Black,
                new XRect(-60, -60, page.Width, page.Height),
                XStringFormats.CenterRight);


            //Netto Moms Total + penge + Streg------------------------------------------------------------------------------------------------------------
            gfx.DrawString("Netto: ", companyAndDebtor, XBrushes.Black,
               new XRect(400, -10, page.Width, page.Height),
               XStringFormats.CenterLeft);

            gfx.DrawString("Moms (25%): ", companyAndDebtor, XBrushes.Black,
                new XRect(400, 10, page.Width, page.Height),
                XStringFormats.CenterLeft);

            gfx.DrawString("Total: ", priceFat, XBrushes.Black,
                new XRect(400, 30, page.Width, page.Height),
                XStringFormats.CenterLeft);

            gfx.DrawString("___________________________ ", smallHeadLine, XBrushes.Black,
                new XRect(400, 40, page.Width, page.Height),
                XStringFormats.CenterLeft);

            gfx.DrawString("kr. 7500 ", companyAndDebtor, XBrushes.Black,
                new XRect(-60, -10, page.Width, page.Height),
                XStringFormats.CenterRight);

            gfx.DrawString("kr. 7500 ", companyAndDebtor, XBrushes.Black,
                new XRect(-60, 10, page.Width, page.Height),
                XStringFormats.CenterRight);

            gfx.DrawString("kr. 7500 ", priceFat, XBrushes.Black,
                new XRect(-60, 30, page.Width, page.Height),
                XStringFormats.CenterRight);


            //Dette  er til at vælge Navnet på filen
            const string filename = "Fakture.pdf";

            //Dette er til at gemme pdf
            document.Save(filename);

            //Dette er til at vise PDF
            Process.Start(filename);
        }
    }
}
