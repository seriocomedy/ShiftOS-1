﻿/*
 * MIT License
 * 
 * Copyright (c) 2017 Michael VanOverbeek and ShiftOS devs
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShiftOS.Engine;

namespace ShiftOS.WinForms.Applications
{
    [Launcher("ShiftLotto", true, "al_shiftlotto", "Games")]
    [RequiresUpgrade("shiftlotto")]
    [WinOpen("shiftlotto")]
    public partial class ShiftLotto : UserControl, IShiftOSWindow
    {
        public ShiftLotto()
        {
            InitializeComponent();
        }

        public void OnLoad()
        {
            timer1.Start();
        }
        

        public void OnSkinLoad()
        {
            
        }

        public bool OnUnload()
        {
            return true;
        }

        public void OnUpgrade()
        {
            
        }

        // The Dynamic Display
        private void timer1_Tick(object sender, EventArgs e)
        {
            int codePoints = Convert.ToInt32(Math.Round(cpUpDown.Value, 0));
            int difficulty = Convert.ToInt32(Math.Round(difUpDown.Value, 0));
            label5.Text = codePoints * difficulty + " CP";
            label7.Text = "Current CP: " + SaveSystem.CurrentSave.Codepoints.ToString() + " CP";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Convert the NumericUpDown to Int
            int codePoints = Convert.ToInt32(Math.Round(cpUpDown.Value, 0));
            int difficulty = Convert.ToInt32(Math.Round(difUpDown.Value, 0));

            // Create Random Ints
            Random rnd = new Random();

            // Set their highest possible number to Difficulty
            int guessedNumber = rnd.Next(0, difficulty);
            int winningNumber = rnd.Next(0, difficulty);

            // Multiply CodePoints * Difficulty
            int jackpot = codePoints * difficulty;

            // Test the random ints
            if (guessedNumber == winningNumber)
            {
                // If you win

                // Add Codepoints
                SaveSystem.TransferCodepointsFrom("shiftlotto", jackpot);

                // Infobox
                Infobox.Show("YOU WON!", "Good Job! " + jackpot.ToString() + " CP has been added to your account. ");
            }
            else
            {
                // If you fail

                // Remove Codepoints
                SaveSystem.TransferCodepointsToVoid(jackpot);

                // Infobox
                Infobox.Show("YOU FAILED!", "Sorry! " + jackpot.ToString() + " CP has been removed from your account.");
            }
        }
    }
}