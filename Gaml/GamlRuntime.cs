using System;
using System.Runtime.InteropServices;
using System.Xaml;

namespace Gaml
{
    public static class GamlRuntime
    {
        private static void QuitHandler(object sender, EventArgs e)
        {
            Gtk.Application.Quit();
        }

        public static void Run(Func<Window> windowCreator)
        {
            Gtk.Application.Init();

            GamlDispatcher.CurrentDispatcher.SetSynchContext();

            var window = windowCreator();
            try
            {
                window.Destroyed += QuitHandler;
                window.ShowAll();
                Gtk.Application.Run();
            }
            finally
            {
                window.Destroyed -= QuitHandler;
            }
        }

        public static void Run<TWindow>()
            where TWindow : Window, new()
        {
            Run(() => new TWindow());
        }

        public static void InitializeComponent(Gtk.Widget widget)
        {
            var type = widget.GetType();
            var name = type.FullName + ".xaml";

            using (var stream = type.Assembly.GetManifestResourceStream(name))
            {
                var xr = new XamlXmlReader(
                    stream,
                    new XamlXmlReaderSettings
                    {
                        LocalAssembly = type.Assembly,
                    });

                var xw = new XamlObjectWriter(
                    xr.SchemaContext,
                    new XamlObjectWriterSettings
                    {
                        RootObjectInstance = widget
                    });

                XamlServices.Transform(xr, xw);
            }
        }

        public static WidgetCollection GetChildren(this Gtk.Container container)
        {
            var gamlWidget = container as Internal.IGamlContainerCache;
            if (gamlWidget == null)
            {
                return new WidgetCollection(container);
            }

            var children = gamlWidget.Children;
            if (children == null)
            {
                children = new WidgetCollection(container);
                gamlWidget.Children = children;
            }

            return children;
        }

        private static Gtk.Widget ToWidget(object content)
        {
            if (content == null)
            {
                return null;
            }

            var widget = content as Gtk.Widget;
            if (widget != null)
            {
                return widget;
            }
            else
            {
                return new Label { Text = content.ToString() };
            }
        }

        public static Gtk.Widget GetContent(this Gtk.Bin bin)
        {
            return bin.Child;
        }

        public static void SetContent(this Gtk.Bin bin, object content)
        {
            bin.Child = ToWidget(content);
        }
    }
}
