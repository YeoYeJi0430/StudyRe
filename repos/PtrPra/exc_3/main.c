#include <stdio.h>
#include <stdlib.h>

int main(void)
{
	//here.
	int a;
	scanf("%d", &a);
	switch (a)
	{
	case 0:
		printf("good");
		break;
	case 1:
		printf("no");
		break;
	}
	system("pause");
	return EXIT_SUCCESS;
}