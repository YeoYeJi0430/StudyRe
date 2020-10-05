#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int calculate_sum(int* array);

int main(void)
{
	int sum, average;
	int num[10];
	for (int i = 0; i < 10; i++)
	{
		scanf("%d", &num[i]);
	}
	sum = calculate_sum(num);
	average = sum / 10;
	printf("%d\n", average);

	system("pause");
	return EXIT_SUCCESS;
}

int calculate_sum(int* array) // int calculate_sum(int array[])µµ °¡´É
{
	int sum = 0;
	for (int i = 0; i < 10; i++)
	{
		sum = sum + array[i]; // instead of *(array+i)
	}
	return sum;
}