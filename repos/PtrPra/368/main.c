#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void MaxAndMin(int* maxPtr, int* minPtr,int *arr,int size)
{
	int* max, * min;
	int i;

	max = min = &arr[0];

	for ( i = 0; i < size; i++)
	{
		if (*max < arr[i])
		{
			max = &arr[i];
		}
		if (*min > arr[i])
		{
			min = &arr[i];
		}
	}

	*maxPtr = max;
	*minPtr = min;
}

int main(void)
{
	int arr[5];
	int* maxPtr, * minPtr;
	int i;
	
	for(i = 0; i < 5; i++)
	{
		scanf("%d", &arr[i]);
	}

	MaxAndMin(&maxPtr, &minPtr, arr, sizeof(arr) / sizeof(int));

	printf("최대 : %d\n", *maxPtr);
	printf("최소 : %d\n", *minPtr);

	system("pause");
	return EXIT_SUCCESS;
}