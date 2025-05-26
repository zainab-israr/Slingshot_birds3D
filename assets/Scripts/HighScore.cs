using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class HighScore //: IComparer<HighScore>
{
    public int Score { get; set; }
    public string Name { get; set; }

    public int ID { get; set; }

    public HighScore(int id, string name, int score)
    {
        this.ID = id;
        this.Name = name;
        this.Score = score;
    }

   /*
    int IComparer<HighScore>.Compare(HighScore x, HighScore y)
    {
        if (x.Score < y.Score)
        {
            return -1;
        }
        else if (x.Score > y.Score)
        {
            return 1;
        }
        else
            return 0;
    }
  
    */

}
