
// This file has been generated by the GUI designer. Do not modify.
namespace pesco
{
	public partial class ExercisePanelWordList1
	{
		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hbox1;

		private global::Gtk.VBox vbox4;

		private global::Gtk.VBox vbox5;

		private global::Gtk.Fixed fixed2;

		private global::Gtk.Image imagBack;

		private global::Gtk.Label label2;

		private global::Gtk.Image imagPepe;

		private global::Gtk.Label label51;

		private global::Gtk.Label label1;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Alignment alignment1;

		private global::Gtk.Button botonempezarsecuencia;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget pesco.ExercisePanelWordList1
			global::Stetic.BinContainer.Attach (this);
			this.Name = "pesco.ExercisePanelWordList1";
			// Container child pesco.ExercisePanelWordList1.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.fixed2 = new global::Gtk.Fixed ();
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.imagBack = new global::Gtk.Image ();
			this.imagBack.Name = "imagBack";
			this.fixed2.Add (this.imagBack);
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.label2 = new global::Gtk.Label ();
			this.label2.WidthRequest = 720;
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("labelPrevius");
			this.label2.UseMarkup = true;
			this.fixed2.Add (this.label2);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.label2]));
			w2.X = 218;
			w2.Y = 118;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.imagPepe = new global::Gtk.Image ();
			this.imagPepe.Name = "imagPepe";
			this.fixed2.Add (this.imagPepe);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.imagPepe]));
			w3.X = 7;
			w3.Y = 220;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.label51 = new global::Gtk.Label ();
			this.label51.WidthRequest = 400;
			this.label51.Name = "label51";
			this.label51.LabelProp = global::Mono.Unix.Catalog.GetString ("<span color=\"blue\"><big><big><big><big><big>Pulsa el botón <span color=\"black\"><b>¡Listo!</b></span>\npara continuar.</big></big></big></big></big></span>\n");
			this.label51.UseMarkup = true;
			this.label51.Wrap = true;
			this.fixed2.Add (this.label51);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.label51]));
			w4.X = 450;
			w4.Y = 310;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.label1 = new global::Gtk.Label ();
			this.label1.WidthRequest = 728;
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("labelLevel");
			this.label1.Justify = ((global::Gtk.Justification)(2));
			this.fixed2.Add (this.label1);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.label1]));
			w5.X = 218;
			w5.Y = 55;
			this.vbox5.Add (this.fixed2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.fixed2]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment1.Name = "alignment1";
			this.hbox2.Add (this.alignment1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.alignment1]));
			w7.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.botonempezarsecuencia = new global::Gtk.Button ();
			this.botonempezarsecuencia.CanFocus = true;
			this.botonempezarsecuencia.Name = "botonempezarsecuencia";
			this.botonempezarsecuencia.UseUnderline = true;
			// Container child botonempezarsecuencia.Gtk.Container+ContainerChild
			global::Gtk.Alignment w8 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w9 = new global::Gtk.HBox ();
			w9.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w10 = new global::Gtk.Image ();
			w10.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Dnd);
			w9.Add (w10);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w12 = new global::Gtk.Label ();
			w12.LabelProp = global::Mono.Unix.Catalog.GetString ("¡Listo!");
			w12.UseUnderline = true;
			w9.Add (w12);
			w8.Add (w9);
			this.botonempezarsecuencia.Add (w8);
			this.hbox2.Add (this.botonempezarsecuencia);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.botonempezarsecuencia]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			this.vbox5.Add (this.hbox2);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox2]));
			w17.PackType = ((global::Gtk.PackType)(1));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.vbox4.Add (this.vbox5);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.vbox5]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			this.hbox1.Add (this.vbox4);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox4]));
			w19.Position = 1;
			w19.Fill = false;
			this.vbox3.Add (this.hbox1);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox1]));
			w20.Position = 1;
			w20.Fill = false;
			this.Add (this.vbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
