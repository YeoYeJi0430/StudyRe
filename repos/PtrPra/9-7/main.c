#include <stdio.h>
#include <stdlib.h>

void swap(int* pa, int* pb);

int main(void)
{
	int a = 10, b = 15;
	
	printf("�ٲ���� a : %d, b : %d\n", a, b);

	swap(&a, &b);

	printf("�ٲ� �� a : %d, b : %d\n", a, b);

	system("pause");
	return EXIT_SUCCESS;
}

void swap(int* pa, int* pb)
{
	int temp;

	temp = *pb;
	*pb = *pa;
	*pa = temp;
}