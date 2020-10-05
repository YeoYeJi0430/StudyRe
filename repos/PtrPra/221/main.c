#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int Max(int a,int b,int c);
int Min(int a,int b,int c);

int main(void)
{
	int a, b, c;

	printf("세 개의 정수를 입력 하세요 : ");
	scanf("%d%d%d", &a, &b, &c);

	printf("가장 큰 수 : %d\n", Max(a,b,c));
	printf("가장 작은 수 : %d\n", Min(a,b,c));

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
