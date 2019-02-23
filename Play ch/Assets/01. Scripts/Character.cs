using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{


    //SerializeField 
    //CharacterControllor를 _animator에 세팅
    
    [SerializeField] AnimationController _animationController;

    enum eState
    {
        IDLE,
        WAIT,
        KICK,
    }

    void Start()
    {
        //IdleState();
        //WaitState();
        ChangeState(eState.IDLE); //()=>{} 무기명함수
        /*
        _animationController.AddEndEvent(()=>
        {
            Debug.Log("Animation Test");
            // Idle -> wait
            // wait -> kick
            // kick -> Idel
        });
        */
    }

    void Update()
    {
    }

    void ChangeState(eState state)
    {
        switch (state)
        {
            case eState.IDLE:
                IdleState();
                break;
            case eState.WAIT:
                WaitState();
                break;
            case eState.KICK:
                KickState();
                break;


        }
    }

    //상태 x zz
    void IdleState()
    {
        /*string trggerName = "idle1";
        int randValue = Random.Range(1, 6);
        trggerName = "idle" + randValue;
        _animator.SetTrigger(trggerName); */
        //Invoke("WaitState",2); //2초후에 WaitState 가장 기본적인 안좋은
        _animationController.PLay("idle1", () =>
        {
            WaitState();
        });
     }

    void WaitState()
    {
        _animationController.PLay("idle2", () =>
        {
            KickState();
        });
        //Invoke("IdleState", 2); //확인
    }

    void KickState()
    {
        _animationController.PLay("idle5", () =>
        {
            IdleState();
        });
    }

}
