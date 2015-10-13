
#pragma strict

var target : Transform;

var smoothTime = 0.3;

private var thisTransform : Transform;
private var velocity : Vector2;

 
    
function Start()
{
    thisTransform = transform;
  


}
    function Update() 
{
        
        //var dist = (target.position - Camera.main.transform.position).z;
        //var leftBorder = Camera.main.ViewportToWorldPoint(Vector3(0,0,dist)).x;
        //var rightBorder = Camera.main.ViewportToWorldPoint(Vector3(1,0,dist)).x;

        //Debug.Log(leftBorder);
       


        thisTransform.position.x = Mathf.SmoothDamp( thisTransform.position.x, target.position.x, velocity.x, smoothTime);
        thisTransform.position.y = Mathf.SmoothDamp( thisTransform.position.y, target.position.y, velocity.y, smoothTime);

   
    }
