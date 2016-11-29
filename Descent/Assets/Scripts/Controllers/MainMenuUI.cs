using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Data;
using Mono.Data.SqliteClient;

public class MainMenuUI : MonoBehaviour
{

    public Dropdown myDropdown;
    public Text speedText;
    public Text healthText;
    public Text staminaText;
    public Text abilityText;
    public Text mightText;
    public Text knowledgeText;
    public Text willpowerText;
    public Text awarenessText;
    private string connectionString;

    void Start()
    {
        myDropdown.onValueChanged.AddListener(delegate {
            myDropdownValueChangedHandler(myDropdown);
        });

        connectionString = "URI=file:" + Application.dataPath + "DDatabase.db";

        speedText.text = "";
        healthText.text = "";
        staminaText.text = "";
        abilityText.text = "";
        mightText.text = "";
        knowledgeText.text = "";
        willpowerText.text = "";
        awarenessText.text = "";

    }
    void Destroy()
    {
        myDropdown.onValueChanged.RemoveAllListeners();
    }

    private void myDropdownValueChangedHandler(Dropdown target)
    {

        if (myDropdown.value == 1)
        {
            using (IDbConnection dbConnection = new SqliteConnection(connectionString))
            {
                dbConnection.Open();

                using (IDbCommand dbCmd = dbConnection.CreateCommand())
                {
                    string sqlQuery = "SELECT*FROM HeroTable WHERE id= 1";

                    dbCmd.CommandText = sqlQuery;

                    using (IDataReader reader = dbCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            speedText.text = "Speed: " + reader.GetInt32(2).ToString();
                            healthText.text = "Health: " + reader.GetInt32(3).ToString();
                            staminaText.text = "Stamina" + reader.GetInt32(4).ToString();
                            abilityText.text = "Ability: " + reader.GetInt32(5).ToString();
                            mightText.text = "Might: " + reader.GetInt32(6).ToString();
                            knowledgeText.text = "Knowledge: " + reader.GetInt32(7).ToString();
                            willpowerText.text = "Willpower: " + reader.GetInt32(8).ToString();
                            awarenessText.text = "Awareness: " + reader.GetInt32(9).ToString();

                        }
                    }
                }
            }
        }
        if (myDropdown.value == 2)
        {

            using (IDbConnection dbConnection = new SqliteConnection(connectionString))
            {
                dbConnection.Open();

                using (IDbCommand dbCmd = dbConnection.CreateCommand())
                {
                    string sqlQuery = "SELECT*FROM HeroTable WHERE id= 2";

                    dbCmd.CommandText = sqlQuery;

                    using (IDataReader reader = dbCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            speedText.text = "Speed: " + reader.GetInt32(2).ToString();
                            healthText.text = "Health: " + reader.GetInt32(3).ToString();
                            staminaText.text = "Stamina: " + reader.GetInt32(4).ToString();
                            abilityText.text = "Ability: " + reader.GetInt32(5).ToString();
                            mightText.text = "Might: " + reader.GetInt32(6).ToString();
                            knowledgeText.text = "Knowledge: " + reader.GetInt32(7).ToString();
                            willpowerText.text = "Willpower: " + reader.GetInt32(8).ToString();
                            awarenessText.text = "Awareness: " + reader.GetInt32(9).ToString();

                        }
                    }
                }
            }

        }
        if (myDropdown.value == 3)
        {
            using (IDbConnection dbConnection = new SqliteConnection(connectionString))
            {
                dbConnection.Open();

                using (IDbCommand dbCmd = dbConnection.CreateCommand())
                {
                    string sqlQuery = "SELECT*FROM HeroTable WHERE id= 3";

                    dbCmd.CommandText = sqlQuery;

                    using (IDataReader reader = dbCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            speedText.text = "Speed: " + reader.GetInt32(2).ToString();
                            healthText.text = "Health: " + reader.GetInt32(3).ToString();
                            staminaText.text = "Stamina: " + reader.GetInt32(4).ToString();
                            abilityText.text = "Ability: " + reader.GetInt32(5).ToString();
                            mightText.text = "Might: " + reader.GetInt32(6).ToString();
                            knowledgeText.text = "Knowledge: " + reader.GetInt32(7).ToString();
                            willpowerText.text = "Willpower: " + reader.GetInt32(8).ToString();
                            awarenessText.text = "Awareness: " + reader.GetInt32(9).ToString();

                        }
                    }
                }
            }
        }
        if (myDropdown.value == 4)
        {
            using (IDbConnection dbConnection = new SqliteConnection(connectionString))
            {
                dbConnection.Open();

                using (IDbCommand dbCmd = dbConnection.CreateCommand())
                {
                    string sqlQuery = "SELECT*FROM HeroTable WHERE id= 4";

                    dbCmd.CommandText = sqlQuery;

                    using (IDataReader reader = dbCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            speedText.text = "Speed: " + reader.GetInt32(2).ToString();
                            healthText.text = "Health: " + reader.GetInt32(3).ToString();
                            staminaText.text = "Stamina: " + reader.GetInt32(4).ToString();
                            abilityText.text = "Ability: " + reader.GetInt32(5).ToString();
                            mightText.text = "Might: " + reader.GetInt32(6).ToString();
                            knowledgeText.text = "Knowledge: " + reader.GetInt32(7).ToString();
                            willpowerText.text = "Willpower: " + reader.GetInt32(8).ToString();
                            awarenessText.text = "Awareness: " + reader.GetInt32(9).ToString();

                        }
                    }
                }
            }
        }
        if (myDropdown.value == 5)
        {
            using (IDbConnection dbConnection = new SqliteConnection(connectionString))
            {
                dbConnection.Open();

                using (IDbCommand dbCmd = dbConnection.CreateCommand())
                {
                    string sqlQuery = "SELECT*FROM HeroTable WHERE id= 5";

                    dbCmd.CommandText = sqlQuery;

                    using (IDataReader reader = dbCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            speedText.text = "Speed: " + reader.GetInt32(2).ToString();
                            healthText.text = "Health: " + reader.GetInt32(3).ToString();
                            staminaText.text = "Stamina: " + reader.GetInt32(4).ToString();
                            abilityText.text = "Ability: " + reader.GetInt32(5).ToString();
                            mightText.text = "Might: " + reader.GetInt32(6).ToString();
                            knowledgeText.text = "Knowledge: " + reader.GetInt32(7).ToString();
                            willpowerText.text = "Willpower: " + reader.GetInt32(8).ToString();
                            awarenessText.text = "Awareness: " + reader.GetInt32(9).ToString();

                        }
                    }
                }
            }
        }
        if (myDropdown.value == 6)
        {
            using (IDbConnection dbConnection = new SqliteConnection(connectionString))
            {
                dbConnection.Open();

                using (IDbCommand dbCmd = dbConnection.CreateCommand())
                {
                    string sqlQuery = "SELECT*FROM HeroTable WHERE id= 6";

                    dbCmd.CommandText = sqlQuery;

                    using (IDataReader reader = dbCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            speedText.text = "Speed: " + reader.GetInt32(2).ToString();
                            healthText.text = "Health: " + reader.GetInt32(3).ToString();
                            staminaText.text = "Stamina: " + reader.GetInt32(4).ToString();
                            abilityText.text = "Ability: " + reader.GetInt32(5).ToString();
                            mightText.text = "Might: " + reader.GetInt32(6).ToString();
                            knowledgeText.text = "Knowledge: " + reader.GetInt32(7).ToString();
                            willpowerText.text = "Willpower: " + reader.GetInt32(8).ToString();
                            awarenessText.text = "Awareness: " + reader.GetInt32(9).ToString();

                        }
                    }
                }
            }
        }
        if (myDropdown.value == 7)
        {
            using (IDbConnection dbConnection = new SqliteConnection(connectionString))
            {
                dbConnection.Open();

                using (IDbCommand dbCmd = dbConnection.CreateCommand())
                {
                    string sqlQuery = "SELECT*FROM HeroTable WHERE id= 7";

                    dbCmd.CommandText = sqlQuery;

                    using (IDataReader reader = dbCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            speedText.text = "Speed: " + reader.GetInt32(2).ToString();
                            healthText.text = "Health: " + reader.GetInt32(3).ToString();
                            staminaText.text = "Stamina: " + reader.GetInt32(4).ToString();
                            abilityText.text = "Ability: " + reader.GetInt32(5).ToString();
                            mightText.text = "Might: " + reader.GetInt32(6).ToString();
                            knowledgeText.text = "Knowledge: " + reader.GetInt32(7).ToString();
                            willpowerText.text = "Willpower: " + reader.GetInt32(8).ToString();
                            awarenessText.text = "Awareness: " + reader.GetInt32(9).ToString();

                        }
                    }
                }
            }
        }
        if (myDropdown.value == 8)
        {
            using (IDbConnection dbConnection = new SqliteConnection(connectionString))
            {
                dbConnection.Open();

                using (IDbCommand dbCmd = dbConnection.CreateCommand())
                {
                    string sqlQuery = "SELECT*FROM HeroTable WHERE id= 8";

                    dbCmd.CommandText = sqlQuery;

                    using (IDataReader reader = dbCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            speedText.text = "Speed: " + reader.GetInt32(2).ToString();
                            healthText.text = "Health: " + reader.GetInt32(3).ToString();
                            staminaText.text = "Stamina: " + reader.GetInt32(4).ToString();
                            abilityText.text = "Ability: " + reader.GetInt32(5).ToString();
                            mightText.text = "Might: " + reader.GetInt32(6).ToString();
                            knowledgeText.text = "Knowledge: " + reader.GetInt32(7).ToString();
                            willpowerText.text = "Willpower: " + reader.GetInt32(8).ToString();
                            awarenessText.text = "Awareness: " + reader.GetInt32(9).ToString();

                        }
                    }
                }
            }
        }
    }

    public void SetDropdownIndex(int index)
    {
        myDropdown.value = index;
    }
}

