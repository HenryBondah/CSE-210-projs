public class car {
    // instance
    public string brand;
    public int miles;
    public string color;    

    // constructor
    public car (){

    }


    // Methods (functions)
    public void move_forward(){

        // return "is running";
        Console.WriteLine(" is running ");
    }

    public void displayInfo(){
        Console.Write($" brand: {brand} Miles: {miles} color: {color}");
    }
}