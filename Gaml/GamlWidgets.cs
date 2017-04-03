namespace Gaml
{
    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class AboutDialog : Gtk.AboutDialog, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public AboutDialog() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    public partial class AccelLabel : Gtk.AccelLabel, Internal.IGamlRuntime
    {
        public AccelLabel() : base(string.Empty) { }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class Alignment : Gtk.Alignment, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public Alignment() : base(default(System.Single), default(System.Single), default(System.Single), default(System.Single)) { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class AppChooserButton : Gtk.AppChooserButton, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public AppChooserButton() : base(string.Empty) { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class AppChooserWidget : Gtk.AppChooserWidget, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public AppChooserWidget() : base(string.Empty) { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class AspectFrame : Gtk.AspectFrame, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public AspectFrame() : base(string.Empty, default(System.Single), default(System.Single), default(System.Single), default(System.Boolean)) { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class Assistant : Gtk.Assistant, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public Assistant() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class Button : Gtk.Button, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public Button() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    public partial class Calendar : Gtk.Calendar, Internal.IGamlRuntime
    {
        public Calendar() { }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    public partial class CellView : Gtk.CellView, Internal.IGamlRuntime
    {
        public CellView() { }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class CheckButton : Gtk.CheckButton, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public CheckButton() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class CheckMenuItem : Gtk.CheckMenuItem, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public CheckMenuItem() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class ColorButton : Gtk.ColorButton, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public ColorButton() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class ColorSelection : Gtk.ColorSelection, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public ColorSelection() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class ColorSelectionDialog : Gtk.ColorSelectionDialog, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public ColorSelectionDialog() : base(string.Empty) { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class ComboBox : Gtk.ComboBox, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public ComboBox() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class ComboBoxText : Gtk.ComboBoxText, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public ComboBoxText() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class Dialog : Gtk.Dialog, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public Dialog() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    public partial class DrawingArea : Gtk.DrawingArea, Internal.IGamlRuntime
    {
        public DrawingArea() { }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    public partial class Entry : Gtk.Entry, Internal.IGamlRuntime
    {
        public Entry() { }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class EventBox : Gtk.EventBox, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public EventBox() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class Expander : Gtk.Expander, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public Expander() : base(string.Empty) { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class Fixed : Gtk.Fixed, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public Fixed() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class FontButton : Gtk.FontButton, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public FontButton() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class FontSelection : Gtk.FontSelection, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public FontSelection() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class FontSelectionDialog : Gtk.FontSelectionDialog, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public FontSelectionDialog() : base(string.Empty) { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class Frame : Gtk.Frame, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public Frame() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class Grid : Gtk.Grid, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public Grid() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class HandleBox : Gtk.HandleBox, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public HandleBox() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class HBox : Gtk.HBox, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public HBox() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class HButtonBox : Gtk.HButtonBox, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public HButtonBox() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class HPaned : Gtk.HPaned, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public HPaned() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    public partial class HScale : Gtk.HScale, Internal.IGamlRuntime
    {
        public HScale() : base(default(System.Double), default(System.Double), default(System.Double)) { }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    public partial class HSeparator : Gtk.HSeparator, Internal.IGamlRuntime
    {
        public HSeparator() { }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    public partial class HSV : Gtk.HSV, Internal.IGamlRuntime
    {
        public HSV() { }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class IconView : Gtk.IconView, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public IconView() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    public partial class Image : Gtk.Image, Internal.IGamlRuntime
    {
        public Image() { }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class ImageMenuItem : Gtk.ImageMenuItem, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public ImageMenuItem() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class InfoBar : Gtk.InfoBar, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public InfoBar() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    public partial class Invisible : Gtk.Invisible, Internal.IGamlRuntime
    {
        public Invisible() { }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    public partial class Label : Gtk.Label, Internal.IGamlRuntime
    {
        public Label() { }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class LinkButton : Gtk.LinkButton, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public LinkButton() : base(string.Empty) { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class MenuBar : Gtk.MenuBar, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public MenuBar() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class Menu : Gtk.Menu, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public Menu() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class MenuItem : Gtk.MenuItem, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public MenuItem() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class MenuToolButton : Gtk.MenuToolButton, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public MenuToolButton() : base(string.Empty) { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class Notebook : Gtk.Notebook, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public Notebook() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class OffscreenWindow : Gtk.OffscreenWindow, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public OffscreenWindow() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class Plug : Gtk.Plug, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public Plug() : base(default(System.UInt64)) { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    public partial class ProgressBar : Gtk.ProgressBar, Internal.IGamlRuntime
    {
        public ProgressBar() { }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class RadioButton : Gtk.RadioButton, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public RadioButton() : base(string.Empty) { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class RadioMenuItem : Gtk.RadioMenuItem, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public RadioMenuItem() : base(string.Empty) { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class RecentChooserMenu : Gtk.RecentChooserMenu, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public RecentChooserMenu() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class RecentChooserWidget : Gtk.RecentChooserWidget, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public RecentChooserWidget() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class ScrolledWindow : Gtk.ScrolledWindow, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public ScrolledWindow() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class SeparatorMenuItem : Gtk.SeparatorMenuItem, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public SeparatorMenuItem() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class SeparatorToolItem : Gtk.SeparatorToolItem, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public SeparatorToolItem() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class Socket : Gtk.Socket, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public Socket() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    public partial class SpinButton : Gtk.SpinButton, Internal.IGamlRuntime
    {
        public SpinButton() : base(default(System.Double), default(System.Double), default(System.Double)) { }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    public partial class Spinner : Gtk.Spinner, Internal.IGamlRuntime
    {
        public Spinner() { }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class Statusbar : Gtk.Statusbar, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public Statusbar() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    public partial class Switch : Gtk.Switch, Internal.IGamlRuntime
    {
        public Switch() { }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class Table : Gtk.Table, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public Table() : base(default(System.UInt32), default(System.UInt32), default(System.Boolean)) { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class TearoffMenuItem : Gtk.TearoffMenuItem, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public TearoffMenuItem() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class TextView : Gtk.TextView, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public TextView() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class ToggleButton : Gtk.ToggleButton, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public ToggleButton() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class ToggleToolButton : Gtk.ToggleToolButton, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public ToggleToolButton() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class Toolbar : Gtk.Toolbar, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public Toolbar() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class ToolButton : Gtk.ToolButton, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public ToolButton() : base(string.Empty) { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class ToolItem : Gtk.ToolItem, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public ToolItem() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class ToolItemGroup : Gtk.ToolItemGroup, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public ToolItemGroup() : base(string.Empty) { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class ToolPalette : Gtk.ToolPalette, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public ToolPalette() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class TreeView : Gtk.TreeView, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public TreeView() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class VBox : Gtk.VBox, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public VBox() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class VButtonBox : Gtk.VButtonBox, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public VButtonBox() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class Viewport : Gtk.Viewport, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public Viewport() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class VolumeButton : Gtk.VolumeButton, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public VolumeButton() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class VPaned : Gtk.VPaned, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public VPaned() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    public partial class VScale : Gtk.VScale, Internal.IGamlRuntime
    {
        public VScale() : base(default(System.Double), default(System.Double), default(System.Double)) { }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    public partial class VSeparator : Gtk.VSeparator, Internal.IGamlRuntime
    {
        public VSeparator() { }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Content")]
    [System.Windows.Markup.ContentProperty("Content")]
    public partial class Window : Gtk.Window, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public Window() : base(string.Empty) { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        [System.ComponentModel.Bindable(true)]
        public object Content
        {
            get
            {
                return GamlRuntime.GetContent(this);
            }
            set
            {
                GamlRuntime.SetContent(this, value);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

    [System.ComponentModel.DefaultProperty("Children")]
    [System.Windows.Markup.ContentProperty("Children")]
    public partial class NodeView : Gtk.NodeView, Internal.IGamlRuntime, IGamlContainer, Internal.IGamlContainerCache
    {
        public NodeView() { }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new WidgetCollection Children
        {
            get
            {
                return GamlRuntime.GetChildren(this);
            }
        }

        WidgetCollection Internal.IGamlContainerCache.Children
        {
            get;
            set;
        }

        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public GamlDispatcher Dispatcher
        {
            get { return GamlDispatcher.CurrentDispatcher; }
        }

        protected void InitializeComponent()
        {
            GamlRuntime.InitializeComponent(this);
        }
    }

}
