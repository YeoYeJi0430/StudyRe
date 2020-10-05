#include <stdio.h>
#include <stdlib.h>
#include <string.h>

/*1-1
변수 num에 저장된 값의 제곱을 걔산하는 함수를 정의하고, 이를 호출하는 nain함수를 작성
Call-by-value

void squ(int num)
{
	int squ;
	squ = num * num;
	printf("%d\n", squ);
}

int main(void)
{
	int number = 3;
	squ(number);

	system("pause");
	return EXIT_SUCCESS;
}
*/

/*1-2
변수 num에 저장된 값의 제곱을 걔산하는 함수를 정의하고, 이를 호출하는 nain함수를 작성
Call-by-reference
void squ(int* num)
{
	*num = *num * *num;
}

int main(void)
{
	int number = 3;
	int* num = &number;
	squ(num);
	printf("%d\n", number);

	system("pause");
	return EXIT_SUCCESS;
}
*/

/*1번
int SquareByValue(int num)
{
	return num * num;
}

void SquareByReference(int* ptr)
{
	int num = *ptr;
	*ptr = num * num;
	//*num = *num * *num;
}

int main(void)
{
	int num = 10;

	printf("%d\n", SquareByValue(num));

	SquareByReference(&num);
	printf("%d\n", num);

	system("pause");
	return EXIT_SUCCESS;
}
*/

/*
3번
세 변수에 저장된 값을 서로 뒤바꾸는 함수 정의
num1->num2,num2->num3,num1->num3

void Swap3(int *pnum1,int *pnum2,int *pnum3)
{
	int temp;
	////temp = *pnum1;
	//*pnum1 = *pnum2;
	//*pnum2 = temp;

	//temp = *pnum1;
	//*pnum1 = *pnum3;
	//*pnum3 = temp;

	temp = *pnum1;
	*pnum1 = *pnum3;
	*pnum3 = *pnum2;
	*pnum2 = temp;
}

int main(void)
{
	int num1 = 1;
	int num2 = 2;
	int num3 = 3;

	Swap3(&num1, &num2, &num3);
	printf("%d %d %d\n", num1, num2, num3);

	system("pause");
	return EXIT_SUCCESS;
}
*/