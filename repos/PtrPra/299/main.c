#include <stdio.h>
#include <stdlib.h>
#include <string.h>
 
/* 1��
���̰� 5�� int�� �迭 arr�� �����ϰ� �̸� 1,2,3,4,5�� �ʱ�ȭ�� ����,
�� �迭�� ù ��° ��Ҹ� ����Ű�� ������ ���� ptr�� �����Ѵ�. �� ���� ������ ���� ptr
�� ����� ���� ������Ű�� ������ ������ ������� �迭��ҿ� �����ϸ鼭 ��� �迭����� ���� 2�� ���� ��Ű��,
���������� ������ �̷������� Ȯ��
int main(void)
{
	int arr[5] = { 1,2,3,4,5 };
	int* ptr = arr;

	for (int i = 0; i < 5; i++)
	{
		*ptr += 2;
		ptr++;
	}
	
	for (int i = 0; i < 5; i++)
	{
		printf("%d ", arr[i]);
	}
	printf("\n");
	
	system("pause");
	return EXIT_SUCCESS;
}
*/

/*2��
������ ���� ptr�� ����� ���� �����Ű�� �ʰ�, ptr�� ������� ���������� �Ͽ�,
�� ����� ��ȯ�Ǵ� �ּ� ���� ���ؼ� ��� �迭��ҿ� �����Ͽ� ���� 2�� ������Ű�� ������ �ۼ�
int main(void)
{
	int arr[5] = { 1,2,3,4,5 };
	int* ptr = arr;

	for (int i = 0; i < 5; i++)
	{
		*(ptr + i) += 2;
	}

	for (int i = 0; i < 5; i++)
	{
		printf("%d ", arr[i]);
	}
	printf("\n");
	system("pause");
	return EXIT_SUCCESS;
}
*/

/*3��
���̰� 5�� int�� �迭 arr�� �����ϰ� �̸� 1,2,3,4,5�� �ʱ�ȭ�� ����, �� �迭�� ������ ��Ҹ�
����Ű�� ������ ���� ptr�� �����Ѵ�. �� ���� ������ ���� ptr�� ����� ���� ���ҽ�Ű��
������ ������ ������� ��� �迭��ҿ� �����Ͽ�, �迭�� ����� ��� ������ ���Ͽ� �� ����� ����ϴ�
���α׷�
int main(void)
{
	int arr[5] = { 1,2,3,4,5 };
	int* ptr;
	int sum = 0;

	for (int i = 4; i > -1; i--)
	{
		ptr = &arr[i];
		sum += *ptr;

	}
	printf("%d\n", sum);
	
	system("pause");
	return EXIT_SUCCESS;
}
*/

/*4��
���̰� 6�� int�� �迭 arr�� �����ϰ� �̸� 1,2,3,4,5,6���� �ʱ�ȭ�� ����, �迭�� ����� ���� ������ 6,5,4,3,2,1�� �ǵ��� �����ϴ� ����
int main(void)
{
	int arr[6] = { 1,2,3,4,5,6 };
	int* pfarr = &arr[0]; // pointer first arr
	int* plarr = &arr[5]; // pointer last arr
	int temp;

	for (int i = 0; i < 3; i++)
	{
		temp = *pfarr;
		*pfarr = *plarr;
		*plarr = temp;

		pfarr += 1;
		plarr -= 1;
	}

	for (int i = 0; i < 6; i++)
	{
		printf("%d ", arr[i]);
	}


	system("pause");
	return EXIT_SUCCESS;
}
*/