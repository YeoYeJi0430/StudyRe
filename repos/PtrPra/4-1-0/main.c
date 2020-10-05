#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define SIZE 100

void add();
void status();
void _delete();
void exit();

int main(void)
{
	char name[SIZE];
	char number[SIZE];
	char command;

	printf("명령 입력 : ");
	scanf("%s", &command);

	while (1)
	{
		if (strcmp(command, "add") == 0)
		{
			add();
		}
		else if (strcmp(command, "status") == 0)
		{
			status();
		}
		else if (strcmp(command, "delete") == 0)
		{
			_delete();
		}
		else if (strcmp(command, "exit") == 0)
		{
			return 0;
		}
	}

	system("pause");
	return EXIT_SUCCESS;
}