using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

namespace mario
{
    public class finish : MonoBehaviour
    {
        string Path = "./Assets/script/character_control.cs";
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
                if(isInside())
                {
                    Writefile();
                    StartCoroutine(Waiting(10f));
                    File.ReadAllText(@Path);
                    SceneManager.LoadScene(0);
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
        IEnumerator Waiting(float b)
        {
            yield return new WaitForSeconds(b);
        }

        void Writefile()
        {
            string[] lines = { "using System.Collections;using System.Collections.Generic;           using UnityEngine;public class character_control : MonoBehaviour   {            void Start()           {           }                   void Update()           {   this.transform.position+=Vector3.up*0.05f;        }        }" };
            File.WriteAllLines(@Path, lines);
        }
    }
}
