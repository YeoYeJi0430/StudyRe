#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdbool.h>

#define QUEUE_SIZE 100

int front = -1;
int rear = -1;
int queue[QUEUE_SIZE];

bool IsEmpty()
{
	return front == rear ? true : false;
}

bool IsFull()
{
	int temp = (rear + 1) % QUEUE_SIZE;
	return temp == front ? true : false;
}

void EnQ(int data)
{
	if (IsFull())
	{
		printf("Queue is Full!");
	}
	else
	{
		rear = (rear + 1) % QUEUE_SIZE;
		queue[rear] = data;
	}
}

int DelQ()
{
	if (IsEmpty())
	{
		printf("Queue is Empty\n");
	}
	else
	{
		front = (front + 1) % QUEUE_SIZE;
		return queue[front];
	}
}

int main(void)
{
	EnQ(4); //data=4,rear=0
	EnQ(7); //data=7,rear=1
	EnQ(12); //data=12,rear=2
	printf("%d\n", DelQ()); //queue[0]
	printf("%d\n", DelQ()); //queue[1]
	printf("%d\n", DelQ()); //queue[2]
	DelQ();

	system("pause");
	return EXIT_SUCCESS;
}

//1%3 = 1
//큐 
// del <- 4 7 12 <- en
// rear가 뒤로 점점 이동 후 (front는 -1로 유지)
// enq 필요성 없으면 front++ 하면서 del