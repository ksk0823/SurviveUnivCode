using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySelectController : MonoBehaviour
{
    public GameObject[] keyPrefabs; // 입력 키의 프리팹들
    public int numRows = 3; // 행의 개수
    public int numColumns = 5; // 열의 개수
    public float rowSpacing = 1.3f; // 행 간의 간격
    public float columnSpacing = 1.3f; // 열 간의 간격

    public int[] keyIndex; // 키 인덱스 저장 배열
    public GameObject[] keys; // 키 오브젝트 저장 배열

    private void Start()
    {
        keyIndex = new int[15]; // 키 인덱스 배열 초기화
        keys = new GameObject[15]; // 키 오브젝트 배열 초기화
        PlaceKeys();
    }

    private void PlaceKeys()
    {
        for (int row = 0; row < numRows; row++)
        {
            for (int column = 0; column < numColumns; column++)
            {
                float x = (column * columnSpacing)-2.58f;
                float y = (-row * rowSpacing)+0.55f;

                int randomKeyIndex = Random.Range(0, keyPrefabs.Length);
                GameObject keyPrefab = keyPrefabs[randomKeyIndex];
                GameObject keyObject = Instantiate(keyPrefab, new Vector3(x, y, 0), Quaternion.identity);
                //Quaternion.identity -> 오브젝트가 회전하지 않고 고정되도록 넣는 값
                keyObject.transform.SetParent(transform);

                keyIndex[(row * 5) + column] = randomKeyIndex;
                keys[(row*5)+column] = keyObject;

                // 키에 대한 추가 설정 (키에 문자 정보 전달 등)

                // 플레이어가 이동하는 방향
                // 1차원 15짜리 배열 2개 ->
                // 1번째 배열 - 랜덤으로 생성한 키 프리팹들의 인덱스 저장
                // 2번째 배열 - 오브젝트 저장
                // 
            }
        }
    }
}
