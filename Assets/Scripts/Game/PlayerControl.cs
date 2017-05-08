using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class PlayerControl : Controller
    {
        StaticValue value = new StaticValue();

        private CarController m_Car;

        void Start()
        {

            m_Car = GetComponent<CarController>();

        }

        private void FixedUpdate()
        {
            Move(this.gameObject);
        }
        public override void Move(GameObject go)
        {
            base.Move(go);
            float h = Input.GetAxis("Horizontal") * 20f;
            float v = Input.GetAxis("Vertical") * 20f;
     
#if UNITY_STANDALONE_WIN && UNITY_EDITOR
            //Unity和PC平台
            if (Input.GetKey(KeyCode.W))
            {
                m_Car.Move(h, v, v, 0);
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                m_Car.Move(0, 0, 0, 0);

            }
            if (Input.GetKey(KeyCode.S))
            {
              
                m_Car.Move(h, v, v, 0);
               
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                m_Car.Move(h, v, v, 0);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                m_Car.Move(h, v, v, 0);
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                m_Car.Move(h, v, v, 0);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                m_Car.Move(h, v, v, 0);
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                m_Car.Move(h, v, v, 0);
            }
#elif UNITY_ANDROID
        //安卓平台
#endif
        }
        private void WheelRotate(GameObject one)
        {
            one.transform.Rotate(new Vector3(1, 0, 0), 180f);
        }
    }
}
