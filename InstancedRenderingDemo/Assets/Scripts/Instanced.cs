using UnityEngine;
using System.Collections.Generic;

public class Instanced : MonoBehaviour {
	public GameObject m_Prefab;
	public int count = 100000;

	// Use this for initialization
	void Start () {
		MaterialPropertyBlock props = new MaterialPropertyBlock();
		MeshRenderer renderer;

		List<GameObject> objects = new List<GameObject>();
		for(int i = 0; i < count; i++)
		{
			objects.Add(Instantiate(m_Prefab));
		}

		foreach (GameObject obj in objects)
		{
			float r = Random.Range(0.0f, 1.0f);
			float g = Random.Range(0.0f, 1.0f);
			float b = Random.Range(0.0f, 1.0f);
			props.SetColor("_Color", new Color(r, g, b));

			obj.transform.position = new Vector3(Random.Range(0, 1000), Random.Range(0, 1000), Random.Range(0, 1000));

			renderer = obj.GetComponent<MeshRenderer>();
			renderer.SetPropertyBlock(props);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
