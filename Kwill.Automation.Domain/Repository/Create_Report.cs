using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;

namespace Kwill.Automation.Domain.Repository
{
    public class Create_Report
    {
        //Create Document
        readonly Document document = new Document();

        //Create Font
        readonly Font TitleFont = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 24, Font.BOLD, BaseColor.GRAY);
        readonly Font TextFont = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, Font.BOLD, BaseColor.BLACK);
        readonly Font ResultFont = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 18, Font.BOLD, BaseColor.RED);

        public void CreateRepor(string Title, string menssage, string imageURL)
        {
            //Get Document
            PdfWriter.GetInstance(document, new FileStream(
                @"C:\Users\josealbertolagos\source\repos\Kwill\Kwill.Automation.Test\bin\Debug\netcoreapp3.1\ReportKwill.pdf",
                FileMode.OpenOrCreate));

            document.NewPage();

            //Add Infotmation
            document.Add(new Paragraph("Date: " + DateTime.Now.ToString()));
            document.Add(new Paragraph("Create by: AutomationTest"));
            document.Add(Chunk.NEWLINE);
            document.Add(Chunk.NEWLINE);
            document.Add(new Paragraph(Title.Replace("_", " "), TitleFont));
            document.Add(Chunk.NEWLINE);
            document.Add(new Paragraph(menssage, TextFont));
            document.Add(Chunk.NEWLINE);

            //Configurate  imagen position
            Image imagen = Image.GetInstance(@".\" + imageURL);
            imagen.BorderWidth = 1;
            imagen.Alignment = Element.ALIGN_LEFT;
            imagen.ScalePercent(500 / imagen.Width * 100);

            //Add imagen
            document.Add(imagen);
            document.Add(Chunk.NEWLINE);

            //Add result
            document.Add(new Paragraph("TEST RESULT : FAIL ❌", ResultFont));
            document.Add(Chunk.NEXTPAGE);

            //Close Document
            document.Close();

        }

      
    }
}

