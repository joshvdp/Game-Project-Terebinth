using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBtn : MonoBehaviour
{
    public FixedTouchField TouchField;

    public GameObject btn, firstDia, lastDia,
                      analog, atk, sprint, block, jump, interact;


    RectTransform bg;

    private void Start()
    {
        bg = gameObject.GetComponent<RectTransform>();
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
        if (firstDia.activeSelf)
        {
            bg.transform.localPosition = new Vector3(215.01f, 297, 0f);
            btn.SetActive(true);
            interact.SetActive(false);
        }

        if (lastDia.activeSelf)
        {
            bg.transform.localPosition = new Vector3(172, 422, 0f);
            atk.SetActive(false);
            sprint.SetActive(false);
            block.SetActive(false);
            jump.SetActive(false);
            analog.SetActive(false);
        }

    }
}
