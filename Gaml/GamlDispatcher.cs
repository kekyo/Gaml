using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gaml
{
    public sealed class GamlDispatcher
    {
        private static readonly GamlDispatcher dispatcher = new GamlDispatcher();

        public static GamlDispatcher CurrentDispatcher
        {
            get
            {
                return dispatcher;
            }
        }

        private SynchronizationContext context;

        internal GamlDispatcher()
        {
        }

        internal void SetSynchContext()
        {
            context = SynchronizationContext.Current;
        }

        private void PrepareSynchContext()
        {
            if (context == null)
            {
                lock (this)
                {
                    if (context == null)
                    {
                        context = SynchronizationContext.Current;
                    }
                }
            }
        }

        public void Invoke(Action action)
        {
            this.PrepareSynchContext();
            context.Send(state => action(), null);
        }

        public TResult Invoke<TResult>(Func<TResult> func)
        {
            this.PrepareSynchContext();
            var result = default(TResult);
            context.Send(state => result = func(), null);

            return result;
        }

        public Task BeginInvoke(Action action)
        {
            this.PrepareSynchContext();

            var tcs = new TaskCompletionSource<object>();
            context.Post(state =>
            {
                try
                {
                    action();
                    tcs.SetResult(null);
                }
                catch (Exception ex)
                {
                    tcs.SetException(ex);
                }
            }, null);

            return tcs.Task;
        }

        public Task<TResult> BeginInvoke<TResult>(Func<TResult> func)
        {
            this.PrepareSynchContext();

            var tcs = new TaskCompletionSource<TResult>();
            context.Post(state =>
            {
                try
                {
                    tcs.SetResult(func());
                }
                catch (Exception ex)
                {
                    tcs.SetException(ex);
                }
            }, null);

            return tcs.Task;
        }
    }
}
