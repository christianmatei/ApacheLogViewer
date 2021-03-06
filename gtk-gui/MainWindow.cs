
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action refreshAction;

	private global::Gtk.Action refreshAction1;

	private global::Gtk.ToggleAction btnShowDate;

	private global::Gtk.ToggleAction btnShowCategory;

	private global::Gtk.ToggleAction btnShowPID;

	private global::Gtk.ToggleAction btnShowIP;

	private global::Gtk.ToggleAction btnShowWarnings;

	private global::Gtk.ToggleAction btnShowNotices;

	private global::Gtk.Action deleteAction;

	private global::Gtk.ToggleAction btnShowStackTrace;

	private global::Gtk.VBox vbox2;

	private global::Gtk.Toolbar toolbar;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView textview;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.refreshAction = new global::Gtk.Action("refreshAction", global::Mono.Unix.Catalog.GetString("Refresh"), null, "gtk-refresh");
		this.refreshAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Refresh");
		w1.Add(this.refreshAction, null);
		this.refreshAction1 = new global::Gtk.Action("refreshAction1", global::Mono.Unix.Catalog.GetString("Refresh"), global::Mono.Unix.Catalog.GetString("Refresh"), "gtk-refresh");
		this.refreshAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Refresh");
		w1.Add(this.refreshAction1, null);
		this.btnShowDate = new global::Gtk.ToggleAction("btnShowDate", global::Mono.Unix.Catalog.GetString("Show date"), global::Mono.Unix.Catalog.GetString("Show date"), "gtk-jump-to");
		this.btnShowDate.ShortLabel = global::Mono.Unix.Catalog.GetString("Date");
		w1.Add(this.btnShowDate, null);
		this.btnShowCategory = new global::Gtk.ToggleAction("btnShowCategory", global::Mono.Unix.Catalog.GetString("Show Category"), global::Mono.Unix.Catalog.GetString("Show category"), "gtk-dnd");
		this.btnShowCategory.ShortLabel = global::Mono.Unix.Catalog.GetString("Category");
		w1.Add(this.btnShowCategory, null);
		this.btnShowPID = new global::Gtk.ToggleAction("btnShowPID", global::Mono.Unix.Catalog.GetString("Show PID"), global::Mono.Unix.Catalog.GetString("Show PID"), "gtk-execute");
		this.btnShowPID.ShortLabel = global::Mono.Unix.Catalog.GetString("PID");
		w1.Add(this.btnShowPID, null);
		this.btnShowIP = new global::Gtk.ToggleAction("btnShowIP", global::Mono.Unix.Catalog.GetString("Show IP"), global::Mono.Unix.Catalog.GetString("Show IP"), "gtk-network");
		this.btnShowIP.ShortLabel = global::Mono.Unix.Catalog.GetString("IP");
		w1.Add(this.btnShowIP, null);
		this.btnShowWarnings = new global::Gtk.ToggleAction("btnShowWarnings", global::Mono.Unix.Catalog.GetString("Show Warnings"), global::Mono.Unix.Catalog.GetString("Show warnings"), "gtk-dialog-warning");
		this.btnShowWarnings.ShortLabel = global::Mono.Unix.Catalog.GetString("Warnings");
		w1.Add(this.btnShowWarnings, null);
		this.btnShowNotices = new global::Gtk.ToggleAction("btnShowNotices", global::Mono.Unix.Catalog.GetString("Show Notices"), global::Mono.Unix.Catalog.GetString("Show notices"), "gtk-dialog-info");
		this.btnShowNotices.ShortLabel = global::Mono.Unix.Catalog.GetString("Notices");
		w1.Add(this.btnShowNotices, null);
		this.deleteAction = new global::Gtk.Action("deleteAction", global::Mono.Unix.Catalog.GetString("Clear Log (root)"), global::Mono.Unix.Catalog.GetString("Clear log (root)"), "gtk-delete");
		this.deleteAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Clear Log (root)");
		w1.Add(this.deleteAction, null);
		this.btnShowStackTrace = new global::Gtk.ToggleAction("btnShowStackTrace", global::Mono.Unix.Catalog.GetString("Show StackTrace"), global::Mono.Unix.Catalog.GetString("Show Stacktrace"), "gtk-indent");
		this.btnShowStackTrace.ShortLabel = global::Mono.Unix.Catalog.GetString("StackTrace");
		w1.Add(this.btnShowStackTrace, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Apache log viewer");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString(@"<ui><toolbar name='toolbar'><toolitem name='refreshAction1' action='refreshAction1'/><separator/><toolitem name='btnShowDate' action='btnShowDate'/><toolitem name='btnShowCategory' action='btnShowCategory'/><toolitem name='btnShowPID' action='btnShowPID'/><toolitem name='btnShowIP' action='btnShowIP'/><separator/><toolitem name='btnShowWarnings' action='btnShowWarnings'/><toolitem name='btnShowNotices' action='btnShowNotices'/><toolitem name='btnShowStackTrace' action='btnShowStackTrace'/><separator/><separator/><toolitem name='deleteAction' action='deleteAction'/></toolbar></ui>");
		this.toolbar = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar")));
		this.toolbar.Name = "toolbar";
		this.toolbar.ShowArrow = false;
		this.toolbar.ToolbarStyle = ((global::Gtk.ToolbarStyle)(2));
		this.vbox2.Add(this.toolbar);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.toolbar]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview = new global::Gtk.TextView();
		this.textview.CanFocus = true;
		this.textview.Name = "textview";
		this.GtkScrolledWindow.Add(this.textview);
		this.vbox2.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow]));
		w4.Position = 1;
		this.Add(this.vbox2);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 1024;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.refreshAction1.Activated += new global::System.EventHandler(this.OnRefreshAction1Activated);
		this.btnShowDate.Toggled += new global::System.EventHandler(this.OnBtnShowDateToggled);
		this.btnShowCategory.Toggled += new global::System.EventHandler(this.OnBtnShowDateToggled);
		this.btnShowPID.Toggled += new global::System.EventHandler(this.OnBtnShowDateToggled);
		this.btnShowIP.Toggled += new global::System.EventHandler(this.OnBtnShowDateToggled);
		this.btnShowWarnings.Toggled += new global::System.EventHandler(this.OnBtnShowDateToggled);
		this.btnShowNotices.Toggled += new global::System.EventHandler(this.OnBtnShowDateToggled);
		this.deleteAction.Activated += new global::System.EventHandler(this.OnBtnClearLogActivated);
		this.btnShowStackTrace.Toggled += new global::System.EventHandler(this.OnBtnShowDateToggled);
		this.textview.KeyPressEvent += new global::Gtk.KeyPressEventHandler(this.OnTextviewKeyPressEvent);
	}
}
