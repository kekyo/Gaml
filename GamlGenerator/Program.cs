using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace GamlGenerator
{
    static class Program
    {
        private static IEnumerable<Type> EnumerateHierarchy(this Type type)
        {
            var t = type;
            while (t != null)
            {
                yield return t;
                t = t.BaseType;
            }
        }

        private static string GetTypeFullName(Type type)
        {
            return type.FullName;
        }

        private static bool CanDefaultValue(Type type)
        {
            return (type.IsPrimitive && (type != typeof(IntPtr))) || (type == typeof(string));
        }

        private static bool IsXamlConstructable(ConstructorInfo ci)
        {
            if (!(ci.IsPublic || ci.IsFamily || ci.IsFamilyAndAssembly || ci.IsFamilyOrAssembly))
            {
                return false;
            }

            var ps = ci.GetParameters();
            if (ps.Length == 0)
            {
                return true;
            }

            if (!ps.All(p => CanDefaultValue(p.ParameterType)))
            {
                return false;
            }

            return ci.DeclaringType.EnumerateHierarchy().
                SelectMany(type => type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)).
                Any(pi => pi.CanRead && pi.CanWrite && pi.IsDefined(typeof(GLib.PropertyAttribute)));
        }

        private static string GetDefaultValueExpression(Type type)
        {
            if (type.IsPrimitive)
            {
                return $"default({type.FullName})";
            }
            else
            {
                return "string.Empty";
            }
        }

        static void Main(string[] args)
        {
            using (var fs = new FileStream(@"..\..\..\Gaml\GamlWidgets.cs", FileMode.Create, FileAccess.ReadWrite, FileShare.None))
            {
                var tw = new StreamWriter(fs);
                tw.WriteLine("namespace Gaml");
                tw.WriteLine("{");

                var assembly = typeof(Gtk.Window).Assembly;

                foreach (var type in
                    assembly.GetTypes().
                    Where(t => t.IsPublic && !t.IsAbstract && !t.IsSealed && t.IsClass &&
                        !t.IsGenericTypeDefinition &&
                        typeof(Gtk.Widget).IsAssignableFrom(t)))
                {
                    var ci = type.GetConstructors().
                        OrderBy(c => c.GetParameters().Length).
                        FirstOrDefault(IsXamlConstructable);
                    if (ci == null)
                    {
                        continue;
                    }

                    if (typeof(Gtk.Bin).IsAssignableFrom(type))
                    {
                        tw.WriteLine("    [System.ComponentModel.DefaultProperty(\"Content\")]");
                        tw.WriteLine("    [System.Windows.Markup.ContentProperty(\"Content\")]");
                    }
                    else if (typeof(Gtk.Container).IsAssignableFrom(type))
                    {
                        tw.WriteLine("    [System.ComponentModel.DefaultProperty(\"Children\")]");
                        tw.WriteLine("    [System.Windows.Markup.ContentProperty(\"Children\")]");
                    }

                    tw.WriteLine("    public partial class {0} : {1}, Internal.IGamlRuntime{2}",
                        type.Name,
                        GetTypeFullName(type),
                        typeof(Gtk.Container).IsAssignableFrom(type) ? ", IGamlContainer, Internal.IGamlContainerCache" : "");
                    tw.WriteLine("    {");

                    var pis = ci.GetParameters();
                    if (pis.Length == 0)
                    {
                        tw.WriteLine("        public {0}() {{ }}", type.Name);
                    }
                    else
                    {
                        tw.WriteLine("        public {0}() : base({1}) {{ }}",
                            type.Name,
                            string.Join(
                                ", ",
                                pis.Select(pi => GetDefaultValueExpression(pi.ParameterType))));
                    }

                    tw.WriteLine();

                    if (typeof(Gtk.Container).IsAssignableFrom(type))
                    {
                        tw.WriteLine("        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]");
                        tw.WriteLine("        public new WidgetCollection Children");
                        tw.WriteLine("        {");
                        tw.WriteLine("            get");
                        tw.WriteLine("            {");
                        tw.WriteLine("                return GamlRuntime.GetChildren(this);");
                        tw.WriteLine("            }");
                        tw.WriteLine("        }");

                        tw.WriteLine();

                        if (typeof(Gtk.Bin).IsAssignableFrom(type))
                        {
                            tw.WriteLine("        [System.ComponentModel.Bindable(true)]");
                            tw.WriteLine("        public object Content");
                            tw.WriteLine("        {");
                            tw.WriteLine("            get");
                            tw.WriteLine("            {");
                            tw.WriteLine("                return GamlRuntime.GetContent(this);");
                            tw.WriteLine("            }");
                            tw.WriteLine("            set");
                            tw.WriteLine("            {");
                            tw.WriteLine("                GamlRuntime.SetContent(this, value);");
                            tw.WriteLine("            }");
                            tw.WriteLine("        }");

                            tw.WriteLine();
                        }

                        tw.WriteLine("        WidgetCollection Internal.IGamlContainerCache.Children");
                        tw.WriteLine("        {");
                        tw.WriteLine("            get;");
                        tw.WriteLine("            set;");
                        tw.WriteLine("        }");

                        tw.WriteLine();
                    }

                    tw.WriteLine("        [System.ComponentModel.Bindable(false)]");
                    tw.WriteLine("        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]");
                    tw.WriteLine("        public GamlDispatcher Dispatcher");
                    tw.WriteLine("        {");
                    tw.WriteLine("            get { return GamlDispatcher.CurrentDispatcher; }");
                    tw.WriteLine("        }");

                    tw.WriteLine();

                    tw.WriteLine("        protected void InitializeComponent()");
                    tw.WriteLine("        {");
                    tw.WriteLine("            GamlRuntime.InitializeComponent(this);");
                    tw.WriteLine("        }");

                    tw.WriteLine("    }");
                    tw.WriteLine();
                }

                tw.WriteLine("}");

                tw.Flush();
                fs.Flush();
            }
        }
    }
}
