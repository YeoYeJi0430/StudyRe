#include <stdio.h>
#include <stdlib.h>

int main(void)
{
	int a = 10, b = 15, total;
	double avg;
	int* pa, * pb, * pt;
	double* pg;

	pa = &a;
	pb = &b;
	pt = &total;
	pg = &avg;

	*pt = *pa + *pb;
	*pg = *pt / 2.0;

	printf("두 정수의 합 : %d\n", total);
	printf("두 정수의 평균 : %.1f\n", avg);

	system("pause");
	return EXIT_SUCCESS;
}