﻿namespace Wisej.DemoBrowser.TinyEditor
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
			this.tinyEditor1 = new Wisej.Web.Ext.TinyEditor.TinyEditor();
			this.SuspendLayout();
			// 
			// tinyEditor1
			// 
			this.tinyEditor1.Anchor = Wisej.Web.AnchorStyles.None;
			this.tinyEditor1.Location = new System.Drawing.Point(292, 3);
			this.tinyEditor1.Name = "tinyEditor1";
			this.tinyEditor1.Size = new System.Drawing.Size(839, 468);
			this.tinyEditor1.TabIndex = 0;
			this.tinyEditor1.Text = "tinyEditor1";
			// 
			// Features
			// 
			this.Controls.Add(this.tinyEditor1);
			this.Name = "Features";
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Ext.TinyEditor.TinyEditor tinyEditor1;
	}
}