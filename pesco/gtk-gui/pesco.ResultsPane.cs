
// This file has been generated by the GUI designer. Do not modify.
namespace pesco
{
	public partial class ResultsPane
	{
		private global::Gtk.Table table2;

		private global::Gtk.ProgressBar barraAtencion;

		private global::Gtk.ProgressBar barraMemoria1;

		private global::Gtk.ProgressBar barraPlanificacion;

		private global::Gtk.ProgressBar barraRazonamiento;

		private global::Gtk.Label label12;

		private global::Gtk.Label label13;

		private global::Gtk.Label label14;

		private global::Gtk.Label label15;

		private global::Gtk.Label label16;

		private global::Gtk.Label label17;

		private global::Gtk.Label label18;

		private global::Gtk.Label label19;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget pesco.ResultsPane
			global::Stetic.BinContainer.Attach (this);
			this.Name = "pesco.ResultsPane";
			// Container child pesco.ResultsPane.Gtk.Container+ContainerChild
			this.table2 = new global::Gtk.Table (((uint)(4)), ((uint)(3)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(22));
			this.table2.ColumnSpacing = ((uint)(20));
			this.table2.BorderWidth = ((uint)(15));
			// Container child table2.Gtk.Table+TableChild
			this.barraAtencion = new global::Gtk.ProgressBar ();
			this.barraAtencion.Name = "barraAtencion";
			this.table2.Add (this.barraAtencion);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table2[this.barraAtencion]));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			// Container child table2.Gtk.Table+TableChild
			this.barraMemoria1 = new global::Gtk.ProgressBar ();
			this.barraMemoria1.Name = "barraMemoria1";
			this.table2.Add (this.barraMemoria1);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table2[this.barraMemoria1]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			// Container child table2.Gtk.Table+TableChild
			this.barraPlanificacion = new global::Gtk.ProgressBar ();
			this.barraPlanificacion.Name = "barraPlanificacion";
			this.barraPlanificacion.Text = "";
			this.barraPlanificacion.Ellipsize = ((global::Pango.EllipsizeMode)(3));
			this.table2.Add (this.barraPlanificacion);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table2[this.barraPlanificacion]));
			w3.TopAttach = ((uint)(3));
			w3.BottomAttach = ((uint)(4));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			// Container child table2.Gtk.Table+TableChild
			this.barraRazonamiento = new global::Gtk.ProgressBar ();
			this.barraRazonamiento.Name = "barraRazonamiento";
			this.table2.Add (this.barraRazonamiento);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2[this.barraRazonamiento]));
			w4.TopAttach = ((uint)(2));
			w4.BottomAttach = ((uint)(3));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			// Container child table2.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.Xalign = 1f;
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Atención");
			this.table2.Add (this.label12);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2[this.label12]));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label13 = new global::Gtk.Label ();
			this.label13.Name = "label13";
			this.label13.Xalign = 1f;
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("Memoria");
			this.table2.Add (this.label13);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2[this.label13]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label14 = new global::Gtk.Label ();
			this.label14.Name = "label14";
			this.label14.Xalign = 1f;
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("Razonamiento");
			this.table2.Add (this.label14);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table2[this.label14]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label15 = new global::Gtk.Label ();
			this.label15.Name = "label15";
			this.label15.Xalign = 1f;
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString ("Planificación");
			this.table2.Add (this.label15);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table2[this.label15]));
			w8.TopAttach = ((uint)(3));
			w8.BottomAttach = ((uint)(4));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label16 = new global::Gtk.Label ();
			this.label16.Name = "label16";
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString ("label16");
			this.table2.Add (this.label16);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table2[this.label16]));
			w9.LeftAttach = ((uint)(2));
			w9.RightAttach = ((uint)(3));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label17 = new global::Gtk.Label ();
			this.label17.Name = "label17";
			this.label17.LabelProp = global::Mono.Unix.Catalog.GetString ("label17");
			this.table2.Add (this.label17);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table2[this.label17]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.LeftAttach = ((uint)(2));
			w10.RightAttach = ((uint)(3));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label18 = new global::Gtk.Label ();
			this.label18.Name = "label18";
			this.label18.LabelProp = global::Mono.Unix.Catalog.GetString ("label18");
			this.table2.Add (this.label18);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table2[this.label18]));
			w11.TopAttach = ((uint)(2));
			w11.BottomAttach = ((uint)(3));
			w11.LeftAttach = ((uint)(2));
			w11.RightAttach = ((uint)(3));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label19 = new global::Gtk.Label ();
			this.label19.Name = "label19";
			this.label19.LabelProp = global::Mono.Unix.Catalog.GetString ("label19");
			this.table2.Add (this.label19);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table2[this.label19]));
			w12.TopAttach = ((uint)(3));
			w12.BottomAttach = ((uint)(4));
			w12.LeftAttach = ((uint)(2));
			w12.RightAttach = ((uint)(3));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
		}
	}
}