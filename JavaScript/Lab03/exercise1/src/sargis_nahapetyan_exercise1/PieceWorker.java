package sargis_nahapetyan_exercise1;

public class PieceWorker extends Employee {

	private double weeklyWage;
	private double pieces;
	
	   // constructor
	   public PieceWorker(String firstName, String lastName, 
	      String socialSecurityNumber, double weeklyWage, double pieces) {
	      super(firstName, lastName, socialSecurityNumber); 

	      if (weeklyWage < 0.0) {
	         throw new IllegalArgumentException(
	            "Weekly wage must be >= 0.0");
	      }

	      this.weeklyWage = weeklyWage;
	      this.pieces = pieces;
	   } 
	   
	   public void setWeeklyWage(double weeklyWage) {
		      if (weeklyWage < 0.0) {
		         throw new IllegalArgumentException(
		            "Weekly wage must be >= 0.0");
		      }

		      this.weeklyWage = weeklyWage;
		   } 
	   
	   public void setPieces(double pieces) {
		      this.pieces = pieces;
		   } 
	   
	   public double getWeeklyWage() 
	   {
		   return weeklyWage;
	   }

	   
	   public double getPieces() 
	   {
		   return pieces;
	   }

	   @Override                                                           
	   public double earnings() 
	   {
		   return (getPieces() * getWeeklyWage()) * getPieces();
	   }
	   
	   @Override                                                   
	   public String toString() {                                  
	      return String.format("salaried employee: %s%n%s: $%,.2f; %s: %.2f",
	         super.toString(), "weekly wage", getWeeklyWage(),              
	         "pieces", getPieces());
	   }  
}
