using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainHero : MonoBehaviour
{
   
    public Rigidbody2D hrb;//플레이어 오브젝트 리지드바디
    public float speed;//플레이어 오브젝트 속도
    public float jump_speed;//점프속도
    //float t;//시간변수
    float jt;//점프시간 변수
    public bool jump;//점프가능여부 변수
    private bool jst;//점프 시작했을때인가?
    
   
    
   



    private void Start()
    {
        
        //t = 0;
        jt = 0;
        jump = true;
        jst = true;
    }

    
    void FixedUpdate()
    {
       
        
        //Debug.Log(jt);
        //t += Time.deltaTime;//시간측정
        //if (t>=0.001)//0.001초마다 행동
        //{
            if (Input.GetKey(KeyCode.D)) //우측이동
            {
                hrb.transform.Translate(speed*Time.fixedDeltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.A))//좌측이동
            {
                hrb.transform.Translate(-speed * Time.fixedDeltaTime, 0, 0);
            }
            
            
           // t = 0;
        //}
        if (jump==true)//점프가 가능하다면
        {
            if (Input.GetKey(KeyCode.Space))//점프 누르면
            {
                if (jst == true)//최소점프높이
                {
                    hrb.AddForce(transform.up * 400);
                    jst = false;
                }
                hrb.gravityScale = 0;
                if (jt <= 0.5)//점프 버튼 누르는시간 조절
                {
                    jt += Time.fixedDeltaTime;
                    hrb.AddForce(transform.up * jump_speed);
                }
                else
                {
                    jt = 0;
                    jst = true;
                    jump = false;
                }
            }
           
            if (jt > 0.5) 
            {
                jump = false;
                jst = true;
                jt = 0;
            }
           
        }
        else 
        {
            hrb.gravityScale = 2;
        }
    }
     void Update()
    {
        
        
        
        if (Input.GetKeyUp(KeyCode.Space))//점프키를 때면 땅에 닿을때까지 점프불가
        {
            //Debug.Log("기도");
            jump = false;
            jst = true;
            jt = 0;
        }
    }
 
}
