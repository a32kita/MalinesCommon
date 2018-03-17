using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MalinesCommon.Windows
{
#if DOC_JA
    /// <summary>
    /// <see cref="DependencyObject"/> のための拡張機能を提供します。
    /// </summary>
#else
    /// <summary>
    /// Provides extensions for <see cref="DependencyObject"/>.
    /// </summary>
#endif
    public static class DependencyObjectExtensions
    {
        // Public static methods

#if DOC_JA
        /// <summary>
        /// ビジュアルツリーから <typeparamref name="T"/> 型の祖先を検索します。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
#else
        /// <summary>
        /// Finds a ancestor element that type is <typeparamref name="T"/> from Visual Tree.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
#endif
        public static T FindAncestor<T>(this DependencyObject source) where T : class
        {
            var currentTarget = source;
            while (true)
            {
                try
                {
                    currentTarget = System.Windows.Media.VisualTreeHelper.GetParent(currentTarget);
                }
                catch
                {
                    return null;
                }

                if (currentTarget == null)
                    return null;
                if (currentTarget is T)
                    return currentTarget as T;
            }
        }
    }
}
