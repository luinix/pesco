
// This file has been generated by the GUI designer. Do not modify.
namespace pesco
{
	public partial class SessionsPodiumPanel
	{
		private global::Gtk.EventBox eventBox;

		private global::Gtk.Fixed fixed1;

		private global::Gtk.Image imageBackground;

		private global::Gtk.Button buttonClose;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget pesco.SessionsPodiumPanel
			global::Stetic.BinContainer.Attach (this);
			this.Name = "pesco.SessionsPodiumPanel";
			// Container child pesco.SessionsPodiumPanel.Gtk.Container+ContainerChild
			this.eventBox = new global::Gtk.EventBox ();
			this.eventBox.Name = "eventBox";
			// Container child eventBox.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.WidthRequest = 1000;
			this.fixed1.HeightRequest = 600;
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.imageBackground = new global::Gtk.Image ();
			this.imageBackground.WidthRequest = 1000;
			this.imageBackground.HeightRequest = 600;
			this.imageBackground.Name = "imageBackground";
			this.fixed1.Add (this.imageBackground);
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.buttonClose = new global::Gtk.Button ();
			this.buttonClose.WidthRequest = 250;
			this.buttonClose.HeightRequest = 40;
			this.buttonClose.CanFocus = true;
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.UseUnderline = true;
			this.buttonClose.Label = global::Mono.Unix.Catalog.GetString ("Cerrar");
			this.fixed1.Add (this.buttonClose);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.buttonClose]));
			w2.X = 375;
			w2.Y = 555;
			this.eventBox.Add (this.fixed1);
			this.Add (this.eventBox);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
