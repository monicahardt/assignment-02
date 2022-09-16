namespace Assignment2;

public class Student{

    public int Id{ get; init; }
    public string? GivenName;
    public string SurName ;
    
    public Status Status { get; init;}

    public DateTime StartDate ;
    
    public DateTime EndDate ;

public  DateTime GraduationDate;

    
    public override String ToString(){
        return $"Id: {Id} GivenName: {GivenName} SurName: {SurName} Status: {Status} StartDate: {StartDate.ToString("yyyy'-'MM'-'dd")} EndDate: {EndDate.ToString("yyyy'-'MM'-'dd")} GraduationDate: {GraduationDate.ToString("yyyy'-'MM'-'dd")}";
    }


}   

