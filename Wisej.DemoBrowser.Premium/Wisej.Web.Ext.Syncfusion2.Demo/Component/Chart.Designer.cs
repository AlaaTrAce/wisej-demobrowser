﻿namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class Chart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chart));
            this.chart1 = new Wisej.Web.Ext.Syncfusion2.Chart();
            this.comboBoxChartType = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/chart/es5-getting-started/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/chart/overview/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxChartType);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxChartType, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.chart1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/chart/line.html";
            // 
            // chart1
            // 
            this.chart1.Dock = Wisej.Web.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(8, 8);
            this.chart1.Name = "chart1";
            this.chart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("chart1.Options"))));
            this.chart1.Size = new System.Drawing.Size(1073, 542);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // comboBoxChartType
            // 
            this.comboBoxChartType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxChartType.Items.AddRange(new object[] {
            "Line",
            "Spline",
            "StepLine"});
            this.comboBoxChartType.LabelText = "Chart Type";
            this.comboBoxChartType.Location = new System.Drawing.Point(23, 57);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(205, 53);
            this.comboBoxChartType.TabIndex = 1;
            // 
            // Chart
            // 
            this.Name = "Chart";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Chart chart1;
        private ComboBox comboBoxChartType;
    }
}