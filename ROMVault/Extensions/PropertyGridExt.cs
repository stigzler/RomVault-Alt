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

        /// <summary>
        /// Gets the (private) PropertyGridView instance.
        /// </summary>
        /// <param name="propertyGrid">The property grid.</param>
        /// <returns>The PropertyGridView instance.</returns>
        private static object GetPropertyGridView(PropertyGrid propertyGrid)
        {
            //private PropertyGridView GetPropertyGridView();
            //PropertyGridView is an internal class...
            MethodInfo methodInfo = typeof(PropertyGrid).GetMethod("GetPropertyGridView", BindingFlags.NonPublic | BindingFlags.Instance);
            return methodInfo.Invoke(propertyGrid, new object[] { });
        }

        /// <summary>
        /// Gets the width of the left column.
        /// </summary>
        /// <param name="propertyGrid">The property grid.</param>
        /// <returns>
        /// The width of the left column.
        /// </returns>
        public static int GetInternalLabelWidth(this PropertyGrid propertyGrid)
        {
            //System.Windows.Forms.PropertyGridInternal.PropertyGridView
            object gridView = GetPropertyGridView(propertyGrid);

            //protected int InternalLabelWidth
            PropertyInfo propInfo = gridView.GetType().GetProperty("InternalLabelWidth", BindingFlags.NonPublic | BindingFlags.Instance);
            return (int)propInfo.GetValue(gridView);
        }

        /// <summary>
        /// Moves the splitter to the supplied horizontal position.
        /// </summary>
        /// <param name="propertyGrid">The property grid.</param>
        /// <param name="xpos">The horizontal position.</param>
        public static void MoveSplitterTo(this PropertyGrid propertyGrid, int xpos)
        {
            //System.Windows.Forms.PropertyGridInternal.PropertyGridView
            object gridView = GetPropertyGridView(propertyGrid);

            //private void MoveSplitterTo(int xpos);
            MethodInfo methodInfo = gridView.GetType().GetMethod("MoveSplitterTo", BindingFlags.NonPublic | BindingFlags.Instance);
            methodInfo.Invoke(gridView, new object[] { xpos });
        }
    }
}