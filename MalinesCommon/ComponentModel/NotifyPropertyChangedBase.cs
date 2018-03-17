using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace MalinesCommon.ComponentModel
{
    /// <summary>
    /// Provides implementations of <see cref="INotifyPropertyChanged"/> base functions.
    /// </summary>
    public class NotifyPropertyChangedBase
    {
        // Private fields
        private PropertyChangedEventHandler _propertyChanged;


        // Public events

#if DOC_JA
        /// <summary>
        /// プロパティの値が変化した時に発生します。
        /// </summary>
#else
        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
#endif
        public event PropertyChangedEventHandler PropertyChanged
        {
            add => this._propertyChanged += value;
            remove => this._propertyChanged -= value;
        }


        // Constructor

#if DOC_JA
        /// <summary>
        /// <see cref="NotifyPropertyChangedBase"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
#else
        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyPropertyChangedBase"/> class.
        /// </summary>
#endif
        public NotifyPropertyChangedBase()
        {
            this._propertyChanged = null;
        }


        // Protected methods

#if DOC_JA
        /// <summary>
        /// <see cref="PropertyChanged"/> イベントを発生させます。
        /// </summary>
        /// <param name="propertyName">変化したプロパティの名前</param>
#else
        /// <summary>
        /// Raises the <see cref="PropertyChanged"/> event.
        /// </summary>
        /// <param name="propertyName">The name of the property that changed.</param>
#endif
        protected void RaisePropertyChanged([CallerMemberName]string propertyName = "")
        {
            this._propertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
