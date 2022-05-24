using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caa : MonoBehaviour
{
    public GameObject c;//카메라 게임오브젝트
    public GameObject hero;//플레이어 게임오브젝트





    void Update()
    {
        c.transform.position = new Vector3(hero.transform.position.x, hero.transform.position.y, -10);//카메라 좌표 플레이어 위치로 이동
    }
}
