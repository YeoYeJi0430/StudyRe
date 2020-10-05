#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(void)
{
	int data[] = { 1,2,3 };
	int* p = &data[0];

	printf("%d %x\n", p, p);//포인터 p의 10진수(%d),16진수(%x)
	printf("%d %x\n", p + 1, p + 1); //p에 더하기1이 되는것이 아니라 주소가 데이터형에 따라 계산됨.
	printf("%d %x\n", p + 2, p + 2);
	system("pause");
	return EXIT_SUCCESS;
}