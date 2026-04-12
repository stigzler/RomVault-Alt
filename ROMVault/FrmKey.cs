/******************************************************
 *     ROMVault3 is written by Gordon J.              *
 *     Contact gordon@romvault.com                    *
 *     Copyright 2025                                 *
 ******************************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ROMVault.UserControls;
using RomVaultCore;

namespace ROMVault
{
    public partial class FrmKey : Form
    {
        public FrmKey()
        {
            InitializeComponent();
        }

        private int height = 0;

        private void AddLabel(string name, string text)
        {
            FlexiLabel label = new FlexiLabel
            {
                Font = new Font("Roboto", this.Font.Size, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                Name = name,
                Text = text,
                AutoSize = true,
                Padding = new Padding(4, 4, 4, 4)

                //Dock = DockStyle.Fill
            };
            this.Controls.Add(label);
            label.Dock = DockStyle.Bottom;
            height += label.Height;
        }

        private void FrmKey_Load(object sender, EventArgs e)
        {
            Dark.dark.SetColors(this, Settings.rvSettings.Darkness);
            Helpers.Theming.SetFormTextSizeToDefault(this);

            List<RepStatus> displayList = new List<RepStatus>
            {
                RepStatus.Correct,
                RepStatus.CorrectMIA,
                RepStatus.Missing,
                RepStatus.MissingMIA,
                RepStatus.Unknown,
                RepStatus.UnNeeded,
                RepStatus.NotCollected,
                RepStatus.InToSort,
                RepStatus.Ignore,

                RepStatus.CanBeFixed,
                RepStatus.CanBeFixedMIA,
                RepStatus.NeededForFix,
                RepStatus.Rename,
                RepStatus.MoveToSort,
                RepStatus.Incomplete,
                RepStatus.Delete,

                RepStatus.Corrupt,
                RepStatus.UnScanned,
            };

            this.Width = 590;

            this.SuspendLayout();

            //Height = displayList.Count * 46 + 110;
            AddLabel("LabelBasic", "Basic Statuses");

            for (int i = 0; i < displayList.Count; i++)
            {
                if (i == 9)
                {
                    AddLabel("LabelFix", "Fix Statuses");
                }

                if (i == 16)
                {
                    AddLabel("LabelProblem", "Problem Statuses");
                }
                PictureBox pictureBox = new PictureBox
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Name = "pictureBox" + i,
                    Size = new Size(48, 48),
                    SizeMode = PictureBoxSizeMode.Zoom
                    //  BackColor = Color.Red,
                };

                //Controls.Add(pictureBox);

                pictureBox.Image = rvImages.GetBitmap("G_" + displayList[i]);

                FlexiLabel label = new FlexiLabel
                {
                    Font = this.Font,
                    BackColor = Color.FromArgb(20, 0, 0, 0),
                    ScaleFactor = 0.8,
                    Padding = new Padding(2, 2, 2, 2),
                    //BorderStyle = BorderStyle.FixedSingle,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Name = "label" + i,
                };

                string text;
                switch (displayList[i])
                {
                    case RepStatus.Missing:
                        text = "Red - This ROM is missing.";
                        break;

                    case RepStatus.MissingMIA:
                        text = "Salmon - This ROM is known to be private or missing in action (MIA).";
                        break;

                    case RepStatus.Correct:
                        text = "Green - This ROM is Correct.";
                        break;

                    case RepStatus.CorrectMIA:
                        text = "SuperGreen - The ROM was known to be MIA (Missing In Action), but you found it. (Good Job!)";
                        break;

                    case RepStatus.NotCollected:
                        text = "Gray - The ROM is not collected here because it belongs in the parent or primary deduped set.";
                        break;

                    case RepStatus.UnNeeded:
                        text = "Light Cyan - The ROM is not needed here because it belongs in the parent or primary deduped set.";
                        break;

                    case RepStatus.Unknown:
                        text = "Cyan - The ROM is not needed here. Use 'Find Fixes' to see what should be done with the ROM.";
                        break;

                    case RepStatus.InToSort:
                        text = "Magenta - The ROM is in a ToSort directory.";
                        break;

                    case RepStatus.Corrupt:
                        text = "Red - This file is corrupt.";
                        break;

                    case RepStatus.UnScanned:
                        text = "Blue - The file could not be scanned. The file could be locked or have incompatible permissions.";
                        break;

                    case RepStatus.Ignore:
                        text = "GreyBlue - The file matches an ignore rule.";
                        break;

                    case RepStatus.CanBeFixed:
                        text = "Yellow - The ROM is missing here, but it's available elsewhere. The ROM will be fixed.";
                        break;

                    case RepStatus.CanBeFixedMIA:
                        text = "SuperYellow - The MIA ROM is missing here, but it's available elsewhere. The ROM will be fixed.";
                        break;

                    case RepStatus.MoveToSort:
                        text = "Purple - The ROM is not needed here, but a copy isn't located elsewhere. The ROM will be moved to the Primary ToSort.";
                        break;

                    case RepStatus.Delete:
                        text = "Brown - The ROM is not needed here, but a copy is located elsewhere. The ROM will be deleted.";
                        break;

                    case RepStatus.NeededForFix:
                        text = "Orange - The ROM is not needed here, but it's needed elsewhere. The ROM will be moved.";
                        break;

                    case RepStatus.Rename:
                        text = "Light Orange - The ROM is needed here, but has the incorrect name. The ROM will be renamed.";
                        break;

                    case RepStatus.Incomplete:
                        text = "Pink - This is a ROM that could be fixed, but will not be because it is part of an incomplete set.";
                        break;

                    default:
                        text = "";
                        break;
                }

                label.Text = text;

                Panel rowPanel = new Panel
                {
                    // BackColor = Color.DarkBlue,
                    // BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(54, 50),
                    Padding = new Padding(2, 2, 2, 2)
                };

                rowPanel.Controls.Add(label);
                label.Dock = DockStyle.Fill;

                rowPanel.Controls.Add(pictureBox);
                pictureBox.Dock = DockStyle.Left;

                this.Controls.Add(rowPanel);
                rowPanel.Dock = DockStyle.Bottom;

                height += rowPanel.Height;
            }

            //for (int i = this.Controls.Count; i == 0; i--)
            //{
            //    this.Controls[i].Dock = DockStyle.Top;
            //}

            this.Height = height + this.Padding.Vertical + 40;

            this.ResumeLayout();
        }
    }
}