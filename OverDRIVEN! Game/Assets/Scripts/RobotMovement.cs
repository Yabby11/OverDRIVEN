using UnityEngine;
using System.Collections;

public class RobotMovement : MonoBehaviour {

    public Transform robot;
    int speed = 30;

    //public string[] letters = { "a", "b", "c" };

    public float selectionTime = 5.0f;

	// Use this for initialization
	void Start () {
        robot = this.transform;

        /*int chosenNum = Random.Range(0, letters.Length);
        Debug.Log(letters[chosenNum]);*/

    }

    // Update is called once per frame
    void Update() {
        //To go in GameManager
        /*if(gameRestarted) {
         * baseAiVehicle = false;
         * armouredVehicle = false;
         * supraVehicle = false;
         * wrxVehicle = false;
         * chevelleVehicle = false;
         * gtrVehicle = false;
         * stingrayVehicle = false
         
            gameRestarted = false;

          }*/
        robot.position += Input.GetAxis("Vertical") * -transform.right / speed;
        robot.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * Time.deltaTime * speed * 2);

        CastRay();        
    }

    void CastRay() {
        RaycastHit hit;
        if(Physics.Raycast(robot.position, -transform.right, out hit, 500.0f)) {
            if(hit.transform.tag == "Car") {
                selectionTime -= Time.deltaTime;
                if(selectionTime <= 0.0f) {
                    switch(hit.transform.name) {
                        case "Base AI" :
                            //GameManager.Instance.baseAiVehicle = true
                            break;
                        case "Armoured":
                            //GameManager.Instance.armouredVehicle = true
                            break;
                        case "Supra":
                            //GameManager.Instance.supraVehicle = true
                            break;
                        case "WRX":
                            //GameManager.Instance.wrxVehicle = true
                            break;
                        case "Chevelle":
                            //GameManager.Instance.chevelleVehicle = true
                            break;
                        case "GTR":
                            //GameManager.Instance.gtrVehicle = true
                            break;
                        case "Stingray":
                            //GameManager.Instance.stingrayVehicle = true
                            break;
                    }
                    Debug.Log("Selected: " + hit.transform.name);
                }
            } else {
                selectionTime = 5.0f;
            }


            Debug.DrawLine(robot.position, hit.point, Color.red);
        }
                
           // } else {
              //  Debug.DrawLine(transform.position, hit.point, Color.green);
            //}
        //}
    }
}
