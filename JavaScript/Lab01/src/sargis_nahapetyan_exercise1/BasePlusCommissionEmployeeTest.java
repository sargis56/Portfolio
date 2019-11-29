package sargis_nahapetyan_exercise1;

public class BasePlusCommissionEmployeeTest {
	public static void main(String[] args) { 

		BasePlusCommissionEmployee employee1 = new BasePlusCommissionEmployee(1, "Cho", "Gall", 34,
				12, 12);
		
		BasePlusCommissionEmployee employee2 = new BasePlusCommissionEmployee(2, "Madden", 23); 
		
		employee1.earnings();
		System.out.printf("Details for employee1: %s%n", employee1.toString());
		
		employee1.setCommissionRate(545);
		employee1.setGrossSales(3424);
		
		System.out.printf("%n%naccount1 ID is: %s%n", employee1.getEmployeeID() 
	    		  + " | First Name is: " + employee1.getFirstName() + " | Last Name is: " 
	    		  + employee1.getLastName()+ " | Commission Rate is: " 
	    		  + employee1.getCommissionRate()+ " | Base Salary is $: " 
	    		  + employee1.getBaseSalary()+ " | Base Salary is :" 
	    	    		  + employee1.getGrossSales());
		
		
		employee2.earnings();
		System.out.printf("Details for employee2: %s%n", employee2.toString());
	} 
}
