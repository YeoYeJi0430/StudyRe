#include <stdio.h>
#include <stdlib.h>
#include <string.h>

/*1번
int main(void)
{
	int num = 10;
	int* ptr1 = &num;
	int* ptr2 = ptr1;

	(*ptr1)++;
	(*ptr2)++;

	printf("%d\n", num);
	system("pause");
	return EXIT_SUCCESS;
}
*/

/*2번
int main(void)
{
	int num1 = 10;
	int num2 = 20;

	printf("%d %d\n", num1, num2);

	int* pnum1 = &num1;
	int* pnum2 = &num2;

	(*pnum1)++;
	(*pnum2)--;

	printf("증감 : %d %d\n", *pnum1, *pnum2);

	pnum1 = &num2;
	pnum2 = &num1;

	printf("교환 : %d %d\n", *pnum1, *pnum2);

	system("pause");
	return EXIT_SUCCESS;
}
*/