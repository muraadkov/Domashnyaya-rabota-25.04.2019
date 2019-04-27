using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            button1.Click += comboBox1_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new CitiesContext())
            {
                foreach (var city in context.Cities.ToList())
                {
                    comboBox1.Items.Add(city.Name);
                }

                Console.ReadLine();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                People people = new People();
                using (var context = new CitiesContext()) {
            string selectedState = comboBox1.SelectedItem.ToString();
            var cities = context.Cities.ToList().Where(x=>x.Name == selectedState);
                    foreach (var s in cities)
                    {
                        label1.Text = Convert.ToString(s.CityCode);
                        people.MobilePhone += s.CityCode;
                    people.MobilePhone += textBox1.Text;
                        people.Name += textBox2.Text;
                    context.Peoples.Add(people);
                    context.SaveChanges();
                }
            }
        }
        }
    }
}
