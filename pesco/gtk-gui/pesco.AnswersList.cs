
// This file has been generated by the GUI designer. Do not modify.
namespace pesco
{
	public partial class AnswersList
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Fixed fixed1;

		private global::Gtk.Image image1859;

		private global::Gtk.Image image5;

		private global::Gtk.VBox vbox6;

		private global::Gtk.Alignment alignment3;

		private global::Gtk.Label titulo;

		private global::Gtk.Label subtitulo;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Alignment alignment2;

		private global::Gtk.VBox vbox3;

		private global::Gtk.Alignment alignment4;

		private global::Gtk.VBox optionButtons;

		private global::Gtk.Alignment alignment5;

		private global::Gtk.Alignment alignment1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget pesco.AnswersList
			global::Stetic.BinContainer.Attach (this);
			this.Name = "pesco.AnswersList";
			// Container child pesco.AnswersList.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.image1859 = new global::Gtk.Image ();
			this.image1859.Name = "image1859";
			this.image1859.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.gui.abuelo3b.png");
			this.fixed1.Add (this.image1859);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.image1859]));
			w1.Y = -10;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.image5 = new global::Gtk.Image ();
			this.image5.Name = "image5";
			this.fixed1.Add (this.image5);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.image5]));
			w2.X = 170;
			w2.Y = 11;
			this.hbox1.Add (this.fixed1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.fixed1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment3.Name = "alignment3";
			this.vbox6.Add (this.alignment3);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.alignment3]));
			w4.Position = 0;
			// Container child vbox6.Gtk.Box+BoxChild
			this.titulo = new global::Gtk.Label ();
			this.titulo.Name = "titulo";
			this.titulo.UseMarkup = true;
			this.titulo.Justify = ((global::Gtk.Justification)(2));
			this.vbox6.Add (this.titulo);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.titulo]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.subtitulo = new global::Gtk.Label ();
			this.subtitulo.Name = "subtitulo";
			this.subtitulo.LabelProp = global::Mono.Unix.Catalog.GetString ("(recuerda que debes pulsar una opción antes de continuar)\n");
			this.subtitulo.Justify = ((global::Gtk.Justification)(2));
			this.vbox6.Add (this.subtitulo);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.subtitulo]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			this.hbox1.Add (this.vbox6);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox6]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			w7.Padding = ((uint)(50));
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment2.Name = "alignment2";
			this.hbox2.Add (this.alignment2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.alignment2]));
			w9.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment4.Name = "alignment4";
			this.vbox3.Add (this.alignment4);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.alignment4]));
			w10.Position = 0;
			// Container child vbox3.Gtk.Box+BoxChild
			this.optionButtons = new global::Gtk.VBox ();
			this.optionButtons.WidthRequest = 1000;
			this.optionButtons.Name = "optionButtons";
			this.optionButtons.Spacing = 6;
			this.vbox3.Add (this.optionButtons);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.optionButtons]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.alignment5 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment5.Name = "alignment5";
			this.vbox3.Add (this.alignment5);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.alignment5]));
			w12.Position = 2;
			this.hbox2.Add (this.vbox3);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox3]));
			w13.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment1.Name = "alignment1";
			this.hbox2.Add (this.alignment1);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.alignment1]));
			w14.Position = 2;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
			w15.Position = 1;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
