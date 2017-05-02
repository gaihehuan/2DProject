using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticValue : MonoBehaviour
{
    private float speed;
    public float SpeedGet
    {
        get { return speed; }
       

    }
    public float SpeedSet
    {
        set { speed = value; }
    }


}
