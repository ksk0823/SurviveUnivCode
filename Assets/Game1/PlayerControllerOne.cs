using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerOne : MonoBehaviour
{
    private float moveSpeed = 6.0f;

    private bool isMoving = false; // �÷��̾� �̵� ����
    private SpriteRenderer spriteRenderer; // �÷��̾� ��������Ʈ ������ ������Ʈ

    private Animator animator;

    private Rigidbody2D rb;

    private void Start()
    {
        // ���� ���� �� �÷��̾��� �ʱ� ��ġ ����
        transform.position = new Vector3(0f, transform.position.y, transform.position.z);
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        // �÷��̾� �̵�
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

        // ȭ���� ��踦 ����� �ʵ��� ��ġ ����
        float minX = ScreenBounds.MinX;
        float maxX = ScreenBounds.MaxX;
        float minY = ScreenBounds.MinY;
        float maxY = ScreenBounds.MaxY;

        Vector3 newPosition = transform.position;
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

        // ���ο� ��ġ�� �̵�
        transform.position = newPosition;
    }

    private void FixedUpdate()
    {
        // ���� �浹 �� ������ ����
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
