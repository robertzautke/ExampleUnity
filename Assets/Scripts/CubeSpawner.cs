using UnityEngine;
using System.Collections;

public class CubeSpawner : MonoBehaviour {

    public GameObject spawnerCube;

    public int maxCubes = 100;
    public int currentNumberOfCubes;

	void Start () {
	
	}
	
	void Update () {

       // while (currentNumberOfCubes < maxCubes) {
            GameObject.Instantiate(spawnerCube);
        //    currentNumberOfCubes++;
        //}

	}
}
