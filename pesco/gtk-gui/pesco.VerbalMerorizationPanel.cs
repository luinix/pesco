
// This file has been generated by the GUI designer. Do not modify.
namespace pesco
{
	public partial class VerbalMerorizationPanel
	{
		private global::Gtk.HBox hbox1;

		private global::Gtk.Alignment alignment3;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Alignment alignment2;

		private global::Gtk.Frame frame1;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Image imagepepe;

		private global::Gtk.VBox vbox4;

		private global::Gtk.Label label3;

		private global::Gtk.VBox vbox5;

		private global::Gtk.Alignment alignment7;

		private global::Gtk.Alignment alignment8;

		private global::Gtk.Label explanation;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Alignment alignment9;

		private global::Gtk.VBox vbox6;

		private global::Gtk.Alignment alignment1;

		private global::Gtk.Table table3;

		private global::Gtk.Button botonListo;

		private global::Gtk.Image imagebtn2;

		private global::Gtk.Label labelP1;

		private global::Gtk.Label labelP11;

		private global::Gtk.Label labelP2;

		private global::Gtk.Label labelP22;

		private global::Gtk.Button recordButton;

		private global::Gtk.Image imagebtn1;

		private global::Gtk.Alignment alignment6;

		private global::Gtk.Alignment alignment10;

		private global::Gtk.Alignment alignment4;

		private global::Gtk.Alignment alignment5;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget pesco.VerbalMerorizationPanel
			global::Stetic.BinContainer.Attach (this);
			this.Name = "pesco.VerbalMerorizationPanel";
			// Container child pesco.VerbalMerorizationPanel.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment3.Name = "alignment3";
			this.hbox1.Add (this.alignment3);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.alignment3]));
			w1.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment2.Name = "alignment2";
			this.vbox2.Add (this.alignment2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.alignment2]));
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
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			// Container child hbox4.Gtk.Box+BoxChild
			this.imagepepe = new global::Gtk.Image ();
			this.imagepepe.Name = "imagepepe";
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
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("<big><big><big><big><b>Grabar Lista de Palabras</b></big></big></big></big>");
			this.label3.UseMarkup = true;
			this.label3.UseUnderline = true;
			this.vbox4.Add (this.label3);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.label3]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			w4.Padding = ((uint)(2));
			// Container child vbox4.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.alignment7 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment7.Name = "alignment7";
			this.vbox5.Add (this.alignment7);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.alignment7]));
			w5.Position = 0;
			// Container child vbox5.Gtk.Box+BoxChild
			this.alignment8 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment8.Name = "alignment8";
			this.alignment8.LeftPadding = ((uint)(50));
			// Container child alignment8.Gtk.Container+ContainerChild
			this.explanation = new global::Gtk.Label ();
			this.explanation.WidthRequest = 1000;
			this.explanation.Name = "explanation";
			this.explanation.Yalign = 1f;
			this.explanation.LabelProp = global::Mono.Unix.Catalog.GetString ("<big><big><big>Siga los pasos y grabe por el micrófono las palabras que recuerde\nde la lista de color azul. </big></big></big>");
			this.explanation.UseMarkup = true;
			this.explanation.Wrap = true;
			this.alignment8.Add (this.explanation);
			this.vbox5.Add (this.alignment8);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.alignment8]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.vbox4.Add (this.vbox5);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.vbox5]));
			w8.Position = 1;
			w8.Padding = ((uint)(10));
			this.hbox4.Add (this.vbox4);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox4]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			this.vbox3.Add (this.hbox4);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox4]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox3.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hseparator1]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.alignment9 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment9.Name = "alignment9";
			this.hbox3.Add (this.alignment9);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.alignment9]));
			w12.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment1.Name = "alignment1";
			this.vbox6.Add (this.alignment1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.alignment1]));
			w13.Position = 0;
			// Container child vbox6.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table (((uint)(2)), ((uint)(3)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(40));
			this.table3.ColumnSpacing = ((uint)(40));
			// Container child table3.Gtk.Table+TableChild
			this.botonListo = new global::Gtk.Button ();
			this.botonListo.CanFocus = true;
			this.botonListo.Name = "botonListo";
			// Container child botonListo.Gtk.Container+ContainerChild
			this.imagebtn2 = new global::Gtk.Image ();
			this.imagebtn2.Name = "imagebtn2";
			this.botonListo.Add (this.imagebtn2);
			this.botonListo.Label = null;
			this.table3.Add (this.botonListo);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table3[this.botonListo]));
			w15.TopAttach = ((uint)(1));
			w15.BottomAttach = ((uint)(2));
			w15.LeftAttach = ((uint)(2));
			w15.RightAttach = ((uint)(3));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.labelP1 = new global::Gtk.Label ();
			this.labelP1.Name = "labelP1";
			this.labelP1.LabelProp = global::Mono.Unix.Catalog.GetString ("<big><big><big><b>Paso 1.</b></big></big></big>");
			this.labelP1.UseMarkup = true;
			this.table3.Add (this.labelP1);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table3[this.labelP1]));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.labelP11 = new global::Gtk.Label ();
			this.labelP11.Name = "labelP11";
			this.labelP11.Xalign = 0f;
			this.labelP11.LabelProp = global::Mono.Unix.Catalog.GetString ("<big><big><big>Pulse<b> Comenzar Grabación</b> y hable\npara decir las palabras.</big></big></big>");
			this.labelP11.UseMarkup = true;
			this.table3.Add (this.labelP11);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table3[this.labelP11]));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.labelP2 = new global::Gtk.Label ();
			this.labelP2.Sensitive = false;
			this.labelP2.Name = "labelP2";
			this.labelP2.LabelProp = global::Mono.Unix.Catalog.GetString ("<big><big><big><b>Paso 2:</b></big></big></big>");
			this.labelP2.UseMarkup = true;
			this.table3.Add (this.labelP2);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table3[this.labelP2]));
			w18.TopAttach = ((uint)(1));
			w18.BottomAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.labelP22 = new global::Gtk.Label ();
			this.labelP22.Sensitive = false;
			this.labelP22.Name = "labelP22";
			this.labelP22.Xalign = 0f;
			this.labelP22.LabelProp = global::Mono.Unix.Catalog.GetString ("<big><big><big>Pulse <b>Parar Grabación</b>, cuando termine\nde hablar.</big></big></big>");
			this.labelP22.UseMarkup = true;
			this.table3.Add (this.labelP22);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table3[this.labelP22]));
			w19.TopAttach = ((uint)(1));
			w19.BottomAttach = ((uint)(2));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.recordButton = new global::Gtk.Button ();
			this.recordButton.CanFocus = true;
			this.recordButton.Name = "recordButton";
			// Container child recordButton.Gtk.Container+ContainerChild
			this.imagebtn1 = new global::Gtk.Image ();
			this.imagebtn1.Name = "imagebtn1";
			this.recordButton.Add (this.imagebtn1);
			this.recordButton.Label = null;
			this.table3.Add (this.recordButton);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table3[this.recordButton]));
			w21.LeftAttach = ((uint)(2));
			w21.RightAttach = ((uint)(3));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox6.Add (this.table3);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.table3]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.alignment6 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment6.Name = "alignment6";
			this.vbox6.Add (this.alignment6);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.alignment6]));
			w23.Position = 2;
			this.hbox3.Add (this.vbox6);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.vbox6]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.alignment10 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment10.Name = "alignment10";
			this.hbox3.Add (this.alignment10);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.alignment10]));
			w25.Position = 2;
			this.vbox1.Add (this.hbox3);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
			w26.PackType = ((global::Gtk.PackType)(1));
			w26.Position = 0;
			this.vbox3.Add (this.vbox1);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.vbox1]));
			w27.Position = 2;
			this.GtkAlignment.Add (this.vbox3);
			this.frame1.Add (this.GtkAlignment);
			this.vbox2.Add (this.frame1);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.frame1]));
			w30.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment4.Name = "alignment4";
			this.vbox2.Add (this.alignment4);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.alignment4]));
			w31.Position = 2;
			this.hbox1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox2]));
			w32.Position = 1;
			w32.Expand = false;
			w32.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment5 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment5.Name = "alignment5";
			this.hbox1.Add (this.alignment5);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.alignment5]));
			w33.Position = 2;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
