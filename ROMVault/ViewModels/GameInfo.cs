using ROMVault.Attributes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROMVault.ViewModels
{
    /// <summary>
    /// "ViewModel" used loosely. Really for the property grid operation.
    /// </summary>
    internal class GameInfo : ViewModelBase
    {
        [SortableCategory("General", 10)]
        public string Category { get; set; } = string.Empty;

        [SortableCategory("General", 10)]
        public string CloneOf { get; set; } = string.Empty;

        [SortableCategory("General", 10)]
        public string Description { get; set; } = string.Empty;

        [SortableCategory("General", 10)]
        public string Manufacturer { get; set; } = string.Empty;

        [SortableCategory("General", 10)]
        public string Name { get; set; } = string.Empty;

        [SortableCategory("General", 10)]
        public string RomOf { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        public string TrupipYear { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        public string TruripCloneOf { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        public string TruripDeveloper { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        public string TruripGenre { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        public string TruripID { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        public string TruripPlayers { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        public string TruripPublisher { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        public string TruripRatings { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        public string TruripRelatedTo { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        public string TruripScore { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        public string TruripSource { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        public string TruripSubGenre { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        public string Year { get; set; } = string.Empty;

        public GameInfo()
        {
            Icon = Properties.Resources.discBig;
            Title = "Game and Rom Info";
        }
    }
}