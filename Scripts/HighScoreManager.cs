using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Data;
using Mono.Data.Sqlite;

public class HighScoreManager : MonoBehaviour
{
    private List<HighScore> highScores = new List<HighScore>();

    public GameObject scorePrefab;

    public Transform scoreParent; //,scoreChild;


    private string connectionString;

    public int topRanks;

   


    // Start is called before the first frame update
    void Start()
    {
        connectionString = "URI=file:" + Application.dataPath + "/HighScoreDB.sqlite";
        //Debug.Log("database found");
        //enterData();
        //InsertScore(EnterName.name, GameManager.Totalscore);
        ShowScores();
    }

    /*private void Awake()
    {
        float h = 20f;

        for (int j = 0; j < highScores.Count; j++)
        {
            Transform x = Instantiate(scoreChild, scoreParent);
            RectTransform y = x.GetComponent<RectTransform>();
            y.anchoredPosition = new Vector2(0, -h * j);
        }

    }
    */
    public void enterData()
    {
        if(EnterName.name!=string.Empty)
        {
            //Debug.Log(EnterName.name);
            //Debug.Log(0);
            connectionString = "URI=file:" + Application.dataPath + "/HighScoreDB.sqlite";
            InsertScore(EnterName.name, GameManager.Totalscore);

        }
    }

    private void InsertScore(string name, int newScore)
    {
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();
            //Debug.Log("lalala");
            using (IDbCommand dbCommand = dbConnection.CreateCommand())
            {
                string sqlQuery = String.Format("INSERT INTO HighScores(Name,Score) VALUES(\"{0}\",\"{1}\")", name,newScore);
                
                dbCommand.CommandText = sqlQuery;
                dbCommand.ExecuteScalar();
                //Debug.Log("insert");
                dbConnection.Close();
            }
        }

    }


    private void GetScores()
    {
        highScores.Clear();

        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using(IDbCommand dbCommand=dbConnection.CreateCommand())
            {
                string sqlQuery = "SELECT * FROM HighScores";

                dbCommand.CommandText = sqlQuery;

                //Debug.Log("select");

                using (IDataReader reader=dbCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        highScores.Add(new HighScore(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
                    }
                    dbConnection.Close();
                    reader.Close();
                }
            }
        }
        //highScores.Sort();
    }


    /*private void DeleteScore(int id)
    {
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCommand = dbConnection.CreateCommand())
            {
                string sqlQuery = String.Format("DELETE FROM HighScores WHERE PlayerID=\"{0}\"",id);

                dbCommand.CommandText = sqlQuery;
                dbCommand.ExecuteScalar();
                dbConnection.Close();
            }
        }

    }*/

    private void ShowScores()
    {
        //scoreParent,scoreChild
        GetScores();

        
        for (int i=0;i<topRanks;i++)
        {
            if (i <= highScores.Count - 1)
            {
                //scorePrefab.transform.position = new Vector3(186.0f, -41.0f, 0.2078947f);
                GameObject tmpObject = Instantiate(scorePrefab);
                HighScore tmpScore = highScores[i];

                tmpObject.GetComponent<HighscoreScript>().SetScore(tmpScore.Name, tmpScore.Score.ToString(), "#" + (i + 1).ToString());

                tmpObject.transform.SetParent(scoreParent);

                //tmpObject.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            }
        }
    }

}
