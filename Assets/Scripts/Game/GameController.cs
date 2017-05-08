using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityStandardAssets.Vehicles.Car
{
    public class GameController : MonoBehaviour
    {
       // public GameObject Car;
        // Use this for initialization
        void Start()
        {
            this.gameObject.AddComponent<PlayerControl>();
        }

    }
}
