
// This file has been generated by the GUI designer. Do not modify.
namespace pesco
{
	public partial class VentanaEjercicios
	{
		private global::Gtk.VBox vboxContainer;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget pesco.VentanaEjercicios
			this.Name = "pesco.VentanaEjercicios";
			this.Title = global::Mono.Unix.Catalog.GetString ("Ejercicio");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.DefaultWidth = 1024;
			this.DefaultHeight = 768;
			// Container child pesco.VentanaEjercicios.Gtk.Container+ContainerChild
			this.vboxContainer = new global::Gtk.VBox ();
			this.vboxContainer.Name = "vboxContainer";
			this.vboxContainer.Spacing = 6;
			this.Add (this.vboxContainer);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		}
	}
}
