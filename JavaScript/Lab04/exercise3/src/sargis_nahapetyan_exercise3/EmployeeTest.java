package sargis_nahapetyan_exercise3;

import java.util.List;
import java.util.ArrayList;
import java.util.Collections;

public class EmployeeTest {

	public static void main(String[] args) {
		List<Employee> list = new ArrayList<>();
		
		Employee employee1 = new Employee("Cho", 122);		
		Employee employee2 = new Employee("Gall", 321); 
		Employee employee3 = new Employee("Glee", 223); 

		list.add(employee1);
		list.add(employee2);
		list.add(employee3);
		
		System.out.printf("Unsorted array elements:%n%s%n", list);
		
		Collections.sort(list, new SalaryComparator());
		
		System.out.printf("%nSorted list elements:%n%s%n", list);
	}

}
