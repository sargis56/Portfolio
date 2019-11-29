package sargis_nahapetyan_exercise2;

public class CheckingAccount {
	   private int accountNumber; 
	   private String customerName;
	   private double accountBalance;
	   
	   public CheckingAccount(int accountNumber, String customerName, double accountBalance) {
		   this.accountNumber = accountNumber;
		   this.accountBalance = accountBalance;	   
		   this.customerName = customerName;
	   }  
	   
	   //Getters
	   public int getAccountNumber() {
		   return accountNumber;         
	   }   
	   
	   public String getCustomerName() {
		   return customerName;         
	   }
	   
	   public double getAccountBalance() {
		   return accountBalance;        
	   }
	   
	   //Setters
	   public void setAccountBalance(double accountBalance) { 
		   if (accountBalance >= 50){
			   this.accountBalance = accountBalance;
		   }	   
	   } 
	   
	   //Methods
	   public double withdraw(double amount) {		   
		   if (getAccountBalance() >= 50 + (amount + 3)){
			   return amount - this.accountBalance - 3;
		   }
		   else
		   {
			 return 0;
		   }
	   } 
	   
	   public String toString() { 
			return String.format("%nAccount Number: %d"
					+ "%nCustomer Name: %s"
					+ "%nAccount Balance:  %.2f",
					accountNumber, customerName, accountBalance);
	   } 
}
