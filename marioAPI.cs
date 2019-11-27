using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace mario
{
    public class marioAPI:MonoBehaviour
    {
        private void Start()
        {
            
        }

        private void Update()
        {
            
        }

        //Require: two 3d vector
        //Modify: None
        //Effect: return the distance on xy plane of the two vectors as float
        public float Distance(Vector3 a1,Vector3 a2)
        {
            Vector2 a,b;
            a.x = a1.x;
            a.y = a1.y;
            b.x = a2.x;
            b.y = a2.y;
            return (b-a).magnitude;
        }
        public class values_
        {
            int[] coins = new int[4];
        }

    }
    
}

