
// This file has been generated by the GUI designer. Do not modify.
namespace pesco
{
	public partial class ListCheckingPanel
	{
		private global::Gtk.HBox hbox1;

		private global::Gtk.Alignment alignment7;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Alignment alignment4;

		private global::Gtk.Frame frame1;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Image imagepepe;

		private global::Gtk.VBox vbox4;

		private global::Gtk.Label label2;

		private global::Gtk.Alignment alignment8;

		private global::Gtk.Label explanation;

		private global::Gtk.Alignment alignment3;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Alignment alignment1;

		private global::Gtk.Label label1;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Alignment alignment2;

		private global::Gtk.VSeparator vseparator2;

		private global::Gtk.Button buttonPrevious;

		private global::Gtk.Button buttonNext;

		private global::Gtk.VSeparator vseparator1;

		private global::Gtk.Button botonListo;

		private global::Gtk.Alignment alignment5;

		private global::Gtk.Alignment alignment6;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget pesco.ListCheckingPanel
			global::Stetic.BinContainer.Attach (this);
			this.Name = "pesco.ListCheckingPanel";
			// Container child pesco.ListCheckingPanel.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment7 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment7.Name = "alignment7";
			this.hbox1.Add (this.alignment7);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.alignment7]));
			w1.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment4.Name = "alignment4";
			this.vbox2.Add (this.alignment4);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.alignment4]));
			w2.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.WidthRequest = 1250;
			this.frame1.HeightRequest = 660;
			this.frame1.Name = "frame1";
			this.frame1.LabelYalign = 0f;
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0f, 0f, 1f, 1f);
			this.GtkAlignment.Name = "GtkAlignment";
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			// Container child hbox4.Gtk.Box+BoxChild
			this.imagepepe = new global::Gtk.Image ();
			this.imagepepe.Name = "imagepepe";
			this.imagepepe.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.resources.img.classifyobjects.pepehablac.png");
			this.hbox4.Add (this.imagepepe);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.imagepepe]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 1;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("<big><big><big><big><b>Selecciona los recados que recuerdes</b></big></big></big></big>");
			this.label2.UseMarkup = true;
			this.label2.UseUnderline = true;
			this.vbox4.Add (this.label2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.label2]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			w4.Padding = ((uint)(2));
			// Container child vbox4.Gtk.Box+BoxChild
			this.alignment8 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment8.Name = "alignment8";
			this.alignment8.LeftPadding = ((uint)(50));
			// Container child alignment8.Gtk.Container+ContainerChild
			this.explanation = new global::Gtk.Label ();
			this.explanation.WidthRequest = 1000;
			this.explanation.Name = "explanation";
			this.explanation.Yalign = 1f;
			this.explanation.LabelProp = global::Mono.Unix.Catalog.GetString ("<big><big><big><b>Para seleccionar</b> pulsa sobre el recado</big></big></big>\n<big><big><big><b>Para deseleccionar</b> pulsa de nuevo sobre él</big></big></big>");
			this.explanation.UseMarkup = true;
			this.explanation.Wrap = true;
			this.alignment8.Add (this.explanation);
			this.vbox4.Add (this.alignment8);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.alignment8]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			w6.Padding = ((uint)(10));
			this.hbox4.Add (this.vbox4);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox4]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.vbox3.Add (this.hbox4);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox4]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5f, 1f, 1f, 1f);
			this.alignment3.Name = "alignment3";
			// Container child alignment3.Gtk.Container+ContainerChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			this.alignment3.Add (this.hbox5);
			this.vbox3.Add (this.alignment3);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.alignment3]));
			w10.Position = 1;
			// Container child vbox3.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (1f, 1f, 0f, 1f);
			this.alignment1.Name = "alignment1";
			// Container child alignment1.Gtk.Container+ContainerChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
			this.alignment1.Add (this.label1);
			this.vbox3.Add (this.alignment1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.alignment1]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox3.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hseparator1]));
			w13.Position = 3;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment2.Name = "alignment2";
			this.hbox2.Add (this.alignment2);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.alignment2]));
			w14.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vseparator2 = new global::Gtk.VSeparator ();
			this.vseparator2.Name = "vseparator2";
			this.hbox2.Add (this.vseparator2);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vseparator2]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonPrevious = new global::Gtk.Button ();
			this.buttonPrevious.CanFocus = true;
			this.buttonPrevious.Name = "buttonPrevious";
			this.buttonPrevious.UseUnderline = true;
			// Container child buttonPrevious.Gtk.Container+ContainerChild
			global::Gtk.Alignment w16 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w17 = new global::Gtk.HBox ();
			w17.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w18 = new global::Gtk.Image ();
			w18.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-back", global::Gtk.IconSize.Dnd);
			w17.Add (w18);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w20 = new global::Gtk.Label ();
			w20.LabelProp = global::Mono.Unix.Catalog.GetString ("Anterior");
			w20.UseUnderline = true;
			w17.Add (w20);
			w16.Add (w17);
			this.buttonPrevious.Add (w16);
			this.hbox2.Add (this.buttonPrevious);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonPrevious]));
			w24.Position = 2;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonNext = new global::Gtk.Button ();
			this.buttonNext.CanFocus = true;
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.UseUnderline = true;
			// Container child buttonNext.Gtk.Container+ContainerChild
			global::Gtk.Alignment w25 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w26 = new global::Gtk.HBox ();
			w26.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w27 = new global::Gtk.Image ();
			w27.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-forward", global::Gtk.IconSize.Dnd);
			w26.Add (w27);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w29 = new global::Gtk.Label ();
			w29.LabelProp = global::Mono.Unix.Catalog.GetString ("Siguiente");
			w29.UseUnderline = true;
			w26.Add (w29);
			w25.Add (w26);
			this.buttonNext.Add (w25);
			this.hbox2.Add (this.buttonNext);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonNext]));
			w33.Position = 3;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vseparator1 = new global::Gtk.VSeparator ();
			this.vseparator1.Name = "vseparator1";
			this.hbox2.Add (this.vseparator1);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vseparator1]));
			w34.Position = 4;
			w34.Expand = false;
			w34.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.botonListo = new global::Gtk.Button ();
			this.botonListo.CanFocus = true;
			this.botonListo.Name = "botonListo";
			this.botonListo.UseUnderline = true;
			// Container child botonListo.Gtk.Container+ContainerChild
			global::Gtk.Alignment w35 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w36 = new global::Gtk.HBox ();
			w36.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w37 = new global::Gtk.Image ();
			w37.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Dnd);
			w36.Add (w37);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w39 = new global::Gtk.Label ();
			w39.LabelProp = global::Mono.Unix.Catalog.GetString ("¡Listo!");
			w39.UseUnderline = true;
			w36.Add (w39);
			w35.Add (w36);
			this.botonListo.Add (w35);
			this.hbox2.Add (this.botonListo);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.botonListo]));
			w43.Position = 5;
			this.vbox3.Add (this.hbox2);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox2]));
			w44.Position = 4;
			w44.Expand = false;
			w44.Fill = false;
			this.GtkAlignment.Add (this.vbox3);
			this.frame1.Add (this.GtkAlignment);
			this.vbox2.Add (this.frame1);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.frame1]));
			w47.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment5 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment5.Name = "alignment5";
			this.vbox2.Add (this.alignment5);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.alignment5]));
			w48.Position = 2;
			this.hbox1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox2]));
			w49.Position = 1;
			w49.Expand = false;
			w49.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment6 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment6.Name = "alignment6";
			this.hbox1.Add (this.alignment6);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.alignment6]));
			w50.Position = 2;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
