﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxSwitch : TestBase
	{
		public dxSwitch()
		{
			InitializeComponent();

			this.dxSwitch1.Instance.onValueChanged += new WidgetEventHandler(dxSwitch1_WidgetEvent);
		}

		private void dxSwitch1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.dxSwitch1.Options.switchedOnText = this.textBoxOnText.Text;
			this.dxSwitch1.Options.switchedOffText = this.textBoxOffText.Text;

			this.dxSwitch1.Update();
        }
    }
}
