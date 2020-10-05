#include <stdio.h>
#include <stdlib.h>
#include <string.h>

/* 1번
int main(void)
{
	char arr[10];
	int count = 0;
	scanf("%s", arr);
	for (int i = 0; i<strlen(arr); i++)
	{
		
		count++;
	}
	printf("%d\n", count);
	
	system("pause");
	return EXIT_SUCCESS;
}
*/

/* 2번
int main(void)
{
	char enter[20];
	char temp;

	printf("입력 : ");
	scanf("%s", enter);

	int len = strlen(enter);

	for (int i = 0; i < len/2; i++)
	{
		temp = enter[i];
		enter[i] = enter[(len - i) - 1];
		enter[(len - i) - 1] = temp;
	}

	printf("뒤집힌 영단어 : %s", enter);

	system("pause");
	return EXIT_SUCCESS;
}
*/

/* 3번
int main(void)
{
	char enter[20];
	char temp;
	char temp2;
	int max = 0;
	scanf("%s", enter);
	for (int i = 0; i < strlen(enter); i++)
	{
		temp = (int)enter[i];
		for (int j = 0; j < i; j++)
		{
			temp2 = (int)enter[j];
			if (temp>temp2)
			{
				max = temp;
			}
		}
	}
	printf("%c\n", max);

	system("pause");
	return EXIT_SUCCESS;
}
*/

/*3번
int main(void)
{
	char enter[20];
	int len;
	char max = 0;
	scanf("%s", enter);
	len = strlen(enter);

	for (int i = 0; i < len; i++)
	{
		if (max<enter[i])
		{
			max = enter[i];
		}
	}
	printf("%c\n", max);

	system("pause");
	return EXIT_SUCCESS;
}
*/