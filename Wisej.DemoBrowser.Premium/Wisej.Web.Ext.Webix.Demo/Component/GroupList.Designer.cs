﻿namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class GroupList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupList));
			this.groupList1 = new Wisej.Web.Ext.Webix.GroupList();
			this.SuspendLayout();
			// 
			// groupList1
			// 
			this.groupList1.Anchor = Wisej.Web.AnchorStyles.None;
			this.groupList1.Location = new System.Drawing.Point(515, 38);
			this.groupList1.Name = "groupList1";
			this.groupList1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("groupList1.Options"))));
			this.groupList1.Size = new System.Drawing.Size(500, 400);
			this.groupList1.TabIndex = 0;
			this.groupList1.Text = "groupList1";
			// 
			// GroupList
			// 
			this.Controls.Add(this.groupList1);
			this.Name = "GroupList";
			this.Controls.SetChildIndex(this.groupList1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Webix.GroupList groupList1;
	}
}