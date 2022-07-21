using System;
using System.Collections.Generic;
using System.Text;
using RepairWorkBusinessLogic.OfficePackage.HelperEnums;
using RepairWorkBusinessLogic.OfficePackage.HelperModels;

namespace RepairWorkBusinessLogic.OfficePackage
{
    public abstract class AbstractSaveToWord
    {
        public void CreateDoc(WordInfo info)
        {
            CreateWord(info);
            CreateParagraph(new WordParagraph
            {
                Texts = new List<(string, WordTextProperties)> { (info.Title, new WordTextProperties { Bold = true, Size = "24", }) },
                TextProperties = new WordTextProperties
                {
                    Size = "24",
                    JustificationType = WordJustificationType.Center
                }
            });
            foreach (var repair in info.Repairs)
            {
                CreateParagraph(new WordParagraph
                {
                    Texts = new List<(string, WordTextProperties)> {
                        (repair.RepairName + ": ", new WordTextProperties {Size = "24", Bold = true}),
                        (Convert.ToInt32(repair.Price).ToString(), new WordTextProperties {
                        Size = "24"
                        })
                    },
                    TextProperties = new WordTextProperties
                    {
                        Size = "24",
                        JustificationType = WordJustificationType.Both
                    }
                });
            }
            SaveWord(info);
        }
        protected abstract void CreateWord(WordInfo info);
        protected abstract void CreateParagraph(WordParagraph paragraph);
        protected abstract void SaveWord(WordInfo info);
    }
}
