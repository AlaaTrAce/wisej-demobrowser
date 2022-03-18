﻿namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejDiagram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejDiagram));
            Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate widgetTemplate1 = new Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate();
            this.ejDiagram1 = new Wisej.Web.Ext.Syncfusion.ejDiagram();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.buttonSave = new Wisej.Web.Button();
            this.buttonLoad = new Wisej.Web.Upload();
            this.comboBox2 = new Wisej.Web.ComboBox();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/diagram/overview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.buttonLoad);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Size = new System.Drawing.Size(250, 483);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonSave, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 400);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/diagram/defaultfunctionalities";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejdiagram";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejDiagram1);
            this.panel.TabIndex = 7;
            // 
            // ejDiagram1
            // 
            this.ejDiagram1.Dock = Wisej.Web.DockStyle.Fill;
            this.ejDiagram1.Location = new System.Drawing.Point(8, 8);
            this.ejDiagram1.Name = "ejDiagram1";
            this.ejDiagram1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejDiagram1.Options"))));
            this.ejDiagram1.Size = new System.Drawing.Size(1073, 542);
            this.ejDiagram1.TabIndex = 0;
            this.ejDiagram1.Text = "ejDiagram1";
            widgetTemplate1.Id = "template1";
            widgetTemplate1.Template = resources.GetString("widgetTemplate1.Template");
            widgetTemplate1.Type = "text/javascript";
            this.ejDiagram1.WidgetTemplates = new Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate[] {
        widgetTemplate1};
            this.ejDiagram1.Appear += new System.EventHandler(this.ejDiagram1_Appear);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 31);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Editable";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Checked = true;
            this.checkBox2.Location = new System.Drawing.Point(28, 86);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(195, 31);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Context Menu";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "HierarchicalTree",
            "OrganizationalChart"});
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "Layout";
            this.comboBox1.Location = new System.Drawing.Point(28, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 60);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "None";
            // 
            // buttonSave
            // 
            this.buttonSave.Display = Wisej.Web.Display.Icon;
            this.buttonSave.ImageSource = "icon-save";
            this.buttonSave.Location = new System.Drawing.Point(76, 340);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(42, 42);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.AllowedFileTypes = ".json";
            this.buttonLoad.HideValue = true;
            this.buttonLoad.ImageSource = "icon-file";
            this.buttonLoad.Location = new System.Drawing.Point(28, 340);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(42, 42);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoSize = false;
            this.comboBox2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBox2.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Top",
            "Bottom"});
            this.comboBox2.Label.Size = 50;
            this.comboBox2.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox2.LabelText = "Bridge Direction";
            this.comboBox2.Location = new System.Drawing.Point(28, 262);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(195, 60);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "Top";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Checked = true;
            this.checkBox3.Location = new System.Drawing.Point(28, 135);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(195, 31);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Enable AutoScroll";
            // 
            // ejDiagram
            // 
            this.Name = "ejDiagram";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejDiagram ejDiagram1;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private ComboBox comboBox1;
		private Button buttonSave;
		private Upload buttonLoad;
		private CheckBox checkBox3;
		private ComboBox comboBox2;
	}
}