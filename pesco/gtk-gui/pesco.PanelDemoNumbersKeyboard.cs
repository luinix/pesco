
// This file has been generated by the GUI designer. Do not modify.
namespace pesco
{
	public partial class PanelDemoNumbersKeyboard
	{
		private global::Gtk.Table tableNumbers;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget pesco.PanelDemoNumbersKeyboard
			global::Stetic.BinContainer.Attach (this);
			this.Name = "pesco.PanelDemoNumbersKeyboard";
			// Container child pesco.PanelDemoNumbersKeyboard.Gtk.Container+ContainerChild
			this.tableNumbers = new global::Gtk.Table (((uint)(4)), ((uint)(3)), true);
			this.tableNumbers.WidthRequest = 400;
			this.tableNumbers.HeightRequest = 325;
			this.tableNumbers.Name = "tableNumbers";
			this.tableNumbers.RowSpacing = ((uint)(6));
			this.tableNumbers.ColumnSpacing = ((uint)(6));
			this.Add (this.tableNumbers);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
