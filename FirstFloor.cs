namespace One_night_at_Triangelen;

public class FirstFloor:Location
{
    public FirstFloor()
    {
        Description = "You are on the first floor. You can see an escalator going up and a main exit going outside.";
        _menu = new Menu(this);
    }
    
    public override void HandleResponse(string response)
    {
        switch (response)
        {
            case("enter escallator"):
                new Escallator();
                break;
            case("go out"):
                new Outside();
                break;
        }
    }
}