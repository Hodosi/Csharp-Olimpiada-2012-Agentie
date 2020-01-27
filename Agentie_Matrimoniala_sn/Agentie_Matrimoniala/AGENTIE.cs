using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Agentie_Matrimoniala
{
    class AGENTIE
    {
        CONNECT conn = new CONNECT();

        public bool insertClient(string nm, string pn, int varsta, string sex, string ocupatie)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Agentie(Nume,Prenume,Varsta,Sex,Ocupatie) VALUES(@nm,@pn,@v,@sex,@oc)";
            command.Connection = conn.GetConnection();

            //@nm,@pn,@v,@sex,@oc
            command.Parameters.Add("nm", SqlDbType.VarChar).Value = nm;
            command.Parameters.Add("pn", SqlDbType.VarChar).Value = pn;
            command.Parameters.Add("v", SqlDbType.Int).Value = varsta;
            command.Parameters.Add("sex", SqlDbType.VarChar).Value = sex;
            command.Parameters.Add("oc", SqlDbType.VarChar).Value = ocupatie;

            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.clsoeConnection();
                return true;
            }
            else
            {
                conn.clsoeConnection();
                return false;
            }
        }

        public bool updateClient(int id, string nm, string pn, int varsta, string sex, string ocupatie)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE Agentie SET Nume=@nm,Prenume=@pn,Varsta=@v,Sex=@sex,Ocupatie=@oc WHERE Id=@id";
            command.Connection = conn.GetConnection();

            //@id,@nm,@pn,@v,@sex,@oc
            command.Parameters.Add("id", SqlDbType.Int).Value = id;
            command.Parameters.Add("nm", SqlDbType.VarChar).Value = nm;
            command.Parameters.Add("pn", SqlDbType.VarChar).Value = pn;
            command.Parameters.Add("v", SqlDbType.Int).Value = varsta;
            command.Parameters.Add("sex", SqlDbType.VarChar).Value = sex;
            command.Parameters.Add("oc", SqlDbType.VarChar).Value = ocupatie;

            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.clsoeConnection();
                return true;
            }
            else
            {
                conn.clsoeConnection();
                return false;
            }
        }
        public bool deleteClient(int id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM Agentie WHERE Id=@id";
            command.Connection = conn.GetConnection();

            //@id
            command.Parameters.Add("id", SqlDbType.VarChar).Value = id;

            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.clsoeConnection();
                return true;
            }
            else
            {
                conn.clsoeConnection();
                return false;
            }
        }

        public DataTable getClient()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Agentie";
            command.Connection = conn.GetConnection();

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public int sumClient()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT SUM(Varsta) FROM Agentie";
            command.Connection = conn.GetConnection();

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return Convert.ToInt32(table.Rows[0][0].ToString());
        }

        public int nrClient()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Agentie";
            command.Connection = conn.GetConnection();

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table.Rows.Count;
        }
    }
}
