using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] CapsulePrefabs;

    [SerializeField,Header("oŒ»‚·‚éŠÔŠu‚ğ§Œä")]
    private float SpawnTime;

    [SerializeField,Header("ƒ‰ƒ“ƒ_ƒ€‚ğ“ü‚ê‚é‚½‚ß‚Ì•Ï”")]
    private int Number;


    // Update is called once per frame
    void Update()
    {
        SpawnTime -= Time.deltaTime;    // SpawnTime‚©‚çŠÔ‚ğŒ¸‚ç‚·
        if (SpawnTime <= 0.0f)          // 0•b‚É‚È‚ê‚Î
        {
            SpawnTime = 1.0f;           // 1•b‚É‚·‚é

            Number = Random.Range(0, CapsulePrefabs.Length);
            Instantiate(CapsulePrefabs[Number], new Vector3(10, 0, 0), Quaternion.identity);
        }
    }
}
