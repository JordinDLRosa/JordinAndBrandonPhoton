using UnityEngine;
using System.Collections;

[BoltGlobalBehaviour]
public class NetworkCallbacks : Bolt.GlobalEventListener
{
    public override void SceneLoadLocalDone(string scene)
    {
        // randomize a position on the x and z plane
        var spawnPosition = new Vector3(Random.Range(-16, 16), 0, Random.Range(-16, 16));

        // instantiate cube
        BoltNetwork.Instantiate(BoltPrefabs.Cube, spawnPosition, Quaternion.identity);
    }
}