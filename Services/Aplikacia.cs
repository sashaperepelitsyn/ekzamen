using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class Aplikacia
    {
        private Aplikacia aplicacia;

        private List<SpisokZada4> spisokZada4;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Aplikacia()
        {
            var TaskList = new SpisokZada4("Входящие");
            spisokZada4 = new List<SpisokZada4>();
            spisokZada4.Add(TaskList);
        }
        /// <summary>
        /// Dозвращает ссылку на экземпляр приложения, а в его отсутствие создает экземпляр.
        /// </summary>
        /// <returns> Возвращает апликацию </returns>
        public Aplikacia GetApplication()
        {
            if (aplicacia != null) return aplicacia;
            aplicacia = new Aplikacia();
            return aplicacia;
        }
        /// <summary>
        /// создает список с задачами и добавляет его в список со списками задач.
        /// </summary>
        /// <param name="name"> Имя списка задач</param>
        public void CreateTaskList(string name)
        {
            var TaskList = new SpisokZada4(name);
            spisokZada4.Add(TaskList);
        }
    }
}
