using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MalinesCommon.Windows.ModernStyle.InternalElements
{
    /// <summary>
    /// Defines a View-Model for <see cref="ModernWindow"/>.
    /// </summary>
    public class ModernWindowViewModel : ViewModel.BackingedViewModelBase
    {
        // Private fields


        // Public properties


        // Binding properties

        /// <summary>
        /// Binding property.
        /// </summary>
        public Brush Binding_BorderBrush
        {
            get => this.GetValue<Brush>();
            set => this.SetValue(value);
        }

        /// <summary>
        /// Binding property.
        /// </summary>
        public Brush Binding_TopBoxBrush
        {
            get => this.GetValue<Brush>();
            set => this.SetValue(value);
        }

        /// <summary>
        /// Binding property.
        /// </summary>
        public Brush Binding_MiddleBoxBrush
        {
            get => this.GetValue<Brush>();
            set => this.SetValue(value);
        }

        /// <summary>
        /// Binding property.
        /// </summary>
        public Brush Binding_BottomBoxBrush
        {
            get => this.GetValue<Brush>();
            set => this.SetValue(value);
        }

        /// <summary>
        /// Binding property.
        /// </summary>
        public string Binding_TitleText
        {
            get => this.GetValue<string>();
            set => this.SetValue(value);
        }


        // Constructor

        /// <summary>
        /// 
        /// </summary>
        public ModernWindowViewModel()
        {
        }
    }
}
