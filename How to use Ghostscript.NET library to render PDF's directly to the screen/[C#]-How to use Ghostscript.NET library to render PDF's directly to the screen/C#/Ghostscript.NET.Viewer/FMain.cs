﻿//
// FMain.cs
// This file is part of Ghostscript.NET.Viewer project
//
// Author: Josip Habjan (habjan@gmail.com, http://www.linkedin.com/in/habjan) 
// Copyright (c) 2013 Josip Habjan. All rights reserved.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Ghostscript.NET.Viewer;

namespace Ghostscript.NET.Viewer
{
    public partial class FMain : Form
    {
        private GhostscriptViewer _viewer;
        private GhostscriptVersionInfo _gsVersion = GhostscriptVersionInfo.GetLastInstalledVersion(GhostscriptLicense.GPL | GhostscriptLicense.AFPL, GhostscriptLicense.GPL);

        public FMain()
        {
            InitializeComponent();

            this.Text = Program.NAME;

            pbPage.Width = 100;
            pbPage.Height = 100;

            _viewer = new GhostscriptViewer();

            _viewer.DisplaySize += new GhostscriptViewerViewEventHandler(_viewer_DisplaySize);
            _viewer.DisplayUpdate += new GhostscriptViewerViewEventHandler(_viewer_DisplayUpdate);
            _viewer.DisplayPage += new GhostscriptViewerViewEventHandler(_viewer_DisplayPage);
        }

        void _viewer_DisplaySize(object sender, GhostscriptViewerViewEventArgs e)
        {
            pbPage.Image = e.Image;
        }

        void _viewer_DisplayUpdate(object sender, GhostscriptViewerViewEventArgs e)
        {
            pbPage.Invalidate();
            pbPage.Update();
        }

        void _viewer_DisplayPage(object sender, GhostscriptViewerViewEventArgs e)
        {
            pbPage.Invalidate();
            pbPage.Update();

            tbPageNumber.Text = _viewer.CurrentPageNumber.ToString();
            tbTotalPages.Text = " / " + _viewer.LastPageNumber.ToString();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            lblSystemInformation.Text = "Operating system: " + (Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit") + "   " +
                "Process: " + (Environment.Is64BitProcess ? "64-bit" : "32-bit");

            lblGsVersion.Text = "Rasterizer: " + _gsVersion.LicenseType.ToString() + " Ghostscript " + 
                _gsVersion.Version.ToString() + " (" + Path.GetFileName(_gsVersion.DllPath) + ")";
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open PDF file";
            ofd.Filter = "PDF, PS files|*.pdf;*.ps";

            if (ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                mnuFileClose_Click(this, null);

                _viewer.Open(ofd.FileName, _gsVersion, false);
                this.Text = System.IO.Path.GetFileName(ofd.FileName) + " - " + Program.NAME;
            }
        }

        private void mnuFileClose_Click(object sender, EventArgs e)
        {
            _viewer.Close();
            pbPage.Image = null;
            this.Text = Program.NAME;
            tbPageNumber.Text = string.Empty;
            tbTotalPages.Text = string.Empty;
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void tbPageFirst_Click(object sender, EventArgs e)
        {
            _viewer.ShowFirstPage();
        }

        private void tbPagePrevious_Click(object sender, EventArgs e)
        {
            _viewer.ShowPreviousPage();
        }

        private void tbPageNext_Click(object sender, EventArgs e)
        {
            _viewer.ShowNextPage();
        }

        private void tbPageLast_Click(object sender, EventArgs e)
        {
            _viewer.ShowLastPage();
        }

        private void tbPageNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbPageNumber.Text.Length > 0)
                {
                    _viewer.ShowPage(int.Parse(tbPageNumber.Text));
                }
            }
            catch (Exception ex) { }
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Powered by Ghostscript.NET & Josip Habjan (habjan@gmail.com)", "About " + Program.NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuNext_Click(object sender, EventArgs e)
        {
            _viewer.ShowNextPage();
        }

        private void mnuPrev_Click(object sender, EventArgs e)
        {
            _viewer.ShowPreviousPage();
        }

        private void mnuFirst_Click(object sender, EventArgs e)
        {
            _viewer.ShowFirstPage();
        }

        private void mnuLast_Click(object sender, EventArgs e)
        {
            _viewer.ShowLastPage();
        }

        private void tpZoomIn_Click(object sender, EventArgs e)
        {
            _viewer.ZoomIn();
        }

        private void tpZoomOut_Click(object sender, EventArgs e)
        {
            _viewer.ZoomOut();
        }
    }
}
