package sargis_nahapetyan_exercise1;

public class HourlyEmployee extends Employee {
	private double hourlyHours;
	private double hourlySalary;
	
	public HourlyEmployee(String firstName, String lastName, String socialSecurityNumber, double hourlySalary, double hourlyHours) {
		super(firstName, lastName, socialSecurityNumber);
		
	      if (hourlySalary < 0.0) {
	          throw new IllegalArgumentException(
	             "Hourly salary must be >= 0.0");
	       }
	     
	      
	       this.hourlySalary = hourlySalary;
	       this.hourlyHours = hourlyHours;
	}
	
	// set salary
	   public void setHourlySalary(double hourlySalary) {
	      if (hourlySalary < 0.0) {
	         throw new IllegalArgumentException(
	            "Hourly salary must be >= 0.0");
	      }

	      this.hourlySalary = hourlySalary;
	   } 

	   // return salary
	   public double getHourlySalary() {return hourlySalary;}
	
	   public double getHourlyHours() {return hourlyHours;}
	   
	   @Override
	   public double earnings() {
		    if (getHourlyHours() <= 40){ 
		    	return (getHourlySalary() * getHourlyHours()); 
		    }
		    else
		    {
		    	return 40 * getHourlySalary() + ( getHourlyHours() - 40 ) * getHourlySalary() * 1.5;
		    }
		                         
		   }                                                                   

	
	   @Override                                                   
	   public String toString() {                                  
		      return String.format("%s: %s%n%s: $%,.2f; %s: %.2f",     
		         "Hourly employee", super.toString(),              
		         "Hourly sales", getHourlySalary(),                                             
		         "Hourly hours", getHourlyHours());              
		   } 
}
