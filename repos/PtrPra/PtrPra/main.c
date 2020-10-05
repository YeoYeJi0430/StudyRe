#include <stdio.h>
#include <stdlib.h>

int main(void)
{
	int a;
	int* pa;

	pa = &a;
	*pa = 10;

	printf("%d\n", *pa);

	system("pause");
	return EXIT_SUCCESS;
}