﻿namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoStepper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoStepper));
            this.kendoStepper1 = new Wisej.Web.Ext.Kendo.kendoStepper();
            this.buttonAddStep = new Wisej.Web.Button();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoStepper1);
            this.panel.Size = new System.Drawing.Size(682, 236);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(250, 236);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(16, 168);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/stepper/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/stepper";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/navigation/stepper/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.buttonAddStep);
            this.flowLayoutPanelProperties.Size = new System.Drawing.Size(218, 110);
            // 
            // kendoStepper1
            // 
            this.kendoStepper1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.kendoStepper1.Location = new System.Drawing.Point(40, 83);
            this.kendoStepper1.Name = "kendoStepper1";
            this.kendoStepper1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoStepper1.Options"))));
            this.kendoStepper1.Size = new System.Drawing.Size(600, 91);
            this.kendoStepper1.TabIndex = 0;
            this.kendoStepper1.Text = "kendoStepper1";
            // 
            // buttonAddStep
            // 
            this.buttonAddStep.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.buttonAddStep.Location = new System.Drawing.Point(3, 3);
            this.buttonAddStep.Name = "buttonAddStep";
            this.buttonAddStep.Size = new System.Drawing.Size(212, 38);
            this.buttonAddStep.TabIndex = 0;
            this.buttonAddStep.Text = "Add step";
            this.buttonAddStep.Click += new System.EventHandler(this.buttonAddStep_Click);
            // 
            // kendoStepper
            // 
            this.MinimumSize = new System.Drawing.Size(1091, 426);
            this.Name = "kendoStepper";
            this.Size = new System.Drawing.Size(1091, 426);
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoStepper kendoStepper1;
        private Button buttonAddStep;
    }
}
