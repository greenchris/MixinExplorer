using System;
using System.Linq;

namespace MixinExplorer.Mixins.Core
{
    /// <summary>
    /// Contains implementation of the core functionality offerd by the Disposable Mixin
    /// </summary>
    public static class DisposableMixinCore
    {
        private static bool _disposed = false;

        public static void Dispose(this DisposableMixin subject, bool disposing, params Object[] unmanagedDependencies)
        {
            _disposed = false;

            if (!_disposed)
            {
                if (disposing)
                {
                    unmanagedDependencies?.ToList().ForEach(d =>
                    {
                        Dispose((object) d);
                        GC.SuppressFinalize(subject);
                    });
                }

                _disposed = true;
            }
            Console.WriteLine($"Disposal of {subject}'s unmanaged resources complete");
        }

        #region private utils
        private static void Dispose(object dependency)
        {
            if (_disposed)
                return;

            if (dependency != null)
                dependency = null;
        }
        #endregion
    }
}
