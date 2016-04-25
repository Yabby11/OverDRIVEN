using UnityEngine;
using System.Collections;

public class GameManager : SingletonBehaviour<GameManager> {

    public float timer;
    public string forwardC;
    public string backwardC;
    public string leftC;
    public string rightC;
    public string[] arrayOfKeys = {"a", "b", "c", "d", "e", "f", "g", " h", "i", "j", "k", "l", "m", " n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

    // Use this for initialization
    void Start () {
        Debug.Log("Start");
        
        forwardC = "w";
        backwardC = "s";
        leftC = "a";
        rightC = "d";
    }

	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        hackerControls();
    }


    int GetRandResult() {
        int result = Random.Range(0, arrayOfKeys.Length);
        return result;
    }


    void hackerControls() {
        if(timer % 30 < 0.1f) {
            string rightC = arrayOfKeys[GetRandResult()];
            string leftC = arrayOfKeys[GetRandResult()];
            string forwardC = arrayOfKeys[GetRandResult()];
            string backwardC = arrayOfKeys[GetRandResult()];

            Debug.Log(rightC);
            Debug.Log(leftC);
            Debug.Log(forwardC);
            Debug.Log(backwardC);
        }
    }
}
