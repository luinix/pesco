
// This file has been generated by the GUI designer. Do not modify.
namespace pesco
{
	public partial class SemanticAnalogiesPanel
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.Alignment alignment12;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Alignment alignment10;

		private global::Gtk.Frame frame3;

		private global::Gtk.Alignment GtkAlignment2;

		private global::Gtk.VBox vbox5;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Image imagepepe;

		private global::Gtk.VBox vbox3;

		private global::Gtk.Label label1;

		private global::Gtk.Alignment alignment3;

		private global::Gtk.Label explanation;

		private global::Gtk.HSeparator hseparator2;

		private global::Gtk.HBox cajaMuestras;

		private global::Gtk.HSeparator hseparator3;

		private global::Gtk.HBox cajaOpciones;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.HBox cajaBotones;

		private global::Gtk.Alignment alignment1;

		private global::Gtk.Button helpButton;

		private global::Gtk.Button botonListo;

		private global::Gtk.Alignment alignment11;

		private global::Gtk.Alignment alignment9;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget pesco.SemanticAnalogiesPanel
			global::Stetic.BinContainer.Attach (this);
			this.Name = "pesco.SemanticAnalogiesPanel";
			// Container child pesco.SemanticAnalogiesPanel.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.WidthRequest = 1200;
			this.vbox2.HeightRequest = 660;
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment12 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment12.Name = "alignment12";
			this.vbox2.Add (this.alignment12);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.alignment12]));
			w1.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.HeightRequest = 700;
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.alignment10 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment10.Name = "alignment10";
			this.hbox5.Add (this.alignment10);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.alignment10]));
			w2.Position = 0;
			// Container child hbox5.Gtk.Box+BoxChild
			this.frame3 = new global::Gtk.Frame ();
			this.frame3.WidthRequest = 1200;
			this.frame3.Name = "frame3";
			this.frame3.ShadowType = ((global::Gtk.ShadowType)(1));
			this.frame3.LabelYalign = 0f;
			// Container child frame3.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0f, 0f, 1f, 1f);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			// Container child hbox2.Gtk.Box+BoxChild
			this.imagepepe = new global::Gtk.Image ();
			this.imagepepe.Name = "imagepepe";
			this.imagepepe.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.resources.img.reasoning.pepehabla.gif");
			this.hbox2.Add (this.imagepepe);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.imagepepe]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 1;
			// Container child vbox3.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<big><big><big><big>Asociación de Palabras</big></big></big></big>");
			this.label1.UseMarkup = true;
			this.label1.UseUnderline = true;
			this.vbox3.Add (this.label1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.label1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			w4.Padding = ((uint)(10));
			// Container child vbox3.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment3.Name = "alignment3";
			this.alignment3.LeftPadding = ((uint)(50));
			// Container child alignment3.Gtk.Container+ContainerChild
			this.explanation = new global::Gtk.Label ();
			this.explanation.WidthRequest = 1000;
			this.explanation.HeightRequest = 75;
			this.explanation.Name = "explanation";
			this.explanation.UseMarkup = true;
			this.explanation.Wrap = true;
			this.alignment3.Add (this.explanation);
			this.vbox3.Add (this.alignment3);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.alignment3]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			w6.Padding = ((uint)(10));
			this.hbox2.Add (this.vbox3);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox3]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.vbox5.Add (this.hbox2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox2]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator ();
			this.hseparator2.Name = "hseparator2";
			this.vbox5.Add (this.hseparator2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hseparator2]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.cajaMuestras = new global::Gtk.HBox ();
			this.cajaMuestras.Name = "cajaMuestras";
			this.cajaMuestras.Spacing = 6;
			this.vbox5.Add (this.cajaMuestras);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.cajaMuestras]));
			w10.Position = 2;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hseparator3 = new global::Gtk.HSeparator ();
			this.hseparator3.Name = "hseparator3";
			this.vbox5.Add (this.hseparator3);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hseparator3]));
			w11.Position = 3;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.cajaOpciones = new global::Gtk.HBox ();
			this.cajaOpciones.HeightRequest = 200;
			this.cajaOpciones.Name = "cajaOpciones";
			this.cajaOpciones.Spacing = 6;
			this.vbox5.Add (this.cajaOpciones);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.cajaOpciones]));
			w12.Position = 4;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox5.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hseparator1]));
			w13.Position = 5;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.cajaBotones = new global::Gtk.HBox ();
			this.cajaBotones.Name = "cajaBotones";
			this.cajaBotones.Spacing = 6;
			// Container child cajaBotones.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment1.Name = "alignment1";
			this.cajaBotones.Add (this.alignment1);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.cajaBotones[this.alignment1]));
			w14.Position = 0;
			// Container child cajaBotones.Gtk.Box+BoxChild
			this.helpButton = new global::Gtk.Button ();
			this.helpButton.CanFocus = true;
			this.helpButton.Name = "helpButton";
			this.helpButton.UseUnderline = true;
			this.helpButton.Xalign = 1f;
			// Container child helpButton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w15 = new global::Gtk.Alignment (1f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w16 = new global::Gtk.HBox ();
			w16.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w17 = new global::Gtk.Image ();
			w17.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-help", global::Gtk.IconSize.Dialog);
			w16.Add (w17);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w19 = new global::Gtk.Label ();
			w19.LabelProp = global::Mono.Unix.Catalog.GetString ("Ayuda");
			w19.UseUnderline = true;
			w16.Add (w19);
			w15.Add (w16);
			this.helpButton.Add (w15);
			this.cajaBotones.Add (this.helpButton);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.cajaBotones[this.helpButton]));
			w23.Position = 1;
			w23.Expand = false;
			w23.Fill = false;
			// Container child cajaBotones.Gtk.Box+BoxChild
			this.botonListo = new global::Gtk.Button ();
			this.botonListo.CanFocus = true;
			this.botonListo.Name = "botonListo";
			this.botonListo.UseUnderline = true;
			// Container child botonListo.Gtk.Container+ContainerChild
			global::Gtk.Alignment w24 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w25 = new global::Gtk.HBox ();
			w25.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w26 = new global::Gtk.Image ();
			w26.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Dialog);
			w25.Add (w26);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w28 = new global::Gtk.Label ();
			w28.LabelProp = global::Mono.Unix.Catalog.GetString ("¡Listo!");
			w28.UseUnderline = true;
			w25.Add (w28);
			w24.Add (w25);
			this.botonListo.Add (w24);
			this.cajaBotones.Add (this.botonListo);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.cajaBotones[this.botonListo]));
			w32.Position = 2;
			w32.Expand = false;
			w32.Fill = false;
			this.vbox5.Add (this.cajaBotones);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.cajaBotones]));
			w33.PackType = ((global::Gtk.PackType)(1));
			w33.Position = 6;
			w33.Expand = false;
			w33.Fill = false;
			this.GtkAlignment2.Add (this.vbox5);
			this.frame3.Add (this.GtkAlignment2);
			this.hbox5.Add (this.frame3);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.frame3]));
			w36.Position = 1;
			w36.Expand = false;
			w36.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.alignment11 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment11.Name = "alignment11";
			this.hbox5.Add (this.alignment11);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.alignment11]));
			w37.Position = 2;
			this.vbox2.Add (this.hbox5);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox5]));
			w38.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment9 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment9.Name = "alignment9";
			this.vbox2.Add (this.alignment9);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.alignment9]));
			w39.Position = 2;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
