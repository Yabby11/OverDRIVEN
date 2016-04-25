using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class UI : MonoBehaviour {

    public float timer;
    public Text timerText;

	// Use this for initialization
	void Start () {
	
        

	}
	
	// Update is called once per frame
	void Update () {

        timer = GameManager.Instance.timer;
        timerText.text = ("Timer: " + timer);
	}
}
