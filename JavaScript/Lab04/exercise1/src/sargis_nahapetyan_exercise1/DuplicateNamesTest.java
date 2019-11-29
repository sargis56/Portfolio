package sargis_nahapetyan_exercise1;

import java.util.List;
import java.util.Scanner;
import java.util.Arrays;
import java.util.HashSet;
import java.util.Set;
import java.util.Collection;

public class DuplicateNamesTest {
	public static void main(String[] args) {
		   @SuppressWarnings("resource")
		   Scanner userInput = new Scanner(System.in);
		   
		String findWord;   
		  
	    // create and display a List<String>
	    String[] names = {"bigguis", "sickus", "dickus", "madden", "john", 
	       "pee", "dee", "lee", "mee", "dickus", "noon", "jing"};
	    List<String> list = Arrays.asList(names);
	    System.out.printf("List: %s%n", list);

	    removeDuplicates(list);
	    
	    System.out.printf("%nPlease search for a name: %n");
	    while (userInput.hasNext()) {
	    	
	    	findWord = userInput.next();
		    searchForName(findWord, list);
	    }  
	    
        
	}
	
	private static void removeDuplicates(Collection<String> values) {
		Set<String> set = new HashSet<>(values);
		System.out.printf("%n<Duplicates Removed> %nCurrent List: ");

		for (String names : set) {
	         System.out.printf("%s ", names);
		}

		System.out.println();
	} 
	
	
	public static void searchForName(String name, Collection<String> values)
	{
		// Name: <Name>
		int index = ((List<String>) values).indexOf(name);
		
        if (index > 0)
        {
        	System.out.println("Name: <" + name + "> had been found");
        }
        else
        {
       	System.out.println("ERROR: No name found");
        }
		
		System.out.printf("%nPlease search for a name: %n");
	}
}
