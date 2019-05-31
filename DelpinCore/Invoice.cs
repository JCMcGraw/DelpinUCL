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
        public decimal Moms(decimal totalPrice)
        {
            decimal momsPrice = (totalPrice * 1.25m)-totalPrice;
            return momsPrice;
        }

        public decimal endPrice(decimal totalPrice,decimal momsPrice)
        {
            decimal endPrice= totalPrice + momsPrice;
            return endPrice;
        }

        public void MakePDF(Lease lease,Business debtor)
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
            gfx.DrawString($"{lease.contactFirstName} {lease.contactLastName}", companyAndDebtor, XBrushes.Black,
                new XRect(80, -320, page.Width, page.Height),
                XStringFormats.CenterLeft);

            gfx.DrawString($"{debtor.street}", companyAndDebtor, XBrushes.Black,
                new XRect(80, -310, page.Width, page.Height),
                XStringFormats.CenterLeft);

            gfx.DrawString($"{debtor.city} {debtor.postalCode}", companyAndDebtor, XBrushes.Black,
                new XRect(80, -300, page.Width, page.Height),
                XStringFormats.CenterLeft);

            gfx.DrawString($"{lease.contactPhone}", companyAndDebtor, XBrushes.Black,
                new XRect(80, -290, page.Width, page.Height),
                XStringFormats.CenterLeft);


            gfx.DrawString($"Kunde Nr: {lease.debtorID}", companyAndDebtor, XBrushes.Black,
                new XRect(80, -260, page.Width, page.Height),
                XStringFormats.CenterLeft);

            //FAKTURA---------------------------------------------------------------------------------------------------------------------------------------
            gfx.DrawString("FAKTURA", fakture, XBrushes.Black,
                new XRect(80, -210, page.Width, page.Height),
                XStringFormats.CenterLeft);

            //Firma informationer----------------------------------------------------------------------------------------------------------------------------
            gfx.DrawString("Delpin", companyNames, XBrushes.Black,
                new XRect(-60, -380, page.Width, page.Height),
                XStringFormats.CenterRight);

            gfx.DrawString("Nordvesthavnsvej 60 ", companyAndDebtor, XBrushes.Black,
                new XRect(-60, -360, page.Width, page.Height),
                XStringFormats.CenterRight);

            gfx.DrawString("6400 Sønderborg ", companyAndDebtor, XBrushes.Black,
                new XRect(-60, -350, page.Width, page.Height),
                XStringFormats.CenterRight);

            gfx.DrawString("Tlf 74 48 88 88 ", companyAndDebtor, XBrushes.Black,
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

            gfx.DrawString($"{lease.dateCreated} ", companyAndDebtor, XBrushes.Black,
                new XRect(-60, -170, page.Width, page.Height),
                XStringFormats.CenterRight);

            //Headlines Resurce Antal Pris Beløb-----------------------------------------------------------------------------------------------------------
            gfx.DrawString("Vare ", smallHeadLine, XBrushes.Black,
                new XRect(80, -130, page.Width, page.Height),
                XStringFormats.CenterLeft);

            gfx.DrawString("Antal Dage ", smallHeadLine, XBrushes.Black,
                new XRect(0, -130, page.Width, page.Height),
                XStringFormats.Center);

            gfx.DrawString("Daglig Lejepris ", smallHeadLine, XBrushes.Black,
                new XRect(80, -130, page.Width, page.Height),
                XStringFormats.Center);

            gfx.DrawString("Levering ", smallHeadLine, XBrushes.Black,
                new XRect(150, -130, page.Width, page.Height),
                XStringFormats.Center);

            gfx.DrawString("Beløb ", smallHeadLine, XBrushes.Black,
                new XRect(-60, -130, page.Width, page.Height),
                XStringFormats.CenterRight);

            //Navn på vare antal pris beløb-------------------------------------------------------------------------------------------------------------
            gfx.DrawString("___________________________________________________________________________________________ ", smallHeadLine, XBrushes.Black,
                new XRect(80, -125, page.Width, page.Height),
                XStringFormats.CenterLeft);

            gfx.DrawString($"{lease.GetLeaseOrders()[0].modelName}", companyAndDebtor, XBrushes.Black,
                new XRect(80, -110, page.Width, page.Height),
                XStringFormats.CenterLeft);

            gfx.DrawString($"{5}", companyAndDebtor, XBrushes.Black,
                new XRect(0, -110, page.Width, page.Height),
                XStringFormats.Center);

            gfx.DrawString($"Kr. {lease.GetLeaseOrders()[0].leasePrice} ", companyAndDebtor, XBrushes.Black,
                new XRect(80, -110, page.Width, page.Height),
                XStringFormats.Center);

            gfx.DrawString($"Kr.{lease.GetLeaseOrders()[0].deliveryPrice}", companyAndDebtor, XBrushes.Black,
                new XRect(150, -110, page.Width, page.Height),
                XStringFormats.Center);

            gfx.DrawString($"Kr. {lease.GetTotalPrice()}", companyAndDebtor, XBrushes.Black,
                new XRect(-60, -110, page.Width, page.Height),
                XStringFormats.CenterRight);

            gfx.DrawString("___________________________________________________________________________________________ ", smallHeadLine, XBrushes.Black,
                new XRect(80, -100, page.Width, page.Height),
                XStringFormats.CenterLeft);

            //Netto Moms Total + penge + Streg------------------------------------------------------------------------------------------------------------
            gfx.DrawString("Netto: ", companyAndDebtor, XBrushes.Black,
               new XRect(400, -20, page.Width, page.Height),
               XStringFormats.CenterLeft);

            gfx.DrawString("Moms (25%): ", companyAndDebtor, XBrushes.Black,
                new XRect(400, -5, page.Width, page.Height),
                XStringFormats.CenterLeft);

            gfx.DrawString("Total: ", priceFat, XBrushes.Black,
                new XRect(400, 10, page.Width, page.Height),
                XStringFormats.CenterLeft);

            gfx.DrawString($"Kr. {lease.GetTotalPrice()} ", companyAndDebtor, XBrushes.Black, //Kan godt være ate den ikke acceptere denne linje
                new XRect(-60, -20, page.Width, page.Height),
                XStringFormats.CenterRight);

            gfx.DrawString($"Kr. {Moms(lease.GetTotalPrice())} ", companyAndDebtor, XBrushes.Black, //Kan godt være ate den ikke acceptere denne linje
                new XRect(-60, -5, page.Width, page.Height),
                XStringFormats.CenterRight);

            gfx.DrawString($"Kr. {endPrice(Moms(lease.GetTotalPrice()), lease.GetTotalPrice())} ", priceFat, XBrushes.Black,
                new XRect(-60, 10, page.Width, page.Height),
                XStringFormats.CenterRight);

            gfx.DrawString("___________________________ ", smallHeadLine, XBrushes.Black,
                new XRect(400, 15, page.Width, page.Height),
                XStringFormats.CenterLeft);

            //Dette  er til at vælge Navnet på filen
            const string filename = "Fakture.pdf";

            //Dette er til at gemme pdf
            document.Save(filename);

            //Dette er til at vise PDF
            Process.Start(filename);
        }
    }
}
