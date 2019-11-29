package sargis_nahapetyan_exercise1;

public class BasePlusCommissionEmployee {
	   private int employeeID; 
	   private String firstName;
	   private String lastName;
	   private double baseSalary =  200.00;
	   private double grossSales;
	   private double commissionRate = 0.1;
	   
	   public BasePlusCommissionEmployee(int employeeID, String firstName, String lastName,
			   double baseSalary, double grossSales, double commissionRate) {
		   this.employeeID = employeeID;
		   this.firstName = firstName;
		   this.lastName = lastName;	   
		   this.baseSalary = baseSalary;
		   this.grossSales = grossSales;
		   this.commissionRate = commissionRate;
	   }      
	   
	   public BasePlusCommissionEmployee(int employeeID, String firstName, double baseSalary) {
		   this.employeeID = employeeID;
		   this.firstName = firstName;	   
		   this.baseSalary = baseSalary;
	   }  
	   
	 //Getters
	   public int getEmployeeID() {
		   return employeeID;         
	   }   
	   
	   public String getFirstName() {    
		   if (this.firstName != null)
		   {
			   return firstName; 
		   }
		   else
		   {
			   return this.firstName = "";
		   }
	   }   
	   
	   public String getLastName() {
		   
		   if (this.lastName != null)
		   {
			   return lastName; 
		   }
		   else
		   {
			   return this.lastName = "";
		   }
	   }   
	   
	   public double getBaseSalary() {
		   return baseSalary;         
	   }   
	   
	   public double getGrossSales() {
		   return grossSales;         
	   }  
	   
	      
	   public double getCommissionRate() {
		   return commissionRate;
		           
	   }  
	   
	   //Setters
	   public void setGrossSales(double grossSales) { 	   
		   if (grossSales >= 0) 
		   {
			   this.grossSales = grossSales;
		   }
	   } 
	   
	   public void setCommissionRate(double commissionRate) { 		   
		   if ((commissionRate >= 0.1) && (commissionRate <= 1.0))
		   {
			   this.commissionRate = commissionRate;
		   }
	   } 
	   
	   //Methods
	   public double earnings() { 
		   // commission rate * gross sales + base salary
		   return (commissionRate * grossSales) + baseSalary;
	   } 
	   
	   public String toString() { 
			return String.format("%nEmployee ID: %d"
					+ "%nFirst Name: %s"
					+ "%nLast Name: %s"
					+ "%nCommission Rate: %.2f"
					+ "%nGross Sales: %.2f"
					+ "%nBase Salary: $%.2f"
					+ "%nEarnings: $%.2f",
					employeeID, firstName, lastName, commissionRate, grossSales, baseSalary, earnings() );
	   } 
}
