#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(void)
{
	int data[] = { 1,2,3 };
	int* p = &data[0];

	printf("%d %x\n", p, p);//������ p�� 10����(%d),16����(%x)
	printf("%d %x\n", p + 1, p + 1); //p�� ���ϱ�1�� �Ǵ°��� �ƴ϶� �ּҰ� ���������� ���� ����.
	printf("%d %x\n", p + 2, p + 2);
	system("pause");
	return EXIT_SUCCESS;
}