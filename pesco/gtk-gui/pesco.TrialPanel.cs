
// This file has been generated by the GUI designer. Do not modify.
namespace pesco
{
	public partial class TrialPanel
	{
		private global::Gtk.HBox hbox2;

		private global::Gtk.Alignment alignment10;

		private global::Gtk.VBox vbox1;

		private global::Gtk.Alignment alignment11;

		private global::Gtk.Frame frame3;

		private global::Gtk.Alignment GtkAlignment3;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Alignment alignment2;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Image imagepepe;

		private global::Gtk.VBox vbox3;

		private global::Gtk.Label label1;

		private global::Gtk.Alignment alignment13;

		private global::Gtk.Alignment alignment4;

		private global::Gtk.Label explanation;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Frame frame2;

		private global::Gtk.Alignment GtkAlignment2;

		private global::Gtk.Table objectsBox;

		private global::Gtk.Label GtkLabel5;

		private global::Gtk.Frame frame1;

		private global::Gtk.Alignment GtkAlignment1;

		private global::Gtk.HBox categoriesBox;

		private global::Gtk.VBox vboxc1;

		private global::Gtk.Button buttonc1;

		private global::Gtk.Fixed fixedc1;

		private global::Gtk.EventBox eventboxc1;

		private global::Gtk.Image imagec1;

		private global::Gtk.Table tablec1;

		private global::Gtk.VBox vboxc2;

		private global::Gtk.Button buttonc2;

		private global::Gtk.Fixed fixedc2;

		private global::Gtk.EventBox eventboxc2;

		private global::Gtk.Image imagec2;

		private global::Gtk.Table tablec2;

		private global::Gtk.VBox vboxc3;

		private global::Gtk.Button buttonc3;

		private global::Gtk.Fixed fixedc3;

		private global::Gtk.EventBox eventboxc3;

		private global::Gtk.Image imagec3;

		private global::Gtk.Table tablec3;

		private global::Gtk.VBox vboxc4;

		private global::Gtk.Button buttonc4;

		private global::Gtk.Fixed fixedc4;

		private global::Gtk.EventBox eventboxc4;

		private global::Gtk.Image imagec4;

		private global::Gtk.Table tablec4;

		private global::Gtk.Label GtkLabel6;

		private global::Gtk.HBox buttonBox;

		private global::Gtk.Alignment alignment3;

		private global::Gtk.Button buttonNext;

		private global::Gtk.Alignment alignment12;

		private global::Gtk.Alignment alignment9;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget pesco.TrialPanel
			global::Stetic.BinContainer.Attach (this);
			this.Name = "pesco.TrialPanel";
			// Container child pesco.TrialPanel.Gtk.Container+ContainerChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.WidthRequest = 1200;
			this.hbox2.HeightRequest = 660;
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment10 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment10.Name = "alignment10";
			this.hbox2.Add (this.alignment10);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.alignment10]));
			w1.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			// Container child vbox1.Gtk.Box+BoxChild
			this.alignment11 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment11.Name = "alignment11";
			this.vbox1.Add (this.alignment11);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.alignment11]));
			w2.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frame3 = new global::Gtk.Frame ();
			this.frame3.WidthRequest = 1250;
			this.frame3.HeightRequest = 660;
			this.frame3.Name = "frame3";
			this.frame3.ShadowType = ((global::Gtk.ShadowType)(1));
			this.frame3.LabelYalign = 0f;
			// Container child frame3.Gtk.Container+ContainerChild
			this.GtkAlignment3 = new global::Gtk.Alignment (0f, 0f, 1f, 1f);
			this.GtkAlignment3.Name = "GtkAlignment3";
			// Container child GtkAlignment3.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment2.HeightRequest = 120;
			this.alignment2.Name = "alignment2";
			// Container child alignment2.Gtk.Container+ContainerChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			// Container child hbox3.Gtk.Box+BoxChild
			this.imagepepe = new global::Gtk.Image ();
			this.imagepepe.Name = "imagepepe";
			this.imagepepe.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.resources.img.classifyobjects.pepehablac.png");
			this.hbox3.Add (this.imagepepe);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.imagepepe]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 1;
			// Container child vbox3.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<big><big><big><big><b>Prueba de Clasificación</b></big></big></big></big>");
			this.label1.UseMarkup = true;
			this.label1.UseUnderline = true;
			this.vbox3.Add (this.label1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.label1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			w4.Padding = ((uint)(10));
			// Container child vbox3.Gtk.Box+BoxChild
			this.alignment13 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment13.Name = "alignment13";
			this.vbox3.Add (this.alignment13);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.alignment13]));
			w5.Position = 1;
			// Container child vbox3.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment4.Name = "alignment4";
			this.alignment4.LeftPadding = ((uint)(50));
			// Container child alignment4.Gtk.Container+ContainerChild
			this.explanation = new global::Gtk.Label ();
			this.explanation.WidthRequest = 1000;
			this.explanation.HeightRequest = 75;
			this.explanation.Name = "explanation";
			this.explanation.Yalign = 1f;
			this.explanation.LabelProp = global::Mono.Unix.Catalog.GetString ("<big><big><big><b>Pulsa una imagen para seleccionarla y luego pulsa sobre el nombre de su categoría</b></big></big></big>");
			this.explanation.UseMarkup = true;
			this.explanation.Wrap = true;
			this.alignment4.Add (this.explanation);
			this.vbox3.Add (this.alignment4);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.alignment4]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			w7.Padding = ((uint)(10));
			this.hbox3.Add (this.vbox3);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.vbox3]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.alignment2.Add (this.hbox3);
			this.vbox2.Add (this.alignment2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.alignment2]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.WidthRequest = 900;
			this.frame2.HeightRequest = 300;
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0f, 0f, 1f, 1f);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(5));
			this.GtkAlignment2.RightPadding = ((uint)(5));
			this.GtkAlignment2.BottomPadding = ((uint)(1));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.objectsBox = new global::Gtk.Table (((uint)(2)), ((uint)(8)), true);
			this.objectsBox.Name = "objectsBox";
			this.GtkAlignment2.Add (this.objectsBox);
			this.frame2.Add (this.GtkAlignment2);
			this.GtkLabel5 = new global::Gtk.Label ();
			this.GtkLabel5.Sensitive = false;
			this.GtkLabel5.Name = "GtkLabel5";
			this.GtkLabel5.Yalign = 0f;
			this.frame2.LabelWidget = this.GtkLabel5;
			this.hbox1.Add (this.frame2);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.frame2]));
			w13.Position = 1;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w14.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment (0f, 0f, 1f, 1f);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(1));
			this.GtkAlignment1.TopPadding = ((uint)(1));
			this.GtkAlignment1.RightPadding = ((uint)(1));
			this.GtkAlignment1.BottomPadding = ((uint)(1));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.categoriesBox = new global::Gtk.HBox ();
			this.categoriesBox.Name = "categoriesBox";
			// Container child categoriesBox.Gtk.Box+BoxChild
			this.vboxc1 = new global::Gtk.VBox ();
			this.vboxc1.Name = "vboxc1";
			// Container child vboxc1.Gtk.Box+BoxChild
			this.buttonc1 = new global::Gtk.Button ();
			this.buttonc1.CanFocus = true;
			this.buttonc1.Name = "buttonc1";
			this.buttonc1.UseUnderline = true;
			this.buttonc1.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
			this.vboxc1.Add (this.buttonc1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vboxc1[this.buttonc1]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vboxc1.Gtk.Box+BoxChild
			this.fixedc1 = new global::Gtk.Fixed ();
			this.fixedc1.WidthRequest = 300;
			this.fixedc1.HeightRequest = 340;
			this.fixedc1.Name = "fixedc1";
			this.fixedc1.HasWindow = false;
			// Container child fixedc1.Gtk.Fixed+FixedChild
			this.eventboxc1 = new global::Gtk.EventBox ();
			this.eventboxc1.Name = "eventboxc1";
			this.eventboxc1.VisibleWindow = false;
			// Container child eventboxc1.Gtk.Container+ContainerChild
			this.imagec1 = new global::Gtk.Image ();
			this.imagec1.Name = "imagec1";
			this.imagec1.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.resources.img.classifyobjects.clasify1.png");
			this.eventboxc1.Add (this.imagec1);
			this.fixedc1.Add (this.eventboxc1);
			// Container child fixedc1.Gtk.Fixed+FixedChild
			this.tablec1 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), true);
			this.tablec1.WidthRequest = 300;
			this.tablec1.HeightRequest = 240;
			this.tablec1.Name = "tablec1";
			this.tablec1.RowSpacing = ((uint)(6));
			this.tablec1.ColumnSpacing = ((uint)(6));
			this.fixedc1.Add (this.tablec1);
			this.vboxc1.Add (this.fixedc1);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vboxc1[this.fixedc1]));
			w19.Position = 1;
			this.categoriesBox.Add (this.vboxc1);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.categoriesBox[this.vboxc1]));
			w20.Position = 0;
			w20.Expand = false;
			// Container child categoriesBox.Gtk.Box+BoxChild
			this.vboxc2 = new global::Gtk.VBox ();
			this.vboxc2.WidthRequest = 300;
			this.vboxc2.HeightRequest = 300;
			this.vboxc2.Name = "vboxc2";
			// Container child vboxc2.Gtk.Box+BoxChild
			this.buttonc2 = new global::Gtk.Button ();
			this.buttonc2.CanFocus = true;
			this.buttonc2.Name = "buttonc2";
			this.buttonc2.UseUnderline = true;
			this.buttonc2.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
			this.vboxc2.Add (this.buttonc2);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vboxc2[this.buttonc2]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vboxc2.Gtk.Box+BoxChild
			this.fixedc2 = new global::Gtk.Fixed ();
			this.fixedc2.WidthRequest = 300;
			this.fixedc2.HeightRequest = 340;
			this.fixedc2.Name = "fixedc2";
			this.fixedc2.HasWindow = false;
			// Container child fixedc2.Gtk.Fixed+FixedChild
			this.eventboxc2 = new global::Gtk.EventBox ();
			this.eventboxc2.Name = "eventboxc2";
			this.eventboxc2.VisibleWindow = false;
			// Container child eventboxc2.Gtk.Container+ContainerChild
			this.imagec2 = new global::Gtk.Image ();
			this.imagec2.Name = "imagec2";
			this.imagec2.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.resources.img.classifyobjects.clasify2.png");
			this.eventboxc2.Add (this.imagec2);
			this.fixedc2.Add (this.eventboxc2);
			// Container child fixedc2.Gtk.Fixed+FixedChild
			this.tablec2 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), true);
			this.tablec2.WidthRequest = 300;
			this.tablec2.HeightRequest = 240;
			this.tablec2.Name = "tablec2";
			this.tablec2.RowSpacing = ((uint)(6));
			this.tablec2.ColumnSpacing = ((uint)(6));
			this.fixedc2.Add (this.tablec2);
			this.vboxc2.Add (this.fixedc2);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vboxc2[this.fixedc2]));
			w25.Position = 1;
			this.categoriesBox.Add (this.vboxc2);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.categoriesBox[this.vboxc2]));
			w26.Position = 1;
			w26.Fill = false;
			// Container child categoriesBox.Gtk.Box+BoxChild
			this.vboxc3 = new global::Gtk.VBox ();
			this.vboxc3.Name = "vboxc3";
			// Container child vboxc3.Gtk.Box+BoxChild
			this.buttonc3 = new global::Gtk.Button ();
			this.buttonc3.CanFocus = true;
			this.buttonc3.Name = "buttonc3";
			this.buttonc3.UseUnderline = true;
			this.buttonc3.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
			this.vboxc3.Add (this.buttonc3);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vboxc3[this.buttonc3]));
			w27.Position = 0;
			w27.Expand = false;
			w27.Fill = false;
			// Container child vboxc3.Gtk.Box+BoxChild
			this.fixedc3 = new global::Gtk.Fixed ();
			this.fixedc3.WidthRequest = 300;
			this.fixedc3.HeightRequest = 340;
			this.fixedc3.Name = "fixedc3";
			this.fixedc3.HasWindow = false;
			// Container child fixedc3.Gtk.Fixed+FixedChild
			this.eventboxc3 = new global::Gtk.EventBox ();
			this.eventboxc3.Name = "eventboxc3";
			this.eventboxc3.VisibleWindow = false;
			// Container child eventboxc3.Gtk.Container+ContainerChild
			this.imagec3 = new global::Gtk.Image ();
			this.imagec3.Name = "imagec3";
			this.imagec3.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.resources.img.classifyobjects.clasify3.png");
			this.eventboxc3.Add (this.imagec3);
			this.fixedc3.Add (this.eventboxc3);
			// Container child fixedc3.Gtk.Fixed+FixedChild
			this.tablec3 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), true);
			this.tablec3.WidthRequest = 300;
			this.tablec3.HeightRequest = 240;
			this.tablec3.Name = "tablec3";
			this.tablec3.RowSpacing = ((uint)(6));
			this.tablec3.ColumnSpacing = ((uint)(6));
			this.fixedc3.Add (this.tablec3);
			this.vboxc3.Add (this.fixedc3);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vboxc3[this.fixedc3]));
			w31.Position = 1;
			this.categoriesBox.Add (this.vboxc3);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.categoriesBox[this.vboxc3]));
			w32.Position = 2;
			w32.Expand = false;
			w32.Fill = false;
			// Container child categoriesBox.Gtk.Box+BoxChild
			this.vboxc4 = new global::Gtk.VBox ();
			this.vboxc4.WidthRequest = 300;
			this.vboxc4.HeightRequest = 300;
			this.vboxc4.Name = "vboxc4";
			// Container child vboxc4.Gtk.Box+BoxChild
			this.buttonc4 = new global::Gtk.Button ();
			this.buttonc4.CanFocus = true;
			this.buttonc4.Name = "buttonc4";
			this.buttonc4.UseUnderline = true;
			this.buttonc4.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
			this.vboxc4.Add (this.buttonc4);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vboxc4[this.buttonc4]));
			w33.Position = 0;
			w33.Expand = false;
			w33.Fill = false;
			// Container child vboxc4.Gtk.Box+BoxChild
			this.fixedc4 = new global::Gtk.Fixed ();
			this.fixedc4.WidthRequest = 300;
			this.fixedc4.HeightRequest = 340;
			this.fixedc4.Name = "fixedc4";
			this.fixedc4.HasWindow = false;
			// Container child fixedc4.Gtk.Fixed+FixedChild
			this.eventboxc4 = new global::Gtk.EventBox ();
			this.eventboxc4.Name = "eventboxc4";
			this.eventboxc4.VisibleWindow = false;
			// Container child eventboxc4.Gtk.Container+ContainerChild
			this.imagec4 = new global::Gtk.Image ();
			this.imagec4.Name = "imagec4";
			this.imagec4.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.ejercicios.resources.img.classifyobjects.clasify4.png");
			this.eventboxc4.Add (this.imagec4);
			this.fixedc4.Add (this.eventboxc4);
			// Container child fixedc4.Gtk.Fixed+FixedChild
			this.tablec4 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), true);
			this.tablec4.WidthRequest = 300;
			this.tablec4.HeightRequest = 240;
			this.tablec4.Name = "tablec4";
			this.tablec4.RowSpacing = ((uint)(6));
			this.tablec4.ColumnSpacing = ((uint)(6));
			this.fixedc4.Add (this.tablec4);
			this.vboxc4.Add (this.fixedc4);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vboxc4[this.fixedc4]));
			w37.Position = 1;
			this.categoriesBox.Add (this.vboxc4);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.categoriesBox[this.vboxc4]));
			w38.PackType = ((global::Gtk.PackType)(1));
			w38.Position = 3;
			w38.Fill = false;
			this.GtkAlignment1.Add (this.categoriesBox);
			this.frame1.Add (this.GtkAlignment1);
			this.GtkLabel6 = new global::Gtk.Label ();
			this.GtkLabel6.Name = "GtkLabel6";
			this.GtkLabel6.LabelProp = global::Mono.Unix.Catalog.GetString ("<big><big><b>Categorías</b></big> </big>                                                                                                               <big><big> <big><span color='blue'>Pulsa sobre la imagen ya clasificada y volverá a su lugar</span></big></big></big>");
			this.GtkLabel6.UseMarkup = true;
			this.GtkLabel6.Justify = ((global::Gtk.Justification)(2));
			this.frame1.LabelWidget = this.GtkLabel6;
			this.vbox2.Add (this.frame1);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.frame1]));
			w41.Position = 2;
			// Container child vbox2.Gtk.Box+BoxChild
			this.buttonBox = new global::Gtk.HBox ();
			this.buttonBox.HeightRequest = 50;
			this.buttonBox.Name = "buttonBox";
			// Container child buttonBox.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment3.Name = "alignment3";
			this.buttonBox.Add (this.alignment3);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.buttonBox[this.alignment3]));
			w42.Position = 0;
			// Container child buttonBox.Gtk.Box+BoxChild
			this.buttonNext = new global::Gtk.Button ();
			this.buttonNext.CanFocus = true;
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.UseUnderline = true;
			// Container child buttonNext.Gtk.Container+ContainerChild
			global::Gtk.Alignment w43 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w44 = new global::Gtk.HBox ();
			w44.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w45 = new global::Gtk.Image ();
			w45.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Dialog);
			w44.Add (w45);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w47 = new global::Gtk.Label ();
			w47.LabelProp = global::Mono.Unix.Catalog.GetString ("Terminar prueba");
			w47.UseUnderline = true;
			w44.Add (w47);
			w43.Add (w44);
			this.buttonNext.Add (w43);
			this.buttonBox.Add (this.buttonNext);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.buttonBox[this.buttonNext]));
			w51.Position = 1;
			this.vbox2.Add (this.buttonBox);
			global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.buttonBox]));
			w52.PackType = ((global::Gtk.PackType)(1));
			w52.Position = 3;
			w52.Expand = false;
			w52.Fill = false;
			this.GtkAlignment3.Add (this.vbox2);
			this.frame3.Add (this.GtkAlignment3);
			this.vbox1.Add (this.frame3);
			global::Gtk.Box.BoxChild w55 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frame3]));
			w55.Position = 1;
			// Container child vbox1.Gtk.Box+BoxChild
			this.alignment12 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment12.Name = "alignment12";
			this.vbox1.Add (this.alignment12);
			global::Gtk.Box.BoxChild w56 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.alignment12]));
			w56.PackType = ((global::Gtk.PackType)(1));
			w56.Position = 2;
			this.hbox2.Add (this.vbox1);
			global::Gtk.Box.BoxChild w57 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox1]));
			w57.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment9 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment9.Name = "alignment9";
			this.hbox2.Add (this.alignment9);
			global::Gtk.Box.BoxChild w58 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.alignment9]));
			w58.PackType = ((global::Gtk.PackType)(1));
			w58.Position = 2;
			this.Add (this.hbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.buttonc1.Clicked += new global::System.EventHandler (this.OnButtoncClicked);
			this.buttonc2.Clicked += new global::System.EventHandler (this.OnButtoncClicked);
			this.buttonc3.Clicked += new global::System.EventHandler (this.OnButtoncClicked);
			this.buttonc4.Clicked += new global::System.EventHandler (this.OnButtoncClicked);
		}
	}
}
