// Fig. 10.14: PayableInterfaceTest.java
// Payable interface test program processing Invoices and 
// Employees polymorphically.

package sargis_nahapetyan_exercise3;

public class PayableInterfaceTest {
   public static void main(String[] args) {
      // create four-element Payable array
      Payable[] payableObjects = new Payable[] {
         new Invoice("01234", "seat", 2, 375.00),
         new Invoice("56789", "tire", 4, 79.95),
         new SalariedEmployee("John", "Smith", "111-11-1111", 800.00),
         //new SalariedEmployee("Lisa", "Barnes", "888-88-8888", 1200.00)
         new HourlyEmployee("John", "Do", "444-44-4444", 30, 45),
         new CommissionEmployee("Sue", "Jones", "333-33-3333", 10000, .06),
         new BasePlusCommissionEmployee("Bob", "Lewis", "444-44-4444", 5000, .04, 300), 
      };

      System.out.println(
         "Invoices and Employees processed polymorphically:"); 

      for (Payable currentPayable : payableObjects) {
    	  
    	  if (currentPayable instanceof BasePlusCommissionEmployee)
    	  {
    		  ((BasePlusCommissionEmployee) currentPayable).setBaseSalary(
    				  ((BasePlusCommissionEmployee) currentPayable).getBaseSalary() +
    						  ((BasePlusCommissionEmployee) currentPayable).getBaseSalary() * 0.1);
    	  }
    	  if (currentPayable instanceof HourlyEmployee)
    	  {
    		  ((HourlyEmployee) currentPayable).setHourlySalary(
    				  ((HourlyEmployee) currentPayable).getHourlySalary() + 2);
    	  }
    	  
         // output currentPayable and its appropriate payment amount
         System.out.printf("%n%s %npayment due: $%,.2f%n", 
            currentPayable.toString(), // could invoke implicitly
            currentPayable.getPaymentAmount()); 
      } 
   } 
} 

