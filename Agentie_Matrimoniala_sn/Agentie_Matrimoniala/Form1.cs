using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Agentie_Matrimoniala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AGENTIE agent = new AGENTIE();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = agent.getClient();
        }

        private void button_adauga_Click(object sender, EventArgs e)
        {
            try
            {
                string nm = this.textBox_nume.Text;
                string pn = this.textBox_prenume.Text;
                int varsta = Convert.ToInt32(this.textBox_varsta.Text);
                string sex = this.textBox_sex.Text;
                string ocupatie = this.textBox_ocupatie.Text;

                if (nm.Trim().Equals("") || pn.Trim().Equals("") || sex.Trim().Equals("") || ocupatie.Trim().Equals("") || this.textBox_varsta.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campuri Incomplete");
                }
                else
                {
                    if (agent.insertClient(nm, pn, varsta, sex, ocupatie))
                    {
                        this.dataGridView1.DataSource = agent.getClient();
                        MessageBox.Show("Client Adaugat");
                    }
                    else
                    {
                        MessageBox.Show("Client Error");
                    }
                }
            }
            catch
            {
              MessageBox.Show("Data Invalide");
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                string nm = this.textBox_nume.Text;
                string pn = this.textBox_prenume.Text;
                int varsta = Convert.ToInt32(this.textBox_varsta.Text);
                string sex = this.textBox_sex.Text;
                string ocupatie = this.textBox_ocupatie.Text;

                if (nm.Trim().Equals("") || pn.Trim().Equals("") || sex.Trim().Equals("") || ocupatie.Trim().Equals("") || this.textBox_varsta.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Campuri Incomplete");
                }
                else
                {
                    if (agent.updateClient(id, nm, pn, varsta, sex, ocupatie))
                    {
                        this.dataGridView1.DataSource = agent.getClient();
                        MessageBox.Show("Client Editat");
                    }
                    else
                    {
                        MessageBox.Show("Client Error");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Data Invalide");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                if (agent.deleteClient(id))
                {
                    this.dataGridView1.DataSource = agent.getClient();
                    MessageBox.Show("Client Sters");
                }
                else
                {
                    MessageBox.Show("Client Delete Error");
                }
            }
            catch
            {
                MessageBox.Show("Selectati un Client");
            }
        }

        private void button_Varsta_Medie_Click(object sender, EventArgs e)
        {
            int sum = agent.sumClient();
            int rows = agent.nrClient();
            int medie = sum / rows;
            MessageBox.Show(medie.ToString());
        }
    }
}
