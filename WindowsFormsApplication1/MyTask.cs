using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class MyTask
    {
        public int Id { get; set; }
        public string AdresStrony { get; set; }
        public string Klucz { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }

        public List<MyTask> MyTasks { get; set; }

        public override string ToString()
        {
            return "Task o nazwie: " + Name;
        }

    }
}

