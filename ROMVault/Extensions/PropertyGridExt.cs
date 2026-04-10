using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace ROMVault.Extensions
{
    public static class PropertyGridExt
    {
        public static void SetCategoryForeColor(this PropertyGrid pg, Color color)
        {
            if (pg == null) return;

            // 1. Set the public property (standard behavior)
            pg.CategoryForeColor = color;

            try
            {
                // 2. Get the internal gridView
                var gridViewField = typeof(PropertyGrid).GetField("gridView",
                    BindingFlags.NonPublic | BindingFlags.Instance);
                var gridView = gridViewField?.GetValue(pg);

                if (gridView == null) return;

                // 3. Find the internal color field (Handles .NET Framework AND .NET Core/5+)
                var internalField = gridView.GetType().GetField("categoryForeColor", BindingFlags.NonPublic | BindingFlags.Instance)
                                 ?? gridView.GetType().GetField("_categoryForeColor", BindingFlags.NonPublic | BindingFlags.Instance);

                if (internalField != null)
                {
                    internalField.SetValue(gridView, color);
                }

                // 4. Force the internal brush cache to refresh
                var notifyMethod = gridView.GetType().GetMethod("NotifyPropertiesChanged",
                    BindingFlags.NonPublic | BindingFlags.Instance);
                notifyMethod?.Invoke(gridView, null);

                // 5. THE "NUDGE": Toggling the sort mode forces the grid to
                // completely reconstruct its row collection and apply the new brushes.
                var currentSort = pg.PropertySort;
                pg.PropertySort = PropertySort.Alphabetical;
                pg.PropertySort = currentSort;

                pg.Invalidate(true);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Color Fix Failed: {ex.Message}");
            }
        }
    }
}