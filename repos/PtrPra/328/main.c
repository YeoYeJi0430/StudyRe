#include <stdio.h>
#include <stdlib.h>
#include <string.h>

/*1��
���̰� 10�� �迭�� �����ϰ� �� 10���� ������ �Է� �޾Ƽ�, Ȧ���� ¦���� ���� ���� ����ϴ�
���α׷��ۼ�
void even_num(int *num)
{
	printf("¦�� : ");
	for (int i = 0; i < 10; i++)
	{
		if (num[i] % 2 == 0)
		{
			printf("%d ", num[i]);
		}
	}
}

void uneven_num(int *num)
{
	printf("Ȧ�� : ");
	for (int i = 0; i < 10; i++)
	{
		if (num[i] % 2 == 1)
		{
			printf("%d ", num[i]);
		}
	}
}

int main(void)
{
	int num[10] = { 0,1,2,3,4,5,6,7,8,9 };

	even_num(&num);
	printf("\n");
	uneven_num(&num);
	printf("\n");

	system("pause");
	return EXIT_SUCCESS;
}
*/

/*
2��
���α׷� ����ڷκ��� 10���� ���·� ������ �ϳ� �Է� ���� ����, �̸� 2������ ��ȯ�ؼ�
����ϴ� ���α׷�
int main(void)
{
	int i, j;
	int num;
	int rest[20];
	
	scanf("%d", &num);
	
	for (i = 0; num > 0; i++)
	{
		rest[i] = num % 2;
		num = num / 2;
	}

	for (j = i-1; j >= 0; j--)
	{
		printf("%d ", rest[j]);
	}

	//for (int i = 0; i < 4; i++)
	//{
	//	rest[i] = num_10 % 2;
	//	num_10 = num_10/2;
	//}
	//for (int i = 0; i < 4; i++)
	//{
	//	printf("%d", rest[i]);
	//}

	system("pause");	
	return EXIT_SUCCESS;
}
*/

/*3��
���̰� 10�� �迭�� �����ϰ� �� 10���� ������ �Է� �޴´�. ��, �Է� ���� ���ڰ�
Ȧ���̸� �迭�� �տ������� ä������, ¦���̸� �ڿ������� ä�������� ����
int main(void)
{
	int in_num[10];
	int out_num[10];
	int a = 0;
	int b = 9;
	int i,j;
	for (i = 0; i < 10; i++)
	{
		printf("�Է� : ");
		scanf("%d", &in_num[i]);
	}
	for (i = 0; i < 10; i++)
	{
		if (in_num[i] % 2 == 1)
		{
			out_num[a] = in_num[i];
			a++;
		}

		else if(in_num[i] % 2 == 0)
		{
			out_num[b] = in_num[i];
			b--;
		}
	}
	printf("�迭 ����� ��� : ");
	for ( i = 0; i < 10; i++)
	{
		printf("%d ", out_num[i]);
	}
	

	system("pause");
	return EXIT_SUCCESS;
}
*/