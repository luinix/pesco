
// This file has been generated by the GUI designer. Do not modify.
namespace pesco
{
	public partial class ResidencePane
	{
		private global::Gtk.VBox vbox4;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Image image231;

		private global::Gtk.VBox vbox5;

		private global::Gtk.Alignment alignment3;

		private global::Gtk.Label label1;

		private global::Gtk.Label subtitulo;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Alignment alignment2;

		private global::Gtk.VBox optionButtons;

		private global::Gtk.Alignment alignment1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget pesco.ResidencePane
			global::Stetic.BinContainer.Attach (this);
			this.WidthRequest = 1200;
			this.HeightRequest = 600;
			this.Name = "pesco.ResidencePane";
			// Container child pesco.ResidencePane.Gtk.Container+ContainerChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.image231 = new global::Gtk.Image ();
			this.image231.Name = "image231";
			this.image231.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.gui.abuelo3.png");
			this.hbox2.Add (this.image231);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.image231]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment3.Name = "alignment3";
			this.vbox5.Add (this.alignment3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.alignment3]));
			w2.Position = 0;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>¿Con quién vives?</b>");
			this.label1.UseMarkup = true;
			this.label1.Justify = ((global::Gtk.Justification)(2));
			this.vbox5.Add (this.label1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.label1]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.subtitulo = new global::Gtk.Label ();
			this.subtitulo.Name = "subtitulo";
			this.subtitulo.LabelProp = global::Mono.Unix.Catalog.GetString ("(recuerda que debes pulsar una opción antes de continuar)\n");
			this.subtitulo.Justify = ((global::Gtk.Justification)(2));
			this.vbox5.Add (this.subtitulo);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.subtitulo]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			this.hbox2.Add (this.vbox5);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox5]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			w5.Padding = ((uint)(150));
			this.vbox4.Add (this.hbox2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox2]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment2.Name = "alignment2";
			this.hbox1.Add (this.alignment2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.alignment2]));
			w7.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.optionButtons = new global::Gtk.VBox ();
			this.optionButtons.WidthRequest = 100;
			this.optionButtons.Name = "optionButtons";
			this.optionButtons.Spacing = 6;
			this.hbox1.Add (this.optionButtons);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.optionButtons]));
			w8.Position = 1;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment1.Name = "alignment1";
			this.hbox1.Add (this.alignment1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.alignment1]));
			w9.Position = 2;
			this.vbox4.Add (this.hbox1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox1]));
			w10.Position = 1;
			this.Add (this.vbox4);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
