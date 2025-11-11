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

void traverse(node *head)
{
    while(head!=NULL)
 {
     cout<<head->val<<" ->";
     head = head->next;
 }cout<<"NULL";
}

void insertBegin(node * &head,int val)
{
    node * newnode = new node (val);
    newnode->next = head;
    head = newnode;
    cout<<"\n\nAfter inserting at beginning.\n";
}
void insertEnd(node *head, int val)
{
    node * tail;
    node * newnode  = new node(val);
    while(head!=NULL)
    {
        tail = head;
        head = head->next;
    }
    tail->next = newnode;
    cout<<"\n\nAfter inserting at the end.\n";
}
void insertpos(node * head,int pos,int val)
{
 if(pos==1)
 {
     insertBegin(head,val);
     return;
 }
 node * newnode = new node(val);
 node * temp;
 node * temp1;
 int i =0;
 while(i!=pos-1)
 {
     temp = head->next;
     i++;
 }
 temp1 = temp->next;
 temp->next = newnode;
 newnode->next = temp1;
 cout<<"\n\nAfter insertion tha the pos "<<pos<<".\n\n\n";
}

void deleteBegin(node * & head)
{
    if(head == NULL) //if linklist is empty
    {
        return;
    }
    node * temp = head;
    head = temp->next;
    free(temp);
    cout<<"\n After delete";
}
void deleteEnd(node * head)
{
    node* tail;
    while(head->next!=NULL)
    {
        tail = head;
         head = head->next;
    }
    tail->next = NULL;
    free(head);
    cout<<endl;
}
void deletePos(node* &head, int pos)
{
    if (head == NULL) {
        cout << "List is empty.\n";
        return;
    }

    // If deleting the first node
    if (pos == 1) {
        node* temp = head;
        head = head->next;
        delete temp;
        cout << "Deleted position " << pos << endl;
        return;
    }

    node* prev = head;
    for (int i = 1; i < pos - 1 && prev != NULL; i++) {
        prev = prev->next;
    }

    // If position is out of range
    if (prev == NULL || prev->next == NULL) {
        cout << "Position out of range.\n";
        return;
    }

    node* toDelete = prev->next;
    prev->next = toDelete->next;
    delete toDelete;

    cout << "Deleted position " << pos << endl;
}

int main ()
{
    node * node1 = new node(1);
    node * node2 = new node(2);
    node * node3 = new node(3);
    
    node * head = node1;
    node1->next = node2;
    node2->next = node3;
    cout<<"Original linklist.\n";
    traverse(head);
    
    insertBegin(head,0); //begin
    traverse(head);
    
    insertEnd(head,100); //end
    traverse(head);
    
    insertpos(head,3,10); //at post
    traverse(head);

    deleteBegin(head);
    traverse(head);
    
    deleteEnd(head);
    traverse(head);
    
    deletePos(head,3);
    traverse(head);
    return 0 ;
}
