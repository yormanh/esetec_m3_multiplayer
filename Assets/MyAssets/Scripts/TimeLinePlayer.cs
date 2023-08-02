using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using DG.Tweening;

public class TimelinePlayer : MonoBehaviour
{
    private PlayableDirector director;
    public GameObject controlPanel;
    [SerializeField] GameObject _objeto;
    bool _isStop = false;


    public void Awake()
    {
            director = GetComponent<PlayableDirector>();
            director.played += OnDirectorPlayed;
            director.stopped += OnDirectorStopped;

    }


    void OnDirectorStopped (PlayableDirector obj)
    {
        controlPanel.SetActive(true);
        HacerAnimacion();
    }
    void HacerAnimacion()
    {
        _objeto.transform.DOShakeRotation(3, 90, 4, 20, false);
        
    }

    void OnDirectorPlayed(PlayableDirector obj)
    {
        controlPanel.SetActive(false);
    }

    public void StartTimeLine()
    {
        director.Play();
    }

    public void Update()
    {
        Debug.Log(director.time);
        //if (director.time >= 4 && _isStop == false)
        //if (_isStop == false && director.time >= 4)
        if (!_isStop && director.time >= 4)
        {
            HacerAnimacion();
            _isStop = true;
        }
    }

   
}