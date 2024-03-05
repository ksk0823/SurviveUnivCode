using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APlusController : MonoBehaviour
{
    private ScoreManager score;
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {

        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //ȭ�� ������ ������ ������Ʈ �Ҹ�
        if (transform.position.y < -4.0f)
        {
            Destroy(gameObject);
        }

    }

    // �浹 ����
    private void OnTriggerEnter2D(Collider2D other)
    {
        // �÷��̾�� �浹 ��
        if (other.CompareTag("Player"))
        {
            score.Num++;
            score.Score += 4.5f;
            Destroy(gameObject);
            Sfx.SoundPlay();
        }
    }
}
