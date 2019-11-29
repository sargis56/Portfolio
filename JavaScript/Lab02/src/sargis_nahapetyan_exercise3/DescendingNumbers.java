package sargis_nahapetyan_exercise3;

import java.util.Arrays;

public class DescendingNumbers {
	
	
	public DescendingNumbers()
	{

	}
	
       
	public static void SortNumbers(int... numbers)
	{
	
		int[] number = numbers;
		
		Arrays.sort(number);
		
		for (int i = number.length -1; i >= 0 ; i--) 
        {
			System.out.printf("%n%d ", number[i]);
        }

	}
}
