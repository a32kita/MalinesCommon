using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using MalinesCommon.Windows.ModernStyle.InternalBases;

namespace MalinesCommon.Windows.ModernStyle
{
    /// <summary>
    /// Provides the definition of modern style window.
    /// </summary>
    public class ModernWindow : ModernWindowBase
    {
        // Private fields


        // Public properties


        // Dependency properties


        // Contructor

#if DOC_JA
        /// <summary>
        /// <see cref="ModernWindow"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
#else
        /// <summary>
        /// Initializes a new instance of <see cref="ModernWindow"/> class.
        /// </summary>
#endif
        public ModernWindow()
        {
            this._applyTemplate();
        }


        // Private methods

#if DOC_JA
        /// <summary>
        /// <see cref="ModernWindow"/> へテンプレートを適用します。
        /// </summary>
#else
        /// <summary>
        /// Applies template to <see cref="ModernWindow"/>.
        /// </summary>
#endif
        private void _applyTemplate()
        {
            //var resDic = Application.LoadComponent(
            //    new Uri("/MalinesCommon;component/windows/modernstyle/internalresources/modernwindowresources.xaml", UriKind.Relative) ) as ResourceDictionary;
            //if (resDic == null)
            //    throw new Exception($"Failed to load resources that is template of {nameof(ModernWindow)}.");
            
            // Loads a template for Modern Window from components.
            // The template defined by XAML.
            var template = Application.LoadComponent(
                new Uri("/MalinesCommon;component/windows/modernstyle/internalresources/modernwindowtemplate.xaml", UriKind.Relative)) as System.Windows.Controls.ControlTemplate;
            
            this.Template = template ?? throw new Exception(String.Format(Properties.Resources.ModernWindow__applyTemplate_loadTemplate, nameof(ModernWindow)));
        }


        // Public methods

        
    }
}
