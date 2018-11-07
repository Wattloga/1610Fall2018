
using UnityEngine;
using UnityEngine.AI;

public class BasicAi : MonoBehaviour
{

	private NavMeshAgent agent;
	public Transform Destination;
	// Use this for initialization
	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		agent.destination = Destination.position;
	}
}
