using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using MalinesCommon.ComponentModel;

namespace MalinesCommon.Windows.ViewModel
{

#if DOC_JA
    /// <summary>
    /// MVVMのためのビューモデルの定義を提供します。
    /// </summary>
#else
    /// <summary>
    /// Provides the definition of View-Model in MVVM.
    /// </summary>
#endif
    public class ViewModelBase : NotifyPropertyChangedBase
    {
        // Constructor

#if DOC_JA
        /// <summary>
        /// <see cref="ViewModelBase"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
#else
        /// <summary>
        /// Initializes a new instance of <see cref="ViewModelBase"/> class.
        /// </summary>
#endif
        public ViewModelBase()
        { }


        // Protected methods

#if DOC_JA
        /// <summary>
        /// バインディング プロパティに値を代入し、プロパティが変更されたことを通知します。
        /// </summary>
        /// <param name="value"></param>
        /// <param name="propertyName"></param>
#else
        /// <summary>
        /// Sets a binding property value and notify property changed.
        /// </summary>
        /// <typeparam name="TStorage"></typeparam>
        /// <param name="storage"></param>
        /// <param name="value"></param>
        /// <param name="propertyName"></param>
#endif
        protected void SetValue<TStorage>(ref TStorage storage, TStorage value, [CallerMemberName] string propertyName = "")
        {
            storage = value;
            this.RaisePropertyChanged(propertyName);
        }
    }
}
