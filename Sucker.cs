using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace mario
{
    public class Sucker : MonoBehaviour
    {
        int Count;
        void Start()
        {
            
        }

        
        void Update()
        {
         for(Count=0;Count<this.transform.childCount;++Count)
            {
                GameObject Cr_child;
                Cr_child = this.transform.GetChild(Count).gameObject;
                if(Cr_child.activeSelf)
                {
                    objectcontrol Script_ = Cr_child.transform.parent.GetComponent<objectcontrol>();
                }
            }
        }

        bool Is_near(GameObject cr,GameObject target)
        {
            
            return true;
        }
    }
}
