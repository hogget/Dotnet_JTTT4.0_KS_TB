using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public BindingList<MyTask> ListaTaskow;

        string pageHtml;
        string action;
        public Form1()
        {
            InitializeComponent();
            ListaTaskow = new BindingList<MyTask>();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            var myTask = new MyTask();
            myTask.AdresStrony = Adres_strony.Text;
            myTask.Klucz = Klucz.Text;
            myTask.Email = Email.Text;
            myTask.Name = nazwaBox.Text;

            using (var context = new JtttContext())
            {
                context.MyTasks.Add(myTask);
                context.SaveChanges();
            }

            ListaTaskow.Add(myTask);
            lista_zadan.DataSource = ListaTaskow;
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void wykonajPojedynczegoTaska(MyTask TaskDoWykonania)
        {
            Html html = new Html();
            var images = html.GetImagesFromPageWithKey(TaskDoWykonania.AdresStrony, TaskDoWykonania.Klucz);
            EMail emailHelper = new EMail("aga.michalik788@gmail.com", "javaandfriends");

            foreach (var imageUrl in images)
                emailHelper.SendMail(TaskDoWykonania.Email, "This should be funny!!!", imageUrl);
        }

        private void WykonajZadaniaZListy(object sender, EventArgs e)
        {
            foreach (var task in ListaTaskow)
            {
                wykonajPojedynczegoTaska(task);
            }
        }

        private void WyczyscListe(object sender, EventArgs e)
        {
            ListaTaskow.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Serialize(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();
            serializer.Serialize(ListaTaskow, "Dane.dat");
        }

        private void Deserialize(object sender, EventArgs e)
        {
            Serializer deserializer = new Serializer();
            ListaTaskow = deserializer.Deserialize("Dane.dat");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nazwaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adres_strony_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void nazwaBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void akcjaTab_selectedTabChanged(object sender, EventArgs e)
        {
            TabControl tab = (TabControl)sender;
            string wybor = (string)tab.SelectedTab.Name;
            if (wybor == "showTab")
            {
                action = "show";
            }
            else if (wybor == "emailTab")
            {
                action = "send";
            }
            Console.Write("Aktualna akcja to: " + action + "\n");
        }

        private void warunekTabIndexChanged(object sender, EventArgs e)
        {
            TabControl tab = (TabControl)sender;
            string wybor = (string)tab.SelectedTab.Name;
            if (wybor == "pogoda")
            {
                pageHtml = "wheather";
            }
          
            Console.Write("Aktualny seris to: " + pageHtml + "\n");
        }

        private void Nazwa_Click(object sender, EventArgs e)
        {

        }
    }
}
