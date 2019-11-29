package sargis_nahapetyan_exercise3;

public class Employee {
	
	   private String name;
	   private double salary;

	   public Employee(String name, double salary) {
	      this.name = name;
	      this.salary = salary;
	   } 
	   
	   public String getName() 
	   {
		   return name;
	   }

	   public double getSalary() 
	   {
		   return salary;
	   }
	   
	   public void setName(String name) 
	   {
		   this.name = name;
	   }

	   public void setSalary(double salary) 
	   {
		   this.salary = salary;
	   }
	   
	   public String toString() { 
			return String.format("%nName: %s"
					+ "%nSalary:  %.2f",
					name, salary);
	   } 
	   
}
