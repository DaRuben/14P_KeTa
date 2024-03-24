using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace hajo_konzol
{
    internal class Program
    {
        
        struct allapot
        {
            public int az { get; set; }
            public int uzemel { get; set; }
            public string hol { get; set; }
        }
        struct hajo
        {
            public int az { get; set; }
            public string nev { get; set; }
            public double hossz { get; set; }
            public double szelesseg { get; set; }
            public double merules { get; set; }
            public double mszam { get; set; }
            public int mteljesitmeny { get; set; }
            public int utas { get; set; }
            public int epult { get; set; }
            public string orszag { get; set; }
            public int? regvar { get; set; }
            public string regor { get; set; }
            public int? allapotaz { get; set; }
        }
        struct varos
        {
            public int az { get; set; }
            public string nev{ get; set;}
        }
        static void Main(string[] args)
        {
            string connString = "server=localhost;user=root;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = new MySqlCommand();

            try
            {
                conn.Open();
                string sql = "CREATE DATABASE IF NOT EXISTS `regiszter`; USE regiszter;";
                command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Adatbázis: " + ex.Message);
            }

            List<allapot> allapotList = new List<allapot>();
            try
            {
                string[] sorok = File.ReadAllLines("allapot.txt");
                string[] elsoSor = sorok[0].Split('\t');
                string mezo1 = elsoSor[0];
                string mezo2 = elsoSor[1];
                string mezo3 = elsoSor[2];

                for (int i = 1; i < sorok.Length; i++)
                {
                    var sor = sorok[i].Split('\t');
                    allapotList.Add(new allapot()
                    {
                        az = Convert.ToInt32(sor[0]),
                        uzemel = Convert.ToInt32(sor[1]),
                        hol = sor[2],
                    });
                }

                MySqlCommand commandAllapotTabla = new MySqlCommand();
                string sqlAllapot = "CREATE TABLE IF NOT EXISTS `allapot`(`" + mezo1+ "` INT NOT NULL AUTO_INCREMENT, `" + mezo2+ "` int(10) NOT NULL, `"+mezo3+ "` varchar(255) NOT NULL, PRIMARY KEY (" + mezo1+ ")) COLLATE='utf8_general_ci' ENGINE=InnoDB";
                commandAllapotTabla = new MySqlCommand(sqlAllapot, conn);
                commandAllapotTabla.ExecuteNonQuery();

               /* string sqlEll = "SELECT COUNT(*) AS osszes FROM allapot";
                MySqlCommand commandEll = new MySqlCommand(sqlEll, conn);
                MySqlDataReader reader = commandEll.ExecuteReader();
                if (reader.Read())
                {

                }*/
                //https://stackoverflow.com/questions/4471482/connecting-to-a-mysql-db-with-c-sharp-need-some-with-datasets

                for (int i = 0; i < allapotList.Count; i++)
                {
                    string sql = "INSERT INTO allapot VALUES('" + allapotList[i].az + "','" + allapotList[i].uzemel + "','" + allapotList[i].hol + "' )";
                    MySqlCommand commandInsert = new MySqlCommand(sql, conn);    
                    commandInsert.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Állapot tábla: "+ex.Message);
            }

            List<varos> varosList = new List<varos>();
            try
            {
                string[] sorok = File.ReadAllLines("varos.txt");
                string[] elsoSor = sorok[0].Split('\t');
                string mezo1 = elsoSor[0];
                string mezo2 = elsoSor[1];

                for (int i = 1; i < sorok.Length; i++)
                {
                    var sor = sorok[i].Split('\t');
                    varosList.Add(new varos()
                    {
                        az = Convert.ToInt32(sor[0]),
                        nev = sor[1],
                    });
                }

                MySqlCommand commandVarosTabla = new MySqlCommand();
                string sqlVaros = "CREATE TABLE IF NOT EXISTS `varos`(`" + mezo1 + "` INT NOT NULL AUTO_INCREMENT, `" + mezo2 + "` varchar(255) NOT NULL, PRIMARY KEY (" + mezo1 + ")) COLLATE='utf8_general_ci' ENGINE=InnoDB";
                commandVarosTabla = new MySqlCommand(sqlVaros, conn);
                commandVarosTabla.ExecuteNonQuery();

                for (int i = 0; i < varosList.Count; i++)
                {
                    string sql = "INSERT INTO varos VALUES('" + varosList[i].az + "','" + varosList[i].nev + "')";
                    MySqlCommand commandInsert = new MySqlCommand(sql, conn);
                    commandInsert.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Város tábla: " + ex.Message);
            }

            List<hajo> hajoList = new List<hajo>();
            try
            {
                string[] sorok = File.ReadAllLines("hajo.txt");
                string[] elsoSor = sorok[0].Split('\t');
                string mezo1 = elsoSor[0];
                string mezo2 = elsoSor[1];
                string mezo3 = elsoSor[2];
                string mezo4 = elsoSor[3];
                string mezo5 = elsoSor[4];
                string mezo6 = elsoSor[5];
                string mezo7 = elsoSor[6];
                string mezo8 = elsoSor[7];
                string mezo9 = elsoSor[8];
                string mezo10 = elsoSor[9];
                string mezo11 = elsoSor[10];
                string mezo12 = elsoSor[11];
                string mezo13 = elsoSor[12];

                MySqlCommand commandHajoTabla = new MySqlCommand();
                string sqlHajo = "CREATE TABLE IF NOT EXISTS `hajo`(`" + mezo1 + "` INT NOT NULL AUTO_INCREMENT," +
                            "`" + mezo2 + "` varchar(255) NOT NULL, " +
                            "`" + mezo3 + "` float(10) NOT NULL, " +
                            "`" + mezo4 + "` float(10) NOT NULL, " +
                            "`" + mezo5 + "` float(10) NOT NULL, " +
                            "`" + mezo6 + "` float(10) NOT NULL, " +
                            "`" + mezo7 + "` int(10) NOT NULL, " +
                            "`" + mezo8 + "` int(10) NOT NULL, " +
                            "`" + mezo9 + "` int(10) NOT NULL, " +
                            "`" + mezo10 + "` varchar(255) NOT NULL, " +
                            "`" + mezo11 + "` int(10), " +
                            "`" + mezo12 + "` varchar(255), " +
                            "`" + mezo13 + "` int(10), " +
                            "PRIMARY KEY (" + mezo1 + ")) COLLATE='utf8_general_ci' ENGINE=InnoDB";
                commandHajoTabla = new MySqlCommand(sqlHajo, conn);
                commandHajoTabla.ExecuteNonQuery();
                

                for (int i = 1; i < sorok.Length; i++)
                {
                    var sor = sorok[i].Split('\t');
                    if (sor[i].Contains("'"))
                    {
                        sor[i] = sor[i].Replace("'", "\\'");
                    }

                    hajoList.Add(new hajo()
                    {
                        az = Convert.ToInt32(sor[0]),
                        nev = sor[1],
                        hossz = Convert.ToDouble(sor[2]),
                        szelesseg = Convert.ToDouble(sor[3]),
                        merules = Convert.ToDouble(sor[4]),
                        mszam = Convert.ToDouble(sor[5]),
                        mteljesitmeny = Convert.ToInt32(sor[6]),
                        utas = Convert.ToInt32(sor[7]),
                        epult = Convert.ToInt32(sor[8]),
                        orszag = sor[9],
                        regvar = Convert.ToInt32(sor[10]),
                        regor = sor[11],
                        allapotaz = Convert.ToInt32(sor[12]),
                    });
                }

                for (int i = 1; i < hajoList.Count; i++)
                {
                    string sql = "INSERT INTO hajo VALUES('" + hajoList[i].az + "','" + hajoList[i].nev + "','" + hajoList[i].hossz + "','" + hajoList[i].szelesseg + "','" + hajoList[i].merules + "','" + hajoList[i].mszam + "','" + hajoList[i].mteljesitmeny + "','" + hajoList[i].utas + "','" + hajoList[i].epult + "','" + hajoList[i].orszag + "','" + hajoList[i].regvar + "','" + hajoList[i].regor + "','" + hajoList[i].allapotaz + "')";
                    MySqlCommand commandInsert = new MySqlCommand(sql, conn);
                    commandInsert.ExecuteNonQuery();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hajó tábla: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
