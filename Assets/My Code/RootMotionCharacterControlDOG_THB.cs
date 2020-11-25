using UnityEngine;
using System.Collections;


[AddComponentMenu("Mixamo/Demo/Root Motion Character")]
public class RootMotionCharacterControlDOG_THB: MonoBehaviour
{
	public float turningSpeed = 90f;
	public RootMotionComputer computer;
	public CharacterController character;
	public bool dogIdle = true;
	public bool dogScratching = false;
	public AudioClip myClip;
	

	void Start()
	{
		// validate component references
		if (computer == null) computer = GetComponent(typeof(RootMotionComputer)) as RootMotionComputer;
		if (character == null) character = GetComponent(typeof(CharacterController)) as CharacterController;
		
		// tell the computer to just output values but not apply motion
		computer.applyMotion = false;
		// tell the computer that this script will manage its execution
		computer.isManagedExternally = true;
		// since we are using a character controller, we only want the z translation output
		computer.computationMode = RootMotionComputationMode.ZTranslation;
		// initialize the computer
		computer.Initialize();
		
		// set up properties for the animations
		GetComponent<Animation>()["idle"].layer = 0; GetComponent<Animation>()["idle"].wrapMode = WrapMode.Loop;
		GetComponent<Animation>()["sitidle"].layer = 1; GetComponent<Animation>()["sitidle"].wrapMode = WrapMode.Loop;
		GetComponent<Animation>()["walk"].layer = 1; GetComponent<Animation>()["walk"].wrapMode = WrapMode.Loop;
		GetComponent<Animation>()["trot"].layer = 1; GetComponent<Animation>()["trot"].wrapMode = WrapMode.Loop;
		GetComponent<Animation>()["scratching"].layer = 1; GetComponent<Animation>()["scratching"].wrapMode = WrapMode.Loop;
		GetComponent<Animation>()["beg"].layer = 1; GetComponent<Animation>()["beg"].wrapMode = WrapMode.Loop;
		GetComponent<Animation>()["barking"].layer = 3; GetComponent<Animation>()["barking"].wrapMode = WrapMode.Once;
		GetComponent<Animation>()["howl"].layer = 3; GetComponent<Animation>()["howl"].wrapMode = WrapMode.Once;
		
		GetComponent<Animation>().Play("sitidle");
		dogScratching = false;
		
	}
	
	void Update()
	{
		float targetMovementWeight = 0f;
		float throttle = 0f;
		float randomEvent = 1f;

		
//		// turning keys
//		if (Input.GetKey(KeyCode.A)) transform.Rotate(Vector3.down, turningSpeed*Time.deltaTime);
//		if (Input.GetKey(KeyCode.D)) transform.Rotate(Vector3.up, turningSpeed*Time.deltaTime);
//		
//		// forward movement keys
//		// ensure that the locomotion animations always blend from idle to moving at the beginning of their cycles
//		if (Input.GetKeyDown(KeyCode.W) && 
//			(animation["walk"].weight == 0f || animation["run"].weight == 0f))
//		{
//			animation["walk"].normalizedTime = 0f;
//			animation["trot"].normalizedTime = 0f;
//		}
//		if (Input.GetKey(KeyCode.W))
//		{
//			targetMovementWeight = 1f;
//		}
//		if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) throttle = 1f;
//				
//		// blend in the movement
//
//		animation.Blend("trot", targetMovementWeight*throttle, 0.5f);
//		animation.Blend("walk", targetMovementWeight*(1f-throttle), 0.5f);
//		// synchronize timing of the footsteps
//		animation.SyncLayer(1);
//		
//		// all the other animations, such as punch, kick, attach, reaction, etc. go here
//		if (Input.GetKeyDown(KeyCode.Alpha1)) animation.CrossFade("barking", 0.2f);
//		if (Input.GetKeyDown(KeyCode.Alpha2)) animation.CrossFade("beg", 0.2f);
//		if (Input.GetKeyDown(KeyCode.Alpha3)) animation.CrossFade("sitidle", 0.2f);
	
		// toggle scratching/idle status every once in a while (2% chance per test)
		randomEvent = Random.value;
		if (randomEvent < 0.01 && dogIdle == true) {
			if (dogScratching == true) {
				GetComponent<Animation>().CrossFade ("sitidle", 0.5f);
				dogScratching = false;
				}
			else {
				GetComponent<Animation>().CrossFade ("scratching", 0.5f);
				dogScratching = true;
				}
			}

	}
		void OnTriggerEnter(Collider myTrigger) {
			if ((myTrigger.gameObject.name == "First Person Controller" || myTrigger.gameObject.name == "Oculus") && dogIdle == true) {
						GetComponent<Animation>().CrossFade ("beg", 0.2f);
						GetComponent<AudioSource>().mute = false;
						GetComponent<AudioSource>().PlayOneShot(myClip, 0.7f);
						dogIdle = false;
						}
		}
	void OnTriggerExit(Collider myTrigger) {
		if (myTrigger.gameObject.name == "First Person Controller" || myTrigger.gameObject.name == "Oculus") {
			GetComponent<Animation>().CrossFade ("sitidle", 0.2f);
			GetComponent<AudioSource>().mute = true;
			dogIdle = true;
		}
	}

	void LateUpdate()
	{
		computer.ComputeRootMotion();
		
		// move the character using the computer's output
//		character.SimpleMove(transform.TransformDirection(computer.deltaPosition)/Time.deltaTime);
	}
}