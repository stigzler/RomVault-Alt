using System.ComponentModel;

namespace ROMVault.Attributes
{
    internal class SortableCategory : CategoryAttribute
    {
        private const char NonPrintableChar = '\r';

        public SortableCategory(string category, ushort categoryPosition, ushort maxCategories = 100) :
            base(category.PadLeft(category.Length + (maxCategories - categoryPosition), SortableCategory.NonPrintableChar))
        {
        }
    }
}