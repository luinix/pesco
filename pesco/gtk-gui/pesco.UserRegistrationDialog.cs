
// This file has been generated by the GUI designer. Do not modify.
namespace pesco
{
	public partial class UserRegistrationDialog
	{
		private global::Gtk.VBox vbox4;

		private global::Gtk.Alignment alignment7;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Alignment alignment8;

		private global::Gtk.VBox dialog1_VBox;

		private global::Gtk.HBox hbox1;

		private global::Gtk.HButtonBox dialog1_ActionArea;

		private global::Gtk.Button buttonPre;

		private global::Gtk.Button buttonOk;

		private global::Gtk.Button button144;

		private global::Gtk.Alignment alignment9;

		private global::Gtk.Alignment alignment2;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget pesco.UserRegistrationDialog
			global::Stetic.BinContainer.Attach (this);
			this.Name = "pesco.UserRegistrationDialog";
			// Container child pesco.UserRegistrationDialog.Gtk.Container+ContainerChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.alignment7 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment7.Name = "alignment7";
			this.vbox4.Add (this.alignment7);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.alignment7]));
			w1.Position = 0;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment8 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment8.Name = "alignment8";
			this.hbox2.Add (this.alignment8);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.alignment8]));
			w2.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.dialog1_VBox = new global::Gtk.VBox ();
			this.dialog1_VBox.Name = "dialog1_VBox";
			this.dialog1_VBox.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			this.dialog1_VBox.Add (this.hbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.dialog1_VBox[this.hbox1]));
			w3.Position = 0;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.dialog1_ActionArea = new global::Gtk.HButtonBox ();
			this.dialog1_ActionArea.Name = "dialog1_ActionArea";
			this.dialog1_ActionArea.Spacing = 10;
			this.dialog1_ActionArea.BorderWidth = ((uint)(5));
			this.dialog1_ActionArea.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonPre = new global::Gtk.Button ();
			this.buttonPre.Sensitive = false;
			this.buttonPre.CanFocus = true;
			this.buttonPre.Name = "buttonPre";
			// Container child buttonPre.Gtk.Container+ContainerChild
			global::Gtk.Alignment w4 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w5 = new global::Gtk.HBox ();
			w5.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w6 = new global::Gtk.Image ();
			w6.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-back", global::Gtk.IconSize.Dialog);
			w5.Add (w6);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w8 = new global::Gtk.Label ();
			w8.LabelProp = global::Mono.Unix.Catalog.GetString ("Anterior");
			w5.Add (w8);
			w4.Add (w5);
			this.buttonPre.Add (w4);
			this.dialog1_ActionArea.Add (this.buttonPre);
			global::Gtk.ButtonBox.ButtonBoxChild w12 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.dialog1_ActionArea[this.buttonPre]));
			w12.Expand = false;
			w12.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseUnderline = true;
			// Container child buttonOk.Gtk.Container+ContainerChild
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
			this.buttonOk.Add (w13);
			this.dialog1_ActionArea.Add (this.buttonOk);
			global::Gtk.ButtonBox.ButtonBoxChild w21 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.dialog1_ActionArea[this.buttonOk]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.button144 = new global::Gtk.Button ();
			this.button144.CanFocus = true;
			this.button144.Name = "button144";
			// Container child button144.Gtk.Container+ContainerChild
			global::Gtk.Alignment w22 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w23 = new global::Gtk.HBox ();
			w23.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w24 = new global::Gtk.Image ();
			w24.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-forward", global::Gtk.IconSize.Dialog);
			w23.Add (w24);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w26 = new global::Gtk.Label ();
			w26.LabelProp = global::Mono.Unix.Catalog.GetString ("Siguiente");
			w23.Add (w26);
			w22.Add (w23);
			this.button144.Add (w22);
			this.dialog1_ActionArea.Add (this.button144);
			global::Gtk.ButtonBox.ButtonBoxChild w30 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.dialog1_ActionArea[this.button144]));
			w30.Position = 2;
			w30.Expand = false;
			w30.Fill = false;
			this.dialog1_VBox.Add (this.dialog1_ActionArea);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.dialog1_VBox[this.dialog1_ActionArea]));
			w31.PackType = ((global::Gtk.PackType)(1));
			w31.Position = 1;
			this.hbox2.Add (this.dialog1_VBox);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.dialog1_VBox]));
			w32.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment9 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment9.Name = "alignment9";
			this.hbox2.Add (this.alignment9);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.alignment9]));
			w33.Position = 2;
			this.vbox4.Add (this.hbox2);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox2]));
			w34.Position = 1;
			// Container child vbox4.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment2.Name = "alignment2";
			this.vbox4.Add (this.alignment2);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.alignment2]));
			w35.Position = 2;
			this.Add (this.vbox4);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.buttonPre.Clicked += new global::System.EventHandler (this.OnButtonPreClicked);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnNextClick);
			this.button144.Clicked += new global::System.EventHandler (this.OnSaveClick);
		}
	}
}