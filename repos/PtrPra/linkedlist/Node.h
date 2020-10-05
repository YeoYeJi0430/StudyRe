#ifndef NODE_H
#define NODE_H

typedef int Data;
typedef struct Node Node;

struct Node
{
	Data data;
	Node* next;
};

Node* CreateNode(Data data);
void ReleaseNode(Node *node);

#endif // !NODE_H

