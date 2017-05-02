using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : Controller {
    StaticValue value = new StaticValue();
    GameObject one;
    GameObject two;
    GameObject three;
    GameObject four;
    // Use this for initialization
    void Start ()
    {
        this.gameObject.AddComponent<Rigidbody>();
        this.gameObject.GetComponent<Rigidbody>().useGravity = false;
        one = GameObject.Find("tire_rear01");
         two = GameObject.Find("tire_rear");
        three = GameObject.Find("Front_tire01");
        four = GameObject.Find("Front_tire");
    }

    private void FixedUpdate()
    {
        Move(this.gameObject);
    }
    public override void Move(GameObject go)
    {
        base.Move(go);
#if UNITY_STANDALONE_WIN && UNITY_EDITOR
        //Unity和PC平台
        if (Input.GetKey(KeyCode.W))
        {
            value.SpeedSet = 10.0f;
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * value.SpeedGet);
            WheelRotate(one);
            WheelRotate(two);
            WheelRotate(three);
            WheelRotate(four);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            value.SpeedSet = 0f;
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * value.SpeedGet);
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            value.SpeedSet = 10.0f;
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.left * value.SpeedGet);
            WheelRotate(one);
            WheelRotate(two);
            WheelRotate(three);
            WheelRotate(four);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            value.SpeedSet = 0f;
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.left * value.SpeedGet);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {

        }
        if (Input.GetKeyDown(KeyCode.D))
        {

        }
#elif UNITY_ANDROID
        //安卓平台
#endif
    }
    private void WheelRotate(GameObject one)
    {
        one.transform.Rotate(new Vector3(0,1,0),180f);
        Debug.Log("test");
    }
}
