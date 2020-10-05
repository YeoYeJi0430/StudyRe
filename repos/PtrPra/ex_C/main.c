#include <stdio.h>
#include <stdlib.h>

int main(void)
{
	//here.
	int i;
	int j;
	for (i = 0; i < 6; i++)
	{
		for (j = 0; j <= i; j++)
		{
			printf("*");
		}
		printf("\n");
	}
	system("pause");
	return EXIT_SUCCESS;
}