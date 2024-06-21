using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeSoft
{
    public partial class EvidenteSiRapoarte : Form
    {
        private DateTime searchBegin;
        private DateTime searchEnd;
        private DateTime searchBeginDB;
        private DateTime searchEndDB;
        private string afectiune;
        int count = 0;
        public EvidenteSiRapoarte()
        {
            InitializeComponent();
        }

        public void setParameter(string afect, string dateB, string dateE, string sort)
        {
            afectiune = afect;

            listBox.Items.Clear();
            listBox1.Items.Clear();
            searchBegin = Convert.ToDateTime(dateB);
            searchEnd = Convert.ToDateTime(dateE);

            int number = 0;

            if (sort == "Crescator")
            {
                count = 0;
                MySql.Data.MySqlClient.MySqlConnection conn;
                string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                try
                {
                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from diagnostice where diagnostic_clinic='" + afectiune + "' order by data_identificare asc", conn);
                    MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        searchBeginDB = Convert.ToDateTime(sdr.GetString(6));
                        searchEndDB = Convert.ToDateTime(sdr.GetString(6));
                        int result = DateTime.Compare(searchBegin, searchBeginDB);
                        if (result <= 0)
                        {
                            int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                            if (resultEnd >= 0)
                            {
                                ++count;
                                ++number;
                                listBox.Items.Clear();
                                listBox.Items.Add("In perioada: " + chooseDataBegin.Text + " - " + chooseDataFinal.Text + " au existat " + count + " diagnostice identificate.");
                                listBox1.Items.Add(number.ToString() + " - " + sdr.GetString(3) + " - " + sdr.GetString(4) + " - " + sdr.GetString(5) + " - " + sdr.GetString(6));
                            }
                        }
                    }
                    conn.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (sort == "Descrescator")
            {
                count = 0;
                MySql.Data.MySqlClient.MySqlConnection conn;
                string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                try
                {
                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from diagnostice where diagnostic_clinic='" + afectiune + "' order by data_identificare desc", conn);
                    MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        searchBeginDB = Convert.ToDateTime(sdr.GetString(6));
                        searchEndDB = Convert.ToDateTime(sdr.GetString(6));
                        int result = DateTime.Compare(searchBegin, searchBeginDB);
                        if (result <= 0)
                        {
                            int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                            if (resultEnd >= 0)
                            {
                                ++count;
                                ++number;
                                listBox.Items.Clear();
                                listBox.Items.Add("In perioada: " + chooseDataBegin.Text + " - " + chooseDataFinal.Text + " au existat " + count + " diagnostice identificate.");
                                listBox1.Items.Add(number.ToString() + " - " + sdr.GetString(3) + " - " + sdr.GetString(4) + " - " + sdr.GetString(5) + " - " + sdr.GetString(6));
                            }
                        }
                    }
                    conn.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                count = 0;
                MySql.Data.MySqlClient.MySqlConnection conn;
                string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                try
                {
                    conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                    conn.Open();
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from diagnostice where diagnostic_clinic='" + afectiune + "'", conn);
                    MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        searchBeginDB = Convert.ToDateTime(sdr.GetString(6));
                        searchEndDB = Convert.ToDateTime(sdr.GetString(6));
                        int result = DateTime.Compare(searchBegin, searchBeginDB);
                        if (result <= 0)
                        {
                            int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                            if (resultEnd >= 0)
                            {
                                ++count;
                                ++number;
                                listBox.Items.Clear();
                                listBox.Items.Add("In perioada: " + chooseDataBegin.Text + " - " + chooseDataFinal.Text + " au existat " + count + " persoane cu diagnosticul " + afectiune + ".");
                                listBox1.Items.Add(number.ToString() + " - " + sdr.GetString(3) + " - " + sdr.GetString(4) + " - " + sdr.GetString(5) + " - " + sdr.GetString(6)); 
                            }
                        }
                    }
                    conn.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void search()
        {
            int number = 0;
            if (alegeComboBox.Text == "Numarul de persoane apte intr-o anumita perioada")
            {
                listBox.Items.Clear();
                listBox1.Items.Clear();
                searchBegin = Convert.ToDateTime(chooseDataBegin.Text);
                searchEnd = Convert.ToDateTime(chooseDataFinal.Text);

                if (sortComboBox.Text == "Crescator")
                {
                    count = 0;
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from consultatie order by data_consultatie asc", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(3));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(3));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                if (resultEnd >= 0 && sdr.GetString(12) == "Apt")
                                {
                                    ++count;
                                    ++number;
                                    listBox.Items.Clear();
                                    listBox.Items.Add("In perioada: " + chooseDataBegin.Text + " - " + chooseDataFinal.Text + " au existat " + count + " persoane apte de munca.");
                                }
                            }
                        }
                        conn.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (sortComboBox.Text == "Descrescator")
                {
                    count = 0;
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from consultatie order by data_consultatie desc", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(5));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(5));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                if (resultEnd >= 0 && sdr.GetString(12) == "Apt")
                                {
                                    ++count;
                                    ++number;
                                    listBox.Items.Clear();
                                    listBox.Items.Add("In perioada: " + chooseDataBegin.Text + " - " + chooseDataFinal.Text + " au existat " + count + " persoane apte de munca.");
                                }
                            }
                        }
                        conn.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    count = 0;
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from consultatie", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(5));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(5));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                if (resultEnd >= 0 && sdr.GetString(12) == "Apt")
                                {
                                    ++count;
                                    ++number;
                                    listBox.Items.Clear();
                                    listBox.Items.Add("In perioada: " + chooseDataBegin.Text + " - " + chooseDataFinal.Text + " au existat " + count + " persoane apte de munca.");
                                }
                            }
                        }
                        conn.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (alegeComboBox.Text == "Numarul de persoane inapte intr-o anumita perioada")
            {
                listBox.Items.Clear();
                listBox1.Items.Clear();
                searchBegin = Convert.ToDateTime(chooseDataBegin.Text);
                searchEnd = Convert.ToDateTime(chooseDataFinal.Text);

                if (sortComboBox.Text == "Crescator")
                {
                    count = 0;
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from consultatie order by data_consultatie asc", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(3));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(3));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                if (resultEnd >= 0 && sdr.GetString(12) == "Inapt")
                                {
                                    ++count;
                                    ++number;
                                    listBox.Items.Clear();
                                    listBox.Items.Add("In perioada: " + chooseDataBegin.Text + " - " + chooseDataFinal.Text + " au existat " + count + " persoane inapte de munca.");
                                }
                            }
                        }
                        conn.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (sortComboBox.Text == "Descrescator")
                {
                    count = 0;
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from consultatie order by data_consultatie desc", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(5));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(5));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                if (resultEnd >= 0 && sdr.GetString(12) == "Inapt")
                                {
                                    ++count;
                                    ++number;
                                    listBox.Items.Clear();
                                    listBox.Items.Add("In perioada: " + chooseDataBegin.Text + " - " + chooseDataFinal.Text + " au existat " + count + " persoane inapte de munca.");
                                }
                            }
                        }
                        conn.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    count = 0;
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from consultatie", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(5));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(5));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                if (resultEnd >= 0 && sdr.GetString(12) == "Inapt")
                                {
                                    ++count;
                                    ++number;
                                    listBox.Items.Clear();
                                    listBox.Items.Add("In perioada: " + chooseDataBegin.Text + " - " + chooseDataFinal.Text + " au existat " + count + " persoane inapte de munca.");
                                }
                            }
                        }
                        conn.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (alegeComboBox.Text == "Numarul de bilete de trimitere emise intr-o anumita perioada")
            {
                listBox.Items.Clear();
                listBox1.Items.Clear();
                searchBegin = Convert.ToDateTime(chooseDataBegin.Text);
                searchEnd = Convert.ToDateTime(chooseDataFinal.Text);

                if (sortComboBox.Text == "Crescator")
                {
                    count = 0;
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from trimitere order by data_trimiterii asc", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(14));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(14));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                if (resultEnd >= 0)
                                {
                                    ++count;
                                    ++number;
                                    listBox.Items.Clear();
                                    listBox.Items.Add("In perioada: " + chooseDataBegin.Text + " - " + chooseDataFinal.Text + " au existat " + count + " bilete de trimitere emise.");
                                    listBox1.Items.Add(number.ToString() + " - " + sdr.GetString(9) + " - " + sdr.GetString(11) + " - " + sdr.GetString(14));
                                }
                            }
                        }
                        conn.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (sortComboBox.Text == "Descrescator")
                {
                    count = 0;
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * trimitere order by data_trimiterii desc", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(14));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(14));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                if (resultEnd >= 0)
                                {
                                    ++count;
                                    ++number;
                                    listBox.Items.Clear();
                                    listBox.Items.Add("In perioada: " + chooseDataBegin.Text + " - " + chooseDataFinal.Text + " au existat " + count + " bilete de trimitere emise.");
                                    listBox1.Items.Add(number.ToString() + " - " + sdr.GetString(9) + " - " + sdr.GetString(11) + " - " + sdr.GetString(14));
                                }
                            }
                        }
                        conn.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    count = 0;
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from trimitere", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(14));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(14));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                if (resultEnd >= 0)
                                {
                                    ++count;
                                    ++number;
                                    listBox.Items.Clear();
                                    listBox.Items.Add("In perioada: " + chooseDataBegin.Text + " - " + chooseDataFinal.Text + " au existat " + count + " bilete de trimitere emise.");
                                    listBox1.Items.Add(number.ToString() + " - " + sdr.GetString(9) + " - " + sdr.GetString(11) + " - " + sdr.GetString(14));
                                }
                            }
                        }
                        conn.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (alegeComboBox.Text == "Numarul de controale apicole efectuate intr-o anumita perioada")
            {
                listBox.Items.Clear();
                listBox1.Items.Clear();
                searchBegin = Convert.ToDateTime(chooseDataBegin.Text);
                searchEnd = Convert.ToDateTime(chooseDataFinal.Text);

                if (sortComboBox.Text == "Crescator")
                {
                    count = 0;
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from consultatie order by data_consultatie asc", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(3));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(3));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                if (resultEnd >= 0)
                                {
                                    ++count;
                                    ++number;
                                    listBox.Items.Clear();
                                    listBox.Items.Add("In perioada: " + chooseDataBegin.Text + " - " + chooseDataFinal.Text + " au existat " + count + " controale apicole efectuate.");
                                    listBox1.Items.Add(number.ToString() + " - " + sdr.GetString(3) + " - " + sdr.GetString(4) + " - " + sdr.GetString(5) + " - " + sdr.GetString(6) + " - " + sdr.GetString(9));
                                }
                            }
                        }
                        conn.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (sortComboBox.Text == "Descrescator")
                {
                    count = 0;
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * consultatie order by data_consultatie desc", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(3));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(3));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                if (resultEnd >= 0)
                                {
                                    ++count;
                                    ++number;
                                    listBox.Items.Clear();
                                    listBox.Items.Add("In perioada: " + chooseDataBegin.Text + " - " + chooseDataFinal.Text + " au existat " + count + " controale apicole efectuate.");
                                    listBox1.Items.Add(number.ToString() + " - " + sdr.GetString(3) + " - " + sdr.GetString(4) + " - " + sdr.GetString(5) + " - " + sdr.GetString(6) + " - " + sdr.GetString(9));
                                }
                            }
                        }
                        conn.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    count = 0;
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from consultatie", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(3));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(3));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                if (resultEnd >= 0)
                                {
                                    ++count;
                                    ++number;
                                    listBox.Items.Clear();
                                    listBox.Items.Add("In perioada: " + chooseDataBegin.Text + " - " + chooseDataFinal.Text + " au existat " + count + " controale apicole efectuate.");
                                    listBox1.Items.Add(number.ToString() + " - " + sdr.GetString(3) + " - " + sdr.GetString(4) + " - " + sdr.GetString(5) + " - " + sdr.GetString(6) + " - " + sdr.GetString(9));
                                }
                            }
                        }
                        conn.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (alegeComboBox.Text == "Numarul de diagnostice emise intr-o anumita perioada")
            {
                listBox.Items.Clear();
                listBox1.Items.Clear();
                searchBegin = Convert.ToDateTime(chooseDataBegin.Text);
                searchEnd = Convert.ToDateTime(chooseDataFinal.Text);

                if (sortComboBox.Text == "Crescator")
                {
                    count = 0;
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from diagnostice order by data_identificare asc", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(6));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(6));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                if (resultEnd >= 0)
                                {
                                    ++count;
                                    ++number;
                                    listBox.Items.Clear();
                                    listBox.Items.Add("In perioada: " + chooseDataBegin.Text + " - " + chooseDataFinal.Text + " au existat " + count + " diagnostice identificate.");
                                    listBox1.Items.Add(number.ToString() + " - " + sdr.GetString(6) + " - " + sdr.GetString(4) + " - " + sdr.GetString(5) + " - " + sdr.GetString(7));
                                }
                            }
                        }
                        conn.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (sortComboBox.Text == "Descrescator")
                {
                    count = 0;
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * diagnostice order by data_identificare desc", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(6));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(6));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                if (resultEnd >= 0)
                                {
                                    ++count;
                                    ++number;
                                    listBox.Items.Clear();
                                    listBox.Items.Add("In perioada: " + chooseDataBegin.Text + " - " + chooseDataFinal.Text + " au existat " + count + " diagnostice identificate.");
                                    listBox1.Items.Add(number.ToString() + " - " + sdr.GetString(6) + " - " + sdr.GetString(4) + " - " + sdr.GetString(5) + " - " + sdr.GetString(7));
                                }
                            }
                        }
                        conn.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    count = 0;
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from diagnostice", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(6));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(6));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                if (resultEnd >= 0)
                                {
                                    ++count;
                                    ++number;
                                    listBox.Items.Clear();
                                    listBox.Items.Add("In perioada: " + chooseDataBegin.Text + " - " + chooseDataFinal.Text + " au existat " + count + " diagnostice identificate.");
                                    listBox1.Items.Add(number.ToString() + " - " + sdr.GetString(6) + " - " + sdr.GetString(4) + " - " + sdr.GetString(5) + " - " + sdr.GetString(7));
                                }
                            }
                        }
                        conn.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (alegeComboBox.Text == "Numarul de programari efectuate intr-o anumita perioada")
            {
                listBox.Items.Clear();
                listBox1.Items.Clear();
                searchBegin = Convert.ToDateTime(chooseDataBegin.Text);
                searchEnd = Convert.ToDateTime(chooseDataFinal.Text);

                if (sortComboBox.Text == "Crescator")
                {
                    count = 0;
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from programari where status='" + "accept" + "' order by data asc", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(3));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(3));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                if (resultEnd >= 0)
                                {
                                    ++count;
                                    ++number;
                                    listBox.Items.Clear();
                                    listBox.Items.Add("In perioada: " + chooseDataBegin.Text + " - " + chooseDataFinal.Text + " au existat " + count + " persoane cu diagnosticul " + afectiune +".");
                                    listBox1.Items.Add(number.ToString() + " - " + sdr.GetString(1) + " " + sdr.GetString(2) + " - " + sdr.GetString(3) + " - " + sdr.GetString(4) + " - " + sdr.GetString(5) + " - " + sdr.GetString(6));
                                }
                            }
                        }
                        conn.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (sortComboBox.Text == "Descrescator")
                {
                    count = 0;
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from programari where status='" + "accept" + "' order by data desc", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(3));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(3));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                if (resultEnd >= 0)
                                {
                                    ++count;
                                    ++number;
                                    listBox.Items.Clear();
                                    listBox.Items.Add("In perioada: " + chooseDataBegin.Text + " - " + chooseDataFinal.Text + " au existat " + count + " persoane cu diagnosticul " + afectiune + ".");
                                    listBox1.Items.Add(number.ToString() + " - " + sdr.GetString(1) + " " + sdr.GetString(2) + " - " + sdr.GetString(3) + " - " + sdr.GetString(4) + " - " + sdr.GetString(5) + " - " + sdr.GetString(6));
                                }
                            }
                        }
                        conn.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    count = 0;
                    MySql.Data.MySqlClient.MySqlConnection conn;
                    string myConnectionString = "Server=127.0.0.1;Port=3306;Database=licenta;Uid=sebi;Pwd=sebi;";
                    try
                    {
                        conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                        conn.Open();
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("select * from programari where status='" + "accept" + "'", conn);
                        MySql.Data.MySqlClient.MySqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            searchBeginDB = Convert.ToDateTime(sdr.GetString(3));
                            searchEndDB = Convert.ToDateTime(sdr.GetString(3));
                            int result = DateTime.Compare(searchBegin, searchBeginDB);
                            if (result <= 0)
                            {
                                int resultEnd = DateTime.Compare(searchEnd, searchEndDB);
                                if (resultEnd >= 0)
                                {
                                    ++count;
                                    ++number;
                                    listBox.Items.Clear();
                                    listBox.Items.Add("In perioada: " + chooseDataBegin.Text + " - " + chooseDataFinal.Text + " au existat " + count + " programari efectuate.");
                                    listBox1.Items.Add(number.ToString() + " - " + sdr.GetString(1) + " " + sdr.GetString(2) + " - " + sdr.GetString(3) + " - " + sdr.GetString(4) + " - " + sdr.GetString(5) + " - " + sdr.GetString(6));
                                }
                            }
                        }
                        conn.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            search();
        }

        private void ok1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Choose ob = new Choose();
            ob.Show();
            this.Hide();
        }

        private void cancel1_Click(object sender, EventArgs e)
        {
            Choose ob = new Choose();
            ob.Show();
            this.Hide();
        }
    }
}
