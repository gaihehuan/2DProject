using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmenyBase : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
    public virtual void EmentyCommen(Transform localPostion,Transform goposition,Transform targetposition,float speed)
    {
        float step = speed * Time.deltaTime;
        localPostion.position = Vector3.MoveTowards(goposition.position, targetposition.position, step);
    }


}
