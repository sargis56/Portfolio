package sargis_nahapetyan_exercise2;

public class CheckingAccountTest {
		public static void main(String[] args) { 

		CheckingAccount customer1 = new CheckingAccount(1, "Cho", 34333);
		
		CheckingAccount customer2 = new CheckingAccount(2, "Gall", 2312313); 
		
		
		System.out.printf("Details for customer1: %s%n", customer1.toString());
		customer1.withdraw(100);
		customer1.setAccountBalance(1);
		
		System.out.printf("%n%ncustomer1 number is: %s%n", customer1.getAccountNumber() 
	  		  + " | Name is: " + customer1.getCustomerName() + " | Balance is $: " 
	  		  + customer1.getAccountBalance());
		
		
		customer2.setAccountBalance(20);
		System.out.printf("Details for customer2: %s%n", customer2.toString());
		customer2.withdraw(4);
		
		System.out.printf("%n%ncustomer2 number is: %s%n", customer2.getAccountNumber() 
		  		  + " | Name is: " + customer2.getCustomerName() + " | Balance is $: " 
		  		  + customer2.getAccountBalance());
	}
}
