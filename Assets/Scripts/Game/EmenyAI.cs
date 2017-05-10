using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EmenyAI : MonoBehaviour
{

    UnityEngine.AI.NavMeshAgent na;
    public GameObject go;
    // Use this for initialization
    void Start ()
    {
        na = GetComponent<UnityEngine.AI.NavMeshAgent>();
        EmentyContrl();
	}

     void EmentyContrl()
    {
        na.SetDestination(go.transform.position);
    }
}
