using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySelectController : MonoBehaviour
{
    public GameObject[] keyPrefabs; // �Է� Ű�� �����յ�
    public int numRows = 3; // ���� ����
    public int numColumns = 5; // ���� ����
    public float rowSpacing = 1.3f; // �� ���� ����
    public float columnSpacing = 1.3f; // �� ���� ����

    public int[] keyIndex; // Ű �ε��� ���� �迭
    public GameObject[] keys; // Ű ������Ʈ ���� �迭

    private void Start()
    {
        keyIndex = new int[15]; // Ű �ε��� �迭 �ʱ�ȭ
        keys = new GameObject[15]; // Ű ������Ʈ �迭 �ʱ�ȭ
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
                //Quaternion.identity -> ������Ʈ�� ȸ������ �ʰ� �����ǵ��� �ִ� ��
                keyObject.transform.SetParent(transform);

                keyIndex[(row * 5) + column] = randomKeyIndex;
                keys[(row*5)+column] = keyObject;

                // Ű�� ���� �߰� ���� (Ű�� ���� ���� ���� ��)

                // �÷��̾ �̵��ϴ� ����
                // 1���� 15¥�� �迭 2�� ->
                // 1��° �迭 - �������� ������ Ű �����յ��� �ε��� ����
                // 2��° �迭 - ������Ʈ ����
                // 
            }
        }
    }
}
