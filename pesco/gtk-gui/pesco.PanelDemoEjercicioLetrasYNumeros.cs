
// This file has been generated by the GUI designer. Do not modify.
namespace pesco
{
	public partial class PanelDemoEjercicioLetrasYNumeros
	{
		private global::Gtk.HBox hbox1;

		private global::Gtk.VBox vbox1;

		private global::Gtk.HSeparator hseparator1;

		private global::pesco.PanelVocalesYNumeros panelEjercicio;

		private global::Gtk.HSeparator hseparator4;

		private global::Gtk.HBox hbox14;

		private global::Gtk.Button botonEjecutaDemo;

		private global::Gtk.Button botonAEnsayo;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget pesco.PanelDemoEjercicioLetrasYNumeros
			global::Stetic.BinContainer.Attach (this);
			this.WidthRequest = 1250;
			this.HeightRequest = 660;
			this.Name = "pesco.PanelDemoEjercicioLetrasYNumeros";
			// Container child pesco.PanelDemoEjercicioLetrasYNumeros.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox1.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hseparator1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.panelEjercicio = new global::pesco.PanelVocalesYNumeros ();
			this.panelEjercicio.HeightRequest = 0;
			this.panelEjercicio.Events = ((global::Gdk.EventMask)(256));
			this.panelEjercicio.Name = "panelEjercicio";
			this.panelEjercicio.RehersalMode = false;
			this.vbox1.Add (this.panelEjercicio);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.panelEjercicio]));
			w2.Position = 1;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparator4 = new global::Gtk.HSeparator ();
			this.hseparator4.Name = "hseparator4";
			this.vbox1.Add (this.hseparator4);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hseparator4]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox14 = new global::Gtk.HBox ();
			this.hbox14.Name = "hbox14";
			this.hbox14.Spacing = 6;
			// Container child hbox14.Gtk.Box+BoxChild
			this.botonEjecutaDemo = new global::Gtk.Button ();
			this.botonEjecutaDemo.HeightRequest = 20;
			this.botonEjecutaDemo.CanFocus = true;
			this.botonEjecutaDemo.Name = "botonEjecutaDemo";
			this.botonEjecutaDemo.UseUnderline = true;
			// Container child botonEjecutaDemo.Gtk.Container+ContainerChild
			global::Gtk.Alignment w4 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w5 = new global::Gtk.HBox ();
			w5.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w6 = new global::Gtk.Image ();
			w6.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-execute", global::Gtk.IconSize.Dialog);
			w5.Add (w6);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w8 = new global::Gtk.Label ();
			w8.LabelProp = global::Mono.Unix.Catalog.GetString ("Ensayar");
			w8.UseUnderline = true;
			w5.Add (w8);
			w4.Add (w5);
			this.botonEjecutaDemo.Add (w4);
			this.hbox14.Add (this.botonEjecutaDemo);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox14[this.botonEjecutaDemo]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox14.Gtk.Box+BoxChild
			this.botonAEnsayo = new global::Gtk.Button ();
			this.botonAEnsayo.CanFocus = true;
			this.botonAEnsayo.Name = "botonAEnsayo";
			this.botonAEnsayo.UseUnderline = true;
			// Container child botonAEnsayo.Gtk.Container+ContainerChild
			global::Gtk.Alignment w13 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w14 = new global::Gtk.HBox ();
			w14.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w15 = new global::Gtk.Image ();
			w15.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-forward", global::Gtk.IconSize.Dialog);
			w14.Add (w15);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w17 = new global::Gtk.Label ();
			w17.LabelProp = global::Mono.Unix.Catalog.GetString ("Siguiente");
			w17.UseUnderline = true;
			w14.Add (w17);
			w13.Add (w14);
			this.botonAEnsayo.Add (w13);
			this.hbox14.Add (this.botonAEnsayo);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox14[this.botonAEnsayo]));
			w21.Position = 2;
			w21.Expand = false;
			w21.Fill = false;
			this.vbox1.Add (this.hbox14);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox14]));
			w22.Position = 3;
			w22.Fill = false;
			this.hbox1.Add (this.vbox1);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox1]));
			w23.Position = 0;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
