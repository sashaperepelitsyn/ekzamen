using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SpisokZada4
    {
        public static string Imya { get; set; }
        public static List<Zada4a> Zada4i { get; set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name"></param>
        public SpisokZada4(string name)
        {
            name = Imya;
        }
        /// <summary>
        /// Получение имени списка задач
        /// </summary>
        /// <returns> Имя </returns>
        public static string GetName()
        {
            return Imya;
        }
        /// <summary>
        /// Добовлет задачи
        /// </summary>
        /// <param name="task"></param>
        public static void AddTask(Zada4a task)
        {
            Zada4i.Add(task);
        }
        /// <summary>
        /// Возвращает список всех задач
        /// </summary>
        /// <returns>возвращает список всех задач </returns>
        public static List<Zada4a> GetTasks()
        {
            return Zada4i;
        }
        /// <summary>
        /// Удаляет задачу
        /// </summary>
        /// <param name="task"> объект задачи</param>
        public static void Remove(Zada4a task)
        {
            Zada4i.Remove(task);
        }
    }
}
