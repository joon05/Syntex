using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caa : MonoBehaviour
{
    public GameObject c;//ī�޶� ���ӿ�����Ʈ
    public GameObject hero;//�÷��̾� ���ӿ�����Ʈ





    void Update()
    {
        c.transform.position = new Vector3(hero.transform.position.x, hero.transform.position.y, -10);//ī�޶� ��ǥ �÷��̾� ��ġ�� �̵�
    }
}
