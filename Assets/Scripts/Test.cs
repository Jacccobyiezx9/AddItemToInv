using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test : MonoBehaviour
{
    //public int[] highScore = new int[10];
    //public Rigidbody[] rb = new Rigidbody[10];
    //public Test[] test;
    public List<int> HighScore = new List<int>();


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < HighScore.Count; i++)
        {
            //Debug.Log(highscore[8]);
            //Debug.Log(highscore.getvalue(8));
            //highscore[8] = i;
            //highscore.setvalue(8, i);

            //to add
            HighScore.Add(i);
            //to remove
            HighScore.Remove(i);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
