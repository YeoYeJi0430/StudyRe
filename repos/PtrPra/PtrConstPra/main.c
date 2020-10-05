#include <stdio.h>
#include <stdlib.h>

int main(void)
{
	int a = 10, b = 20;
	const int* pa = &a;

	printf("a값 출력 : %d\n", *pa);
	
	pa = &b;
	printf("b값 출력 : %d\n", *pa);

	pa = &a;
	a = 30;
	printf("30출력 가능한가 : %d\n", * pa);

	system("pause");
	return EXIT_SUCCESS;
}