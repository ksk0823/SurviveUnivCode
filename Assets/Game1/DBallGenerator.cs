using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBallGenerator : MonoBehaviour
{
    public GameObject DBallPrefab;
    float span = 1.0f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(DBallPrefab); //화살 생성
            int px = Random.Range(-6, 7); //화살의 x 위치를 랜덤하게
            go.transform.position = new Vector3(px, 13, 0);
        }

    }
}
