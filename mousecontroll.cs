using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace mario
{
    public class mousecontroll : MonoBehaviour
    {
        
        private bool isMouseDown;
        private Vector3 lastMousePosition = Vector3.zero;
        marioAPI marioo;
        Vector3 This_pos;
        // Start is called before the first frame update
        void Start()
        {
            marioo= new marioAPI();
        }

        // Update is called once per frame
        void Update()
        {
            
            if (isInside() || isMouseDown)
            {
                TwoDMove();
            }
            This_pos = this.transform.position;
        }
        public bool Is_;
        bool isInside()
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (marioo.Distance(pos,This_pos)<= 0.5f)
            {
                Is_ = true;
                return true;
            }
            Is_ = false;
            return false;
        }
        private void TwoDMove()
        {
            if (Input.GetMouseButtonDown(0))
            {
                isMouseDown = true;
            }
            if (Input.GetMouseButtonUp(0))
            {
                isMouseDown = false;
                lastMousePosition = Vector3.zero;//这里要归零，不然会有漂移效果
            }
            if (isMouseDown)
            {
                if (lastMousePosition != Vector3.zero)
                {
                    Vector3 offset = Camera.main.ScreenToWorldPoint(Input.mousePosition) - lastMousePosition;
                    transform.position += offset;
                }
                lastMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);


            }
        }

    }
    
}
