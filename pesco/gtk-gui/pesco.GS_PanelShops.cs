
// This file has been generated by the GUI designer. Do not modify.
namespace pesco
{
	public partial class GS_PanelShops
	{
		private global::Gtk.Frame frame4;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.VBox vbox4;

		private global::Gtk.Alignment alignment1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Alignment alignment3;

		private global::Gtk.Table table;

		private global::Gtk.Alignment alignment4;

		private global::Gtk.Alignment alignment2;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget pesco.GS_PanelShops
			global::Stetic.BinContainer.Attach (this);
			this.Name = "pesco.GS_PanelShops";
			// Container child pesco.GS_PanelShops.Gtk.Container+ContainerChild
			this.frame4 = new global::Gtk.Frame ();
			this.frame4.Name = "frame4";
			this.frame4.ShadowType = ((global::Gtk.ShadowType)(4));
			this.frame4.BorderWidth = ((uint)(2));
			// Container child frame4.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0.5f, 1f, 1f, 1f);
			this.GtkAlignment.Name = "GtkAlignment";
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment1.Name = "alignment1";
			this.vbox4.Add (this.alignment1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.alignment1]));
			w1.Position = 0;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment3.Name = "alignment3";
			this.hbox1.Add (this.alignment3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.alignment3]));
			w2.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.table = new global::Gtk.Table (((uint)(1)), ((uint)(1)), true);
			this.table.Name = "table";
			this.table.RowSpacing = ((uint)(6));
			this.table.ColumnSpacing = ((uint)(6));
			this.hbox1.Add (this.table);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.table]));
			w3.Position = 1;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment4.Name = "alignment4";
			this.hbox1.Add (this.alignment4);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.alignment4]));
			w4.Position = 2;
			this.vbox4.Add (this.hbox1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox1]));
			w5.Position = 1;
			// Container child vbox4.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5f, 0.5f, 1f, 1f);
			this.alignment2.Name = "alignment2";
			this.vbox4.Add (this.alignment2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.alignment2]));
			w6.Position = 2;
			this.GtkAlignment.Add (this.vbox4);
			this.frame4.Add (this.GtkAlignment);
			this.Add (this.frame4);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
