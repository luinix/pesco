
// This file has been generated by the GUI designer. Do not modify.
namespace pesco
{
	public partial class PanelVocalesYNumeros
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.Alignment alignment12;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Image imagepepe;

		private global::Gtk.VBox vbox7;

		private global::Gtk.Label labelTitle;

		private global::Gtk.Alignment alignment13;

		private global::Gtk.Label explanation;

		private global::Gtk.HBox hbox1;

		private global::Gtk.VBox vbox3;

		private global::Gtk.Fixed fixed3;

		private global::Gtk.Label labelPrevius;

		private global::Gtk.HBox hbox9;

		private global::Gtk.VBox vbox6;

		private global::Gtk.Alignment alignment9;

		private global::Gtk.Image image5;

		private global::Gtk.Fixed fixed2;

		private global::Gtk.Image image6;

		private global::Gtk.Label label5;

		private global::Gtk.HSeparator hseparator2;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Alignment alignment16;

		private global::Gtk.Button botonListo1;

		private global::Gtk.Table table2;

		private global::Gtk.Alignment alignment2;

		private global::Gtk.Alignment alignment4;

		private global::Gtk.Alignment alignment6;

		private global::Gtk.Alignment alignment7;

		private global::Gtk.Fixed fixed1;

		private global::Gtk.Image image394;

		private global::Gtk.Label labelCaracter;

		private global::Gtk.VBox vbox4;

		private global::Gtk.Alignment alignment11;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Label label1;

		private global::Gtk.HBox hboxCompletado;

		private global::Gtk.HBox hbox2;

		private global::Gtk.VBox vbox8;

		private global::Gtk.Table table1;

		private global::Gtk.Button boton1;

		private global::Gtk.Image image588;

		private global::Gtk.Button boton2;

		private global::Gtk.Image image589;

		private global::Gtk.Button boton3;

		private global::Gtk.Image image590;

		private global::Gtk.Button boton4;

		private global::Gtk.Image image591;

		private global::Gtk.Button boton5;

		private global::Gtk.Image image592;

		private global::Gtk.Button boton6;

		private global::Gtk.Image image593;

		private global::Gtk.Button boton7;

		private global::Gtk.Image image594;

		private global::Gtk.Button boton8;

		private global::Gtk.Image image595;

		private global::Gtk.Button boton9;

		private global::Gtk.Image image596;

		private global::Gtk.Alignment alignment5;

		private global::Gtk.VBox vbox5;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Button botonA;

		private global::Gtk.Image image469;

		private global::Gtk.Button botonE;

		private global::Gtk.Image image470;

		private global::Gtk.Button botonI;

		private global::Gtk.Image image471;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Alignment alignment1;

		private global::Gtk.Button botonO;

		private global::Gtk.Image image472;

		private global::Gtk.Button botonU;

		private global::Gtk.Button botonU1;

		private global::Gtk.Image image473;

		private global::Gtk.Alignment alignment3;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Alignment alignment8;

		private global::Gtk.Button botonListo;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget pesco.PanelVocalesYNumeros
			global::Stetic.BinContainer.Attach (this);
			this.Name = "pesco.PanelVocalesYNumeros";
			// Container child pesco.PanelVocalesYNumeros.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment12 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment12.Name = "alignment12";
			// Container child alignment12.Gtk.Container+ContainerChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			// Container child hbox8.Gtk.Box+BoxChild
			this.imagepepe = new global::Gtk.Image ();
			this.imagepepe.Name = "imagepepe";
			this.imagepepe.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.resources.img.reasoning.pepehabla.gif");
			this.hbox8.Add (this.imagepepe);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.imagepepe]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.vbox7 = new global::Gtk.VBox ();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 1;
			// Container child vbox7.Gtk.Box+BoxChild
			this.labelTitle = new global::Gtk.Label ();
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.LabelProp = global::Mono.Unix.Catalog.GetString ("<big><big><big><big>Números y Vocales</big></big></big></big>");
			this.labelTitle.UseMarkup = true;
			this.labelTitle.UseUnderline = true;
			this.vbox7.Add (this.labelTitle);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.labelTitle]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			w2.Padding = ((uint)(10));
			// Container child vbox7.Gtk.Box+BoxChild
			this.alignment13 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment13.Name = "alignment13";
			this.alignment13.LeftPadding = ((uint)(50));
			// Container child alignment13.Gtk.Container+ContainerChild
			this.explanation = new global::Gtk.Label ();
			this.explanation.WidthRequest = 1000;
			this.explanation.HeightRequest = 75;
			this.explanation.Name = "explanation";
			this.explanation.UseMarkup = true;
			this.explanation.Wrap = true;
			this.alignment13.Add (this.explanation);
			this.vbox7.Add (this.alignment13);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.alignment13]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			w4.Padding = ((uint)(10));
			this.hbox8.Add (this.vbox7);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.vbox7]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.alignment12.Add (this.hbox8);
			this.vbox2.Add (this.alignment12);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.alignment12]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.WidthRequest = 1250;
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.fixed3 = new global::Gtk.Fixed ();
			this.fixed3.Name = "fixed3";
			this.fixed3.HasWindow = false;
			// Container child fixed3.Gtk.Fixed+FixedChild
			this.labelPrevius = new global::Gtk.Label ();
			this.labelPrevius.WidthRequest = 1000;
			this.labelPrevius.Name = "labelPrevius";
			this.labelPrevius.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
			this.labelPrevius.UseMarkup = true;
			this.fixed3.Add (this.labelPrevius);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.labelPrevius]));
			w8.X = 20;
			w8.Y = 50;
			this.vbox3.Add (this.fixed3);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.fixed3]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox ();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.alignment9 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment9.Name = "alignment9";
			this.vbox6.Add (this.alignment9);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.alignment9]));
			w10.Position = 0;
			// Container child vbox6.Gtk.Box+BoxChild
			this.image5 = new global::Gtk.Image ();
			this.image5.Name = "image5";
			this.image5.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.gui.abuelo2.png");
			this.vbox6.Add (this.image5);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.image5]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.hbox9.Add (this.vbox6);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.vbox6]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.fixed2 = new global::Gtk.Fixed ();
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.image6 = new global::Gtk.Image ();
			this.image6.Name = "image6";
			this.image6.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.Reasoning.gui.dialog2.png");
			this.fixed2.Add (this.image6);
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.label5 = new global::Gtk.Label ();
			this.label5.WidthRequest = 786;
			this.label5.HeightRequest = 189;
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("<span color=\"blue\"><big><big><big><big><big><big>Pulsa el botón <span color=\"black\"><b>¡Listo!</b></span> cuando estés preparado para iniciar una nueva secuencia de este ejercicio.</big></big></big></big></big></big></span>\n");
			this.label5.UseMarkup = true;
			this.label5.Wrap = true;
			this.fixed2.Add (this.label5);
			global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.label5]));
			w14.X = 115;
			w14.Y = 70;
			this.hbox9.Add (this.fixed2);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.fixed2]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			this.vbox3.Add (this.hbox9);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox9]));
			w16.Position = 1;
			w16.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator ();
			this.hseparator2.Name = "hseparator2";
			this.vbox3.Add (this.hseparator2);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hseparator2]));
			w17.Position = 2;
			w17.Expand = false;
			w17.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.alignment16 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment16.Name = "alignment16";
			this.hbox7.Add (this.alignment16);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.alignment16]));
			w18.Position = 0;
			// Container child hbox7.Gtk.Box+BoxChild
			this.botonListo1 = new global::Gtk.Button ();
			this.botonListo1.CanFocus = true;
			this.botonListo1.Name = "botonListo1";
			this.botonListo1.UseUnderline = true;
			// Container child botonListo1.Gtk.Container+ContainerChild
			global::Gtk.Alignment w19 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w20 = new global::Gtk.HBox ();
			w20.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w21 = new global::Gtk.Image ();
			w21.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Dnd);
			w20.Add (w21);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w23 = new global::Gtk.Label ();
			w23.LabelProp = global::Mono.Unix.Catalog.GetString ("¡Listo!");
			w23.UseUnderline = true;
			w20.Add (w23);
			w19.Add (w20);
			this.botonListo1.Add (w19);
			this.hbox7.Add (this.botonListo1);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.botonListo1]));
			w27.Position = 1;
			this.vbox3.Add (this.hbox7);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox7]));
			w28.Position = 3;
			w28.Expand = false;
			w28.Fill = false;
			this.hbox1.Add (this.vbox3);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox3]));
			w29.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table (((uint)(3)), ((uint)(3)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.alignment2 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment2.Name = "alignment2";
			this.table2.Add (this.alignment2);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table2[this.alignment2]));
			w30.LeftAttach = ((uint)(1));
			w30.RightAttach = ((uint)(2));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.alignment4 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment4.Name = "alignment4";
			this.table2.Add (this.alignment4);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table2[this.alignment4]));
			w31.TopAttach = ((uint)(1));
			w31.BottomAttach = ((uint)(2));
			w31.LeftAttach = ((uint)(2));
			w31.RightAttach = ((uint)(3));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.alignment6 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment6.Name = "alignment6";
			this.table2.Add (this.alignment6);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table2[this.alignment6]));
			w32.TopAttach = ((uint)(1));
			w32.BottomAttach = ((uint)(2));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.alignment7 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment7.Name = "alignment7";
			this.table2.Add (this.alignment7);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table2[this.alignment7]));
			w33.TopAttach = ((uint)(2));
			w33.BottomAttach = ((uint)(3));
			w33.LeftAttach = ((uint)(1));
			w33.RightAttach = ((uint)(2));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.image394 = new global::Gtk.Image ();
			this.image394.Name = "image394";
			this.image394.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.LetrasYNumeros.blackboard.png");
			this.fixed1.Add (this.image394);
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.labelCaracter = new global::Gtk.Label ();
			this.labelCaracter.WidthRequest = 149;
			this.labelCaracter.HeightRequest = 194;
			this.labelCaracter.Name = "labelCaracter";
			this.labelCaracter.Justify = ((global::Gtk.Justification)(2));
			this.fixed1.Add (this.labelCaracter);
			global::Gtk.Fixed.FixedChild w35 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.labelCaracter]));
			w35.X = 170;
			w35.Y = 53;
			this.table2.Add (this.fixed1);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.table2[this.fixed1]));
			w36.TopAttach = ((uint)(1));
			w36.BottomAttach = ((uint)(2));
			w36.LeftAttach = ((uint)(1));
			w36.RightAttach = ((uint)(2));
			w36.XOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add (this.table2);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.table2]));
			w37.Position = 1;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.WidthRequest = 1250;
			this.vbox4.Name = "vbox4";
			// Container child vbox4.Gtk.Box+BoxChild
			this.alignment11 = new global::Gtk.Alignment (0f, 0f, 1f, 0f);
			this.alignment11.Name = "alignment11";
			this.alignment11.LeftPadding = ((uint)(20));
			// Container child alignment11.Gtk.Container+ContainerChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 15;
			// Container child hbox6.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1f;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<big><big>Completado: </big></big>");
			this.label1.UseMarkup = true;
			this.hbox6.Add (this.label1);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.label1]));
			w38.Position = 0;
			w38.Expand = false;
			w38.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.hboxCompletado = new global::Gtk.HBox ();
			this.hboxCompletado.Name = "hboxCompletado";
			this.hboxCompletado.Spacing = 6;
			this.hbox6.Add (this.hboxCompletado);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.hboxCompletado]));
			w39.Position = 1;
			this.alignment11.Add (this.hbox6);
			this.vbox4.Add (this.alignment11);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.alignment11]));
			w41.Position = 0;
			w41.Expand = false;
			w41.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox8 = new global::Gtk.VBox ();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			// Container child vbox8.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(3)), true);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(3));
			this.table1.ColumnSpacing = ((uint)(3));
			this.table1.BorderWidth = ((uint)(50));
			// Container child table1.Gtk.Table+TableChild
			this.boton1 = new global::Gtk.Button ();
			this.boton1.CanFocus = true;
			this.boton1.Name = "boton1";
			// Container child boton1.Gtk.Container+ContainerChild
			this.image588 = new global::Gtk.Image ();
			this.image588.Name = "image588";
			this.image588.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.resources.img.numersvowels.num1.gif");
			this.boton1.Add (this.image588);
			this.boton1.Label = null;
			this.table1.Add (this.boton1);
			// Container child table1.Gtk.Table+TableChild
			this.boton2 = new global::Gtk.Button ();
			this.boton2.CanFocus = true;
			this.boton2.Name = "boton2";
			// Container child boton2.Gtk.Container+ContainerChild
			this.image589 = new global::Gtk.Image ();
			this.image589.Name = "image589";
			this.image589.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.resources.img.numersvowels.num2.gif");
			this.boton2.Add (this.image589);
			this.boton2.Label = null;
			this.table1.Add (this.boton2);
			global::Gtk.Table.TableChild w45 = ((global::Gtk.Table.TableChild)(this.table1[this.boton2]));
			w45.LeftAttach = ((uint)(1));
			w45.RightAttach = ((uint)(2));
			// Container child table1.Gtk.Table+TableChild
			this.boton3 = new global::Gtk.Button ();
			this.boton3.CanFocus = true;
			this.boton3.Name = "boton3";
			// Container child boton3.Gtk.Container+ContainerChild
			this.image590 = new global::Gtk.Image ();
			this.image590.Name = "image590";
			this.image590.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.resources.img.numersvowels.num3.gif");
			this.boton3.Add (this.image590);
			this.boton3.Label = null;
			this.table1.Add (this.boton3);
			global::Gtk.Table.TableChild w47 = ((global::Gtk.Table.TableChild)(this.table1[this.boton3]));
			w47.LeftAttach = ((uint)(2));
			w47.RightAttach = ((uint)(3));
			// Container child table1.Gtk.Table+TableChild
			this.boton4 = new global::Gtk.Button ();
			this.boton4.CanFocus = true;
			this.boton4.Name = "boton4";
			// Container child boton4.Gtk.Container+ContainerChild
			this.image591 = new global::Gtk.Image ();
			this.image591.Name = "image591";
			this.image591.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.resources.img.numersvowels.num4.gif");
			this.boton4.Add (this.image591);
			this.boton4.Label = null;
			this.table1.Add (this.boton4);
			global::Gtk.Table.TableChild w49 = ((global::Gtk.Table.TableChild)(this.table1[this.boton4]));
			w49.TopAttach = ((uint)(1));
			w49.BottomAttach = ((uint)(2));
			// Container child table1.Gtk.Table+TableChild
			this.boton5 = new global::Gtk.Button ();
			this.boton5.CanFocus = true;
			this.boton5.Name = "boton5";
			// Container child boton5.Gtk.Container+ContainerChild
			this.image592 = new global::Gtk.Image ();
			this.image592.Name = "image592";
			this.image592.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.resources.img.numersvowels.num5.gif");
			this.boton5.Add (this.image592);
			this.boton5.Label = null;
			this.table1.Add (this.boton5);
			global::Gtk.Table.TableChild w51 = ((global::Gtk.Table.TableChild)(this.table1[this.boton5]));
			w51.TopAttach = ((uint)(1));
			w51.BottomAttach = ((uint)(2));
			w51.LeftAttach = ((uint)(1));
			w51.RightAttach = ((uint)(2));
			// Container child table1.Gtk.Table+TableChild
			this.boton6 = new global::Gtk.Button ();
			this.boton6.CanFocus = true;
			this.boton6.Name = "boton6";
			// Container child boton6.Gtk.Container+ContainerChild
			this.image593 = new global::Gtk.Image ();
			this.image593.Name = "image593";
			this.image593.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.resources.img.numersvowels.num6.gif");
			this.boton6.Add (this.image593);
			this.boton6.Label = null;
			this.table1.Add (this.boton6);
			global::Gtk.Table.TableChild w53 = ((global::Gtk.Table.TableChild)(this.table1[this.boton6]));
			w53.TopAttach = ((uint)(1));
			w53.BottomAttach = ((uint)(2));
			w53.LeftAttach = ((uint)(2));
			w53.RightAttach = ((uint)(3));
			// Container child table1.Gtk.Table+TableChild
			this.boton7 = new global::Gtk.Button ();
			this.boton7.CanFocus = true;
			this.boton7.Name = "boton7";
			// Container child boton7.Gtk.Container+ContainerChild
			this.image594 = new global::Gtk.Image ();
			this.image594.Name = "image594";
			this.image594.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.resources.img.numersvowels.num7.gif");
			this.boton7.Add (this.image594);
			this.boton7.Label = null;
			this.table1.Add (this.boton7);
			global::Gtk.Table.TableChild w55 = ((global::Gtk.Table.TableChild)(this.table1[this.boton7]));
			w55.TopAttach = ((uint)(2));
			w55.BottomAttach = ((uint)(3));
			// Container child table1.Gtk.Table+TableChild
			this.boton8 = new global::Gtk.Button ();
			this.boton8.CanFocus = true;
			this.boton8.Name = "boton8";
			// Container child boton8.Gtk.Container+ContainerChild
			this.image595 = new global::Gtk.Image ();
			this.image595.Name = "image595";
			this.image595.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.resources.img.numersvowels.num8.gif");
			this.boton8.Add (this.image595);
			this.boton8.Label = null;
			this.table1.Add (this.boton8);
			global::Gtk.Table.TableChild w57 = ((global::Gtk.Table.TableChild)(this.table1[this.boton8]));
			w57.TopAttach = ((uint)(2));
			w57.BottomAttach = ((uint)(3));
			w57.LeftAttach = ((uint)(1));
			w57.RightAttach = ((uint)(2));
			// Container child table1.Gtk.Table+TableChild
			this.boton9 = new global::Gtk.Button ();
			this.boton9.CanFocus = true;
			this.boton9.Name = "boton9";
			// Container child boton9.Gtk.Container+ContainerChild
			this.image596 = new global::Gtk.Image ();
			this.image596.Name = "image596";
			this.image596.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.resources.img.numersvowels.num9.gif");
			this.boton9.Add (this.image596);
			this.boton9.Label = null;
			this.table1.Add (this.boton9);
			global::Gtk.Table.TableChild w59 = ((global::Gtk.Table.TableChild)(this.table1[this.boton9]));
			w59.TopAttach = ((uint)(2));
			w59.BottomAttach = ((uint)(3));
			w59.LeftAttach = ((uint)(2));
			w59.RightAttach = ((uint)(3));
			this.vbox8.Add (this.table1);
			global::Gtk.Box.BoxChild w60 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.table1]));
			w60.Position = 1;
			w60.Expand = false;
			w60.Fill = false;
			this.hbox2.Add (this.vbox8);
			global::Gtk.Box.BoxChild w61 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox8]));
			w61.Position = 0;
			w61.Expand = false;
			w61.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment5 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment5.Name = "alignment5";
			this.hbox2.Add (this.alignment5);
			global::Gtk.Box.BoxChild w62 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.alignment5]));
			w62.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 3;
			this.vbox5.BorderWidth = ((uint)(50));
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Homogeneous = true;
			this.hbox3.Spacing = 3;
			// Container child hbox3.Gtk.Box+BoxChild
			this.botonA = new global::Gtk.Button ();
			this.botonA.CanFocus = true;
			this.botonA.Name = "botonA";
			// Container child botonA.Gtk.Container+ContainerChild
			this.image469 = new global::Gtk.Image ();
			this.image469.Name = "image469";
			this.image469.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.resources.img.numersvowels.vocala.gif");
			this.botonA.Add (this.image469);
			this.botonA.Label = null;
			this.hbox3.Add (this.botonA);
			global::Gtk.Box.BoxChild w64 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.botonA]));
			w64.Position = 0;
			w64.Expand = false;
			w64.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.botonE = new global::Gtk.Button ();
			this.botonE.CanFocus = true;
			this.botonE.Name = "botonE";
			// Container child botonE.Gtk.Container+ContainerChild
			this.image470 = new global::Gtk.Image ();
			this.image470.Name = "image470";
			this.image470.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.resources.img.numersvowels.vocale.gif");
			this.botonE.Add (this.image470);
			this.botonE.Label = null;
			this.hbox3.Add (this.botonE);
			global::Gtk.Box.BoxChild w66 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.botonE]));
			w66.Position = 1;
			w66.Expand = false;
			w66.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.botonI = new global::Gtk.Button ();
			this.botonI.CanFocus = true;
			this.botonI.Name = "botonI";
			// Container child botonI.Gtk.Container+ContainerChild
			this.image471 = new global::Gtk.Image ();
			this.image471.Name = "image471";
			this.image471.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.resources.img.numersvowels.vocali.gif");
			this.botonI.Add (this.image471);
			this.botonI.Label = null;
			this.hbox3.Add (this.botonI);
			global::Gtk.Box.BoxChild w68 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.botonI]));
			w68.Position = 2;
			w68.Expand = false;
			w68.Fill = false;
			this.vbox5.Add (this.hbox3);
			global::Gtk.Box.BoxChild w69 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox3]));
			w69.Position = 1;
			w69.Expand = false;
			w69.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 3;
			// Container child hbox5.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment1.Name = "alignment1";
			// Container child alignment1.Gtk.Container+ContainerChild
			this.botonO = new global::Gtk.Button ();
			this.botonO.CanFocus = true;
			this.botonO.Name = "botonO";
			// Container child botonO.Gtk.Container+ContainerChild
			this.image472 = new global::Gtk.Image ();
			this.image472.Name = "image472";
			this.image472.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.resources.img.numersvowels.vocalo.gif");
			this.botonO.Add (this.image472);
			this.botonO.Label = null;
			this.alignment1.Add (this.botonO);
			this.hbox5.Add (this.alignment1);
			global::Gtk.Box.BoxChild w72 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.alignment1]));
			w72.Position = 0;
			w72.Expand = false;
			w72.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.botonU = new global::Gtk.Button ();
			this.botonU.CanFocus = true;
			this.botonU.Name = "botonU";
			// Container child botonU.Gtk.Container+ContainerChild
			this.botonU1 = new global::Gtk.Button ();
			this.botonU1.CanFocus = true;
			this.botonU1.Name = "botonU1";
			// Container child botonU1.Gtk.Container+ContainerChild
			this.image473 = new global::Gtk.Image ();
			this.image473.Name = "image473";
			this.image473.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.resources.img.numersvowels.vocalu.gif");
			this.botonU1.Add (this.image473);
			this.botonU1.Label = null;
			this.botonU.Add (this.botonU1);
			this.botonU.Label = null;
			this.hbox5.Add (this.botonU);
			global::Gtk.Box.BoxChild w75 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.botonU]));
			w75.Position = 1;
			w75.Expand = false;
			w75.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment3.Name = "alignment3";
			this.hbox5.Add (this.alignment3);
			global::Gtk.Box.BoxChild w76 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.alignment3]));
			w76.Position = 3;
			this.vbox5.Add (this.hbox5);
			global::Gtk.Box.BoxChild w77 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox5]));
			w77.Position = 2;
			w77.Expand = false;
			w77.Fill = false;
			this.hbox2.Add (this.vbox5);
			global::Gtk.Box.BoxChild w78 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox5]));
			w78.Position = 2;
			w78.Expand = false;
			w78.Fill = false;
			this.vbox4.Add (this.hbox2);
			global::Gtk.Box.BoxChild w79 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox2]));
			w79.Position = 1;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox4.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w80 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hseparator1]));
			w80.Position = 2;
			w80.Expand = false;
			w80.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 3;
			// Container child hbox4.Gtk.Box+BoxChild
			this.alignment8 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment8.Name = "alignment8";
			this.hbox4.Add (this.alignment8);
			global::Gtk.Box.BoxChild w81 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.alignment8]));
			w81.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.botonListo = new global::Gtk.Button ();
			this.botonListo.CanFocus = true;
			this.botonListo.Name = "botonListo";
			this.botonListo.UseUnderline = true;
			// Container child botonListo.Gtk.Container+ContainerChild
			global::Gtk.Alignment w82 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w83 = new global::Gtk.HBox ();
			w83.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w84 = new global::Gtk.Image ();
			w84.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Dnd);
			w83.Add (w84);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w86 = new global::Gtk.Label ();
			w86.LabelProp = global::Mono.Unix.Catalog.GetString ("¡Listo!");
			w86.UseUnderline = true;
			w83.Add (w86);
			w82.Add (w83);
			this.botonListo.Add (w82);
			this.hbox4.Add (this.botonListo);
			global::Gtk.Box.BoxChild w90 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.botonListo]));
			w90.Position = 1;
			w90.Expand = false;
			w90.Fill = false;
			this.vbox4.Add (this.hbox4);
			global::Gtk.Box.BoxChild w91 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox4]));
			w91.Position = 3;
			w91.Expand = false;
			w91.Fill = false;
			this.hbox1.Add (this.vbox4);
			global::Gtk.Box.BoxChild w92 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox4]));
			w92.Position = 2;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w93 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w93.Position = 1;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.botonListo1.Hide ();
			this.botonListo.Hide ();
			this.Hide ();
			this.boton9.Clicked += new global::System.EventHandler (this.OnClickNine);
			this.boton8.Clicked += new global::System.EventHandler (this.OnClickEight);
			this.boton7.Clicked += new global::System.EventHandler (this.OnClickSeven);
			this.boton6.Clicked += new global::System.EventHandler (this.OnClickSix);
			this.boton5.Clicked += new global::System.EventHandler (this.OnClickFive);
			this.boton4.Clicked += new global::System.EventHandler (this.OnClickFour);
			this.boton3.Clicked += new global::System.EventHandler (this.OnClickThree);
			this.boton2.Clicked += new global::System.EventHandler (this.OnClickTwo);
			this.boton1.Clicked += new global::System.EventHandler (this.OnClickOne);
			this.botonA.Clicked += new global::System.EventHandler (this.OnClickA);
			this.botonE.Clicked += new global::System.EventHandler (this.OnClickE);
			this.botonI.Clicked += new global::System.EventHandler (this.OnClickI);
			this.botonO.Clicked += new global::System.EventHandler (this.OnClickO);
			this.botonU1.Clicked += new global::System.EventHandler (this.OnClickU);
		}
	}
}