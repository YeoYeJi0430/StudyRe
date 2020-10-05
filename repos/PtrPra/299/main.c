#include <stdio.h>
#include <stdlib.h>
#include <string.h>
 
/* 1번
길이가 5인 int형 배열 arr을 선언하고 이를 1,2,3,4,5로 초기화한 다음,
이 배열의 첫 번째 요소를 가리키는 포인터 변수 ptr을 선언한다. 그 다음 포인터 변수 ptr
에 저장된 값을 증가시키는 형태의 연산을 기반으로 배열요소에 접근하면서 모든 배열요소의 값을 2씩 증가 시키고,
정상적으로 증가가 이뤄졌는지 확인
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

/*2번
포인터 변수 ptr에 저장된 값을 변경시키지 않고, ptr을 대상으로 덧셈연산을 하여,
그 결과로 반환되는 주소 값을 통해서 모든 배열요소에 접근하여 값을 2씩 증가시키는 예제를 작성
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

/*3번
길이가 5인 int형 배열 arr을 선언하고 이를 1,2,3,4,5로 초기화한 다음, 이 배열의 마지막 요소를
가리키는 포인터 변수 ptr을 선언한다. 그 다음 포인터 변수 ptr에 저장된 값을 감소시키는
형태의 연산을 기반으로 모든 배열요소에 접근하여, 배열에 저장된 모든 정수를 더하여 그 결과를 출력하는
프로그램
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

/*4번
길이가 6인 int형 배열 arr을 선언하고 이를 1,2,3,4,5,6으로 초기화한 다음, 배열에 저장된 값의 순서가 6,5,4,3,2,1이 되도록 변경하는 예제
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