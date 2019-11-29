package sargis_nahapetyan_exercise2;

import java.util.Scanner; 

public class LottoTest {

	public static void main(String[] args) {
		
		@SuppressWarnings("resource")
		Scanner userInput = new Scanner(System.in);
		int sum; 
		int inNum;
		for (int roll = 1; roll < 6; roll++) {
			Lotto lotto = new Lotto();
			
			sum = lotto.getRandomNumber(0) + lotto.getRandomNumber(1) + lotto.getRandomNumber(2);
			
			System.out.printf("%nRoll: %d%n", roll);
			System.out.printf("%nPlease guess a number between 3 and 27%n");
			//System.out.printf("%nRoll: %d%n%d%n", roll, sum);
			
		    while (!userInput.hasNextInt()) {
		        System.out.println("ERROR: Input not a number, please try agein");
		        
		        userInput.next();

		    }
	        inNum = userInput.nextInt();
	        
	        if (inNum == sum)
	        {
	        	System.out.println("You win!");
	        	break;
	        }
	        else
	        {
	        	System.out.println("Incorrect");
		        if (roll == 5)
		        {
		        	System.out.println("Game Over, computer wins");
		        }
	        }
	        


		}

	}

}
