using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChangePosition
{
    public class Movement_PC : MonoBehaviour
    {
        public FixedTouchField TouchField;

        public GameObject scndIntro, lastIntro, atk, run, blk, jmp, lastDia,      //dialogue
                           map, health, pause;  // buttons & UI

        RectTransform bg;

        private void Start()
        {
            bg = gameObject.GetComponent<RectTransform>();
            pause.SetActive(false);
            
        }

        private void OnEnable()
        {
            TouchField.OnTouchDown += DoThisOnDown;
        }

        private void OnDisable()
        {
            TouchField.OnTouchDown -= DoThisOnDown;
        }

        void DoThisOnDown()
        {
            if (scndIntro.activeSelf)
            {
                

                map.SetActive(false);
                health.SetActive(false);

            }

           

            if (lastDia.activeSelf)
            {
                
                map.SetActive(true);
                pause.SetActive(true);
            }
        }
    }
}

