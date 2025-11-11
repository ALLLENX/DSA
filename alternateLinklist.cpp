#include<bits/stdc++.h>
using namespace std;
class node 
{
    public:
    int val;
    node *next;
    
    node(int v)
    {
        val = v;
         next = NULL;
    }
};
void deleteAlternate(node *head)
{
    node * temp = head;
    
    while(temp !=NULL && temp->next !=NULL)
    {
        node * deletenode = temp->next;
        temp->next = temp->next->next;
        temp = temp->next;
        delete deletenode;
    }
   
}




void traverse(node *head)
{
    while(head!=NULL)
 {
     cout<<head->val<<" ->";
     head = head->next;
 }cout<<"NULL";
}
int main ()
{
    node * node1 = new node(1);
    node * node2 = new node(2);
    node * node3 = new node(3);
    node * node4 = new node(4);
    node * node5 = new node(5);
    node * node6 = new node(6);
    node * node7 = new node(7);
    
    node * head = node1;
    node1->next = node2;
    node2->next = node3;
    node3->next = node4;
    node4->next = node5;
    node5->next = node6;
    node6->next = node7;
    cout<<"Oiginal linklist\n";
    traverse(head);
    
    cout<<"\n\nalternate dletion of linklist , sartin from position 2 :\n";
    deleteAlternate(head);\
    traverse(head);
    
    return 0; 
}
