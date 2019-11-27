using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

namespace mario
{
    public class Nowstart : MonoBehaviour
    {
        marioAPI marioo;
        Vector3 This_pos;
        // Start is called before the first frame update
        void Start()
        {
            marioo = new marioAPI();
        }

        // Update is called once per frame
        void Update()
        {
            This_pos = this.transform.position;
            if (Input.GetMouseButtonDown(0))
            {
                if (isInside())
                { 
                    SceneManager.LoadScene("Scratch");
                }
            }

        }
        public bool Is_;
        bool isInside()
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (marioo.Distance(pos, This_pos) <= 0.5f)
            {
                Is_ = true;
                return true;
            }
            Is_ = false;
            return false;
        }
    }
}
