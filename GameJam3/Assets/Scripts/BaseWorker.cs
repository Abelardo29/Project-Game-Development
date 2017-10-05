using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWorker : MonoBehaviour {

    public Vector2 baseCamp;
    public string training = "none";
    public float movementSpeed;
	public int trainingTime;
	public int miningTime;
	public GameObject player, headquarters, resource;
	public int iron = 0;

    [HideInInspector]
    public Vector3 goal;

    public Color defaultColor = Color.magenta;

    BaseWorker (string trainingParam) {
        training = trainingParam;
    }

	void Start () {
		transform.position = new Vector3(baseCamp.x, 0, baseCamp.y);
        GetComponent<Renderer>().material.color = defaultColor;
    }
	
	void Update () {
	}

    private void LateUpdate() {
            MoveToLocation(goal);

    }

    void MoveToLocation(Vector3 goal) {
        transform.position = Vector3.MoveTowards(transform.position, goal, movementSpeed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, 0f, transform.position.z);        
    }

    public void MoveToBuilding(GameObject building) {
        goal = building.transform.position;
            MoveToLocation(building.transform.position);
    }

    private void OnCollisionEnter (Collision coll) {
		goal = transform.position;
		switch (coll.gameObject.tag) {
		case "BuildingTraining":
			
			Debug.Log("Training!");

			player.GetComponent<SelectWorker> ().Unselect ();
			StartCoroutine (Train ());
			break;

		case "Iron":
			if (training.Equals("Mining") ){
				Debug.Log ("Starting to mine!");
				resource = coll.gameObject;
				StartCoroutine (MineIron ());
			}
				break;

		case "BaseCamp": 
			Debug.Log ("Arrived at BaseCamp!");
			player.GetComponent<ResourceManager> ().stone += iron;
			iron = 0;
			goal = resource.transform.position;
			break;

				default:
				Debug.Log("Something went seriously wrong");
				break;
		}


        
    }

	IEnumerator Train () {

		GetComponent<MeshRenderer>().enabled = false;
		yield return new WaitForSeconds (trainingTime);

		training = "Mining";
		Debug.Log ("Training done!"); 

		GetComponent<MeshRenderer> ().enabled = true;
	}

		IEnumerator MineIron (){
				
		yield return new WaitForSeconds (miningTime);

		for (int i = 0; i < 20; i++) {
			yield return new WaitForSeconds (0.1f);
				iron++;
		}
			yield return new WaitForSeconds (miningTime);

			Debug.Log ("Mining done!");
			iron += 10;
		MoveToBuilding (headquarters);
	}
}