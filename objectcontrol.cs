using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace mario
{
    public class objectcontrol : MonoBehaviour
    {
        // Start is called before the first frame update
        GameObject[] module1;
        public GameObject module1_;
        marioAPI marioo;
        int count;
        int maxnum;
        void Start()
        {
            maxnum = 10;
            marioo = new marioAPI();
            count = 0;
            module1 = new GameObject[10];
            for (int i = 0; i < 10; i++)
            {
                module1[i] = Instantiate(module1_,this.transform);
                module1[i].SetActive(false);
                module1[i].transform.position = module1_.transform.position;
            }
            module1[0].SetActive(true);
        }

        // Update is called once per frame
        void Update()
        {
            module1[count].SetActive(true);
            if (count > maxnum)
                return;
            if(marioo.Distance(module1[count].transform.position , module1_.transform.position)>=1.0f)
            {
                ++count;
            }

        }
    }
}
