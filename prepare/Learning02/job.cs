public class Job {
    // instance
    public string _company;
    public string _jobTitle;     
    public int _startYear;
    public int _endYear;    


    // constructor
    public Job(){
    }

    // Methods (functions)
    public void status(){

        Console.WriteLine(" You are still working. ");
    }

    public void displayInfo(){
        Console.Write($"{_company} {_jobTitle} {_startYear}-{_endYear}" );
    }
}