namespace One_night_at_Triangelen;

public class ToiletStall:Location
{
    
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
        _menu = new Menu(this);
    }
    
}