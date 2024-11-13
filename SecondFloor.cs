namespace One_night_at_Triangelen;

public class SecondFloor:Location
{
    public SecondFloor()
    {
        Description =
            "You are on the second floor in what you recognize as Triangelen. There is an escallator and an entrance to the Ladies room.";
        _menu = new Menu(this);
    }
    
    public override void HandleResponse(string response)
    {
        switch (response)
        {
            case("enter escallator"):
                new Escallator();
                break;
            case("enter ladies room"):
                new LadiesRoom();
                break;
            
        }
    }
}