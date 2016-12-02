using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Mono.Data.SqliteClient;
using System.Data;

public class GetHeroInfo : MonoBehaviour {

    int heroID1;
    int heroID2;
    int heroID3;
    int heroID4;
    public Text H1name;
    public Text H1health;
    public Text H1fatigue;
    public Text H2name;
    public Text H2health;
    public Text H2fatigue;
    public Text H3name;
    public Text H3health;
    public Text H3fatigue;
    public Text H4name;
    public Text H4health;
    public Text H4fatigue;
    private string connectionString;

    // Use this for initialization
    void Awake()
    {
        connectionString = "URI=file:" + Application.dataPath + "DDatabase.db";

        //addInfo();

        heroID1 = PlayerPrefs.GetInt("HeroID1");
        heroID2 = PlayerPrefs.GetInt("HeroID2");
        heroID3 = PlayerPrefs.GetInt("HeroID4");
        heroID4 = PlayerPrefs.GetInt("HeroID4");

        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                string sqlQuery = "SELECT*FROM HeroTable WHERE id=" + heroID1;

                dbCmd.CommandText = sqlQuery;

                using (IDataReader reader = dbCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        H1name.text = reader.GetString(1);
                        H1health.text = "Health: " + reader.GetInt32(2).ToString();
                        H1fatigue.text = "Stamina: " + reader.GetInt32(3).ToString();
                    }
                }
            }
            dbConnection.Close();
        }
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                string sqlQuery = "SELECT*FROM HeroTable WHERE id=" + heroID2;

                dbCmd.CommandText = sqlQuery;

                using (IDataReader reader = dbCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        H2name.text = reader.GetString(1);
                        H2health.text = "Health: " + reader.GetInt32(2).ToString();
                        H2fatigue.text = "Stamina: " + reader.GetInt32(3).ToString();
                    }
                }
            }
            dbConnection.Close();
        }
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                string sqlQuery = "SELECT*FROM HeroTable WHERE id=" + heroID3;

                dbCmd.CommandText = sqlQuery;

                using (IDataReader reader = dbCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        H3name.text = reader.GetString(1);
                        H3health.text = "Health: " + reader.GetInt32(2).ToString();
                        H3fatigue.text = "Stamina: " + reader.GetInt32(3).ToString();
                    }
                }
            }
            dbConnection.Close();
        }
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                string sqlQuery = "SELECT*FROM HeroTable WHERE id=" + heroID4;

                dbCmd.CommandText = sqlQuery;

                using (IDataReader reader = dbCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        H4name.text = reader.GetString(1);
                        H4health.text = "Health: " + reader.GetInt32(2).ToString();
                        H4fatigue.text = "Stamina: " + reader.GetInt32(3).ToString();
                    }
                }
            }
            dbConnection.Close();
        }


    }

    void addInfo ()
    {

        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {

                //First create the table.
                string sql = "CREATE TABLE IF NOT EXISTS gTable (id INTEGER, name TEXT, health INTEGER, fatigue INTEGER)";
                dbCmd.CommandText = sql;


                //Next populate it with a singular field.
                int id = 0;
                string name = "Ashrian";
                int health = 10;
                int fatigue = 5;
                sql = "INSERT INTO gTable (id, name, health, fatigue) VALUES (" + id + ", '" + name + "', "+health+", "+fatigue+")";


            }
        }
    }
}
