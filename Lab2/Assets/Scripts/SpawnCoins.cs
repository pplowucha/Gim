using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    public Transform[] coinSpawns;
    public GameObject leftSideCoin;
    public GameObject middleSideCoin;
    public GameObject rightSideCoin;

    // Use this for initialization
    void Start()
    {
        Spawn(); // Generate some coins when the script is called.
    }

    // Spawn a random coin object
    void Spawn()
    {
        // For however many coins we have, spawn them if a coin flips to 1.
        for (int i = 0; i < coinSpawns.Length; i++)
        {
            GameObject coin = middleSideCoin; // default coin (just in case)
            switch (i)
            {
                case 0: // left side
                    coin = leftSideCoin;
                    break;
                case 1: // middle side
                    coin = middleSideCoin;
                    break;
                case 2: // right side
                    coin = rightSideCoin;
                    break;
            }
            int coinFlip = Random.Range(0, 2); // Produce a value of 0 or 1
            if (coinFlip > 0)
                Instantiate(coin, coinSpawns[i].position, Quaternion.identity); // coinSpawns[i] is our prefab.
        }
    }
}