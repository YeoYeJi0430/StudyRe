#include <stdio.h>
#include <stdlib.h>

//�����Լ�
int main(void)
{
	int x[5] = { 3,5,78,11,233 };
	int* p1;
	int* p2;
	int z;

	p1 = &x[3];
	p2 = &x[1];
	z = *p1 + *p2;

	printf("��� : %d\n", z);

	system("pause");
	return EXIT_SUCCESS;
}

