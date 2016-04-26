using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RobotController : MonoBehaviour {

    //Get the transform of the robot.
    public Transform robot;

    //Set the speed that will be used in the movement and rotation calculations.
    int speed = 30;

    //Set up the Raycast.
    RaycastHit hit;

    //How long the laser has been on the car, after 5 seconds, signifying that they want to choose that one.
    public float selectionTime = 5.0f;

	void Start () {
        //Set the robot transform to the variable.
        robot = this.transform;
    }

    void Update() {
        //Movement.
        robot.position += Input.GetAxis("Vertical") * -transform.right / speed;

        //Rotation.
        robot.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * Time.deltaTime * speed * 2);

        //Laser.
        CastRay();        
    }

    void CastRay() {
        if(Physics.Raycast(robot.position, -transform.right, out hit, 500.0f)) {
            //If the Raycast hits a car,
            if(hit.transform.tag == "Car") {
                //Start counting down to 0 form 5.
                selectionTime -= Time.deltaTime;
                //If the countdown reaches 0,
                if(selectionTime <= 0.0f) {
                    //What car did you laser down? Set it to the selected car.
                    switch(hit.transform.name) {
                        case "Base AI" :
                            GameManager.Instance.baseAiVehicle = true;
                            break;
                        case "Armoured":
                            GameManager.Instance.armouredVehicle = true;
                            break;
                        case "Supra":
                            GameManager.Instance.supraVehicle = true;
                            break;
                        case "WRX":
                            GameManager.Instance.wrxVehicle = true;
                            break;
                        case "Chevelle":
                            GameManager.Instance.chevelleVehicle = true;
                            break;
                        case "GTR":
                            GameManager.Instance.gtrVehicle = true;
                            break;
                        case "Stingray":
                            GameManager.Instance.stingrayVehicle = true;
                            break;
                    }
                    Debug.Log("Selected: " + hit.transform.name);
                    GameManager.Instance.gameCanBegin = true;

                    SceneManager.LoadScene(2);
                }
            } else {
                //If you moved your laser before the time was up, reset the countdown time.
                selectionTime = 5.0f;
            }

            //So in the Editor, we can see the Raycast hitting the cars.
            Debug.DrawLine(robot.position, hit.point, Color.red);
        }
    }

    void OnGUI() {
        if(selectionTime < 5.0f && selectionTime > -0.01f)
        GUI.Label(new Rect(10, 10, 400, 90), "Selecting " + hit.transform.name + " in: " + selectionTime.ToString("F2") + " seconds");
    }
}
