using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBallController : MonoBehaviour
{
    private ScoreManager score;
    // Start is called before the first frame update
    void Start()
    {

        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
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
            score.Score += 0f;
            Destroy(gameObject);
            Sfx.SoundPlay();
        }
    }
}
