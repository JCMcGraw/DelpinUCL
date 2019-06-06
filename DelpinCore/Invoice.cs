using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Drawing;//Denne skal bruges
using PdfSharp.Pdf;//Denne skal bruges
using System.Diagnostics;//Denne skal bruges


namespace DelpinCore
{
    class Invoice
    {
        public decimal Moms(decimal totalPrice)
        {
            decimal momsPrice = (totalPrice * 1.25m)-totalPrice;
            return Math.Round(momsPrice,2);
        }

        //Slutprisen ink moms
        public decimal endPrice(decimal totalPrice,decimal momsPrice)
        {
            decimal endPrice= totalPrice + momsPrice;
            return Math.Round(endPrice,2);
        }

        public string MakePDF(Lease lease, Business business)
        {
            // Her bruges classen pdfDocument.
            PdfDocument document = new PdfDocument();

            // Her laver jeg et pdf dokument og kalder det Faktura
            document.Info.Title = "Faktura";

            // Her laves en side
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Opret skrift størelse og sill
            XFont companyAndDebtor = new XFont("Calibri", 10, XFontStyle.Regular);
            XFont fakture = new XFont("Calibri", 20, XFontStyle.Bold);
            XFont smallHeadLine = new XFont("Calibri", 10, XFontStyle.Bold);
            XFont priceFat = new XFont("Calibri", 10, XFontStyle.Bold);

            // Draw the text. Dette er hvad der skal være på teksten, og hvor det skal være. Der kan laves lige så mange som man vil 
            //Kunde Oplysninger------------------------------------------------------------------------------------------------------------------------------
            
                gfx.DrawString($"{business.companyName}", companyAndDebtor, XBrushes.Black,
                    new XRect(80, -270, page.Width, page.Height),
                    XStringFormats.CenterLeft);

                gfx.DrawString($"{business.street}", companyAndDebtor, XBrushes.Black,
                    new XRect(80, -260, page.Width, page.Height),
                    XStringFormats.CenterLeft);

                gfx.DrawString($"{business.postalCode} {business.city}", companyAndDebtor, XBrushes.Black,
                    new XRect(80, -250, page.Width, page.Height),
                    XStringFormats.CenterLeft);

                gfx.DrawString($"Kunde Nr: {lease.debtorID}", companyAndDebtor, XBrushes.Black,
                    new XRect(80, -230, page.Width, page.Height),
                    XStringFormats.CenterLeft);
            
            //FAKTURA---------------------------------------------------------------------------------------------------------------------------------------
            gfx.DrawString("FAKTURA", fakture, XBrushes.Black,
                new XRect(80, -170, page.Width, page.Height),
                XStringFormats.CenterLeft);

            //Billede af Delpin----------------------------------------------------------------------------------------------------------------------------
            var image = DelpinCore.Properties.Resources.Delpinlogo;
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            image.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);

            XImage xImage = XImage.FromStream(stream);
            gfx.DrawImage(xImage, 405, 35);

            //Firma informationer----------------------------------------------------------------------------------------------------------------------------
            gfx.DrawString("Nordvesthavnsvej 60 ", companyAndDebtor, XBrushes.Black,
                new XRect(-60, -300, page.Width, page.Height),
                XStringFormats.CenterRight);

            gfx.DrawString("6400 Sønderborg ", companyAndDebtor, XBrushes.Black,
                new XRect(-60, -290, page.Width, page.Height),
                XStringFormats.CenterRight);

            gfx.DrawString("Tlf 74 48 88 88 ", companyAndDebtor, XBrushes.Black,
                new XRect(-60, -280, page.Width, page.Height),
                XStringFormats.CenterRight);

            //BankOplysninger------------------------------------------------------------------------------------------------------------------------------
            gfx.DrawString("Bank ", companyAndDebtor, XBrushes.Black,
                new XRect(-60, -250, page.Width, page.Height),
                XStringFormats.CenterRight);

            gfx.DrawString("Reg. Nr:9735 ", companyAndDebtor, XBrushes.Black,
                new XRect(-60, -240, page.Width, page.Height),
                XStringFormats.CenterRight);

            gfx.DrawString("Konto Nr:4571973602842330 ", companyAndDebtor, XBrushes.Black,
                new XRect(-60, -230, page.Width, page.Height),
                XStringFormats.CenterRight);

            //Fakture Nr dato og betalings dato------------------------------------------------------------------------------------------------------------
            gfx.DrawString($"Faktura Nr.{lease.leaseID} ", companyAndDebtor, XBrushes.Black,
                new XRect(-60, -180, page.Width, page.Height),
                XStringFormats.CenterRight);

            gfx.DrawString($"{lease.dateCreated.ToShortDateString()} ", companyAndDebtor, XBrushes.Black,
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

            //Her oprettes en variabel som sættes til 0
            int lineSpace = 0;

            for (int i = 0; i < lease.GetLeaseOrders().Count; i++)
            {
                //Her bliver Variablen sat til 15. så hver gange der bliver kørt GetLeaseOrders(tilføjet en ny vare linje bliver der pludset 15 til y aksens position)
                lineSpace = 15 * i;

                gfx.DrawString($"{lease.GetLeaseOrders()[i].modelName}", companyAndDebtor, XBrushes.Black,
                new XRect(80, -110+lineSpace, page.Width, page.Height),
                XStringFormats.CenterLeft);

                gfx.DrawString($"{lease.GetLeaseOrders()[i].GetDaysRented()}", companyAndDebtor, XBrushes.Black,
                    new XRect(0, -110+lineSpace, page.Width, page.Height),
                    XStringFormats.Center);

                gfx.DrawString($"Kr. {lease.GetLeaseOrders()[i].leasePrice} ", companyAndDebtor, XBrushes.Black,
                    new XRect(80, -110+lineSpace, page.Width, page.Height),
                    XStringFormats.Center);

                gfx.DrawString($"Kr. {lease.GetLeaseOrders()[i].deliveryPrice}", companyAndDebtor, XBrushes.Black,
                    new XRect(150, -110+lineSpace, page.Width, page.Height),
                    XStringFormats.Center);

                gfx.DrawString($"Kr. {lease.GetLeaseOrders()[i].GetTotalPrice()}", companyAndDebtor, XBrushes.Black,
                    new XRect(-60, -110+lineSpace, page.Width, page.Height),
                    XStringFormats.CenterRight);
            }

            gfx.DrawString("___________________________________________________________________________________________ ", smallHeadLine, XBrushes.Black,
                new XRect(80, -100+lineSpace, page.Width, page.Height),
                XStringFormats.CenterLeft);

            //Hvis det er erhvers person
            if (business.CVR.Length == 8)
            {
                gfx.DrawString("Total: ", priceFat, XBrushes.Black,
                    new XRect(400, -20 + lineSpace, page.Width, page.Height),
                    XStringFormats.CenterLeft);

                gfx.DrawString($"Kr. {lease.GetTotalPrice()} ", companyAndDebtor, XBrushes.Black,
                    new XRect(-60, -20 + lineSpace, page.Width, page.Height),
                    XStringFormats.CenterRight);

                gfx.DrawString("___________________________ ", smallHeadLine, XBrushes.Black,
                    new XRect(400, -15 + lineSpace, page.Width, page.Height),
                    XStringFormats.CenterLeft);
            }

            //Hvis det er Privat person
            else
            {
                gfx.DrawString("Netto: ", companyAndDebtor, XBrushes.Black,
               new XRect(400, -20 + lineSpace, page.Width, page.Height),
               XStringFormats.CenterLeft);

                gfx.DrawString("Moms (25%): ", companyAndDebtor, XBrushes.Black,
                    new XRect(400, -5 + lineSpace, page.Width, page.Height),
                    XStringFormats.CenterLeft);

                gfx.DrawString("Total: ", priceFat, XBrushes.Black,
                    new XRect(400, 10 + lineSpace, page.Width, page.Height),
                    XStringFormats.CenterLeft);

                gfx.DrawString($"Kr. {lease.GetTotalPrice()} ", companyAndDebtor, XBrushes.Black,
                    new XRect(-60, -20 + lineSpace, page.Width, page.Height),
                    XStringFormats.CenterRight);

                gfx.DrawString($"Kr. {Moms(lease.GetTotalPrice())} ", companyAndDebtor, XBrushes.Black,
                    new XRect(-60, -5 + lineSpace, page.Width, page.Height),
                    XStringFormats.CenterRight);

                gfx.DrawString($"Kr. {endPrice(Moms(lease.GetTotalPrice()), lease.GetTotalPrice())} ", priceFat, XBrushes.Black,
                    new XRect(-60, 10 + lineSpace, page.Width, page.Height),
                    XStringFormats.CenterRight);

                gfx.DrawString("___________________________ ", smallHeadLine, XBrushes.Black,
                    new XRect(400, 15 + lineSpace, page.Width, page.Height),
                    XStringFormats.CenterLeft);
            }
            
            //Her Laves navnet på filen
            string filename = $"Faktura{lease.leaseID}.pdf";

            try
            {
                //Dette er til at gemme pdf
                document.Save(filename);
            }
            catch (Exception)
            {
                return "Filen kan ikke gemmes";
            }
            
            //Dette er til at vise PDF
            Process.Start(filename);
            return "Success";
        }
    }
}
