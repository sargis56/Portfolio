package sargis_nahapetyan_exercise3;

import java.util.Comparator;

public class SalaryComparator implements Comparator<Employee> {

    @Override
    public int compare(Employee employee1, Employee employee2) {
    	if ((employee1.getSalary() <= 0) && (employee2.getSalary() <= 0)) 
    	{
    		return 0;
    	}
    	else if (employee1.getSalary() <= 0)
    	{
    		return -1;
    	}
    	else if (employee2.getSalary() <= 0)
    	{
    		return 1;
    	}
    	else if (employee1.getSalary() < employee2.getSalary())
    	{
    		return 1;
    	}
    	else if (employee1.getSalary() > employee2.getSalary())
    	{
    		return -1;
    	}
    	else
    	{
    		return 0;
    	}
    	
    }
	
}
