#include <stdio.h>
#include <stdlib.h>
#include <string.h>


int main(void)
{
	int num[5];
	int max, min, sum;

	max = num[0];
	min = num[0];

	printf("5���� ������ �Է��ϼ��� : ");
	for (int i = 0; i < 5; i++)
	{
		scanf("%d", &num[i]);
	}

	for (int i = 0; i < 5; i++)
	{
		if (num[i]>max)
		{
			max = num[i];
		}
		if (num[i] < min)
		{
			min = num[i];
		}
	}

	

	printf("�ִ� : %d\n", max);
	printf("�ּڰ� : %d\n", min);

	system("pause");
	return EXIT_SUCCESS;
}