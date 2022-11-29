using Facility;
public  class Manager : Role
{
    public Manager() 
    {
        _roleName = "Manager";
    }

    protected override void RoleSelection()
    {
        ViewFacility(_availableShop);
    }
}

    

