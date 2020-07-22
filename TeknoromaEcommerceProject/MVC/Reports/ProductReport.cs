using DAL.Entity;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Hosting;
using Syncfusion.Drawing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Threading.Tasks;

namespace MVC.Reports
{
    public class ProductReport
    {
        private IWebHostEnvironment _oHostEnvironment;
        public ProductReport(IWebHostEnvironment ohostEnviroment)
        {
            _oHostEnvironment = ohostEnviroment;
        }
        int _maxColumn = 3;
        Document document;
        iTextSharp.text.Font font;
        PdfPTable pdfPTable = new PdfPTable(3);
        PdfPCell _pdfCell;
        MemoryStream _memorystream = new MemoryStream();
        List<Product> products = new List<Product>();
        public byte[] Report(List<Product> _products)
        {
            products = _products;
            document = new Document(PageSize.A4,0f,0f,0f,0f);
            document.SetPageSize(PageSize.A4);
            document.SetMargins(5f, 5f, 20f, 5f);
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            font = FontFactory.GetFont("Tahoma", 8f, 1);
            PdfWriter pdfWriter = PdfWriter.GetInstance(document, _memorystream);
            document.Open();
            float[] sizes = new float[_maxColumn];
            for (int i = 0; i < _maxColumn; i++)
            {
                if (i == 0) sizes[i] = 20;
                else sizes[i] = 100;
            }
            pdfPTable.SetWidths(sizes);
            
            this.Reportbody();
            pdfPTable.HeaderRows = 2;
            document.Add(pdfPTable);
            document.Close();
            return _memorystream.ToArray();

        }

        private void Reportbody()
        {

            var fontstyleBold = FontFactory.GetFont("Tahoma", 9f, 1);
            font=FontFactory.GetFont("Tahoma", 9f, 0);
            foreach (var item in products)
            {
                _pdfCell = new PdfPCell(new Phrase(item.ProductName, fontstyleBold));
                _pdfCell.BackgroundColor = BaseColor.GRAY;
                pdfPTable.AddCell(_pdfCell);
                pdfPTable.CompleteRow();
            }
            
        }
        //private void ReportHeader()
        //{
        //    _pdfCell = new PdfPCell(this.AddLogo());
        //    _pdfCell.Colspan = 1;
        //    _pdfCell.Border = 0;
        //    pdfPTable.AddCell(_pdfCell);

        //    _pdfCell = new PdfPCell(this.SetPageTitle());
        //    _pdfCell.Colspan = _maxColumn - 1;
        //    _pdfCell.Border = 0;
        //    pdfPTable.AddCell(_pdfCell);

        //    pdfPTable.CompleteRow();
        //}

    }
}
