using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainHero : MonoBehaviour
{
   
    public Rigidbody2D hrb;//�÷��̾� ������Ʈ ������ٵ�
    public float speed;//�÷��̾� ������Ʈ �ӵ�
    public float jump_speed;//�����ӵ�
    //float t;//�ð�����
    float jt;//�����ð� ����
    public bool jump;//�������ɿ��� ����
    private bool jst;//���� �����������ΰ�?
    
   
    
   



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
        //t += Time.deltaTime;//�ð�����
        //if (t>=0.001)//0.001�ʸ��� �ൿ
        //{
            if (Input.GetKey(KeyCode.D)) //�����̵�
            {
                hrb.transform.Translate(speed*Time.fixedDeltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.A))//�����̵�
            {
                hrb.transform.Translate(-speed * Time.fixedDeltaTime, 0, 0);
            }
            
            
           // t = 0;
        //}
        if (jump==true)//������ �����ϴٸ�
        {
            if (Input.GetKey(KeyCode.Space))//���� ������
            {
                if (jst == true)//�ּ���������
                {
                    hrb.AddForce(transform.up * 400);
                    jst = false;
                }
                hrb.gravityScale = 0;
                if (jt <= 0.5)//���� ��ư �����½ð� ����
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
        
        
        
        if (Input.GetKeyUp(KeyCode.Space))//����Ű�� ���� ���� ���������� �����Ұ�
        {
            //Debug.Log("�⵵");
            jump = false;
            jst = true;
            jt = 0;
        }
    }
 
}
