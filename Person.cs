using System;

namespace TestingPractice
{

public class Person

{
    private int firstNum;
    private int secondNum;

	public Person(int first, int second)
	{
        firstNum = first;
        secondNum = second;

	}

    public int addTwoNumbers(int num1, int num2)
    {
        int answer = (num1+num2);

        return answer;
    }
}
}