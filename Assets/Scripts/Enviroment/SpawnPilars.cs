using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class SpawnPilars : MonoBehaviour
{
    [SerializeField] private GameObject pilarPrefab;

    [SerializeField] private float pilarDistanceX = 5f;
    [SerializeField] private float pilarYPosition = 2.5f;

    private Transform lastPilar;

    private List<GameObject> objectPool = new List<GameObject>();
    private List<GameObject> disabletObjects = new List<GameObject>();

    private void Update()
    {
        if(CheckForDistanceFromLast())
        {
            SpawnPilar();
        }
    }

    private bool CheckForDistanceFromLast()
    {
        if(lastPilar == null || transform.position.x - lastPilar.position.x > pilarDistanceX)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void SpawnPilar()
    {
        GameObject pilar = GetPilarFromPool();
        pilar.transform.position = new Vector3(transform.position.x, Random.Range(-pilarYPosition, pilarYPosition), 0);
        lastPilar = pilar.transform;
    }

    private GameObject GetPilarFromPool()
    {
        GameObject pilar = null;
        if (disabletObjects.Count > 0)
        {
            pilar = disabletObjects[0];
            disabletObjects.RemoveAt(0);
        }
        else
        {
            pilar = Instantiate(pilarPrefab);
            objectPool.Add(pilar);
        }
        pilar.SetActive(true);
        return pilar;
    }

    public void AddToDisabled(GameObject pilar)
    {
        disabletObjects.Add(pilar);
    }
}
