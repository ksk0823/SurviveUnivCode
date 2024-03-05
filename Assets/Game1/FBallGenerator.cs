using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBallGenerator : MonoBehaviour
{
    public GameObject FBallPrefab;
    float span = 1.0f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(FBallPrefab); //ȭ�� ����
            int px = Random.Range(-6, 7); //ȭ���� x ��ġ�� �����ϰ�
            go.transform.position = new Vector3(px, 9.5f, 0);
        }

    }
}