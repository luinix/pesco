
// This file has been generated by the GUI designer. Do not modify.
namespace pesco
{
	public partial class BalloonsPanel
	{
		private global::Gtk.EventBox eventBox;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Alignment alignment9;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Alignment alignment1;

		private global::Gtk.VBox vbox4;

		private global::Gtk.HBox hboxTop;

		private global::Gtk.Label labelBalloonsString;

		private global::Gtk.Label labelBalloons;

		private global::Gtk.Alignment alignment7;

		private global::Gtk.Label labelLevelString;

		private global::Gtk.Label labelLevel;

		private global::Gtk.Label labelVelocityString;

		private global::Gtk.Label labelVelocity;

		private global::Gtk.DrawingArea drawingAreaGame;

		private global::Gtk.HBox hboxDemo;

		private global::Gtk.Button buttonGoLast;

		private global::Gtk.Alignment alignment5;

		private global::Gtk.Alignment alignment6;

		private global::Gtk.Button buttonStartExercise;

		private global::Gtk.Button buttonGoBack;

		private global::Gtk.Button buttonGoForward;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Alignment alignment10;

		private global::Gtk.Button buttonPulsar;

		private global::Gtk.Alignment alignment11;

		private global::Gtk.Alignment alignment2;

		private global::Gtk.Alignment alignment8;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget pesco.BalloonsPanel
			global::Stetic.BinContainer.Attach (this);
			this.Name = "pesco.BalloonsPanel";
			// Container child pesco.BalloonsPanel.Gtk.Container+ContainerChild
			this.eventBox = new global::Gtk.EventBox ();
			this.eventBox.Name = "eventBox";
			// Container child eventBox.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment9 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment9.Name = "alignment9";
			this.vbox2.Add (this.alignment9);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.alignment9]));
			w1.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment1.Name = "alignment1";
			this.hbox2.Add (this.alignment1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.alignment1]));
			w2.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.WidthRequest = 1000;
			this.vbox4.HeightRequest = 720;
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hboxTop = new global::Gtk.HBox ();
			this.hboxTop.Name = "hboxTop";
			this.hboxTop.Spacing = 6;
			// Container child hboxTop.Gtk.Box+BoxChild
			this.labelBalloonsString = new global::Gtk.Label ();
			this.labelBalloonsString.Name = "labelBalloonsString";
			this.labelBalloonsString.LabelProp = global::Mono.Unix.Catalog.GetString ("<span size=\"x-large\" color=\"blue\">Globos:</span>");
			this.labelBalloonsString.UseMarkup = true;
			this.hboxTop.Add (this.labelBalloonsString);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hboxTop[this.labelBalloonsString]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hboxTop.Gtk.Box+BoxChild
			this.labelBalloons = new global::Gtk.Label ();
			this.labelBalloons.Name = "labelBalloons";
			this.hboxTop.Add (this.labelBalloons);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hboxTop[this.labelBalloons]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hboxTop.Gtk.Box+BoxChild
			this.alignment7 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment7.Name = "alignment7";
			this.hboxTop.Add (this.alignment7);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hboxTop[this.alignment7]));
			w5.Position = 2;
			// Container child hboxTop.Gtk.Box+BoxChild
			this.labelLevelString = new global::Gtk.Label ();
			this.labelLevelString.Name = "labelLevelString";
			this.labelLevelString.Xalign = 1f;
			this.labelLevelString.LabelProp = global::Mono.Unix.Catalog.GetString ("<span size=\"x-large\" color=\"blue\">Nivel:</span>");
			this.labelLevelString.UseMarkup = true;
			this.labelLevelString.Justify = ((global::Gtk.Justification)(1));
			this.hboxTop.Add (this.labelLevelString);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hboxTop[this.labelLevelString]));
			w6.Position = 3;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hboxTop.Gtk.Box+BoxChild
			this.labelLevel = new global::Gtk.Label ();
			this.labelLevel.Name = "labelLevel";
			this.hboxTop.Add (this.labelLevel);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hboxTop[this.labelLevel]));
			w7.Position = 4;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hboxTop.Gtk.Box+BoxChild
			this.labelVelocityString = new global::Gtk.Label ();
			this.labelVelocityString.Name = "labelVelocityString";
			this.labelVelocityString.Xalign = 1f;
			this.labelVelocityString.LabelProp = global::Mono.Unix.Catalog.GetString ("<span size=\"x-large\" color=\"blue\">Velocidad:</span>");
			this.labelVelocityString.UseMarkup = true;
			this.labelVelocityString.Justify = ((global::Gtk.Justification)(1));
			this.hboxTop.Add (this.labelVelocityString);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hboxTop[this.labelVelocityString]));
			w8.Position = 5;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hboxTop.Gtk.Box+BoxChild
			this.labelVelocity = new global::Gtk.Label ();
			this.labelVelocity.Name = "labelVelocity";
			this.hboxTop.Add (this.labelVelocity);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hboxTop[this.labelVelocity]));
			w9.Position = 6;
			w9.Expand = false;
			w9.Fill = false;
			this.vbox4.Add (this.hboxTop);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hboxTop]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.drawingAreaGame = new global::Gtk.DrawingArea ();
			this.drawingAreaGame.WidthRequest = 1000;
			this.drawingAreaGame.HeightRequest = 600;
			this.drawingAreaGame.Name = "drawingAreaGame";
			this.vbox4.Add (this.drawingAreaGame);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.drawingAreaGame]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hboxDemo = new global::Gtk.HBox ();
			this.hboxDemo.HeightRequest = 50;
			this.hboxDemo.Name = "hboxDemo";
			this.hboxDemo.Spacing = 6;
			// Container child hboxDemo.Gtk.Box+BoxChild
			this.buttonGoLast = new global::Gtk.Button ();
			this.buttonGoLast.CanFocus = true;
			this.buttonGoLast.Name = "buttonGoLast";
			this.buttonGoLast.UseUnderline = true;
			// Container child buttonGoLast.Gtk.Container+ContainerChild
			global::Gtk.Alignment w12 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w13 = new global::Gtk.HBox ();
			w13.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w14 = new global::Gtk.Image ();
			w14.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-goto-last", global::Gtk.IconSize.Dnd);
			w13.Add (w14);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w16 = new global::Gtk.Label ();
			w16.LabelProp = global::Mono.Unix.Catalog.GetString ("Saltar instrucciones");
			w16.UseUnderline = true;
			w13.Add (w16);
			w12.Add (w13);
			this.buttonGoLast.Add (w12);
			this.hboxDemo.Add (this.buttonGoLast);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hboxDemo[this.buttonGoLast]));
			w20.Position = 0;
			// Container child hboxDemo.Gtk.Box+BoxChild
			this.alignment5 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment5.Name = "alignment5";
			// Container child alignment5.Gtk.Container+ContainerChild
			this.alignment6 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment6.Name = "alignment6";
			this.alignment5.Add (this.alignment6);
			this.hboxDemo.Add (this.alignment5);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hboxDemo[this.alignment5]));
			w22.Position = 1;
			// Container child hboxDemo.Gtk.Box+BoxChild
			this.buttonStartExercise = new global::Gtk.Button ();
			this.buttonStartExercise.CanFocus = true;
			this.buttonStartExercise.Name = "buttonStartExercise";
			this.buttonStartExercise.UseUnderline = true;
			// Container child buttonStartExercise.Gtk.Container+ContainerChild
			global::Gtk.Alignment w23 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w24 = new global::Gtk.HBox ();
			w24.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w25 = new global::Gtk.Image ();
			w25.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Dnd);
			w24.Add (w25);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w27 = new global::Gtk.Label ();
			w27.LabelProp = global::Mono.Unix.Catalog.GetString ("Comenzar ejercicio");
			w27.UseUnderline = true;
			w24.Add (w27);
			w23.Add (w24);
			this.buttonStartExercise.Add (w23);
			this.hboxDemo.Add (this.buttonStartExercise);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hboxDemo[this.buttonStartExercise]));
			w31.Position = 2;
			// Container child hboxDemo.Gtk.Box+BoxChild
			this.buttonGoBack = new global::Gtk.Button ();
			this.buttonGoBack.CanFocus = true;
			this.buttonGoBack.Name = "buttonGoBack";
			this.buttonGoBack.UseUnderline = true;
			// Container child buttonGoBack.Gtk.Container+ContainerChild
			global::Gtk.Alignment w32 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w33 = new global::Gtk.HBox ();
			w33.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w34 = new global::Gtk.Image ();
			w34.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-back", global::Gtk.IconSize.Dnd);
			w33.Add (w34);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w36 = new global::Gtk.Label ();
			w36.LabelProp = global::Mono.Unix.Catalog.GetString ("Anterior");
			w36.UseUnderline = true;
			w33.Add (w36);
			w32.Add (w33);
			this.buttonGoBack.Add (w32);
			this.hboxDemo.Add (this.buttonGoBack);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hboxDemo[this.buttonGoBack]));
			w40.Position = 3;
			// Container child hboxDemo.Gtk.Box+BoxChild
			this.buttonGoForward = new global::Gtk.Button ();
			this.buttonGoForward.CanFocus = true;
			this.buttonGoForward.Name = "buttonGoForward";
			this.buttonGoForward.UseUnderline = true;
			// Container child buttonGoForward.Gtk.Container+ContainerChild
			global::Gtk.Alignment w41 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w42 = new global::Gtk.HBox ();
			w42.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w43 = new global::Gtk.Image ();
			w43.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-forward", global::Gtk.IconSize.Dnd);
			w42.Add (w43);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w45 = new global::Gtk.Label ();
			w45.LabelProp = global::Mono.Unix.Catalog.GetString ("Siguiente");
			w45.UseUnderline = true;
			w42.Add (w45);
			w41.Add (w42);
			this.buttonGoForward.Add (w41);
			this.hboxDemo.Add (this.buttonGoForward);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hboxDemo[this.buttonGoForward]));
			w49.Position = 4;
			this.vbox4.Add (this.hboxDemo);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hboxDemo]));
			w50.Position = 3;
			w50.Expand = false;
			w50.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.alignment10 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment10.Name = "alignment10";
			this.hbox3.Add (this.alignment10);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.alignment10]));
			w51.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonPulsar = new global::Gtk.Button ();
			this.buttonPulsar.CanFocus = true;
			this.buttonPulsar.Name = "buttonPulsar";
			this.buttonPulsar.UseUnderline = true;
			this.buttonPulsar.Label = global::Mono.Unix.Catalog.GetString ("¡Letra repetida!");
			this.hbox3.Add (this.buttonPulsar);
			global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.buttonPulsar]));
			w52.Position = 1;
			// Container child hbox3.Gtk.Box+BoxChild
			this.alignment11 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment11.Name = "alignment11";
			this.hbox3.Add (this.alignment11);
			global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.alignment11]));
			w53.Position = 2;
			this.vbox4.Add (this.hbox3);
			global::Gtk.Box.BoxChild w54 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox3]));
			w54.Position = 4;
			this.hbox2.Add (this.vbox4);
			global::Gtk.Box.BoxChild w55 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox4]));
			w55.Position = 1;
			w55.Expand = false;
			w55.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment2.Name = "alignment2";
			this.hbox2.Add (this.alignment2);
			global::Gtk.Box.BoxChild w56 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.alignment2]));
			w56.Position = 2;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w57 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
			w57.Position = 1;
			w57.Expand = false;
			w57.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment8 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment8.Name = "alignment8";
			this.vbox2.Add (this.alignment8);
			global::Gtk.Box.BoxChild w58 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.alignment8]));
			w58.PackType = ((global::Gtk.PackType)(1));
			w58.Position = 2;
			this.eventBox.Add (this.vbox2);
			this.Add (this.eventBox);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.buttonGoLast.Clicked += new global::System.EventHandler (this.OnButtonGoLastClicked);
			this.buttonStartExercise.Clicked += new global::System.EventHandler (this.OnButtonStartExerciseClicked);
			this.buttonGoBack.Clicked += new global::System.EventHandler (this.OnButtonGoBackClicked);
			this.buttonGoForward.Clicked += new global::System.EventHandler (this.OnButtonGoForwardClicked);
			this.buttonPulsar.Clicked += new global::System.EventHandler (this.callbackButtonPulsar);
		}
	}
}
