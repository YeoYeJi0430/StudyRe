#include <stdio.h>
#include <stdlib.h>

void swap(int a, int b);

int main(void)
{
	int a = 10, b = 15;

	printf("a : %d, b : %d\n", a, b);

	swap(a,b);

	printf("a : %d, b : %d\n", a, b);
	system("pause");
	return EXIT_SUCCESS;
}

void swap(int a, int b)
{
	int temp;
	
	temp = a;
	a = b;
	b = temp;

	return(a, b);
}