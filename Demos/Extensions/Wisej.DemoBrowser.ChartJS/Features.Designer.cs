﻿namespace Wisej.DemoBrowser.ChartJS
{
    partial class Features
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

        #region Wisej Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chartJS1 = new Wisej.Web.Ext.ChartJS.ChartJS();
            this.chartJS2 = new Wisej.Web.Ext.ChartJS.ChartJS();
            this.chartJS4 = new Wisej.Web.Ext.ChartJS.ChartJS();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartJS1
            // 
            this.chartJS1.Anchor = Wisej.Web.AnchorStyles.None;
            this.chartJS1.AppearanceKey = "chartjs";
            this.chartJS1.BackColor = System.Drawing.Color.White;
            this.chartJS1.BorderStyle = Wisej.Web.BorderStyle.Dotted;
            this.chartJS1.CssStyle = "border-radius: 8px;\r\nbox-shadow: rgba(0, 0, 0, 0.16) 0px 1px 4px;";
            this.flowLayoutPanel1.SetFillWeight(this.chartJS1, 1);
            this.chartJS1.Labels = new string[] {
        "Jan",
        "Feb",
        "Mar",
        "Apr",
        "May",
        "Jun",
        "Jul",
        "Aug",
        "Sep",
        "Oct",
        "Nov",
        "Dec"};
            this.chartJS1.Location = new System.Drawing.Point(450, 10);
            this.chartJS1.Margin = new Wisej.Web.Padding(10);
            this.chartJS1.MinimumSize = new System.Drawing.Size(225, 0);
            this.chartJS1.Name = "chartJS1";
            this.chartJS1.Options.DataLabel.BackgroundColor = System.Drawing.Color.Empty;
            this.chartJS1.Options.DataLabel.BorderColor = System.Drawing.Color.Empty;
            this.chartJS1.Options.DataLabel.Color = System.Drawing.Color.Black;
            this.chartJS1.Options.DataLabel.Opacity = 1F;
            this.chartJS1.Options.DataLabel.TextAlign = Wisej.Web.Ext.ChartJS.DataLabelTextAlignment.Start;
            this.chartJS1.Options.DataLabel.TextShadowColor = System.Drawing.Color.Empty;
            this.chartJS1.Options.DataLabel.TextStrokeColor = System.Drawing.Color.Empty;
            this.chartJS1.Options.Legend.Display = false;
            this.chartJS1.Padding = new Wisej.Web.Padding(8);
            this.chartJS1.Size = new System.Drawing.Size(420, 302);
            this.chartJS1.TabIndex = 9;
            this.chartJS1.Text = "Line Chart";
            this.chartJS1.ChartClick += new Wisej.Web.Ext.ChartJS.ChartClickEventHandler(this.chartJS_ChartClick);
            // 
            // chartJS2
            // 
            this.chartJS2.Anchor = Wisej.Web.AnchorStyles.None;
            this.chartJS2.AppearanceKey = "chartjs";
            this.chartJS2.BackColor = System.Drawing.Color.White;
            this.chartJS2.BorderStyle = Wisej.Web.BorderStyle.Dotted;
            this.chartJS2.ChartType = Wisej.Web.Ext.ChartJS.ChartType.Bar;
            this.chartJS2.CssStyle = "border-radius: 8px;\r\nbox-shadow: rgba(0, 0, 0, 0.16) 0px 1px 4px;";
            this.flowLayoutPanel1.SetFillWeight(this.chartJS2, 1);
            this.chartJS2.Labels = new string[] {
        "Jan",
        "Feb",
        "Mar",
        "Apr",
        "May",
        "Jun",
        "Jul",
        "Aug",
        "Sep",
        "Oct",
        "Nov",
        "Dec"};
            this.chartJS2.Location = new System.Drawing.Point(10, 10);
            this.chartJS2.Margin = new Wisej.Web.Padding(10);
            this.chartJS2.MinimumSize = new System.Drawing.Size(225, 0);
            this.chartJS2.Name = "chartJS2";
            this.chartJS2.Options.DataLabel.BackgroundColor = System.Drawing.Color.Empty;
            this.chartJS2.Options.DataLabel.BorderColor = System.Drawing.Color.Empty;
            this.chartJS2.Options.DataLabel.Color = System.Drawing.Color.Black;
            this.chartJS2.Options.DataLabel.Opacity = 1F;
            this.chartJS2.Options.DataLabel.TextAlign = Wisej.Web.Ext.ChartJS.DataLabelTextAlignment.Start;
            this.chartJS2.Options.DataLabel.TextShadowColor = System.Drawing.Color.Empty;
            this.chartJS2.Options.DataLabel.TextStrokeColor = System.Drawing.Color.Empty;
            this.chartJS2.Options.Title.Text = "Bar Chart";
            this.chartJS2.Padding = new Wisej.Web.Padding(8);
            this.chartJS2.Size = new System.Drawing.Size(420, 302);
            this.chartJS2.TabIndex = 10;
            this.chartJS2.Text = "Bar Chart";
            this.chartJS2.ChartClick += new Wisej.Web.Ext.ChartJS.ChartClickEventHandler(this.chartJS_ChartClick);
            // 
            // chartJS4
            // 
            this.chartJS4.Anchor = Wisej.Web.AnchorStyles.None;
            this.chartJS4.AppearanceKey = "chartjs";
            this.chartJS4.BackColor = System.Drawing.Color.White;
            this.chartJS4.BorderStyle = Wisej.Web.BorderStyle.Dotted;
            this.chartJS4.ChartType = Wisej.Web.Ext.ChartJS.ChartType.Radar;
            this.chartJS4.CssStyle = "border-radius: 8px;\r\nbox-shadow: rgba(0, 0, 0, 0.16) 0px 1px 4px;";
            this.flowLayoutPanel1.SetFillWeight(this.chartJS4, 1);
            this.chartJS4.Labels = new string[] {
        "Jan",
        "Feb",
        "Mar",
        "Apr",
        "May",
        "Jun",
        "Jul",
        "Aug",
        "Sep",
        "Oct",
        "Nov",
        "Dec"};
            this.chartJS4.Location = new System.Drawing.Point(890, 10);
            this.chartJS4.Margin = new Wisej.Web.Padding(10);
            this.chartJS4.MinimumSize = new System.Drawing.Size(225, 0);
            this.chartJS4.Name = "chartJS4";
            this.chartJS4.Options.DataLabel.BackgroundColor = System.Drawing.Color.Empty;
            this.chartJS4.Options.DataLabel.BorderColor = System.Drawing.Color.Empty;
            this.chartJS4.Options.DataLabel.Color = System.Drawing.Color.Black;
            this.chartJS4.Options.DataLabel.Opacity = 1F;
            this.chartJS4.Options.DataLabel.TextAlign = Wisej.Web.Ext.ChartJS.DataLabelTextAlignment.Start;
            this.chartJS4.Options.DataLabel.TextShadowColor = System.Drawing.Color.Empty;
            this.chartJS4.Options.DataLabel.TextStrokeColor = System.Drawing.Color.Empty;
            this.chartJS4.Padding = new Wisej.Web.Padding(8);
            this.chartJS4.Size = new System.Drawing.Size(420, 302);
            this.chartJS4.TabIndex = 12;
            this.chartJS4.Text = "Radar Chart";
            this.chartJS4.ChartClick += new Wisej.Web.Ext.ChartJS.ChartClickEventHandler(this.chartJS_ChartClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.chartJS2);
            this.flowLayoutPanel1.Controls.Add(this.chartJS1);
            this.flowLayoutPanel1.Controls.Add(this.chartJS4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(51, 76);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1320, 322);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // Features
            // 
            this.AutoScroll = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.Ext.ChartJS.ChartJS chartJS1;
        private Web.Ext.ChartJS.ChartJS chartJS2;
        private Web.Ext.ChartJS.ChartJS chartJS4;
        private Web.FlowLayoutPanel flowLayoutPanel1;
    }
}
