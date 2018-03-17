using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using MalinesCommon.ComponentModel;

namespace MalinesCommon.Windows.ViewModel
{
#if DOC_JA
    /// <summary>
    /// バインディングプロパティのためのバッキングフィールドを持つMVVM用のビューモデルの定義を提供します。
    /// </summary>
#else
    /// <summary>
    /// Provides the definition of View-Model that have backing fields for binding in MVVM.
    /// </summary>
#endif
    public class BackingedViewModelBase : NotifyPropertyChangedBase
    {
        // Private fields
        private Dictionary<string, object> _properties;


        // Constructor

#if DOC_JA
        /// <summary>
        /// <see cref="BackingedViewModelBase"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
#else
        /// <summary>
        /// Initializes a new instance of <see cref="BackingedViewModelBase"/> class.
        /// </summary>
#endif
        public BackingedViewModelBase()
        {
            this._properties = new Dictionary<string, object>();
        }


        // Protected methods

#if DOC_JA
        /// <summary>
        /// 指定した名前のバインディング プロパティが存在しているかどうかを判断します。
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
#else
        /// <summary>
        /// Determines whether a binding property named <paramref name="propertyName"/> exists on properties collection.
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
#endif
        protected bool ExistsProperty([CallerMemberName] string propertyName = "")
        {
            return this._properties.ContainsKey(propertyName);
        }

#if DOC_JA
        /// <summary>
        /// バインディング プロパティを削除します。
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
#else
        /// <summary>
        /// Remove a binding property.
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
#endif
        protected bool DeleteProperty([CallerMemberName] string propertyName = "")
        {
            return this._properties.Remove(propertyName);
        }

#if DOC_JA
        /// <summary>
        /// 指定したバインディング プロパティの値を取得します。
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
#else
        /// <summary>
        /// Gets binding property value.
        /// </summary>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="propertyName"></param>
        /// <returns></returns>
#endif
        protected TProperty GetValue<TProperty>([CallerMemberName] string propertyName = "")
        {
            if (!this._properties.ContainsKey(propertyName))
                return default(TProperty);

            try
            {
                return (TProperty)this._properties[propertyName];
            }
            //catch (KeyNotFoundException ex)
            //{
            //    throw new BackingedViewModelException($"The property name '{propertyName}' is invalid.", ex);
            //}
            catch (InvalidCastException ex)
            {
                throw new BackingedViewModelException(String.Format(Properties.Resources.BackingedViewModelBase_GetValue_CastError, typeof(TProperty).Name, propertyName), ex);
            }
            catch (Exception ex)
            {
                throw new BackingedViewModelException(String.Format(Properties.Resources.BackingedViewModelBase_GetValue_UnknownError, ex.GetType().Name), ex);
            }
        }


#if DOC_JA
        /// <summary>
        /// バインディング プロパティに値を代入し、プロパティが変更されたことを通知します。
        /// </summary>
        /// <param name="value"></param>
        /// <param name="propertyName"></param>
#else
        /// <summary>
        /// Sets binding property value and notify property changed.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="propertyName"></param>
#endif
        protected void SetValue(object value, [CallerMemberName] string propertyName = "")
        {
            this._properties[propertyName] = value;
            this.RaisePropertyChanged(propertyName);
        }
    }
}
