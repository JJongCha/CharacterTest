using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Animation Event

    System.Action _endEvent = null;

    public void PLay(string triggerName, System.Action endEvent)
    {
        _animator.SetTrigger(triggerName);
        _endEvent = endEvent;
    }


    public void AddEndEvent(System.Action endEvent)
    {
        _endEvent = endEvent;

    }

    void AnimationEnd()
    {
        Debug.Log("AnimationEnd");
        if(null != _endEvent) // 함수변수 
        {
            _endEvent(); //우리가 등록한 함수
        }
    }


}
