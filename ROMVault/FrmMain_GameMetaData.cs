using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using RomVaultCore;
using RomVaultCore.RvDB;
using RVIO;

namespace ROMVault
{
    public partial class FrmMain
    {
        private void AddTextBox(int line, string name, int x, int x1, out Label lBox, out TextBox tBox)
        {
            int y = 14 + line * 16;

            lBox = new Label
            {
                Location = SPoint(x, y + 1),
                Size = SSize(x1 - x - 2, 13),
                Text = name + @" :",
                TextAlign = ContentAlignment.TopRight,
                Tag = "trans"
            };
            tBox = new TextBox
            {
                AutoSize = false,
                Location = SPoint(x1, y),
                Size = SSize(20, 17),
                BorderStyle = BorderStyle.FixedSingle,
                ReadOnly = true,
                TabStop = false,
                Tag = "trans"
            };
            //gbSetInfo.Controls.Add(lBox);
            //gbSetInfo.Controls.Add(tBox);
        }

        private Point SPoint(int x, int y)
        {
            return new Point((int)(x * _scaleFactorX), (int)(y * _scaleFactorY));
        }

        private Size SSize(int x, int y)
        {
            return new Size((int)(x * _scaleFactorX), (int)(y * _scaleFactorY));
        }

        private void AddGameMetaData()
        {
            UpdateGameMetaData(new RvFile(FileType.Dir));
        }

        private void UpdateGameInfoControls()
        {
            MainPG.SelectedObject = GameInfo;
        }

        private void UpdateGameMetaData(RvFile tGame)
        {
            GameInfo = new ViewModels.GameInfo();

            GameInfo.Name = tGame.Name;
            string gameId = tGame.Game?.GetData(RvGame.GameData.Id);

            if (!string.IsNullOrWhiteSpace(gameId))
                GameInfo.Name += $" (ID:{gameId})";

            if (tGame.Game != null)
            {
                if (tGame.Game.GetData(RvGame.GameData.EmuArc) == "yes")
                {
                    string desc = tGame.Game.GetData(RvGame.GameData.Description);
                    if (desc == "¤") desc = Path.GetFileNameWithoutExtension(tGame.Name);
                    GameInfo.Description = desc;

                    GameInfo.TruripPublisher = tGame.Game.GetData(RvGame.GameData.Publisher);

                    GameInfo.TruripDeveloper = tGame.Game.GetData(RvGame.GameData.Developer);

                    GameInfo.TruripID = tGame.Game.GetData(RvGame.GameData.Id);

                    GameInfo.TruripSource = tGame.Game.GetData(RvGame.GameData.Source);

                    GameInfo.CloneOf = tGame.Game.GetData(RvGame.GameData.CloneOf);

                    GameInfo.TruripRelatedTo = tGame.Game.GetData(RvGame.GameData.RelatedTo);

                    GameInfo.TrupipYear = tGame.Game.GetData(RvGame.GameData.Year);

                    GameInfo.TruripPlayers = tGame.Game.GetData(RvGame.GameData.Players);

                    GameInfo.TruripGenre = tGame.Game.GetData(RvGame.GameData.Genre);

                    GameInfo.TruripSubGenre = tGame.Game.GetData(RvGame.GameData.SubGenre);

                    GameInfo.TruripRatings = tGame.Game.GetData(RvGame.GameData.Ratings);

                    GameInfo.TruripScore = tGame.Game.GetData(RvGame.GameData.Score);

                    LoadTruRipPannel(tGame);
                }
                else
                {
                    bool found = false;
                    string path = tGame.Parent.DatTreeFullName;
                    foreach (EmulatorInfo ei in Settings.rvSettings.EInfo)
                    {
                        if (path.Length <= 8)
                            continue;

                        if (!string.Equals(path.Substring(8), ei.TreeDir, StringComparison.CurrentCultureIgnoreCase))
                            continue;

                        if (string.IsNullOrWhiteSpace(ei.ExtraPath))
                            continue;

                        if (ei.ExtraPath != null)
                        {
                            found = true;
                            if (ei.ExtraPath.Substring(0, 1) == "%")
                                LoadMameSLPannels(tGame, ei.ExtraPath.Substring(1));
                            else
                                LoadMamePannels(tGame, ei.ExtraPath);

                            break;
                        }
                    }

                    if (!found)
                        found = LoadNFOPannel(tGame);

                    if (!found)
                        found = LoadC64Pannel(tGame);

                    if (!found)
                        HidePannel();

                    string desc = tGame.Game.GetData(RvGame.GameData.Description);
                    if (desc == "¤") desc = Path.GetFileNameWithoutExtension(tGame.Name);
                    GameInfo.Description = desc;

                    GameInfo.Manufacturer = tGame.Game.GetData(RvGame.GameData.Manufacturer);

                    GameInfo.CloneOf = tGame.Game.GetData(RvGame.GameData.CloneOf);

                    GameInfo.RomOf = tGame.Game.GetData(RvGame.GameData.RomOf);

                    GameInfo.Year = tGame.Game.GetData(RvGame.GameData.Year);

                    GameInfo.Category = tGame.Game.GetData(RvGame.GameData.Category);
                }
            }
            else
            {
                HidePannel();
            }

            this.ActiveControl = GameGrid;

            UpdateGameInfoControls();
        }
    }
}