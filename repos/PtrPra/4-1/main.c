#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define CAPACITY 100
#define BUFFER_SIZE 20

char* names[CAPACITY];
char* numbers[CAPACITY]; /*phone numbers 051-111-2222 기호사용 0으로 시작 char*/
int n = 0; /*사람 수 <-*/

void add();
void find(); /*명령창에 이름 입력시 전화번호를 출력*/
void status();
void _remove();

int main(void)
{
	char command[BUFFER_SIZE]; /*command : 명령단어를 받음*/
	while (1)
	{
		printf("$ ");
		scanf("%s", command); 

		if (strcmp(command, "add") == 0) /*strcmp : string.h 두 문자열이 동일하면 0을 반환한다.*/
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

	names[n] = strdup(buf1); /*복사 하는 이유 : buf1,buf2 배열을 add함수가 끝나면 사라짐. 
							 buf1에 저장된 문자열을 복제한 후 배열 names[0]에 복제된 배열의 주소를 저장해야한다.
							 복제된 배열은 strdup 함수 내에서 malloc으로 할당된 메모리 이므로 add함수가 종료된 후에도 소멸 하지않는다.*/
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
			return; /*strcmp함수를 통해 같은 이름을 찾고, 번호를 출력하고 난 후 find함수 종료*/
		}
	}
	printf("No person named '%s' exists.\n", buf);/*이름이 존재하지 않을때 문장 출력*/
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
	for ( i = 0; i < n; i++) /*삭제할 사람이 있는지 먼저 찾아야함.*/
	{
		if (strcmp(buf, names[i]) == 0) /*names[i]에 있는 이름과 지금 삭제하려는 이름 (buf에 있는 이름)이 같은지 확인*/
		{
			names[i] = names[n - 1]; /*맨 마지막 사람을 삭제된 자리로 옮긴다.*/
			numbers[i] = numbers[n - 1];
			n--;
			printf("'%s' was deleted successfully. \n", buf);
			return;
		}
	}
	printf("No person named '%s' exists.\n", buf);
}