
using UnityEngine;

public class TankControl 
{
    private TankModel tankModel;
    private TankView tankView;
    private Rigidbody rb;
    public TankControl(TankModel _tankModel,TankView _tankView)
    {
        tankModel = _tankModel;
        tankView = GameObject.Instantiate<TankView>(_tankView);
        rb = tankView.getrigidbody();
        
        
        tankView.SetUpTankController(this);
        tankModel.SetUpTankController(this);

        tankView.ChangeColor(tankModel.color);
    }

    public void Move(float movement,float movementSpeed)
    {
        rb.velocity = tankView.transform.forward * movement * movementSpeed;
    }
    public void Rotate(float rotate,float rotateSpeed)
    {
        Vector3 vector = new Vector3(0f, rotate * rotateSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

    public TankModel GetTankModel()
    {
        return tankModel;
    }
}
