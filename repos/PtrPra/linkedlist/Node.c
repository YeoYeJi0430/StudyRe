#include "Node.h"
#include <stdlib.h>

Node* CreateNode(Data data)
{
	Node* node = (Node*)malloc(sizeof(Node));
	if (node == NULL)
	{
		exit(1);
	}
	node->data = data;
	node->next = NULL;
	return node;
}

void ReleaseNode(Node* node)
{
	free(node);
}
