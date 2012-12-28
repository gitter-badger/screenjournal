
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.VBox vbox1;
	private global::Gtk.Notebook notebook1;
	private global::Gtk.VBox vbox3;
	private global::Gtk.Button runbutton;
	private global::Gtk.Label runtab;
	private global::Gtk.VBox vbox2;
	private global::Gtk.HBox hbox2;
	private global::Gtk.Label label3;
	private global::Gtk.Entry directorybox;
	private global::Gtk.HBox hbox3;
	private global::Gtk.Label label4;
	private global::Gtk.Entry timeintervalbox;
	private global::Gtk.Button savesettingsbutton;
	private global::Gtk.Label settingstab;
	private global::Gtk.Statusbar statusbar1;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("ScreenJournal");
		this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-media-record", global::Gtk.IconSize.Menu);
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.DefaultWidth = 640;
		this.DefaultHeight = 480;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.notebook1 = new global::Gtk.Notebook ();
		this.notebook1.CanFocus = true;
		this.notebook1.Name = "notebook1";
		this.notebook1.CurrentPage = 0;
		// Container child notebook1.Gtk.Notebook+NotebookChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.runbutton = new global::Gtk.Button ();
		this.runbutton.CanFocus = true;
		this.runbutton.Name = "runbutton";
		this.runbutton.UseUnderline = true;
		// Container child runbutton.Gtk.Container+ContainerChild
		global::Gtk.Alignment w2 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w3 = new global::Gtk.HBox ();
		w3.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w4 = new global::Gtk.Image ();
		w4.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-media-record", global::Gtk.IconSize.Button);
		w3.Add (w4);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w6 = new global::Gtk.Label ();
		w6.LabelProp = global::Mono.Unix.Catalog.GetString ("Start recording");
		w6.UseUnderline = true;
		w3.Add (w6);
		w2.Add (w3);
		this.runbutton.Add (w2);
		this.vbox3.Add (this.runbutton);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.runbutton]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		this.notebook1.Add (this.vbox3);
		// Notebook tab
		this.runtab = new global::Gtk.Label ();
		this.runtab.Name = "runtab";
		this.runtab.LabelProp = global::Mono.Unix.Catalog.GetString ("Run");
		this.notebook1.SetTabLabel (this.vbox3, this.runtab);
		this.runtab.ShowAll ();
		// Container child notebook1.Gtk.Notebook+NotebookChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Image save directory");
		this.hbox2.Add (this.label3);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label3]));
		w12.Position = 0;
		w12.Expand = false;
		w12.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.directorybox = new global::Gtk.Entry ();
		this.directorybox.CanFocus = true;
		this.directorybox.Name = "directorybox";
		this.directorybox.IsEditable = true;
		this.directorybox.InvisibleChar = '●';
		this.hbox2.Add (this.directorybox);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.directorybox]));
		w13.Position = 2;
		this.vbox2.Add (this.hbox2);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
		w14.Position = 0;
		w14.Expand = false;
		w14.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Interval (seconds)");
		this.hbox3.Add (this.label4);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label4]));
		w15.Position = 0;
		w15.Expand = false;
		w15.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.timeintervalbox = new global::Gtk.Entry ();
		this.timeintervalbox.CanFocus = true;
		this.timeintervalbox.Name = "timeintervalbox";
		this.timeintervalbox.Text = global::Mono.Unix.Catalog.GetString ("300");
		this.timeintervalbox.IsEditable = true;
		this.timeintervalbox.InvisibleChar = '●';
		this.hbox3.Add (this.timeintervalbox);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.timeintervalbox]));
		w16.Position = 2;
		this.vbox2.Add (this.hbox3);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox3]));
		w17.Position = 1;
		w17.Expand = false;
		w17.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.savesettingsbutton = new global::Gtk.Button ();
		this.savesettingsbutton.CanFocus = true;
		this.savesettingsbutton.Name = "savesettingsbutton";
		this.savesettingsbutton.UseUnderline = true;
		// Container child savesettingsbutton.Gtk.Container+ContainerChild
		global::Gtk.Alignment w18 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w19 = new global::Gtk.HBox ();
		w19.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w20 = new global::Gtk.Image ();
		w20.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
		w19.Add (w20);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w22 = new global::Gtk.Label ();
		w22.LabelProp = global::Mono.Unix.Catalog.GetString ("Save settings");
		w22.UseUnderline = true;
		w19.Add (w22);
		w18.Add (w19);
		this.savesettingsbutton.Add (w18);
		this.vbox2.Add (this.savesettingsbutton);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.savesettingsbutton]));
		w26.Position = 2;
		w26.Expand = false;
		w26.Fill = false;
		this.notebook1.Add (this.vbox2);
		global::Gtk.Notebook.NotebookChild w27 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.vbox2]));
		w27.Position = 1;
		// Notebook tab
		this.settingstab = new global::Gtk.Label ();
		this.settingstab.Name = "settingstab";
		this.settingstab.LabelProp = global::Mono.Unix.Catalog.GetString ("Settings");
		this.notebook1.SetTabLabel (this.vbox2, this.settingstab);
		this.settingstab.ShowAll ();
		this.vbox1.Add (this.notebook1);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.notebook1]));
		w28.Position = 0;
		// Container child vbox1.Gtk.Box+BoxChild
		this.statusbar1 = new global::Gtk.Statusbar ();
		this.statusbar1.Name = "statusbar1";
		this.statusbar1.Spacing = 1;
		this.vbox1.Add (this.statusbar1);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.statusbar1]));
		w29.Position = 1;
		w29.Expand = false;
		w29.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.runbutton.Clicked += new global::System.EventHandler (this.OnRunbuttonClicked);
	}
}
