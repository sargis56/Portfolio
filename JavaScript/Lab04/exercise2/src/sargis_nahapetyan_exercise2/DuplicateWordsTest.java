package sargis_nahapetyan_exercise2;

import java.util.HashSet;
import java.util.Set;

public class DuplicateWordsTest {

	public static void main(String[] args) {
		
		int id = 1;
		String sentence1 = "B, b a d. a c,c,c,c.c c c t2, 12, 2";
		String sentence2 = "My faith is in my faith, that I once had. To begin the life that i onced use to have.";
		
		Set<String> duplicates = findDuplicateWord(sentence1); 
		int dupeNum = findDuplicatesNum(sentence1);
		
		System.out.println(id + ". Sentence used: " + sentence1); 
		System.out.println(id + ". Duplicate words found: " + duplicates);
		System.out.println(id +". Number of duplicate words in the sentence: " + dupeNum);
		
		duplicates = findDuplicateWord(sentence2); 
		dupeNum = findDuplicatesNum(sentence2);
		id++;
		System.out.println("\n" + id + ". Sentence used: " + sentence2); 
		System.out.println(id + ". Duplicate words found: " + duplicates);
		System.out.println(id +". Number of duplicate words in the sentence: " + dupeNum);	
		
	    
	}
	
	public static Set<String> findDuplicateWord(String sentence){
			
		Set<String> dups = new HashSet<>();
		
		String[] words = sentence.replaceAll("[^a-zA-Z ]", "").toLowerCase().split("\\s+");
		Set<String> set = new HashSet<>();
		
		for(String item : words)
		{ 
			if(!set.add(item))
			{ 
				dups.add(item); 
			} 
			
		}
		
		return dups;
	}
	
	public static int findDuplicatesNum(String sentence){
		
		int num = 0;
		
		String[] words = sentence.toLowerCase().replaceAll("[^a-zA-Z ]", "").split("\\s+");
		Set<String> set = new HashSet<>();
		
		for(String item : words)
		{ 
			if(!set.add(item))
			{ 
				num++;
			} 
			
		}
		
		return num;
	}

}
