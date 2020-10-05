#include <stdio.h>
#include <stdlib.h>
#include <string.h>

/*1번
가로의 길이가 9, 세로의 길이가 3인 int형 2차원 배열을 선언하여
구구단 중 2단,3단,4단을 저장.

int main(void)
{
	int num[3][9];
	int i,j;
	
	//for ( i = 2; i < 5; i++)
	//{
	//	for (j = 0; j < 3; j++)
	//	{
	//		row = j;
	//		if (col == 10)
	//		{
	//			col = 0;
	//		}
	//		out = i * (col + 1);
	//		num[row][col] = out;
	//		col++;
	//	}
	//	
	//}
	
	for ( i = 0; i < 3; i++)
	{
		for (j = 0; j < 9; j++)
		{
			num[i][j] = (i + 2) * (j + 1);
			printf("%d ", num[i][j]);
		}
		printf("\n");
	}

	system("pause");
	return EXIT_SUCCESS;
}
*/

/*2번 
배열A에 저장된 값을 이용해서 배열B 초기화 진행
int main(void)
{
	int arr_A[2][4] =
	{
		1,2,3,4,
		5,6,7,8
	};
	int arr_B[4][2];

	for (int i = 0; i < 2; i++)
	{
		for (int j = 0; j < 4; j++)
		{
			printf("%d", arr_A[i][j]);
		}
		printf("\n");
	}

	for (int i = 0; i < 4; i++)
	{
		for (int j = 0; j < 2; j++)
		{
			arr_B[i][j] = arr_A[j][i];
		}
	}
	for (int i = 0; i < 4; i++)
	{
		for (int j = 0; j < 2; j++)
		{
			printf("%d", arr_B[i][j]);
		}
		printf("\n");
	}
	system("pause");
	return EXIT_SUCCESS;
}
*/

/*3번 
성적관리 프로그램작성
int main(void)
{
	int score[5][5] = { 0, };
	int i;
	int j;
	for ( i = 0; i < 4; i++)
	{
		for ( j = 0; j < 4; j++)
		{
			scanf("%d", &score[i][j]);
		}
	}

	for ( i = 0; i < 4; i++)
	{
		for (j = 0; j < 4; j++)
		{
			score[i][4] += score[i][j];
		}
	}

	for ( i = 0; i < 5; i++)
	{
		for (j = 0; j < 4; j++)
		{
			score[4][i] += score[j][i];
		}
	}

	for ( i = 0; i < 5; i++)
	{
		for (j = 0; j < 5; j++)
		{
			printf("%d ", score[i][j]);
		}
		printf("\n");
	}
	system("pause");
	return EXIT_SUCCESS;
}
*/