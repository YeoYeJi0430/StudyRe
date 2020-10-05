#include <stdio.h>
#include <stdlib.h>
#include <string.h>

/*1번
길이가 10인 배열을 선언하고 총 10개의 정수를 입력 받아서, 홀수와 짝수를 구분 지어 출력하는
프로그램작성
void even_num(int *num)
{
	printf("짝수 : ");
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
	printf("홀수 : ");
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
2번
프로그램 사용자로부터 10진수 형태로 정수를 하나 입력 받은 다음, 이를 2진수로 변환해서
출력하는 프로그램
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

/*3번
길이가 10인 배열을 선언하고 총 10개의 정수를 입력 받는다. 단, 입력 받은 숫자가
홀수이면 배열의 앞에서부터 채워가고, 짝수이면 뒤에서부터 채워나가는 형식
int main(void)
{
	int in_num[10];
	int out_num[10];
	int a = 0;
	int b = 9;
	int i,j;
	for (i = 0; i < 10; i++)
	{
		printf("입력 : ");
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
	printf("배열 요소의 출력 : ");
	for ( i = 0; i < 10; i++)
	{
		printf("%d ", out_num[i]);
	}
	

	system("pause");
	return EXIT_SUCCESS;
}
*/