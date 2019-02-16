using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    //SerializeField 
    //CharacterControllor
    [SerializeField] Animator _animator;    

    void Start()
    {
        IdleState();
    }

    void Update()
    {
    }

        //상태 
    void IdleState()
    {
        string trggerName = "idle1";
        int randValue = Random.Range(1, 6);
        trggerName = "idle" + randValue;
        _animator.SetTrigger(trggerName);
        
    }
}
