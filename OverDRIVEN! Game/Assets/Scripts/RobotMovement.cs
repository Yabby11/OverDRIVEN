using UnityEngine;
using System.Collections;

public class RobotMovement : MonoBehaviour {

    public Transform robot;
    int speed = 40;

	// Use this for initialization
	void Start () {
        robot = this.transform;
    }

    // Update is called once per frame
    void Update() {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) / speed;
        robot.position += Vector3.MoveTowards(transform.position, movement, Mathf.Infinity);

        Quaternion rot = Quaternion.Euler(0, Input.GetAxis("Mouse X") + 90, 0);
        robot.rotation = Quaternion.Slerp(transform.rotation, rot, Time.deltaTime / speed);
    }
}
