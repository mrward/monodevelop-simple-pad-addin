
using System;
using MonoDevelop.Ide.Gui;

namespace MonoDevelopSimplePadAddin
{
	public class SimplePad : IPadContent
	{
		Gtk.Label label;

		public void Initialize (IPadWindow window)
		{
			label = new Gtk.Label ("Simple pad label");
			label.Visible = true;
		}

		public void RedrawContent ()
		{
		}

		public Gtk.Widget Control {
			get { return label; }
		}

		public void Dispose ()
		{
		}
	}
}

