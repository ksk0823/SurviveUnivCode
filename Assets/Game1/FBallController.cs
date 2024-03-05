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

        //화면 밖으로 나오면 오브젝트 소멸
        if (transform.position.y < -4.0f)
        {
            Destroy(gameObject);
        }

    }

    // 충돌 판정
    private void OnTriggerEnter2D(Collider2D other)
    {
        // 플레이어와 충돌 시
        if (other.CompareTag("Player"))
        {
            score.Num++;
            score.Score += 0f;
            Destroy(gameObject);
            Sfx.SoundPlay();
        }
    }
}
