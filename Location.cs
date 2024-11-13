namespace One_night_at_Triangelen;

public abstract class Location
{
    public string Description;

    protected Menu _menu; 

    public abstract void HandleResponse(string response);
}