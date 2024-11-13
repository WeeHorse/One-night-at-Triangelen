namespace One_night_at_Triangelen;

public class ToiletStall:Location
{
    List<Object> _exits = new List<Object>();
    
    public override void HandleResponse(string response)          
    {                                                    
        switch (response)                                
        {                                                
            case("open door"):                           
                Console.WriteLine("opening door");       
                new LadiesRoom();                        
                break;                                   
        }                                                
    }                                                    

    public ToiletStall():base() // constructor
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