using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Transform car;
    public float moveSpeed = 0.0f;
    public float maxMoveSpeed = 6.66f;
    public float rotateSpeed = 100.0f;

    // Use this for initialization
    void Start () {
        car = this.transform;
    }

    // Update is called once per frame
    void Update() {
        car.position += transform.forward * moveSpeed * Time.deltaTime;
        //Movement Up and Down
        if(Input.GetKey(GameManager.Instance.forwardC) && Input.GetKey(GameManager.Instance.backwardC)) {
            if(moveSpeed > 0.05f) {
                moveSpeed -= Time.deltaTime * 3;
            } else if(moveSpeed < 0.05f) {
                moveSpeed += Time.deltaTime * 3;
            } else if(moveSpeed > -0.05f && moveSpeed < 0.05f) {
                //MASSIVE SKIDDIES
            }

        } else if(Input.GetKey(GameManager.Instance.forwardC)) {
            if(moveSpeed < maxMoveSpeed) {
                if(moveSpeed < 0.0f) {
                    moveSpeed += Time.deltaTime * 3;
                } else {
                    moveSpeed += Time.deltaTime;
                }
            }

        } else if(Input.GetKey(GameManager.Instance.backwardC)) {
            if(moveSpeed > -maxMoveSpeed) {
                if(moveSpeed > 0.0f) {
                    moveSpeed -= Time.deltaTime * 3;
                } else {
                    moveSpeed -= Time.deltaTime;
                }
            }

        } else if(moveSpeed > 0.05f) {
            moveSpeed -= Time.deltaTime * 2;

        } else if (moveSpeed < 0.05f) {
            moveSpeed += Time.deltaTime * 2;
        }

        if(Input.GetKey(GameManager.Instance.leftC)) {
            car.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * moveSpeed * 15);
        } else if(Input.GetKey(GameManager.Instance.rightC)) {
            car.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * moveSpeed * 15);
        }
    }
}
