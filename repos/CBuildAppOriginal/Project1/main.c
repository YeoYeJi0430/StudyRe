#include <stdio.h>
#include <stdlib.h>

//�����Լ�
int main(void)
{
	char data[5] = { 's','u','p','e','r' };
	char* x;
	char z;
	
	x = data + 1;

	printf("u����ϱ� : %c\n", *x);

	system("pause");
	return EXIT_SUCCESS;
}