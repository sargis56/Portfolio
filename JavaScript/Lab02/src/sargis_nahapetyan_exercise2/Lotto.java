package sargis_nahapetyan_exercise2;
import java.security.SecureRandom;

public class Lotto {
	
	SecureRandom rand = new SecureRandom(); 
	private int[] randomInt = new int[3];
	
	public Lotto()
	{
		this.randomInt[0] = rand.nextInt( (8) + 1 );
		this.randomInt[1] = rand.nextInt( (8) + 1 );;
		this.randomInt[2] = rand.nextInt( (8) + 1 );;
	}
	
	public int getRandomNumber(int index) {
		return randomInt[index];         
	} 
}
