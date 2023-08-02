using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.EventSystems;

public class Cube : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init();
        //transform.DOMoveX(100, 1);
        transform.DOShakeRotation(2, 12, 4, 20, false);
        //DOTween.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
