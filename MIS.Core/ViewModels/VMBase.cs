using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Core.ViewModels
{
    /// <summary>
    /// ViewModelBase
    /// </summary>
    public class VMBase<T> : DynamicObject, INotifyPropertyChanged
        where T : class, IModel, new()
    {
        public VMBase(T wrappedObject)
        {
            this.WrappedObject = wrappedObject;
        }

        #region 动态属性绑定支持

        /// <summary>
        /// 包装的数据实体类 Model
        /// </summary>
        public T WrappedObject { get; set; }

        /// <summary>
        /// 尝试访问包装类的属性值
        /// </summary>
        /// <param name="binder"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            //在包装类中查找属性值，失败返回false;
            string propertyName = binder.Name;
            PropertyInfo property = this.WrappedObject.GetType().GetProperty(propertyName);
            if (property == null || property.CanRead == false)
            {
                result = null; return false;
            }
            result = property.GetValue(this.WrappedObject, null);
            return true;
        }

        /// <summary>
        /// 尝试设置包装类的属性值
        /// </summary>
        /// <param name="binder"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            //在包装类中设置属性值，失败返回false;
            string propertyName = binder.Name;
            PropertyInfo property = this.WrappedObject.GetType().GetProperty(propertyName);
            if (property == null || property.CanWrite == false)
                return false;
            property.SetValue(this.WrappedObject, value, null);
            this.OnPropertyChanged(propertyName);
            return true;
        }

        #endregion

        #region 数据库基本逻辑 CURD
        
        #endregion

        #region INotifyPropertyChanged 实现

        /// <summary>
        /// 属性改变事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 引发属性改变事件
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
