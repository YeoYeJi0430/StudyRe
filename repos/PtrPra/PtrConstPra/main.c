#include <stdio.h>
#include <stdlib.h>

int main(void)
{
	int a = 10, b = 20;
	const int* pa = &a;

	printf("a�� ��� : %d\n", *pa);
	
	pa = &b;
	printf("b�� ��� : %d\n", *pa);

	pa = &a;
	a = 30;
	printf("30��� �����Ѱ� : %d\n", * pa);

	system("pause");
	return EXIT_SUCCESS;
}