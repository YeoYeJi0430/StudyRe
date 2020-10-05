#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define CAPACITY 100
#define BUFFER_SIZE 20

char* names[CAPACITY];
char* numbers[CAPACITY]; /*phone numbers 051-111-2222 ��ȣ��� 0���� ���� char*/
int n = 0; /*��� �� <-*/

void add();
void find(); /*���â�� �̸� �Է½� ��ȭ��ȣ�� ���*/
void status();
void _remove();

int main(void)
{
	char command[BUFFER_SIZE]; /*command : ��ɴܾ ����*/
	while (1)
	{
		printf("$ ");
		scanf("%s", command); 

		if (strcmp(command, "add") == 0) /*strcmp : string.h �� ���ڿ��� �����ϸ� 0�� ��ȯ�Ѵ�.*/
		{
			add();
		}
		else if (strcmp(command, "find") == 0)
		{
			find();
		}
		else if (strcmp(command, "status") == 0)
		{
			status();
		}
		else if (strcmp(command, "delete") == 0)
		{
			_remove();
		}
		else if (strcmp(command, "exit") == 0)
		{
			break;
		}
	}
	system("pause");
	return EXIT_SUCCESS;
}

void add()
{
	char buf1[BUFFER_SIZE], buf2[BUFFER_SIZE];
	scanf("%s", buf1);
	scanf("%s", buf2);

	names[n] = strdup(buf1); /*���� �ϴ� ���� : buf1,buf2 �迭�� add�Լ��� ������ �����. 
							 buf1�� ����� ���ڿ��� ������ �� �迭 names[0]�� ������ �迭�� �ּҸ� �����ؾ��Ѵ�.
							 ������ �迭�� strdup �Լ� ������ malloc���� �Ҵ�� �޸� �̹Ƿ� add�Լ��� ����� �Ŀ��� �Ҹ� �����ʴ´�.*/
	numbers[n] = strdup(buf2);
	n++;

	printf("%s was added successfully.\n", buf1);
}

void find()
{
	char buf[BUFFER_SIZE];
	scanf("%s", buf);

	int i;
	for ( i = 0; i < n; i++)
	{
		if (strcmp(buf, names[i]) == 0)
		{
			printf("%s\n", numbers[i]);
			return; /*strcmp�Լ��� ���� ���� �̸��� ã��, ��ȣ�� ����ϰ� �� �� find�Լ� ����*/
		}
	}
	printf("No person named '%s' exists.\n", buf);/*�̸��� �������� ������ ���� ���*/
}

void status()
{
	int i;
	for ( i = 0; i < n; i++)
	{
		printf("%s %s\n", names[i], numbers[i]);
		printf("Total %d persons.\n", n);
	}
}

void _remove()
{
	char buf[BUFFER_SIZE];
	scanf("%s", buf);

	int i;
	for ( i = 0; i < n; i++) /*������ ����� �ִ��� ���� ã�ƾ���.*/
	{
		if (strcmp(buf, names[i]) == 0) /*names[i]�� �ִ� �̸��� ���� �����Ϸ��� �̸� (buf�� �ִ� �̸�)�� ������ Ȯ��*/
		{
			names[i] = names[n - 1]; /*�� ������ ����� ������ �ڸ��� �ű��.*/
			numbers[i] = numbers[n - 1];
			n--;
			printf("'%s' was deleted successfully. \n", buf);
			return;
		}
	}
	printf("No person named '%s' exists.\n", buf);
}