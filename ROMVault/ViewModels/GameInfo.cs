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
        // Model:
        public string Category { get; set; } = string.Empty;

        public string CloneOf { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string RomOf { get; set; } = string.Empty;
        public string TrupipYear { get; set; } = string.Empty;
        public string TruripCloneOf { get; set; } = string.Empty;
        public string TruripDeveloper { get; set; } = string.Empty;
        public string TruripGenre { get; set; } = string.Empty;
        public string TruripID { get; set; } = string.Empty;
        public string TruripPlayers { get; set; } = string.Empty;
        public string TruripPublisher { get; set; } = string.Empty;
        public string TruripRatings { get; set; } = string.Empty;
        public string TruripRelatedTo { get; set; } = string.Empty;
        public string TruripScore { get; set; } = string.Empty;
        public string TruripSource { get; set; } = string.Empty;
        public string TruripSubGenre { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;

        public GameInfo()
        {
            Icon = Properties.Resources.discBig;
            Title = "Game and Rom Info";
        }
    }
}