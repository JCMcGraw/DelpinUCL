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
        public double Moms(double totalPrice)
        {
            double momsPrice = (totalPrice * 1.25)-totalPrice;
            return momsPrice;
        }

        public double endPrice(double totalPrice,double momsPrice)
        {
            double endPrice= totalPrice + momsPrice;
            return endPrice;
        }

        //public void MakePDF(Lease)
        //{
        //    //Her bruges classen pdfDocument.
        //    PdfDocument document = new PdfDocument();

        //    //Her laver jeg et pdf dokument og kalder det Created with DPFsharp
        //    document.Info.Title = "Created with PDFsharp";

        //    // Her laves en tom side
        //    PdfPage page = document.AddPage();

        //    // Get an XGraphics object for drawing
        //    XGraphics gfx = XGraphics.FromPdfPage(page);

        //    // Create a font (Dette er skrift størelse og sill)
        //    XFont companyAndDebtor = new XFont("Calibri", 10, XFontStyle.Regular);
        //    XFont fakture = new XFont("Calibri", 20, XFontStyle.Bold);
        //    XFont companyNames = new XFont("Calibri", 13, XFontStyle.Bold);
        //    XFont smallHeadLine = new XFont("Calibri", 10, XFontStyle.Bold);
        //    XFont priceFat = new XFont("Calibri", 10, XFontStyle.Bold);

        //    // Draw the text Dette er hvad der skal være på teksten og hvor det skal være Der kan laves lige så mange som man vil 

        //    //Kunde Oplysninger------------------------------------------------------------------------------------------------------------------------------
        //    gfx.DrawString($"{contactFirstName} {contactLastName}", companyAndDebtor, XBrushes.Black,
        //        new XRect(80, -320, page.Width, page.Height),
        //        XStringFormats.CenterLeft);

        //    gfx.DrawString($"{street}", companyAndDebtor, XBrushes.Black,
        //        new XRect(80, -310, page.Width, page.Height),
        //        XStringFormats.CenterLeft);

        //    gfx.DrawString($"{city} {postalCode}", companyAndDebtor, XBrushes.Black,
        //        new XRect(80, -300, page.Width, page.Height),
        //        XStringFormats.CenterLeft);

        //    gfx.DrawString($"{contactPhone}", companyAndDebtor, XBrushes.Black,
        //        new XRect(80, -290, page.Width, page.Height),
        //        XStringFormats.CenterLeft);


        //    gfx.DrawString($"Kunde Nr: {debtorID}", companyAndDebtor, XBrushes.Black,
        //        new XRect(80, -260, page.Width, page.Height),
        //        XStringFormats.CenterLeft);

        //    //FAKTURA---------------------------------------------------------------------------------------------------------------------------------------
        //    gfx.DrawString("FAKTURA", fakture, XBrushes.Black,
        //        new XRect(80, -210, page.Width, page.Height),
        //        XStringFormats.CenterLeft);

        //    //Firma informationer----------------------------------------------------------------------------------------------------------------------------
        //    gfx.DrawString("Delpin", companyNames, XBrushes.Black,
        //        new XRect(-60, -380, page.Width, page.Height),
        //        XStringFormats.CenterRight);

        //    gfx.DrawString("Branch Vejnavn og nr ", companyAndDebtor, XBrushes.Black,
        //        new XRect(-60, -360, page.Width, page.Height),
        //        XStringFormats.CenterRight);

        //    gfx.DrawString("Branch by og postNr ", companyAndDebtor, XBrushes.Black,
        //        new XRect(-60, -350, page.Width, page.Height),
        //        XStringFormats.CenterRight);

        //    gfx.DrawString("Tlf ", companyAndDebtor, XBrushes.Black,
        //        new XRect(-60, -320, page.Width, page.Height),
        //        XStringFormats.CenterRight);

        //    //BankOplysninger------------------------------------------------------------------------------------------------------------------------------
        //    gfx.DrawString("Bank ", companyAndDebtor, XBrushes.Black,
        //        new XRect(-60, -280, page.Width, page.Height),
        //        XStringFormats.CenterRight);

        //    gfx.DrawString("Reg. Nr:0000 ", companyAndDebtor, XBrushes.Black,
        //        new XRect(-60, -270, page.Width, page.Height),
        //        XStringFormats.CenterRight);

        //    gfx.DrawString("Konto Nr:000000000000 ", companyAndDebtor, XBrushes.Black,
        //        new XRect(-60, -260, page.Width, page.Height),
        //        XStringFormats.CenterRight);

        //    //Fakture Nr dato og betalings dato------------------------------------------------------------------------------------------------------------
        //    gfx.DrawString("Fakture Nr 1 ", companyAndDebtor, XBrushes.Black,
        //        new XRect(-60, -180, page.Width, page.Height),
        //        XStringFormats.CenterRight);

        //    gfx.DrawString($"{startDate} ", companyAndDebtor, XBrushes.Black,
        //        new XRect(-60, -170, page.Width, page.Height),
        //        XStringFormats.CenterRight);

        //    gfx.DrawString($"{endDate} ", companyAndDebtor, XBrushes.Black,
        //        new XRect(-60, -160, page.Width, page.Height),
        //        XStringFormats.CenterRight);

        //    //Headlines Resurce Antal Pris Beløb-----------------------------------------------------------------------------------------------------------
        //    gfx.DrawString("Vare ", smallHeadLine, XBrushes.Black,
        //        new XRect(80, -130, page.Width, page.Height),
        //        XStringFormats.CenterLeft);

        //    gfx.DrawString("Antal Dage ", smallHeadLine, XBrushes.Black,
        //        new XRect(0, -130, page.Width, page.Height),
        //        XStringFormats.Center);

        //    gfx.DrawString("Daglig Lejepris ", smallHeadLine, XBrushes.Black,
        //        new XRect(80, -130, page.Width, page.Height),
        //        XStringFormats.Center);

        //    gfx.DrawString("Levering ", smallHeadLine, XBrushes.Black,
        //        new XRect(150, -130, page.Width, page.Height),
        //        XStringFormats.Center);

        //    gfx.DrawString("Beløb ", smallHeadLine, XBrushes.Black,
        //        new XRect(-60, -130, page.Width, page.Height),
        //        XStringFormats.CenterRight);

        //    //Navn på vare antal pris beløb-------------------------------------------------------------------------------------------------------------
        //    gfx.DrawString("___________________________________________________________________________________________ ", smallHeadLine, XBrushes.Black,
        //        new XRect(80, -125, page.Width, page.Height),
        //        XStringFormats.CenterLeft);

        //    gfx.DrawString($"{modelName}", companyAndDebtor, XBrushes.Black,
        //        new XRect(80, -110, page.Width, page.Height),
        //        XStringFormats.CenterLeft);

        //    gfx.DrawString($"{numberOfDays}", companyAndDebtor, XBrushes.Black,
        //        new XRect(0, -110, page.Width, page.Height),
        //        XStringFormats.Center);

        //    gfx.DrawString($"Kr. {price} ", companyAndDebtor, XBrushes.Black,
        //        new XRect(80, -110, page.Width, page.Height),
        //        XStringFormats.Center);

        //    gfx.DrawString($"Kr.{deliveryPrice}", companyAndDebtor, XBrushes.Black,
        //        new XRect(150, -110, page.Width, page.Height),
        //        XStringFormats.Center);

        //    gfx.DrawString($"Kr. {totalPrice}", companyAndDebtor, XBrushes.Black,
        //        new XRect(-60, -110, page.Width, page.Height),
        //        XStringFormats.CenterRight);

        //    gfx.DrawString("___________________________________________________________________________________________ ", smallHeadLine, XBrushes.Black,
        //        new XRect(80, -100, page.Width, page.Height),
        //        XStringFormats.CenterLeft);

        //    //Ialt før Moms ------------------------------------------------------------------------------------------------------------------------------
        //    gfx.DrawString($"leasePrice + leasePrice ", priceFat, XBrushes.Black,
        //        new XRect(-60, -85, page.Width, page.Height),
        //        XStringFormats.CenterRight);

        //    //Netto Moms Total + penge + Streg------------------------------------------------------------------------------------------------------------
        //    gfx.DrawString("Netto: ", companyAndDebtor, XBrushes.Black,
        //       new XRect(400, -20, page.Width, page.Height),
        //       XStringFormats.CenterLeft);

        //    gfx.DrawString("Moms (25%): ", companyAndDebtor, XBrushes.Black,
        //        new XRect(400, -5, page.Width, page.Height),
        //        XStringFormats.CenterLeft);

        //    gfx.DrawString("Total: ", priceFat, XBrushes.Black,
        //        new XRect(400, 10, page.Width, page.Height),
        //        XStringFormats.CenterLeft);

        //    gfx.DrawString($"Kr. {totalPrice} ", companyAndDebtor, XBrushes.Black, //Kan godt være ate den ikke acceptere denne linje
        //        new XRect(-60, -20, page.Width, page.Height),
        //        XStringFormats.CenterRight);

        //    gfx.DrawString($"Kr. {momsPrice} ", companyAndDebtor, XBrushes.Black, //Kan godt være ate den ikke acceptere denne linje
        //        new XRect(-60, -5, page.Width, page.Height),
        //        XStringFormats.CenterRight);

        //    gfx.DrawString($"Kr. {endPrice} ", priceFat, XBrushes.Black,
        //        new XRect(-60, 10, page.Width, page.Height),
        //        XStringFormats.CenterRight);

        //    gfx.DrawString("___________________________ ", smallHeadLine, XBrushes.Black,
        //        new XRect(400, 15, page.Width, page.Height),
        //        XStringFormats.CenterLeft);

        //    //Dette  er til at vælge Navnet på filen
        //    const string filename = "Fakture.pdf";

        //    //Dette er til at gemme pdf
        //    document.Save(filename);

        //    //Dette er til at vise PDF
        //    Process.Start(filename);
        //}
    }
}
