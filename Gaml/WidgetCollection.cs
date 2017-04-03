using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Gtk;

namespace Gaml
{
    public class WidgetCollection : IList<Widget>, IList
    {
        private readonly Gtk.Container container;

        public WidgetCollection(Gtk.Container container)
        {
            this.container = container;
        }

        public Widget this[int index]
        {
            get
            {
                return container.Children[index];
            }

            set
            {
                container.Children[index] = value;
            }
        }

        object IList.this[int index]
        {
            get
            {
                return container.Children[index];
            }

            set
            {
                container.Children[index] = (Gtk.Widget)value;
            }
        }

        public int Count
        {
            get
            {
                return container.Children.Length;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        int ICollection.Count
        {
            get
            {
                return container.Children.Length;
            }
        }

        bool IList.IsFixedSize
        {
            get
            {
                return false;
            }
        }

        bool IList.IsReadOnly
        {
            get
            {
                return false;
            }
        }

        bool ICollection.IsSynchronized
        {
            get
            {
                return false;
            }
        }

        object ICollection.SyncRoot
        {
            get
            {
                return container;
            }
        }

        public void Add(Widget item)
        {
            container.Add(item);
        }

        int IList.Add(object value)
        {
            container.Add((Widget)value);
            return container.Children.Length - 1;
        }

        public void Clear()
        {
            foreach (var child in container.Children)
            {
                container.Remove(child);
            }
        }

        void IList.Clear()
        {
            this.Clear();
        }

        public bool Contains(Widget widget)
        {
            return container.Children.Contains(widget);
        }

        bool IList.Contains(object value)
        {
            return this.Contains((Widget)value);
        }

        private void CopyTo(Widget[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        void ICollection<Widget>.CopyTo(Widget[] array, int arrayIndex)
        {
            this.CopyTo(array, arrayIndex);
        }

        void ICollection.CopyTo(Array array, int index)
        {
            this.CopyTo((Widget[])array, index);
        }

        public IEnumerator<Widget> GetEnumerator()
        {
            return ((IEnumerable<Widget>)container.Children).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int IndexOf(Widget widget)
        {
            return Array.IndexOf(container.Children, widget);
        }

        int IList.IndexOf(object value)
        {
            return this.IndexOf((Widget)value);
        }

        public void Insert(int index, Widget widget)
        {
            throw new NotImplementedException();
        }

        void IList.Insert(int index, object value)
        {
            this.Insert(index, (Widget)value);
        }

        public bool Remove(Widget widget)
        {
            if (this.Contains(widget))
            {
                container.Remove(widget);
                return true;
            }

            return false;
        }

        void IList.Remove(object value)
        {
            this.Remove((Widget)value);
        }

        public void RemoveAt(int index)
        {
            var widget = container.Children[index];
            this.Remove(widget);
        }

        void IList.RemoveAt(int index)
        {
            this.RemoveAt(index);
        }
    }
}
