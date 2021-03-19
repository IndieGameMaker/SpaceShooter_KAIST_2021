using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterCtrl : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform playerTr;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        playerTr = GameObject.Find("Player").GetComponent<Transform>(); //하이러키 뷰의 게임오브젝트의 이름으로 검색
        playerTr = GameObject.FindGameObjectWithTag("PLAYER").GetComponent<Transform>(); //게임오브젝트의 태그명으로 검색
    }

    void Update()
    {
        agent.SetDestination(playerTr.position);
    }
}
