using System;
using System.Collections.Generic;
using System.Text;
using RepairWorkBusinessLogic.OfficePackage.HelperEnums;

namespace RepairWorkBusinessLogic.OfficePackage.HelperModels
{
    public class PdfRowParameters
    {
        public List<string> Texts { get; set; }
        public string Style { get; set; }
        public PdfParagraphAlignmentType ParagraphAlignment { get; set; }
    }
}
