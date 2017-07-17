using Xamarin.Forms;
using XLabs.Forms;
using System;
using System.Reflection;
using Plugin.VersionTracking;

namespace Versions
{
	public partial class VersionsPage : ContentPage
	{
		public VersionsPage()
		{
			InitializeComponent();

			var vt = CrossVersionTracking.Current;

			lblVersion.Text = String.Format("{0} ({1})", vt.CurrentVersion, vt.CurrentBuild);




		}
	}
}
