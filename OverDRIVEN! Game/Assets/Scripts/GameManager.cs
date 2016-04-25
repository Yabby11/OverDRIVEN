using UnityEngine;
using System.Collections;

public class GameManager : SingletonBehaviour<GameManager> {

    public float timer;
    public string leftC;
    public string rightC;
    public string forwardC;
    public string backwardC;
    public int RandResult;
    public int RandResult2;
    public int RandResult3;
    public int RandResult4;
    public string[] arrayOfKeys = { "a", "b", "c", "d", "e", "f", "g", " h", "i", "j", "k", "l", "m", " n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

    // Use this for initialization
    void Start () {
        Debug.Log("Start");

        
        RandResult = Random.Range(0, 25);
        RandResult2 = Random.Range(0, 25);
        RandResult3 = Random.Range(0, 25);
        RandResult4 = Random.Range(0, 25);

        if (RandResult2 == RandResult)
        {

            RandResult2 = Random.Range(0, 25);

        }

        if (RandResult3 == RandResult && RandResult3 == RandResult2)
        {

            RandResult3 = Random.Range(0, 25);

        }

        if (RandResult4 == RandResult && RandResult4 == RandResult2 && RandResult4 == RandResult3)
        {

            RandResult4 = Random.Range(0, 25);

        }

        rightC = arrayOfKeys[RandResult];
        leftC = arrayOfKeys[RandResult2];
        forwardC = arrayOfKeys[RandResult3];
        backwardC = arrayOfKeys[RandResult4];
       
    }
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;

       
        hackerControls();
       
      

    }




    void hackerControls()
    {

        if(timer % 30 == 0)
        {
            Debug.Log("control change");



            RandResult = Random.Range(0, 25);
            RandResult2 = Random.Range(0, 25);
            RandResult3 = Random.Range(0, 25);
            RandResult4 = Random.Range(0, 25);

            if (RandResult2 == RandResult)
            {

                RandResult2 = Random.Range(0, 25);

            }

            if (RandResult3 == RandResult && RandResult3 == RandResult2)
            {

                RandResult3 = Random.Range(0, 25);

            }

            if (RandResult4 == RandResult && RandResult4 == RandResult2 && RandResult4 == RandResult3)
            {

                RandResult4 = Random.Range(0, 25);

            }

            string rightC = arrayOfKeys[RandResult];
            string leftC = arrayOfKeys[RandResult];
            string forwardC = arrayOfKeys[RandResult];
            string backwardC = arrayOfKeys[RandResult];


            Debug.Log(rightC);
            Debug.Log(leftC);
            Debug.Log(forwardC);
            Debug.Log(backwardC);







        }


    }

}
