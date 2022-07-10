
using UnityEngine;

public class TankControl 
{
    private TankModel tankModel;
    private TankView tankView;

    public TankControl(TankModel _tankModel,TankView _tankView)
    {
        tankModel = _tankModel;
        tankView = _tankView;

        tankView.SetUpTankController(this);
        tankModel.SetUpTankController(this);

        GameObject.Instantiate(tankView.gameObject);
    }
}
