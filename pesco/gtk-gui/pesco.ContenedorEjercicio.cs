
// This file has been generated by the GUI designer. Do not modify.
namespace pesco
{
	public partial class ContenedorEjercicio
	{
		private global::Gtk.VBox vbox2;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget pesco.ContenedorEjercicio
			global::Stetic.BinContainer.Attach (this);
			this.Name = "pesco.ContenedorEjercicio";
			// Container child pesco.ContenedorEjercicio.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.DestroyEvent += new global::Gtk.DestroyEventHandler (this.OnDestroyEvent);
		}
	}
}
