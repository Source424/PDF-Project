using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfProcessor
{
    class HighlightStandardBank : IHighlightCredit, IHighlightSalary
    {
        public void HighlightCredit(string document)
        {
            throw new NotImplementedException();
        }

        public void HighlightSalary(string document)
        {
            throw new NotImplementedException();
        }
    }
}
