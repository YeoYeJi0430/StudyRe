#include <stdio.h>
#include <stdlib.h>

int main(void)
{
	//here.
	int x, y, z;

	for (x = 0; x <= 5; x++)
	{
		for (z = 0; z <= x; z++)
		{
			printf(" ");
		}
		
		for (y = 5; y > x; y--)
		{
			printf("*");
		}
		printf("\n");

	}


	system("pause");
	return EXIT_SUCCESS;
}