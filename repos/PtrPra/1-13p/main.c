#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(void)
{
	int* array = (int*)malloc(4 * sizeof(int));//sizeof(int)=16 ->ũ�Ⱑ 4�� �迭 4ĭ ->16byte
	array[0] = 1;
	array[1] = 2;
	*(array+2) = 3;

	int* tmp = (int*)malloc(8 * sizeof(int));
	for (int i = 0; i < 4; i++)
	{
		tmp[i] = array[i];
	}
	//�迭�� Ű��� ���� ������ �� ū���� �ּҸ� �Ҵ�ް� ���� �迭�� �Ŀ� �Ҵ���������� �ű�°�.
	//for���� array �迭�� �ִ� �����͸� tmp �迭�� �ű�� �ִ°���.

	array = tmp; //tmp�� �������ִ� 8ĭ�迭 �ּҸ� array�� ����,�� �� �����Ͷ� ����
	
	array[4] = 4;
	array[5] = 5;

	printf("%d", array[5]);
	system("pause");
	return EXIT_SUCCESS;
}