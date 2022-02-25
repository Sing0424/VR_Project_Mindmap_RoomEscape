var onhand : Transform;

function  Update () {

}

function OnMouseDown () {
	GetComponent.<Rigidbody>().useGravity = false;
	this.transform.position = onhand.position;
	this.transform.parent = GameObject.Find("player").transform;
	this.transform.parent = GameObject.Find("Camera").transform;
}

function OnMouseUp (){
	this.transform.parent = null;
	GetComponent.<Rigidbody>().useGravity = true;
}