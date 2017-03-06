using System;
using System.Linq;

namespace MixinExplorer.Mixins.Core
{
    /// <summary>
    /// Contains implementation of the core functionality offerd by the Disposable Mixin
    /// </summary>
    public static class DisposableMixinCore
    {
        private static bool _disposed;

        public static void Dispose(this DisposableMixin subject, bool disposingDependencies, params object[] unmanagedDependencies)
        {
            _disposed = false;

            if (!_disposed)
            {
                if (disposingDependencies)
                {
                    unmanagedDependencies?.ToList().ForEach(d =>
                    {
                        Dispose(d);
                        GC.SuppressFinalize(subject);
                    });
                }
                _disposed = true;
                Dispose(subject);
            }
        }

        #region private utils
        private static void Dispose(object obj)
        {
            if (_disposed)
                Console.WriteLine($"Disposal of {obj} and its unmanaged resources is complete");

            if (obj != null)
                obj = null;
        }
        #endregion
    }
}
