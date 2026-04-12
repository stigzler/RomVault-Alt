using ROMVault.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [ReadOnly(true)]
        public string Name { get; set; } = string.Empty;

        [SortableCategory("General", 10)]
        [ReadOnly(true)]
        public string Description { get; set; } = string.Empty;

        [SortableCategory("General", 10)]
        [ReadOnly(true)]
        public string Category { get; set; } = string.Empty;

        [SortableCategory("General", 10)]
        [ReadOnly(true)]
        public string CloneOf { get; set; } = string.Empty;

        [SortableCategory("General", 10)]
        [ReadOnly(true)]
        public string Manufacturer { get; set; } = string.Empty;

        [SortableCategory("General", 10)]
        [ReadOnly(true)]
        public string RomOf { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        [ReadOnly(true)]
        public string TrupipYear { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        [ReadOnly(true)]
        public string TruripCloneOf { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        [ReadOnly(true)]
        public string TruripDeveloper { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        [ReadOnly(true)]
        public string TruripGenre { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        [ReadOnly(true)]
        public string TruripID { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        [ReadOnly(true)]
        public string TruripPlayers { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        [ReadOnly(true)]
        public string TruripPublisher { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        [ReadOnly(true)]
        public string TruripRatings { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        [ReadOnly(true)]
        public string TruripRelatedTo { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        [ReadOnly(true)]
        public string TruripScore { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        [ReadOnly(true)]
        public string TruripSource { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        [ReadOnly(true)]
        public string TruripSubGenre { get; set; } = string.Empty;

        [SortableCategory("Trurip", 15)]
        [ReadOnly(true)]
        public string Year { get; set; } = string.Empty;

        public GameInfo()
        {
            Icon = Properties.Resources.discBig;
            Title = "Game and Rom Info";
        }
    }
}