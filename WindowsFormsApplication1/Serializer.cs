using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication1
{
    class Serializer
    {
        public void Serialize(BindingList<MyTask> taskBindingList, string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(fileStream, taskBindingList);
        }
        
        public BindingList<MyTask> Deserialize(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(fileName, FileMode.Open);
            return (BindingList<MyTask>)formatter.Deserialize(fileStream);
        }
    }
}
