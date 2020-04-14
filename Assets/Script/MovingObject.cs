using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public float speed;//기본 이동속도

    private Vector3 vector;

    public float runSpeed;//뛰는 속도
    private float applyRunSpeed;

    private Animator animator;

    public bool OnVector;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        OnVector = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) // 키 눌린 코드 신호를 받아오는것.
        {
            //SceneManager.LoadScene("뒤로갈 씬 이름 "); // 씬으로 이동 .
            Application.Quit();  // 씬 종료 .(나가기)                        위씬으로 이동이나 종료기능 둘중하나 원하시는것을 사용하시면 됩니다. 
        }

        if (Input.GetKey(KeyCode.Q))
        {
            applyRunSpeed = runSpeed;//뛰는거 적용
        }
        else
        {
            applyRunSpeed = 0;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)) {
            OnVector = true;


        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            OnVector = false;
        }

        


        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {

            vector.Set(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), transform.position.z);
            animator.SetFloat("DirX", vector.x);
            animator.SetFloat("DirY", vector.y);

            
            
            /*if (OnVector != true)
            {
                
                
            }*/


            //animator.SetBool("walking", true);//걷는 애니메이션

            if (vector.x != 0)
            {
                transform.Translate(vector.x * (speed + applyRunSpeed), 0, 0);//x값 변환
                

            }
            else if (vector.y != 0)
            {
                transform.Translate(0, vector.y * (speed + applyRunSpeed), 0);//y값 변환
                

            }

        }
    }
}
