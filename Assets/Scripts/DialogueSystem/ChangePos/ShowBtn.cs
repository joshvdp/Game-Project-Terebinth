using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBtn : MonoBehaviour
{
    public FixedTouchField TouchField;

    public GameObject btn, firstDia, lastDia,
                      buttons, analog;


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
            bg.transform.localPosition = new Vector3(172, 422, 0f);
            btn.SetActive(true);
        }

        if (lastDia.activeSelf)
        {
            bg.transform.localPosition = new Vector3(172, 422, 0f);
            buttons.SetActive(false);
            analog.SetActive(false);
        }

    }
}