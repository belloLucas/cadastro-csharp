using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {

        List<Person> peopleList = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Add button
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string city = textBox2.Text;
            string gender = (Masculino.Checked) ? "Masculino" : "Feminino";

            Person newPerson = new Person
            {
                Name = name,
                City = city,
                Gender = gender,
            };

            peopleList.Add(newPerson);

            cleanInputs();
            listBox1.Items.Add(newPerson);
        }

        //Delete button
        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                Person selectedPerson = (Person)listBox1.SelectedItem;
                peopleList.Remove(selectedPerson);
                listBox1.Items.Remove(listBox1.SelectedItem);

                cleanInputs();
            }
        }

        //Update button
        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null) 
            {
                Person selectedPerson = (Person)listBox1.SelectedItem;
                listBox1.Items.Remove(selectedPerson);

                selectedPerson.Name = textBox1.Text;
                selectedPerson.City = textBox2.Text;
                selectedPerson.Gender = (Masculino.Checked) ? "Masculino" : "Feminino";

                listBox1.Items.Add(selectedPerson);
                peopleList.Remove(selectedPerson);
                peopleList.Add(selectedPerson);

                cleanInputs();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Masculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cleanInputs()
        {
            textBox1.Clear();
            textBox2.Clear();
            Masculino.Checked = false;
            Feminino.Checked = false;
        }

        //Filter button
        private void button4_Click(object sender, EventArgs e)
        {
            //Não consegui implementar a função para ordenar número de contatos por cidade a tempo
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
