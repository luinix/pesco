
// This file has been generated by the GUI designer. Do not modify.
namespace pesco
{
	public partial class FunctionalScaleDialog
	{
		private global::Gtk.VBox dialog1_VBox;

		private global::Gtk.VBox vbox4;

		private global::Gtk.HButtonBox dialog1_ActionArea;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button botonAtras;

		private global::Gtk.Button botonSiguiente;

		private global::Gtk.Button botonGuardar;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget pesco.FunctionalScaleDialog
			global::Stetic.BinContainer.Attach (this);
			this.Name = "pesco.FunctionalScaleDialog";
			// Container child pesco.FunctionalScaleDialog.Gtk.Container+ContainerChild
			this.dialog1_VBox = new global::Gtk.VBox ();
			this.dialog1_VBox.Name = "dialog1_VBox";
			this.dialog1_VBox.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			this.dialog1_VBox.Add (this.vbox4);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.dialog1_VBox[this.vbox4]));
			w1.Position = 0;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.dialog1_ActionArea = new global::Gtk.HButtonBox ();
			this.dialog1_ActionArea.Name = "dialog1_ActionArea";
			this.dialog1_ActionArea.Spacing = 10;
			this.dialog1_ActionArea.BorderWidth = ((uint)(5));
			this.dialog1_ActionArea.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			// Container child buttonCancel.Gtk.Container+ContainerChild
			global::Gtk.Alignment w2 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w3 = new global::Gtk.HBox ();
			w3.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w4 = new global::Gtk.Image ();
			w4.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Dialog);
			w3.Add (w4);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w6 = new global::Gtk.Label ();
			w6.LabelProp = global::Mono.Unix.Catalog.GetString ("_Cancelar");
			w6.UseUnderline = true;
			w3.Add (w6);
			w2.Add (w3);
			this.buttonCancel.Add (w2);
			this.dialog1_ActionArea.Add (this.buttonCancel);
			global::Gtk.ButtonBox.ButtonBoxChild w10 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.dialog1_ActionArea[this.buttonCancel]));
			w10.Expand = false;
			w10.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.botonAtras = new global::Gtk.Button ();
			this.botonAtras.CanFocus = true;
			this.botonAtras.Name = "botonAtras";
			this.botonAtras.UseUnderline = true;
			// Container child botonAtras.Gtk.Container+ContainerChild
			global::Gtk.Alignment w11 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w12 = new global::Gtk.HBox ();
			w12.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w13 = new global::Gtk.Image ();
			w13.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-back", global::Gtk.IconSize.Dialog);
			w12.Add (w13);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w15 = new global::Gtk.Label ();
			w15.LabelProp = global::Mono.Unix.Catalog.GetString ("Anterior");
			w15.UseUnderline = true;
			w12.Add (w15);
			w11.Add (w12);
			this.botonAtras.Add (w11);
			this.dialog1_ActionArea.Add (this.botonAtras);
			global::Gtk.ButtonBox.ButtonBoxChild w19 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.dialog1_ActionArea[this.botonAtras]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.botonSiguiente = new global::Gtk.Button ();
			this.botonSiguiente.CanFocus = true;
			this.botonSiguiente.Name = "botonSiguiente";
			this.botonSiguiente.UseUnderline = true;
			// Container child botonSiguiente.Gtk.Container+ContainerChild
			global::Gtk.Alignment w20 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w21 = new global::Gtk.HBox ();
			w21.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w22 = new global::Gtk.Image ();
			w22.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-forward", global::Gtk.IconSize.Dialog);
			w21.Add (w22);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w24 = new global::Gtk.Label ();
			w24.LabelProp = global::Mono.Unix.Catalog.GetString ("Siguiente");
			w24.UseUnderline = true;
			w21.Add (w24);
			w20.Add (w21);
			this.botonSiguiente.Add (w20);
			this.dialog1_ActionArea.Add (this.botonSiguiente);
			global::Gtk.ButtonBox.ButtonBoxChild w28 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.dialog1_ActionArea[this.botonSiguiente]));
			w28.Position = 2;
			w28.Expand = false;
			w28.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.botonGuardar = new global::Gtk.Button ();
			this.botonGuardar.CanDefault = true;
			this.botonGuardar.CanFocus = true;
			this.botonGuardar.Name = "botonGuardar";
			// Container child botonGuardar.Gtk.Container+ContainerChild
			global::Gtk.Alignment w29 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w30 = new global::Gtk.HBox ();
			w30.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w31 = new global::Gtk.Image ();
			w31.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-forward", global::Gtk.IconSize.Dialog);
			w30.Add (w31);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w33 = new global::Gtk.Label ();
			w33.LabelProp = global::Mono.Unix.Catalog.GetString ("Siguiente");
			w30.Add (w33);
			w29.Add (w30);
			this.botonGuardar.Add (w29);
			this.dialog1_ActionArea.Add (this.botonGuardar);
			global::Gtk.ButtonBox.ButtonBoxChild w37 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.dialog1_ActionArea[this.botonGuardar]));
			w37.Position = 3;
			w37.Expand = false;
			w37.Fill = false;
			this.dialog1_VBox.Add (this.dialog1_ActionArea);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.dialog1_VBox[this.dialog1_ActionArea]));
			w38.PackType = ((global::Gtk.PackType)(1));
			w38.Position = 1;
			w38.Expand = false;
			w38.Fill = false;
			this.Add (this.dialog1_VBox);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.buttonCancel.Hide ();
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteDialog);
			this.botonAtras.Clicked += new global::System.EventHandler (this.OnPreviousQuestion);
			this.botonSiguiente.Clicked += new global::System.EventHandler (this.OnNextQuestion);
			this.botonGuardar.Clicked += new global::System.EventHandler (this.OnSaveEscala);
		}
	}
}
