using UnityEngine;
using System.Collections;

/// <summary>
/// Regular rendering mode. 
/// </summary>
public class Regular : MonoBehaviour {

	public GameObject m_Prefab;
	public int count = 100000;

	// Use this for initialization
	void Start()
	{
		for (int i = 0; i < count; i++)
		{
			Instantiate(m_Prefab).transform.position = new Vector3(Random.Range(0, 1000), Random.Range(0, 1000), Random.Range(0, 1000));
		}
	}
}
