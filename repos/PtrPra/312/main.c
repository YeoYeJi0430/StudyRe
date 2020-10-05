#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void ShowArayElem(int* param, int len)
{
	for (int i = 0; i < len; i++)
	{
		printf("%d ", param[i]);
	}
	printf("\n");
}

void AddArayElem(int* param, int len, int add)
{
	for (int i = 0; i < len; i++)
	{
		param[i] += add;
	}
}

int main(void)
{
	int arr1[3] = { 1,2,3 };
	
	AddArayElem(arr1, sizeof(arr1) / sizeof(int), 1);
	ShowArayElem(arr1, sizeof(arr1) / sizeof(int));

	system("pause");
	return EXIT_SUCCESS;
}