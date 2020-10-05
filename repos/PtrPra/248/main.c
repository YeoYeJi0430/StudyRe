/*구구단 출력*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(void)
{
	int mul;
	int numstart;
	int numfinish;

	//printf("수를 입력 하세요 : ");
	//scanf("%d", &numstart);

	
	for (int i = 1; i < 10; i++)
	{
		for (int j = 1; j < 10; j++)
		{
			mul = i * j;
			printf("%d*%d = %d ", i, j, mul);
		}
		printf("\n");
	}
	printf("\n");

	system("pause");
	return EXIT_SUCCESS;
}