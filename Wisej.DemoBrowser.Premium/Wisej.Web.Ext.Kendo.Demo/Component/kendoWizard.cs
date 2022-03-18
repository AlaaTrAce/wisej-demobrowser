﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoWizard : TestBase
	{
		public kendoWizard()
		{
			InitializeComponent();

			this.kendoWizard1.Instance.done += new WidgetEventHandler(kendoWizard1_WidgetEvent);
			this.kendoWizard1.Instance.select += new WidgetEventHandler(kendoWizard1_WidgetEvent);
			this.kendoWizard1.Instance.activate += new WidgetEventHandler(kendoWizard1_WidgetEvent);
			this.kendoWizard1.Instance.formValidateFailed += new WidgetEventHandler(kendoWizard1_WidgetEvent);
		}

		private void kendoWizard1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.kendoWizard1.Instance.previous();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.kendoWizard1.Instance.next();
		}
	}
}