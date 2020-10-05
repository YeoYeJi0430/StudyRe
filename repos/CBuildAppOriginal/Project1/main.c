#include <stdio.h>
#include <stdlib.h>

//메인함수
int main(void)
{
	char data[5] = { 's','u','p','e','r' };
	char* x;
	char z;
	
	x = data + 1;

	printf("u출력하기 : %c\n", *x);

	system("pause");
	return EXIT_SUCCESS;
}