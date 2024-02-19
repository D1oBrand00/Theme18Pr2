using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme18Pr2
{
    /// <summary>
    /// Абстрактный класс обработчик документа
    /// </summary>
    abstract class AbstractHandler
    {
        /// <summary>
        /// Абстрактный метод открытия документа
        /// </summary>
        public abstract void Open();
        /// <summary>
        /// Абстрактный метод создания документа
        /// </summary>
        public abstract void Create();
        /// <summary>
        /// Абстрактный метод изменения документа
        /// </summary>
        public abstract void Change();
        /// <summary>
        /// Абстрактный метод сохранения документа
        /// </summary>
        public abstract void Save();
    }
}
