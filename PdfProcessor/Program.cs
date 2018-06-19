using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            string pdfDocument = "";
            HighlightCreditAmounts highlightCreditAmounts = new HighlightCreditAmounts();
            highlightCreditAmounts.Highlight(pdfDocument);
        }
    }
}
