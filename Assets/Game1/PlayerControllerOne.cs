using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerOne : MonoBehaviour
{
    private float moveSpeed = 6.0f;

    private bool isMoving = false; // 플레이어 이동 여부
    private SpriteRenderer spriteRenderer; // 플레이어 스프라이트 렌더러 컴포넌트

    private Animator animator;

    private Rigidbody2D rb;

    private void Start()
    {
        // 게임 시작 시 플레이어의 초기 위치 고정
        transform.position = new Vector3(0f, transform.position.y, transform.position.z);
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        // 플레이어 이동
        float moveDirection = Input.GetAxis("Horizontal");

        if (moveDirection < 0)
        {
            isMoving = true;
            transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0f, 0f));
            spriteRenderer.flipX = false;
            this.animator.speed = moveSpeed / 3.0f;
        }
        else if (moveDirection > 0)
        {
            isMoving = true;
            transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0f, 0f));
            spriteRenderer.flipX = true;
            this.animator.speed = moveSpeed / 3.0f;
        }
        else
        {
            isMoving = false;
        }


        /*
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            isMoving = true;
            transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0f, 0f));
            spriteRenderer.flipX = false;
            this.animator.speed = moveSpeed/3.0f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            isMoving = true;
            transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0f, 0f));
            spriteRenderer.flipX = true;
            this.animator.speed = moveSpeed/3.0f;
        }
        else
        {
            isMoving = false;

        }*/ 

        if (!isMoving)
        {
            this.animator.speed = 0f;
            spriteRenderer.sprite = Resources.Load<Sprite>("man");
            //transform.position = new Vector3(Mathf.Round(transform.position.x), transform.position.y, transform.position.z);
        } 

        // 화면의 경계를 벗어나지 않도록 위치 제한
        float minX = ScreenBounds.MinX;
        float maxX = ScreenBounds.MaxX;
        float minY = ScreenBounds.MinY;
        float maxY = ScreenBounds.MaxY;

        Vector3 newPosition = transform.position;
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

        // 새로운 위치로 이동
        transform.position = newPosition;
    }

    private void FixedUpdate()
    {
        // 벽과 충돌 시 움직임 제어
        if (isMoving)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        }
        else
        {
            rb.constraints = RigidbodyConstraints2D.None;
        }
    }
}
