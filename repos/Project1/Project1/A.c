#include <stdio.h>
#include <string.h>
#include <stdlib.h>

main()
{
	int a = 0;
	int b = 2;;

	printf("%d", b);
	a = b++ + 1;
	printf("%d", a);
	printf("%d", b);
}