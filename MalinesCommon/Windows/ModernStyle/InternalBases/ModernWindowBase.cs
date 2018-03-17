using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shell;

namespace MalinesCommon.Windows.ModernStyle.InternalBases
{
    /// <summary>
    /// Provides the base definition of window that for modern styles user interfaces.
    /// </summary>
    public class ModernWindowBase : Window
    {
        // Private fields


        // Dependency properties

            
        // Constructor

        /// <summary>
        /// Initializes a new instance of <see cref="ModernWindowBase"/> class.
        /// </summary>
        public ModernWindowBase()
        {
            this._applyWindowChrome();
        }


        // Private methods

        /// <summary>
        /// Applies <see cref="WindowChrome"/> settings to window.
        /// </summary>
        private void _applyWindowChrome()
        {
            this.SetValue(WindowChrome.WindowChromeProperty, new WindowChrome()
            {
                ResizeBorderThickness = new Thickness(1),
                CaptionHeight = SystemParameters.CaptionHeight,
            });
        }
    }
}
