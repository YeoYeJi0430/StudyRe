#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int Max(int a,int b,int c);
int Min(int a,int b,int c);

int main(void)
{
	int a, b, c;

	printf("�� ���� ������ �Է� �ϼ��� : ");
	scanf("%d%d%d", &a, &b, &c);

	printf("���� ū �� : %d\n", Max(a,b,c));
	printf("���� ���� �� : %d\n", Min(a,b,c));

	system("pause");
	return EXIT_SUCCESS;
}

int Max(int a, int b, int c)
{
	if (a>b)
	{
		return (a > c) ? a : c;
	}
	else
	{
		return (b > c) ? b : c;
	}
	
}

int Min(int a, int b, int c)
{
	if (a<b)
	{
		return (a < c) ? a : c;
	}
	else
	{
		return (b < c) ? b : c;
	}
}
