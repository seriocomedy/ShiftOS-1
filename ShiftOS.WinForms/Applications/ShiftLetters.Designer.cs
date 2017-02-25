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

namespace ShiftOS.WinForms.Applications
{
    partial class ShiftLetters
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblword = new System.Windows.Forms.Label();
            this.tbguess = new System.Windows.Forms.TextBox();
            this.lbllives = new System.Windows.Forms.Label();
            this.btnrestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblword
            // 
            this.lblword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblword.AutoSize = true;
            this.lblword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblword.Location = new System.Drawing.Point(116, 34);
            this.lblword.Name = "lblword";
            this.lblword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblword.Size = new System.Drawing.Size(89, 22);
            this.lblword.TabIndex = 1;
            this.lblword.Text = "Loading...";
            // 
            // tbguess
            // 
            this.tbguess.Location = new System.Drawing.Point(147, 108);
            this.tbguess.Name = "tbguess";
            this.tbguess.Size = new System.Drawing.Size(22, 20);
            this.tbguess.TabIndex = 2;
            this.tbguess.TextChanged += new System.EventHandler(this.tbguess_TextChanged);
            // 
            // lbllives
            // 
            this.lbllives.AutoSize = true;
            this.lbllives.Location = new System.Drawing.Point(127, 190);
            this.lbllives.Name = "lbllives";
            this.lbllives.Size = new System.Drawing.Size(69, 13);
            this.lbllives.TabIndex = 3;
            this.lbllives.Text = "Still loading...";
            // 
            // btnrestart
            // 
            this.btnrestart.Location = new System.Drawing.Point(130, 148);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(75, 23);
            this.btnrestart.TabIndex = 4;
            this.btnrestart.Text = "Restart";
            this.btnrestart.UseVisualStyleBackColor = true;
            this.btnrestart.Visible = false;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // ShiftLetters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnrestart);
            this.Controls.Add(this.lbllives);
            this.Controls.Add(this.tbguess);
            this.Controls.Add(this.lblword);
            this.Name = "ShiftLetters";
            this.Size = new System.Drawing.Size(333, 256);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblword;
        private System.Windows.Forms.TextBox tbguess;
        private System.Windows.Forms.Label lbllives;
        private System.Windows.Forms.Button btnrestart;
    }
}
