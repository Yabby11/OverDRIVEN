using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Transform car;

    public float moveSpeed = 0.2f;
    public float rotateSpeed = 10.0f;

    // Use this for initialization
    void Start () {
        car = this.transform;
    }
	
	// Update is called once per frame
	void Update () {
        //Movement Up and Down
        if(Input.GetKey(GameManager.Instance.forwardC)) {
            if(Input.GetKey(GameManager.Instance.leftC)) {
                car.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * rotateSpeed);
                car.position += transform.forward * moveSpeed;
            } else if(Input.GetKey(GameManager.Instance.rightC)) {
                car.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * rotateSpeed);
                car.position += transform.forward * moveSpeed;
            } else {
                car.position += transform.forward * moveSpeed;
            }
        } else if(Input.GetKey(GameManager.Instance.backwardC)) {
            if(Input.GetKey(GameManager.Instance.leftC)) {
                car.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * rotateSpeed);
                car.position += -transform.forward * moveSpeed;
            } else if(Input.GetKey(GameManager.Instance.rightC)) {
                car.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * rotateSpeed);
                car.position += -transform.forward * moveSpeed;
            } else {
                car.position += -transform.forward * moveSpeed;
            }
        }
    }
}
