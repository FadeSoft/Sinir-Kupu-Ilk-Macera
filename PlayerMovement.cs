using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	AndroidButon ab;

	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;
	public float zıplamagucu;

	void Start(){

		ab = GameObject.FindGameObjectWithTag ("Canvas").GetComponent<AndroidButon> ();
	}
	void FixedUpdate ()
	{
		Android (); 

		rb.AddForce(0 ,0 ,forwardForce * Time.deltaTime);

		if (Input.GetKey("d"))
		{
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //bu sag içim 
		}
		if (Input.GetKey("a"))
		{
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange); // buda sol 
		}

		if (rb.position.y < -1f)
		{
			FindObjectOfType<Gamemanager>().EndGame();
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if(isGrounded)
			{
            GetComponent<Rigidbody>().AddForce(Vector3.up*zıplamagucu);	
            isGrounded=false;
			}
			
		}
        
	}
   
  
	
public void zıpla()
    {
        if (isGrounded)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * zıplamagucu);
            isGrounded = false;
        }


    }
	void Android(){ 

		if (ab.sag) {
		
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

		}

		if (ab.sol) {

			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);

		}
	}
	public bool isGrounded;
    public RaycastHit hit;
    public float RayDistance = 2;
    public LayerMask Groundmask;
    public void Update()
    {
        Ray x = new Ray(transform.position, Vector3.down);
		 Debug.DrawRay(x.origin, x.direction * RayDistance,Color.blue);
        if (Physics.Raycast(x,out hit, RayDistance,Groundmask))
        {
            isGrounded = true;
        }
		else
		isGrounded=false;	
    }

}