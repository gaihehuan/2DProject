using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    bool isTurn = false;
    float curtime = 0;
    public static float TimeControl = 0;
    // Use this for initialization
    void Start()
    {
       //Mathf.p
    }

    public void ControlCamera()
    {
        if (TimeControl >= 3f)
        {
            Debug.Log(TimeControl);
            this.gameObject.transform.Translate(new Vector2(0.02f, 0), Space.World);
         
        }
        else
        {
            this.gameObject.transform.Translate(-new Vector2(0.02f, 0), Space.World);

        }

    }
    void FixedUpdate()
    {
        //ControlCamera();
       this.transform.position = new Vector3(Mathf.PingPong(Time.time, 3), transform.position.y, transform.position.z);
    }
}
