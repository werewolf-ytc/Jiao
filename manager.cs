using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace mario
{
    public class manager : MonoBehaviour
    {
        // Start is called before the first frame update

        GameObject d;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {


        }

        public void move_()
        {
            this.transform.GetChild(0).gameObject.transform.position += Vector3.down * 0.01f;
        }
    }
}
