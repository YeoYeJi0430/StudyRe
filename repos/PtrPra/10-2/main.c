#include <stdio.h>
#include <stdlib.h>

int main(void)
{
	int ary[3];
	*(ary + 0) = 10;
	*(ary + 1) = *(ary + 0) + 10;

	printf("세 번째 배열 요소에 키보드 입력 : ");
	scanf("%d", ary + 2);
	printf("%d %d %d\n", ary[0], ary[1], ary[2]);

	system("pause");
	return EXIT_SUCCESS;
}