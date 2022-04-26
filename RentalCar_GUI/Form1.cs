using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace RentalCar_GUI
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = null;
        MySqlCommand sql = null;
        List<Auto> autoList = new List<Auto>();
        bool firstRun = true;
        bool firstRun2 = true;
        bool firstRun3 = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "rentalcar";
            sb.CharacterSet = "utf8";
            connection = new MySqlConnection(sb.ToString());
            sql = connection.CreateCommand();

            adatokBetoltese();
        }

        private void adatokBetoltese()
        {
            
          //  comboBoxAuto.MultiColumn = false;
            dateTimeTol.Value = DateTime.Today.AddDays(0);
            dateTimeIg.Value = DateTime.Today.AddDays(2);
            comboBoxAuto.Items.Clear();
            try
            {
                
                connection.Open();
                sql.CommandText = "SELECT * FROM auto;";
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                      
                        Auto tmpAuto= new Auto(dr.GetInt32("id"), dr.GetString("rendszam"), dr.GetString("marka"), dr.GetString("model"), dr.GetInt32("ar"));
                        autoList.Add(tmpAuto);
                        comboBoxAuto.Items.Add(tmpAuto);


                      
                    }
                    comboBoxAuto.SelectedIndex = 3;
                    numericNapi.Value = 23000;
                    numericFizet.Value = 46000;
                    // MessageBox.Show(myMessage);
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void calculateFizetendo()
        {
            int napidij =(int) numericNapi.Value;
            string Tmpintervallum =(dateTimeIg.Value - dateTimeTol.Value).ToString().Split('.')[0];
            int intervallum ;
            bool success = int.TryParse(Tmpintervallum, out intervallum);
            if (success && intervallum > -1) {
                int fizetendo = intervallum * napidij;
                numericFizet.Value = fizetendo;
              //  MessageBox.Show(fizetendo.ToString());
            }
            else
            {
                MessageBox.Show("A kezdőértéknek kisebbnek kell lennie, mint a végérték!");
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Tmpintervallum = (dateTimeIg.Value - dateTimeTol.Value).ToString().Split('.')[0];
            int intervallum;
            bool success = int.TryParse(Tmpintervallum, out intervallum);
            if (!success || intervallum < 0)
            {
                MessageBox.Show("A kezdőértéknek kisebbnek kell lennie, mint a végérték!");
            }
            else
            {
                var kiv = comboBoxAuto.SelectedItem;
                Auto kivAuto = (Auto)kiv;
                string logmessage = kivAuto.Id + " " + kivAuto.Rendszam + " " + kivAuto.Marka + " " + kivAuto.Model + " " + numericNapi.Value + " " + intervallum + " " + numericFizet.Value;
                // MessageBox.Show(logmessage);
                connection.Open();
                try
                {

                    sql.CommandText = "INSERT INTO kolcsonzes(id, tol, ig) VALUES(@id,  @tol, @ig);";
                    sql.Parameters.AddWithValue("@id", kivAuto.Id);
                    sql.Parameters.AddWithValue("@tol", dateTimeTol.Value);
                    sql.Parameters.AddWithValue("@ig", dateTimeIg.Value);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Sikeres hozzáadás!");
                    dateTimeTol.Value = DateTime.Today.AddDays(0);
                    dateTimeIg.Value = DateTime.Today.AddDays(2);
                    comboBoxAuto.SelectedIndex = 3;


                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            


            }
        }
            

        private void comboBoxAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstRun)
            {
                firstRun = false;
            }
            else
            {
                var kiv = comboBoxAuto.SelectedItem;
                Auto kivAuto = (Auto)kiv;
                numericNapi.Value = kivAuto.Ar;
                calculateFizetendo();
            }
           
        }

        private void dateTimeTol_ValueChanged(object sender, EventArgs e)
        {
            if (firstRun2)
            {
                firstRun2 = false;
            }
            else
            {
                calculateFizetendo();
            }
        }

        private void dateTimeIg_ValueChanged(object sender, EventArgs e)
        {
            if (firstRun3)
            {
                firstRun3 = false;
            }
            else
            {
                calculateFizetendo();
            }
        }
    }
}
