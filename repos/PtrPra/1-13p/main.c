#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(void)
{
	int* array = (int*)malloc(4 * sizeof(int));//sizeof(int)=16 ->크기가 4인 배열 4칸 ->16byte
	array[0] = 1;
	array[1] = 2;
	*(array+2) = 3;

	int* tmp = (int*)malloc(8 * sizeof(int));
	for (int i = 0; i < 4; i++)
	{
		tmp[i] = array[i];
	}
	//배열을 키우는 것은 공간이 더 큰곳에 주소를 할당받고 원래 배열을 후에 할당받은곳으로 옮긴는것.
	//for문은 array 배열에 있던 데이터를 tmp 배열로 옮기고 있는것임.

	array = tmp; //tmp가 가지고있는 8칸배열 주소를 array에 대입,둘 다 포인터라서 가능
	
	array[4] = 4;
	array[5] = 5;

	printf("%d", array[5]);
	system("pause");
	return EXIT_SUCCESS;
}