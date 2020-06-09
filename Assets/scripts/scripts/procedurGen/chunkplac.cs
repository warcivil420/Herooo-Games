using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chunkplac : MonoBehaviour
{
    public bool flag = false;
    
    public int rt=1;
    public Transform Player;
    public chunk[] ChunkPrefabs;
    public chunk FirstChunk;
    private List<chunk> spawnedChunks = new List<chunk>();

    void Start()
    {
        spawnedChunks.Add(FirstChunk);   
    }

    void Update()
    {

        if (Player.position.x > (spawnedChunks[spawnedChunks.Count-1].end.position.x)-16)
        {
            rt++;
            Debug.Log(spawnedChunks[spawnedChunks.Count - 1].end.position.x);
            SpawnChunk();
        }
    }

private void SpawnChunk()
    {
        chunk newChunk = Instantiate(ChunkPrefabs[Random.Range(0, ChunkPrefabs.Length)]);
        newChunk.transform.position = spawnedChunks[spawnedChunks.Count-1].end.position-newChunk.begin.localPosition;
        spawnedChunks.Add(newChunk);
        if(spawnedChunks.Count >= 4)
        {
            Destroy(spawnedChunks[0].gameObject);
            spawnedChunks.RemoveAt(0);
        }
    }


}
