namespace One_night_at_Triangelen;

public class ToiletStall:Location
{
    List<Object> _exits = new List<Object>();

    public ToiletStall() // constructor
    {
        Description = "You wake up in a toilet stall, but you have no memory of how you got here or where you are. There is a door.";
        _exits.Add(new LadiesRoom());
        _menu = new Menu(this);
    }

    private Menu _menu;
    public Menu GetMenu()
    {
        return _menu;
    }
}