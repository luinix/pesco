
// This file has been generated by the GUI designer. Do not modify.
namespace pesco
{
	public partial class PersonalDataPane
	{
		private global::Gtk.Frame frame1;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Label label20;

		private global::Gtk.Entry campoNombre;

		private global::Gtk.Table table1;

		private global::Gtk.Entry campoApellidos;

		private global::Gtk.Label label21;

		private global::Gtk.Label label22;

		private global::Gtk.Entry campoPoblacion;

		private global::Gtk.Label label23;

		private global::Gtk.Entry campoTelefono;

		private global::Gtk.Label label24;

		private global::Gtk.HBox hbox4;

		private global::Gtk.ToggleButton sexoHombre;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Image image110;

		private global::Gtk.VSeparator vseparator6;

		private global::Gtk.Label label12;

		private global::Gtk.ToggleButton sexoMujer;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Image image109;

		private global::Gtk.VSeparator vseparator5;

		private global::Gtk.Label label11;

		private global::Gtk.Label label25;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label label4;

		private global::Gtk.Entry dia;

		private global::Gtk.Label label5;

		private global::Gtk.Entry mes;

		private global::Gtk.Label label6;

		private global::Gtk.Entry anyo;

		private global::Gtk.Label GtkLabel3;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget pesco.PersonalDataPane
			global::Stetic.BinContainer.Attach (this);
			this.Name = "pesco.PersonalDataPane";
			// Container child pesco.PersonalDataPane.Gtk.Container+ContainerChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.WidthRequest = 1200;
			this.frame1.HeightRequest = 600;
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(2));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0f, 0f, 1f, 1f);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			this.GtkAlignment.TopPadding = ((uint)(4));
			this.GtkAlignment.RightPadding = ((uint)(12));
			this.GtkAlignment.BottomPadding = ((uint)(4));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label20 = new global::Gtk.Label ();
			this.label20.Name = "label20";
			this.label20.Xalign = 0f;
			this.label20.LabelProp = global::Mono.Unix.Catalog.GetString ("Nombre");
			this.vbox2.Add (this.label20);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label20]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.campoNombre = new global::Gtk.Entry ();
			this.campoNombre.CanFocus = true;
			this.campoNombre.Name = "campoNombre";
			this.campoNombre.IsEditable = true;
			this.campoNombre.InvisibleChar = '●';
			this.vbox2.Add (this.campoNombre);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.campoNombre]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(2)), ((uint)(1)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.campoApellidos = new global::Gtk.Entry ();
			this.campoApellidos.CanFocus = true;
			this.campoApellidos.Name = "campoApellidos";
			this.campoApellidos.IsEditable = true;
			this.campoApellidos.InvisibleChar = '●';
			this.table1.Add (this.campoApellidos);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.campoApellidos]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label21 = new global::Gtk.Label ();
			this.label21.Name = "label21";
			this.label21.Xalign = 0f;
			this.label21.LabelProp = global::Mono.Unix.Catalog.GetString ("Apellidos");
			this.table1.Add (this.label21);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.label21]));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox2.Add (this.table1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.table1]));
			w5.Position = 2;
			w5.Expand = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label22 = new global::Gtk.Label ();
			this.label22.Name = "label22";
			this.label22.Xalign = 0f;
			this.label22.LabelProp = global::Mono.Unix.Catalog.GetString ("Población");
			this.vbox2.Add (this.label22);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label22]));
			w6.Position = 3;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.campoPoblacion = new global::Gtk.Entry ();
			this.campoPoblacion.CanFocus = true;
			this.campoPoblacion.Name = "campoPoblacion";
			this.campoPoblacion.IsEditable = true;
			this.campoPoblacion.InvisibleChar = '●';
			this.vbox2.Add (this.campoPoblacion);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.campoPoblacion]));
			w7.Position = 4;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label23 = new global::Gtk.Label ();
			this.label23.Name = "label23";
			this.label23.Xalign = 0f;
			this.label23.LabelProp = global::Mono.Unix.Catalog.GetString ("Teléfono");
			this.vbox2.Add (this.label23);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label23]));
			w8.Position = 5;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.campoTelefono = new global::Gtk.Entry ();
			this.campoTelefono.CanFocus = true;
			this.campoTelefono.Name = "campoTelefono";
			this.campoTelefono.IsEditable = true;
			this.campoTelefono.MaxLength = 9;
			this.campoTelefono.InvisibleChar = '●';
			this.vbox2.Add (this.campoTelefono);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.campoTelefono]));
			w9.Position = 6;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label24 = new global::Gtk.Label ();
			this.label24.Name = "label24";
			this.label24.Xalign = 0f;
			this.label24.LabelProp = global::Mono.Unix.Catalog.GetString ("Sexo");
			this.vbox2.Add (this.label24);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label24]));
			w10.Position = 7;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.sexoHombre = new global::Gtk.ToggleButton ();
			this.sexoHombre.CanFocus = true;
			this.sexoHombre.Name = "sexoHombre";
			// Container child sexoHombre.Gtk.Container+ContainerChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.image110 = new global::Gtk.Image ();
			this.image110.Name = "image110";
			this.image110.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.Hombre.png");
			this.hbox8.Add (this.image110);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.image110]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.vseparator6 = new global::Gtk.VSeparator ();
			this.vseparator6.Name = "vseparator6";
			this.hbox8.Add (this.vseparator6);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.vseparator6]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Hombre");
			this.hbox8.Add (this.label12);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.label12]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			this.sexoHombre.Add (this.hbox8);
			this.sexoHombre.Label = null;
			this.hbox4.Add (this.sexoHombre);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.sexoHombre]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.sexoMujer = new global::Gtk.ToggleButton ();
			this.sexoMujer.CanFocus = true;
			this.sexoMujer.Name = "sexoMujer";
			// Container child sexoMujer.Gtk.Container+ContainerChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.image109 = new global::Gtk.Image ();
			this.image109.Name = "image109";
			this.image109.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("pesco.Mujer.png");
			this.hbox7.Add (this.image109);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.image109]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.vseparator5 = new global::Gtk.VSeparator ();
			this.vseparator5.Name = "vseparator5";
			this.hbox7.Add (this.vseparator5);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.vseparator5]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Mujer");
			this.hbox7.Add (this.label11);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.label11]));
			w18.Position = 2;
			w18.Expand = false;
			w18.Fill = false;
			this.sexoMujer.Add (this.hbox7);
			this.sexoMujer.Label = null;
			this.hbox4.Add (this.sexoMujer);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.sexoMujer]));
			w20.Position = 1;
			w20.Expand = false;
			w20.Fill = false;
			this.vbox2.Add (this.hbox4);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
			w21.Position = 8;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label25 = new global::Gtk.Label ();
			this.label25.Name = "label25";
			this.label25.Xalign = 0f;
			this.label25.LabelProp = global::Mono.Unix.Catalog.GetString ("Fecha de Nacimiento");
			this.vbox2.Add (this.label25);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label25]));
			w22.Position = 9;
			w22.Expand = false;
			w22.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Día");
			this.hbox3.Add (this.label4);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label4]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.dia = new global::Gtk.Entry ();
			this.dia.WidthRequest = 39;
			this.dia.CanFocus = true;
			this.dia.Name = "dia";
			this.dia.IsEditable = true;
			this.dia.MaxLength = 2;
			this.dia.InvisibleChar = '●';
			this.hbox3.Add (this.dia);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.dia]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Mes");
			this.hbox3.Add (this.label5);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label5]));
			w25.Position = 2;
			w25.Expand = false;
			w25.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.mes = new global::Gtk.Entry ();
			this.mes.WidthRequest = 39;
			this.mes.CanFocus = true;
			this.mes.Name = "mes";
			this.mes.IsEditable = true;
			this.mes.MaxLength = 2;
			this.mes.InvisibleChar = '●';
			this.hbox3.Add (this.mes);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.mes]));
			w26.Position = 3;
			w26.Expand = false;
			w26.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Año");
			this.hbox3.Add (this.label6);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label6]));
			w27.Position = 4;
			w27.Expand = false;
			w27.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.anyo = new global::Gtk.Entry ();
			this.anyo.WidthRequest = 80;
			this.anyo.CanFocus = true;
			this.anyo.Name = "anyo";
			this.anyo.IsEditable = true;
			this.anyo.MaxLength = 4;
			this.anyo.InvisibleChar = '●';
			this.hbox3.Add (this.anyo);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.anyo]));
			w28.Position = 5;
			w28.Expand = false;
			w28.Fill = false;
			this.vbox2.Add (this.hbox3);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox3]));
			w29.Position = 10;
			w29.Expand = false;
			w29.Fill = false;
			this.GtkAlignment.Add (this.vbox2);
			this.frame1.Add (this.GtkAlignment);
			this.GtkLabel3 = new global::Gtk.Label ();
			this.GtkLabel3.Name = "GtkLabel3";
			this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString ("<big><b>Datos Personales</b></big>");
			this.GtkLabel3.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel3;
			this.Add (this.frame1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.campoNombre.WidgetEvent += new global::Gtk.WidgetEventHandler (this.OnCampoNombreWidgetEvent);
			this.campoApellidos.WidgetEvent += new global::Gtk.WidgetEventHandler (this.OnCampoApellidosWidgetEvent);
			this.campoTelefono.WidgetEvent += new global::Gtk.WidgetEventHandler (this.OnCampoTelefonoWidgetEvent);
			this.sexoHombre.Toggled += new global::System.EventHandler (this.OnSexoHombreToggled);
			this.sexoMujer.Toggled += new global::System.EventHandler (this.OnSexoMujerToggled);
			this.dia.WidgetEvent += new global::Gtk.WidgetEventHandler (this.OnDiaWidgetEvent);
			this.mes.WidgetEvent += new global::Gtk.WidgetEventHandler (this.OnMesWidgetEvent);
			this.anyo.WidgetEvent += new global::Gtk.WidgetEventHandler (this.OnAnyoWidgetEvent);
		}
	}
}
